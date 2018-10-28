using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace NWNLauncher
{
    public partial class MainForm : Form
    {
        private List<string> dirs;

        private static Regex keyValRegex = new Regex(
            @"Player Name=(?<Value>.+)",
            RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled |
            RegexOptions.CultureInvariant | RegexOptions.IgnoreCase
        );

        const string playerPattern = @"Player Name=(?<Value>.+)";

        public MainForm()
        {
            InitializeComponent();

            this.Shown += new EventHandler(MainForm_Shown);
        }

        void MainForm_Shown(object sender, EventArgs e)
        {
            setupMainForm();
        }

        private void setupButton(object sender, EventArgs e)
        {
            if (this.accountsList.SelectedIndex == -1)
            {
                MessageBox.Show("Select account first!", "Account setup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedAccount = dirs[this.accountsList.SelectedIndex];
            if (selectedAccount != null && !("").Equals(selectedAccount))
            {
                List<string> inis = new List<string>(Directory.EnumerateFiles("accounts" + Path.DirectorySeparatorChar + selectedAccount));
                foreach (string s in inis)
                {
                    int breakPoint = s.LastIndexOf(Path.DirectorySeparatorChar);
                    File.Copy(s, s.Substring(breakPoint + 1), true);
                }
                setupAccountName(selectedAccount);
                setupWindowedMode(this.windowedChecker.Checked);

                this.activeAccount.Text = getActiveAccount();

                MessageBox.Show(selectedAccount + "'s account was set.", "Account setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void setupMainForm()
        {
            this.accountsList.Items.Clear();
            dirs = new List<string>(Directory.EnumerateDirectories("accounts"));
            for (int i = 0; i < dirs.Count; i++)
            {
                int breakPoint = dirs[i].LastIndexOf(Path.DirectorySeparatorChar);
                string accountName = dirs[i].Substring(breakPoint + 1);
                dirs[i] = accountName;
            }
            this.accountsList.Items.AddRange(dirs.ToArray());

            this.activeAccount.Text = getActiveAccount();
        }

        private void setupWindowedMode(bool windowed)
        {
            if (windowed)
                File.Copy("accounts\\nwn_windowed.ini", "nwn.ini", true);
            else
                File.Copy("accounts\\nwn_fullscreen.ini", "nwn.ini", true);
        }

        private void setupAccountName(string name)
        {
            if (name == null || ("").Equals(name))
            {
                return;
            }
            const string filename = "nwnplayer.ini";
            if (File.Exists(filename))
            {
                try
                {
                    string content = File.ReadAllText(filename);
                    Match match = Regex.Match(content, playerPattern, RegexOptions.IgnoreCase);

                    if (match.Success)
                    {
                        int index = match.Groups["Value"].Index;
                        int length = match.Groups["Value"].Length;

                        content = content.Remove(index, length);
                        content = content.Insert(index, name);

                        File.WriteAllText(filename, content);
                    }
                }
                catch { }
            }
        }

        private string getActiveAccount()
        {
            const string filename = "nwnplayer.ini";
            string accountName = "";
            if (File.Exists(filename))
            {
                try
                {
                    string content = File.ReadAllText(filename);
                    Match match = Regex.Match(content, playerPattern, RegexOptions.IgnoreCase);

                    if (match.Success)
                    {
                        accountName = match.Groups["Value"].Value;
                    }
                }
                catch { }
            }
            return accountName;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "NWMain.exe";
            process.Start();
            Application.Exit();
        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            NewAccount na = new NewAccount();
            na.Show();
            na.FormClosed += new FormClosedEventHandler(na_FormClosed);
        }

        void na_FormClosed(object sender, FormClosedEventArgs e)
        {
            setupMainForm();
        }
    }
}
