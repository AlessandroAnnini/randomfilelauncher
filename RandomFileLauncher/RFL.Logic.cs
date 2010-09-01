using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace RandomFileLauncher
{
    public partial class FrmMain
    {
        private void OsVersion()
        {
            if (_osInfo.Version.Major == 5)
            {
                btnBrowseFolder.BackColor = Color.Silver;
                btnLaunch.BackColor = Color.Silver;
                btnSearch.BackColor = Color.Silver;
            }
        }

        private void BrowseFolder()
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _path = folderBrowserDialog1.SelectedPath;
                tboxPath1.Text = _path;
                tboxPath1.Refresh();
                Search();
            }
        }

        private void Search()
        {
            _files.Clear();
            Waiting(true);

            FileTypes();
            if (_searchPattern.Count == 0)
                _searchPattern.Add("*.*");

            TextBox tmpTxBox = new TextBox();
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    tmpTxBox = (TextBox) control;

                    if (!string.IsNullOrEmpty(tmpTxBox.Text))
                    {
                        _path = tmpTxBox.Text;
                    }
                }
                else continue;

                try
                {
                    List<string> tmpFiles = GetFiles(_path, _searchPattern, SearchOption.AllDirectories);
                    _files.AddRange(tmpFiles);
                }
                catch (IOException ex)
                {
                    if (ex.Message != null) Debug.WriteLine(ex.Message);
                }
                
            }
            if (string.IsNullOrEmpty(_path))
            {
                MessageBox.Show("Choose a path", "", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            lblResult.Text = string.Format("{0} files found", _files.Count());
            btnLaunch.Focus();
            Waiting(false);
        }

        /// <summary>
        /// Get all the files in a directory that match
        /// the specified search pattern
        /// </summary>
        /// <param name="path">The directory to seach</param>
        /// <param name="listOfSearchPatterns">The list of search patterns</param>
        /// <param name="searchOption">Type of search</param>>
        /// <returns>The list of files that match the specified pattern</returns>
        private List<string> GetFiles(string path, IEnumerable<string> listOfSearchPatterns, SearchOption searchOption)
        {
            if (listOfSearchPatterns == null) throw new ArgumentNullException("listOfSearchPatterns");
            _matchingFiles = new List<string>();

            try
            {
                foreach (string pattern in listOfSearchPatterns)
                {
                    //add the the files that match our pattern to our list
                    _matchingFiles.AddRange(Directory.GetFiles(path, pattern, searchOption));

                }
            }
            catch (IOException ex)
            {
                if (ex.Message != null) Debug.WriteLine(ex.Message);
            }

            return _matchingFiles;
        }

        private void Launch()
        {
            if (_files.Count != 0)
            {
                int number = rnd.Next(0, _files.Count);
                if (_alreadyOpened.IndexOf(number) >= 0)
                    Launch();
                _choosenRnd = number;
                Process.Start(_files[number]);
                _alreadyOpened.Add(number);
            }
        }

        private void Delete()
        {
            if (_choosenRnd != -1)
            {
                File.Delete(_files[_choosenRnd]);
                _choosenRnd = -1;

            }
        }

        private void Back()
        {
            if (_choosenRnd != -1)
            {
                Process.Start(_files[_choosenRnd]);
                _choosenRnd = -1;
            }
        }

        private void Waiting(bool isWaiting)
        {
            if (isWaiting)
            {
                Cursor.Current = Cursors.WaitCursor;
                btnSearch.Text = "Searching...";
                foreach (Control control in Controls)
                {
                    if (control is TextBox || control is Button || control is CheckBox)
                        control.Enabled = false;
                }
                foreach (Control control in pnlControls.Controls)
                {
                    if (control is TextBox || control is Button || control is CheckBox)
                        control.Enabled = false;
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                btnSearch.Text = "Search";
                foreach (Control control in Controls)
                {
                    if (control is TextBox || control is Button || control is CheckBox)
                        control.Enabled = true;
                }
                foreach (Control control in pnlControls.Controls)
                {
                    if (control is TextBox || control is Button || control is CheckBox)
                        control.Enabled = true;
                }
            }
        }

        private void AddControls()
        {
            if (_currentNewControl > MaNewControl) return;

            SuspendLayout();
            AdaptFormSize();
            NewFormPosition();
            ResumeLayout();

            #region NEW DYNAMIC PATH TEXTBOX
            _dynamicTextbox[_currentNewControl] = new TextBox
                                                      {
                                                          Name = "dynamictextbox" + _currentNewControl,
                                                          Size = new Size(234, 20)
                                                      };
            int prevTboxY = tboxPath1.Location.Y;
            if (_currentNewControl > 0)
            {
                prevTboxY = _dynamicTextbox[_currentNewControl - 1].Location.Y;
            }
            _dynamicTextbox[_currentNewControl].Location = new Point(12, prevTboxY + 26);
            Controls.Add(_dynamicTextbox[_currentNewControl]); 
            #endregion

            #region NEW DYNAMIC PATH BUTTON
            _dynamicButton[_currentNewControl] = new Button
                                                     {
                                                         Name = "dynamictextbox" + _currentNewControl,
                                                         Tag = _currentNewControl,
                                                         Size = new Size(28, 20)
                                                     };
            int prevBtnY = tboxPath1.Location.Y;
            if (_currentNewControl > 0)
            {
                prevBtnY = _dynamicButton[_currentNewControl - 1].Location.Y;
            }
            _dynamicButton[_currentNewControl].Location = new Point(252, prevBtnY + 26);
            _dynamicButton[_currentNewControl].Text = "...";
            _dynamicButton[_currentNewControl].BackColor = Color.White;
            _dynamicButton[_currentNewControl].UseVisualStyleBackColor = true;
            _dynamicButton[_currentNewControl].Click += DynBtnBrowseFolderClick;
            Controls.Add(_dynamicButton[_currentNewControl]); 
            #endregion

            _currentNewControl += 1;
        }

        private void AdaptFormSize()
        {
            int formHeight = Size.Height;
            Size = new Size(298, formHeight + 26);
        }

        private void NewFormPosition()
        {
            int loc = Location.Y;
            Location = new Point(Location.X, loc - 26);
        }

        private void DynBtnBrowseFolderClick(object sender, EventArgs e)
        {
            Button tmpBtn = new Button();
            if (sender is Button)
                tmpBtn = (Button)sender;

            DynBrowseFolder(tmpBtn);
        }

        private void DynBrowseFolder(Button tmpBtn)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _path = folderBrowserDialog1.SelectedPath;
                if (_path != null) _dynamicTextbox[Convert.ToInt32(tmpBtn.Tag)].Text = _path;
                _dynamicTextbox[Convert.ToInt32(tmpBtn.Tag)].Refresh();
                Search();
            }
        }
    }
}
