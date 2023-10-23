using System.Text.Json;

namespace VampireSurvivorsSaveSync
{
    public partial class FrmMain : Form
    {
        private Settings? UserSettings { get; set; } = default!;
        private static string _settingsFile = Path.Combine(Directory.GetCurrentDirectory(), "usersettings.json");

        public FrmMain()
        {
            UserSettings = new Settings();
            if (_settingsFile != null && File.Exists(_settingsFile))
            {
                try
                {
                    var settingsJson = File.ReadAllText(_settingsFile);
                    UserSettings = JsonSerializer.Deserialize<Settings>(settingsJson);
                }
                catch
                {
                    // just keep empty settings file
                }
            }

            InitializeComponent();
        }

        private void BtnChooseSteamSave_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;

                txtSteam.Text = filePath;
            }
        }

        private void BtnChooseAndroidSave_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;

                txtAndroid.Text = filePath;
            }
        }

        private void BtnSyncSteamAndroid_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtSteam.Text))
            {
                File.Copy(txtSteam.Text, txtAndroid.Text, true);
            }

        }

        private void BtnSyncAndroidSteam_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtAndroid.Text))
            {
                File.Copy(txtAndroid.Text, txtSteam.Text, true);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings ??= new Settings();

            UserSettings.AndroidSave = txtAndroid.Text;
            UserSettings.SteamSave = txtSteam.Text;

            var jsonUserSettings = JsonSerializer.Serialize(UserSettings);
            File.WriteAllText(_settingsFile, jsonUserSettings);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (UserSettings is not null)
            {
                txtAndroid.Text = UserSettings.AndroidSave;
                txtSteam.Text = UserSettings.SteamSave;
            }
        }
    }
}