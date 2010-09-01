using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RandomFileLauncher
{
    public partial class FrmMain : Form
    {
        #region DECLARATIONS
        readonly OperatingSystem _osInfo = Environment.OSVersion;
        private string _path = string.Empty;
        List<string> _searchPattern = new List<string>();
        List<string> _files = new List<string>();
        private List<string> _matchingFiles;
        Random rnd = new Random();
        int _choosenRnd = -1;
        List<int> _alreadyOpened = new List<int>();

        private readonly Button[] _dynamicButton = new Button[3];
        private readonly TextBox[] _dynamicTextbox = new TextBox[3];
        private const int MaNewControl = 2;
        private int _currentNewControl;
        #endregion

        public FrmMain()
        {
            InitializeComponent();
            lblVersion.Text = string.Format("V. {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PositionReporterEdge();
            OsVersion();
        }

        #region OPTIONS
        private void FileTypes()
        {
            _searchPattern.Clear();

            if (chbAudio.Checked)
            {
                _searchPattern.Add("*.mp3");
                _searchPattern.Add("*.wav");
                _searchPattern.Add("*.flac");
                _searchPattern.Add("*.m4a");
                _searchPattern.Add("*.wma");
            }
            if (chbVideo.Checked)
            {
                _searchPattern.Add("*.mpeg");
                _searchPattern.Add("*.mpg");
                _searchPattern.Add("*.avi");
                _searchPattern.Add("*.wmv");
                _searchPattern.Add("*.mp4");
                _searchPattern.Add("*.mov");
                _searchPattern.Add("*.mkv");
                _searchPattern.Add("*.rm");
                _searchPattern.Add("*.ram");
                _searchPattern.Add("*.flv");
            }
            if (chbPicture.Checked)
            {
                _searchPattern.Add("*.jpeg");
                _searchPattern.Add("*.jpg");
                _searchPattern.Add("*.gif");
                _searchPattern.Add("*.png");
            }
            if (chbText.Checked)
            {
                _searchPattern.Add("*.txt");
                _searchPattern.Add("*.pdf");
                _searchPattern.Add("*.odt");
                _searchPattern.Add("*.doc");
                _searchPattern.Add("*.docx");
            }
        }

        private void ChbAlwaysOnTopCheckedChanged(object sender, EventArgs e)
        {
            TopMost = chbAlwaysOnTop.Checked;
        }

        private void ChbTransparentCheckedChanged(object sender, EventArgs e)
        {
            Opacity = chbTransparent.Checked ? 0.4 : 1;
        }
        #endregion

        #region BUTTONS
        private void BtnBrowseFolderClick(object sender, EventArgs e)
        {
            BrowseFolder();
        }

        private void BtnLaunchClick(object sender, EventArgs e)
        {
            if (_files.Count != 0)
                Launch();
            else
                MessageBox.Show("No files to open.", "No files");
        }

        private void BtnSearchClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxPath1.Text))
                Search();
            else
                MessageBox.Show("Please, choose a path.", "Path missing");
        }

        private void BtnLaunchKeyPress(object sender, KeyPressEventArgs e)
        {
            if (_files.Count != 0)
                Launch();
            else
                MessageBox.Show("No files to open.", "No files");
        }

        private void FrmMain_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("I'm working on it!", "Nothing yet...");
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please, close the file before.", "File in use");
            }
        }

        private void BtnAddTextboxClick(object sender, EventArgs e)
        {
            AddControls();
        }
        #endregion

        private void PositionReporterEdge()
        {
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            int newHeight = screenHeight - ClientSize.Height - 125;
            int newWidth = screenWidth - ClientSize.Width - 20;

            Location = new Point(newWidth, newHeight);
        }
    }
    //NOTE http://www.keithrull.com/2008/02/02/HowToSearchADirectoryForFilesUsingMultipleSearchPatterns.aspx
}
