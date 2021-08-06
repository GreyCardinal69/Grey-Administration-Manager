
namespace GreyAdministrationManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.LaunchStartups = new System.Windows.Forms.Button();
            this.AutoStartUp = new System.Windows.Forms.Panel();
            this.GAMStartUp = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.EventMgr = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.RemoveEntry = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.AddApp = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.NextPage = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Launch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PathText = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StartUp = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Path = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ApplicationName = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.StartUpSwitch = new System.Windows.Forms.Button();
            this.ApplicationsList = new System.Windows.Forms.ListBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.AutoStartUp.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.AutoStartUp);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Font = new System.Drawing.Font("Zekton Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 557);
            this.panel1.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel15.Controls.Add(this.LaunchStartups);
            this.panel15.Location = new System.Drawing.Point(297, 12);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(121, 37);
            this.panel15.TabIndex = 8;
            // 
            // LaunchStartups
            // 
            this.LaunchStartups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LaunchStartups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LaunchStartups.Font = new System.Drawing.Font("Zekton Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaunchStartups.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LaunchStartups.Location = new System.Drawing.Point(3, 3);
            this.LaunchStartups.Name = "LaunchStartups";
            this.LaunchStartups.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.LaunchStartups.Size = new System.Drawing.Size(114, 31);
            this.LaunchStartups.TabIndex = 4;
            this.LaunchStartups.TabStop = false;
            this.LaunchStartups.Text = "LaunchStartups";
            this.LaunchStartups.UseVisualStyleBackColor = false;
            this.LaunchStartups.Click += new System.EventHandler(this.LaunchStartups_Click);
            // 
            // AutoStartUp
            // 
            this.AutoStartUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.AutoStartUp.Controls.Add(this.GAMStartUp);
            this.AutoStartUp.Location = new System.Drawing.Point(48, 115);
            this.AutoStartUp.Name = "AutoStartUp";
            this.AutoStartUp.Size = new System.Drawing.Size(121, 37);
            this.AutoStartUp.TabIndex = 7;
            // 
            // GAMStartUp
            // 
            this.GAMStartUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GAMStartUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GAMStartUp.Font = new System.Drawing.Font("Zekton Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GAMStartUp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GAMStartUp.Location = new System.Drawing.Point(3, 3);
            this.GAMStartUp.Name = "GAMStartUp";
            this.GAMStartUp.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.GAMStartUp.Size = new System.Drawing.Size(114, 31);
            this.GAMStartUp.TabIndex = 4;
            this.GAMStartUp.TabStop = false;
            this.GAMStartUp.Text = "GAM StartUp Y\\N";
            this.GAMStartUp.UseVisualStyleBackColor = false;
            this.GAMStartUp.Click += new System.EventHandler(this.GAMStartUp_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel14.Controls.Add(this.EventMgr);
            this.panel14.Location = new System.Drawing.Point(194, 509);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(327, 34);
            this.panel14.TabIndex = 3;
            // 
            // EventMgr
            // 
            this.EventMgr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.EventMgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventMgr.Font = new System.Drawing.Font("Zekton Rg", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventMgr.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EventMgr.Location = new System.Drawing.Point(3, 3);
            this.EventMgr.MinimumSize = new System.Drawing.Size(218, 28);
            this.EventMgr.Multiline = true;
            this.EventMgr.Name = "EventMgr";
            this.EventMgr.PlaceholderText = "Events";
            this.EventMgr.Size = new System.Drawing.Size(321, 28);
            this.EventMgr.TabIndex = 2;
            this.EventMgr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel12.Controls.Add(this.RemoveEntry);
            this.panel12.Location = new System.Drawing.Point(576, 115);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(86, 37);
            this.panel12.TabIndex = 6;
            // 
            // RemoveEntry
            // 
            this.RemoveEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.RemoveEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveEntry.Font = new System.Drawing.Font("Zekton Rg", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveEntry.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RemoveEntry.Location = new System.Drawing.Point(3, 3);
            this.RemoveEntry.Name = "RemoveEntry";
            this.RemoveEntry.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.RemoveEntry.Size = new System.Drawing.Size(80, 31);
            this.RemoveEntry.TabIndex = 4;
            this.RemoveEntry.TabStop = false;
            this.RemoveEntry.Text = "Remove";
            this.RemoveEntry.UseVisualStyleBackColor = false;
            this.RemoveEntry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveEntry_MouseClick);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel11.Controls.Add(this.Save);
            this.panel11.Location = new System.Drawing.Point(576, 15);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(86, 37);
            this.panel11.TabIndex = 6;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Zekton Rg", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Save.Location = new System.Drawing.Point(3, 3);
            this.Save.Name = "Save";
            this.Save.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.Save.Size = new System.Drawing.Size(80, 31);
            this.Save.TabIndex = 4;
            this.Save.TabStop = false;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Save_MouseClick);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel10.Controls.Add(this.AddApp);
            this.panel10.Location = new System.Drawing.Point(576, 66);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(86, 37);
            this.panel10.TabIndex = 5;
            // 
            // AddApp
            // 
            this.AddApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AddApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddApp.Font = new System.Drawing.Font("Zekton Rg", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddApp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddApp.Location = new System.Drawing.Point(3, 3);
            this.AddApp.Name = "AddApp";
            this.AddApp.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.AddApp.Size = new System.Drawing.Size(80, 31);
            this.AddApp.TabIndex = 4;
            this.AddApp.TabStop = false;
            this.AddApp.Text = "AddApp";
            this.AddApp.UseVisualStyleBackColor = false;
            this.AddApp.Click += new System.EventHandler(this.AddApp_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel9.Controls.Add(this.PreviousPage);
            this.panel9.Location = new System.Drawing.Point(48, 63);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(121, 37);
            this.panel9.TabIndex = 6;
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PreviousPage.Font = new System.Drawing.Font("Zekton Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviousPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PreviousPage.Location = new System.Drawing.Point(3, 3);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.PreviousPage.Size = new System.Drawing.Size(114, 31);
            this.PreviousPage.TabIndex = 4;
            this.PreviousPage.TabStop = false;
            this.PreviousPage.Text = "Previous Page";
            this.PreviousPage.UseVisualStyleBackColor = false;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel8.Controls.Add(this.NextPage);
            this.panel8.Location = new System.Drawing.Point(48, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(121, 37);
            this.panel8.TabIndex = 5;
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextPage.Font = new System.Drawing.Font("Zekton Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NextPage.Location = new System.Drawing.Point(3, 3);
            this.NextPage.Name = "NextPage";
            this.NextPage.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.NextPage.Size = new System.Drawing.Size(114, 31);
            this.NextPage.TabIndex = 4;
            this.NextPage.TabStop = false;
            this.NextPage.Text = "Next Page";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel7.Controls.Add(this.Launch);
            this.panel7.Location = new System.Drawing.Point(366, 327);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(208, 37);
            this.panel7.TabIndex = 5;
            // 
            // Launch
            // 
            this.Launch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Launch.Font = new System.Drawing.Font("Zekton Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Launch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Launch.Location = new System.Drawing.Point(3, 3);
            this.Launch.Name = "Launch";
            this.Launch.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.Launch.Size = new System.Drawing.Size(202, 31);
            this.Launch.TabIndex = 5;
            this.Launch.TabStop = false;
            this.Launch.Text = "Launch Application";
            this.Launch.UseVisualStyleBackColor = false;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel5.Controls.Add(this.PathText);
            this.panel5.Location = new System.Drawing.Point(247, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 34);
            this.panel5.TabIndex = 2;
            // 
            // PathText
            // 
            this.PathText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PathText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathText.Font = new System.Drawing.Font("Zekton Rg", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PathText.Location = new System.Drawing.Point(3, 3);
            this.PathText.MinimumSize = new System.Drawing.Size(218, 28);
            this.PathText.Multiline = true;
            this.PathText.Name = "PathText";
            this.PathText.PlaceholderText = "Path To .exe";
            this.PathText.Size = new System.Drawing.Size(321, 28);
            this.PathText.TabIndex = 2;
            this.PathText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.StartUp);
            this.panel4.Location = new System.Drawing.Point(131, 327);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel4.Size = new System.Drawing.Size(86, 37);
            this.panel4.TabIndex = 3;
            // 
            // StartUp
            // 
            this.StartUp.AutoSize = true;
            this.StartUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.StartUp.Font = new System.Drawing.Font("Zekton Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartUp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartUp.Location = new System.Drawing.Point(3, 4);
            this.StartUp.MinimumSize = new System.Drawing.Size(80, 30);
            this.StartUp.Name = "StartUp";
            this.StartUp.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.StartUp.Size = new System.Drawing.Size(80, 30);
            this.StartUp.TabIndex = 0;
            this.StartUp.Text = "StartUp";
            this.StartUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.Path);
            this.panel3.Location = new System.Drawing.Point(131, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 34);
            this.panel3.TabIndex = 2;
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Path.Font = new System.Drawing.Font("Zekton Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Path.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Path.Location = new System.Drawing.Point(3, 3);
            this.Path.MinimumSize = new System.Drawing.Size(80, 28);
            this.Path.Name = "Path";
            this.Path.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Path.Size = new System.Drawing.Size(80, 28);
            this.Path.TabIndex = 1;
            this.Path.Text = "Path";
            this.Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.ApplicationName);
            this.panel2.Controls.Add(this.Title);
            this.panel2.Location = new System.Drawing.Point(247, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 35);
            this.panel2.TabIndex = 1;
            // 
            // ApplicationName
            // 
            this.ApplicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ApplicationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApplicationName.Font = new System.Drawing.Font("Zekton Rg", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ApplicationName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ApplicationName.Location = new System.Drawing.Point(3, 3);
            this.ApplicationName.MinimumSize = new System.Drawing.Size(218, 28);
            this.ApplicationName.Multiline = true;
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.PlaceholderText = "ApplicationName";
            this.ApplicationName.Size = new System.Drawing.Size(218, 28);
            this.ApplicationName.TabIndex = 1;
            this.ApplicationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(218, 28);
            this.Title.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel6.Controls.Add(this.StartUpSwitch);
            this.panel6.Location = new System.Drawing.Point(250, 327);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(86, 37);
            this.panel6.TabIndex = 4;
            // 
            // StartUpSwitch
            // 
            this.StartUpSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.StartUpSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartUpSwitch.Font = new System.Drawing.Font("Zekton Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartUpSwitch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartUpSwitch.Location = new System.Drawing.Point(3, 3);
            this.StartUpSwitch.MaximumSize = new System.Drawing.Size(80, 35);
            this.StartUpSwitch.Name = "StartUpSwitch";
            this.StartUpSwitch.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.StartUpSwitch.Size = new System.Drawing.Size(80, 32);
            this.StartUpSwitch.TabIndex = 4;
            this.StartUpSwitch.TabStop = false;
            this.StartUpSwitch.Text = "Y\\N";
            this.StartUpSwitch.UseVisualStyleBackColor = false;
            this.StartUpSwitch.Click += new System.EventHandler(this.StartUpSwitch_Click);
            // 
            // ApplicationsList
            // 
            this.ApplicationsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplicationsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ApplicationsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApplicationsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ApplicationsList.Font = new System.Drawing.Font("Zekton Rg", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ApplicationsList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ApplicationsList.FormattingEnabled = true;
            this.ApplicationsList.IntegralHeight = false;
            this.ApplicationsList.ItemHeight = 14;
            this.ApplicationsList.Location = new System.Drawing.Point(0, 0);
            this.ApplicationsList.Margin = new System.Windows.Forms.Padding(0);
            this.ApplicationsList.MaximumSize = new System.Drawing.Size(150, 945);
            this.ApplicationsList.Name = "ApplicationsList";
            this.ApplicationsList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ApplicationsList.Size = new System.Drawing.Size(150, 551);
            this.ApplicationsList.TabIndex = 0;
            this.ApplicationsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ApplicationsList_MouseClick);
            this.ApplicationsList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ApplicationsList_DrawItem);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel13.Controls.Add(this.ApplicationsList);
            this.panel13.Location = new System.Drawing.Point(2, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(147, 554);
            this.panel13.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(862, 555);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Name = "Form1";
            this.Text = "Grey Administration Manager";
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.AutoStartUp.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Button StartUpSwitch;
        private System.Windows.Forms.Label StartUp;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.ListBox ApplicationsList;
        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button AddApp;
        private System.Windows.Forms.TextBox ApplicationName;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button RemoveEntry;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox EventMgr;
        private System.Windows.Forms.Panel AutoStartUp;
        private System.Windows.Forms.Button GAMStartUp;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button LaunchStartups;
    }
}

