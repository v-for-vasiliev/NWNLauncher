using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NWNLauncher
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!("").Equals(key1Edit.Text)
                && !("").Equals(key2Edit.Text)
                && !("").Equals(key3Edit.Text)
                && !("").Equals(accountNameEdit.Text))
            {
                try
                {
                    string accountDir = "accounts" + Path.DirectorySeparatorChar + accountNameEdit.Text;
                    string iniFile = accountDir + Path.DirectorySeparatorChar + "nwncdkey.ini";
                    string iniContent = "[CDKEY]" + Environment.NewLine +
                                        "Key1=" + key1Edit.Text + Environment.NewLine +
                                        "Key2=" + key2Edit.Text + Environment.NewLine +
                                        "Key3=" + key2Edit.Text + Environment.NewLine;

                    if (!Directory.Exists(accountDir))
                    {
                        Directory.CreateDirectory(accountDir);

                        using (FileStream fs = new FileStream(iniFile, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            byte[] bContent = new byte[iniContent.Length * sizeof(char)];
                            Buffer.BlockCopy(iniContent.ToCharArray(), 0, bContent, 0, bContent.Length);
                            fs.Write(bContent, 0, bContent.Length);
                        }

                        MessageBox.Show("Account was created successfully!", "New Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Account " + accountNameEdit.Text + " already exist!", "Creation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error create new account. Reason: " + ex.Message, "Creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill all fields and try again", "Creation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
