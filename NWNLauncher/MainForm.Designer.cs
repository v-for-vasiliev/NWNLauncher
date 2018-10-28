namespace NWNLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accountsList = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.accoutsLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.windowedChecker = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activeAccountLabel = new System.Windows.Forms.Label();
            this.activeAccount = new System.Windows.Forms.TextBox();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountsList
            // 
            this.accountsList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountsList.FormattingEnabled = true;
            this.accountsList.ItemHeight = 26;
            this.accountsList.Location = new System.Drawing.Point(12, 45);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(270, 160);
            this.accountsList.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectButton.Location = new System.Drawing.Point(7, 19);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(113, 46);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Setup";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.setupButton);
            // 
            // accoutsLabel
            // 
            this.accoutsLabel.AutoSize = true;
            this.accoutsLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accoutsLabel.Location = new System.Drawing.Point(13, 13);
            this.accoutsLabel.Name = "accoutsLabel";
            this.accoutsLabel.Size = new System.Drawing.Size(90, 26);
            this.accoutsLabel.TabIndex = 2;
            this.accoutsLabel.Text = "Accounts";
            // 
            // launchButton
            // 
            this.launchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.launchButton.Location = new System.Drawing.Point(295, 147);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(113, 46);
            this.launchButton.TabIndex = 3;
            this.launchButton.Text = "Launch Game";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // windowedChecker
            // 
            this.windowedChecker.AutoSize = true;
            this.windowedChecker.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windowedChecker.Location = new System.Drawing.Point(7, 71);
            this.windowedChecker.Name = "windowedChecker";
            this.windowedChecker.Size = new System.Drawing.Size(85, 18);
            this.windowedChecker.TabIndex = 4;
            this.windowedChecker.Text = "Windowed";
            this.windowedChecker.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.windowedChecker);
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(288, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account setup";
            // 
            // activeAccountLabel
            // 
            this.activeAccountLabel.AutoSize = true;
            this.activeAccountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeAccountLabel.Location = new System.Drawing.Point(8, 218);
            this.activeAccountLabel.Name = "activeAccountLabel";
            this.activeAccountLabel.Size = new System.Drawing.Size(104, 19);
            this.activeAccountLabel.TabIndex = 6;
            this.activeAccountLabel.Text = "Active account";
            // 
            // activeAccount
            // 
            this.activeAccount.Enabled = false;
            this.activeAccount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activeAccount.Location = new System.Drawing.Point(12, 241);
            this.activeAccount.Name = "activeAccount";
            this.activeAccount.Size = new System.Drawing.Size(270, 31);
            this.activeAccount.TabIndex = 7;
            // 
            // newAccountButton
            // 
            this.newAccountButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newAccountButton.Location = new System.Drawing.Point(295, 204);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(113, 46);
            this.newAccountButton.TabIndex = 8;
            this.newAccountButton.Text = "New Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 281);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.activeAccount);
            this.Controls.Add(this.activeAccountLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.accoutsLabel);
            this.Controls.Add(this.accountsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NWN Launcher v0.0.3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox accountsList;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label accoutsLabel;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.CheckBox windowedChecker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label activeAccountLabel;
        private System.Windows.Forms.TextBox activeAccount;
        private System.Windows.Forms.Button newAccountButton;

    }
}

