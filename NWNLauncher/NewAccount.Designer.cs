namespace NWNLauncher
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.newAccountGroup = new System.Windows.Forms.GroupBox();
            this.key3Edit = new System.Windows.Forms.TextBox();
            this.key2Edit = new System.Windows.Forms.TextBox();
            this.key1Edit = new System.Windows.Forms.TextBox();
            this.key3Label = new System.Windows.Forms.Label();
            this.key2Label = new System.Windows.Forms.Label();
            this.key1Label = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountNameEdit = new System.Windows.Forms.TextBox();
            this.newAccountGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // newAccountGroup
            // 
            this.newAccountGroup.Controls.Add(this.key3Edit);
            this.newAccountGroup.Controls.Add(this.key2Edit);
            this.newAccountGroup.Controls.Add(this.key1Edit);
            this.newAccountGroup.Controls.Add(this.key3Label);
            this.newAccountGroup.Controls.Add(this.key2Label);
            this.newAccountGroup.Controls.Add(this.key1Label);
            this.newAccountGroup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newAccountGroup.Location = new System.Drawing.Point(13, 13);
            this.newAccountGroup.Name = "newAccountGroup";
            this.newAccountGroup.Size = new System.Drawing.Size(546, 120);
            this.newAccountGroup.TabIndex = 0;
            this.newAccountGroup.TabStop = false;
            this.newAccountGroup.Text = "New Account";
            // 
            // key3Edit
            // 
            this.key3Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key3Edit.Location = new System.Drawing.Point(72, 86);
            this.key3Edit.Name = "key3Edit";
            this.key3Edit.Size = new System.Drawing.Size(468, 27);
            this.key3Edit.TabIndex = 5;
            // 
            // key2Edit
            // 
            this.key2Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key2Edit.Location = new System.Drawing.Point(72, 53);
            this.key2Edit.Name = "key2Edit";
            this.key2Edit.Size = new System.Drawing.Size(468, 27);
            this.key2Edit.TabIndex = 4;
            // 
            // key1Edit
            // 
            this.key1Edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key1Edit.Location = new System.Drawing.Point(72, 20);
            this.key1Edit.Name = "key1Edit";
            this.key1Edit.Size = new System.Drawing.Size(468, 27);
            this.key1Edit.TabIndex = 3;
            // 
            // key3Label
            // 
            this.key3Label.AutoSize = true;
            this.key3Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key3Label.Location = new System.Drawing.Point(18, 89);
            this.key3Label.Name = "key3Label";
            this.key3Label.Size = new System.Drawing.Size(48, 19);
            this.key3Label.TabIndex = 2;
            this.key3Label.Text = "Key3=";
            // 
            // key2Label
            // 
            this.key2Label.AutoSize = true;
            this.key2Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key2Label.Location = new System.Drawing.Point(18, 56);
            this.key2Label.Name = "key2Label";
            this.key2Label.Size = new System.Drawing.Size(48, 19);
            this.key2Label.TabIndex = 1;
            this.key2Label.Text = "Key2=";
            // 
            // key1Label
            // 
            this.key1Label.AutoSize = true;
            this.key1Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key1Label.Location = new System.Drawing.Point(18, 23);
            this.key1Label.Name = "key1Label";
            this.key1Label.Size = new System.Drawing.Size(48, 19);
            this.key1Label.TabIndex = 0;
            this.key1Label.Text = "Key1=";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(12, 139);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(114, 45);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNameLabel.Location = new System.Drawing.Point(348, 141);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(74, 13);
            this.accountNameLabel.TabIndex = 2;
            this.accountNameLabel.Text = "Account name";
            // 
            // accountNameEdit
            // 
            this.accountNameEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNameEdit.Location = new System.Drawing.Point(351, 157);
            this.accountNameEdit.Name = "accountNameEdit";
            this.accountNameEdit.Size = new System.Drawing.Size(202, 27);
            this.accountNameEdit.TabIndex = 3;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 192);
            this.Controls.Add(this.accountNameEdit);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.newAccountGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.newAccountGroup.ResumeLayout(false);
            this.newAccountGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox newAccountGroup;
        private System.Windows.Forms.Label key1Label;
        private System.Windows.Forms.Label key3Label;
        private System.Windows.Forms.Label key2Label;
        private System.Windows.Forms.TextBox key3Edit;
        private System.Windows.Forms.TextBox key2Edit;
        private System.Windows.Forms.TextBox key1Edit;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.TextBox accountNameEdit;
    }
}