namespace An_Dinh_Palace
{
    partial class RSmainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSmainForm));
            this.groupBoxPalaceDirectory = new System.Windows.Forms.GroupBox();
            this.listBoxListofArea = new System.Windows.Forms.ListBox();
            this.labelPalaceDirectory = new System.Windows.Forms.Label();
            this.textBoxAboutPalace = new System.Windows.Forms.TextBox();
            this.groupBoxAnDinhDescription = new System.Windows.Forms.GroupBox();
            this.richTextBoxAnDinhDescription = new System.Windows.Forms.RichTextBox();
            this.groupBoxNavControl = new System.Windows.Forms.GroupBox();
            this.buttonMainHall = new System.Windows.Forms.Button();
            this.myCustomButtonEast = new An_Dinh_Palace.MyCustomButton.MyCustomButton();
            this.myCustomButtonWest = new An_Dinh_Palace.MyCustomButton.MyCustomButton();
            this.myCustomButtonSouth = new An_Dinh_Palace.MyCustomButton.MyCustomButton();
            this.myCustomButtonNorth = new An_Dinh_Palace.MyCustomButton.MyCustomButton();
            this.textBoxNavControl = new System.Windows.Forms.TextBox();
            this.groupBoxAreaInformation = new System.Windows.Forms.GroupBox();
            this.textBoxAreaDescription = new System.Windows.Forms.TextBox();
            this.textBoxAreaName = new System.Windows.Forms.TextBox();
            this.labelAreaDescription = new System.Windows.Forms.Label();
            this.labelAreaName = new System.Windows.Forms.Label();
            this.text_Effect2 = new An_Dinh_Palace.Text_Effect();
            this.buttonLinkNewForm = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxPalaceDirectory.SuspendLayout();
            this.groupBoxAnDinhDescription.SuspendLayout();
            this.groupBoxNavControl.SuspendLayout();
            this.groupBoxAreaInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPalaceDirectory
            // 
            this.groupBoxPalaceDirectory.BackColor = System.Drawing.Color.Lime;
            this.groupBoxPalaceDirectory.Controls.Add(this.listBoxListofArea);
            this.groupBoxPalaceDirectory.Controls.Add(this.labelPalaceDirectory);
            this.groupBoxPalaceDirectory.Location = new System.Drawing.Point(5, 234);
            this.groupBoxPalaceDirectory.Name = "groupBoxPalaceDirectory";
            this.groupBoxPalaceDirectory.Size = new System.Drawing.Size(191, 233);
            this.groupBoxPalaceDirectory.TabIndex = 0;
            this.groupBoxPalaceDirectory.TabStop = false;
            this.groupBoxPalaceDirectory.Text = "Palace Directory";
            // 
            // listBoxListofArea
            // 
            this.listBoxListofArea.BackColor = System.Drawing.Color.Purple;
            this.listBoxListofArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxListofArea.ForeColor = System.Drawing.Color.White;
            this.listBoxListofArea.FormattingEnabled = true;
            this.listBoxListofArea.ItemHeight = 16;
            this.listBoxListofArea.Items.AddRange(new object[] {
            "1. Main Hall",
            "2. Living Room",
            "3. Dinning Room",
            "4. Upstairs",
            "5.Front Yard",
            "",
            "",
            "Use navigation control",
            " to see area\'s information"});
            this.listBoxListofArea.Location = new System.Drawing.Point(-1, 31);
            this.listBoxListofArea.Name = "listBoxListofArea";
            this.listBoxListofArea.Size = new System.Drawing.Size(192, 196);
            this.listBoxListofArea.TabIndex = 1;
            // 
            // labelPalaceDirectory
            // 
            this.labelPalaceDirectory.AutoSize = true;
            this.labelPalaceDirectory.BackColor = System.Drawing.Color.Black;
            this.labelPalaceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalaceDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPalaceDirectory.Location = new System.Drawing.Point(5, 3);
            this.labelPalaceDirectory.Name = "labelPalaceDirectory";
            this.labelPalaceDirectory.Size = new System.Drawing.Size(186, 25);
            this.labelPalaceDirectory.TabIndex = 0;
            this.labelPalaceDirectory.Text = "Palace Directory";
            // 
            // textBoxAboutPalace
            // 
            this.textBoxAboutPalace.BackColor = System.Drawing.Color.Yellow;
            this.textBoxAboutPalace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAboutPalace.Location = new System.Drawing.Point(11, 0);
            this.textBoxAboutPalace.Name = "textBoxAboutPalace";
            this.textBoxAboutPalace.Size = new System.Drawing.Size(191, 29);
            this.textBoxAboutPalace.TabIndex = 2;
            this.textBoxAboutPalace.Text = "An Dinh Palace";
            // 
            // groupBoxAnDinhDescription
            // 
            this.groupBoxAnDinhDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBoxAnDinhDescription.Controls.Add(this.richTextBoxAnDinhDescription);
            this.groupBoxAnDinhDescription.Controls.Add(this.textBoxAboutPalace);
            this.groupBoxAnDinhDescription.Location = new System.Drawing.Point(1, 27);
            this.groupBoxAnDinhDescription.Name = "groupBoxAnDinhDescription";
            this.groupBoxAnDinhDescription.Size = new System.Drawing.Size(201, 188);
            this.groupBoxAnDinhDescription.TabIndex = 3;
            this.groupBoxAnDinhDescription.TabStop = false;
            this.groupBoxAnDinhDescription.Text = "groupBoxAn Dinh Description";
            // 
            // richTextBoxAnDinhDescription
            // 
            this.richTextBoxAnDinhDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richTextBoxAnDinhDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAnDinhDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAnDinhDescription.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxAnDinhDescription.Location = new System.Drawing.Point(6, 35);
            this.richTextBoxAnDinhDescription.Name = "richTextBoxAnDinhDescription";
            this.richTextBoxAnDinhDescription.Size = new System.Drawing.Size(189, 136);
            this.richTextBoxAnDinhDescription.TabIndex = 4;
            this.richTextBoxAnDinhDescription.Text = resources.GetString("richTextBoxAnDinhDescription.Text");
            // 
            // groupBoxNavControl
            // 
            this.groupBoxNavControl.BackColor = System.Drawing.Color.DarkGray;
            this.groupBoxNavControl.Controls.Add(this.buttonMainHall);
            this.groupBoxNavControl.Controls.Add(this.myCustomButtonEast);
            this.groupBoxNavControl.Controls.Add(this.myCustomButtonWest);
            this.groupBoxNavControl.Controls.Add(this.myCustomButtonSouth);
            this.groupBoxNavControl.Controls.Add(this.myCustomButtonNorth);
            this.groupBoxNavControl.Controls.Add(this.textBoxNavControl);
            this.groupBoxNavControl.Location = new System.Drawing.Point(359, 382);
            this.groupBoxNavControl.Name = "groupBoxNavControl";
            this.groupBoxNavControl.Size = new System.Drawing.Size(345, 299);
            this.groupBoxNavControl.TabIndex = 7;
            this.groupBoxNavControl.TabStop = false;
            this.groupBoxNavControl.Enter += new System.EventHandler(this.groupBoxNavControl_Enter);
            // 
            // buttonMainHall
            // 
            this.buttonMainHall.BackColor = System.Drawing.Color.Black;
            this.buttonMainHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainHall.ForeColor = System.Drawing.Color.Red;
            this.buttonMainHall.Location = new System.Drawing.Point(105, 122);
            this.buttonMainHall.Name = "buttonMainHall";
            this.buttonMainHall.Size = new System.Drawing.Size(135, 91);
            this.buttonMainHall.TabIndex = 13;
            this.buttonMainHall.Text = "Main Hall";
            this.buttonMainHall.UseVisualStyleBackColor = false;
            this.buttonMainHall.Click += new System.EventHandler(this.buttonMainHall_Click);
            // 
            // myCustomButtonEast
            // 
            this.myCustomButtonEast.BackColor = System.Drawing.Color.Blue;
            this.myCustomButtonEast.BorderColor = System.Drawing.Color.Yellow;
            this.myCustomButtonEast.BorderRadius = 40;
            this.myCustomButtonEast.BorderSize = 3;
            this.myCustomButtonEast.FlatAppearance.BorderSize = 0;
            this.myCustomButtonEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCustomButtonEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCustomButtonEast.ForeColor = System.Drawing.Color.White;
            this.myCustomButtonEast.Location = new System.Drawing.Point(240, 122);
            this.myCustomButtonEast.Name = "myCustomButtonEast";
            this.myCustomButtonEast.Size = new System.Drawing.Size(105, 91);
            this.myCustomButtonEast.TabIndex = 12;
            this.myCustomButtonEast.Text = "East";
            this.myCustomButtonEast.UseVisualStyleBackColor = false;
            this.myCustomButtonEast.Click += new System.EventHandler(this.myCustomButtonEast_Click);
            // 
            // myCustomButtonWest
            // 
            this.myCustomButtonWest.BackColor = System.Drawing.Color.Lime;
            this.myCustomButtonWest.BorderColor = System.Drawing.Color.DarkMagenta;
            this.myCustomButtonWest.BorderRadius = 40;
            this.myCustomButtonWest.BorderSize = 3;
            this.myCustomButtonWest.FlatAppearance.BorderSize = 0;
            this.myCustomButtonWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCustomButtonWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCustomButtonWest.ForeColor = System.Drawing.Color.White;
            this.myCustomButtonWest.Location = new System.Drawing.Point(0, 122);
            this.myCustomButtonWest.Name = "myCustomButtonWest";
            this.myCustomButtonWest.Size = new System.Drawing.Size(99, 91);
            this.myCustomButtonWest.TabIndex = 11;
            this.myCustomButtonWest.Text = "West";
            this.myCustomButtonWest.UseVisualStyleBackColor = false;
            this.myCustomButtonWest.Click += new System.EventHandler(this.myCustomButtonWest_Click);
            // 
            // myCustomButtonSouth
            // 
            this.myCustomButtonSouth.BackColor = System.Drawing.Color.Magenta;
            this.myCustomButtonSouth.BorderColor = System.Drawing.Color.LimeGreen;
            this.myCustomButtonSouth.BorderRadius = 40;
            this.myCustomButtonSouth.BorderSize = 3;
            this.myCustomButtonSouth.FlatAppearance.BorderSize = 0;
            this.myCustomButtonSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCustomButtonSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCustomButtonSouth.ForeColor = System.Drawing.Color.White;
            this.myCustomButtonSouth.Location = new System.Drawing.Point(120, 209);
            this.myCustomButtonSouth.Name = "myCustomButtonSouth";
            this.myCustomButtonSouth.Size = new System.Drawing.Size(97, 84);
            this.myCustomButtonSouth.TabIndex = 9;
            this.myCustomButtonSouth.Text = "South";
            this.myCustomButtonSouth.UseVisualStyleBackColor = false;
            this.myCustomButtonSouth.Click += new System.EventHandler(this.myCustomButtonSouth_Click);
            // 
            // myCustomButtonNorth
            // 
            this.myCustomButtonNorth.BackColor = System.Drawing.Color.Red;
            this.myCustomButtonNorth.BorderColor = System.Drawing.Color.LawnGreen;
            this.myCustomButtonNorth.BorderRadius = 40;
            this.myCustomButtonNorth.BorderSize = 3;
            this.myCustomButtonNorth.FlatAppearance.BorderSize = 0;
            this.myCustomButtonNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myCustomButtonNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCustomButtonNorth.ForeColor = System.Drawing.Color.White;
            this.myCustomButtonNorth.Location = new System.Drawing.Point(120, 35);
            this.myCustomButtonNorth.Name = "myCustomButtonNorth";
            this.myCustomButtonNorth.Size = new System.Drawing.Size(99, 91);
            this.myCustomButtonNorth.TabIndex = 10;
            this.myCustomButtonNorth.Text = "North";
            this.myCustomButtonNorth.UseVisualStyleBackColor = false;
            this.myCustomButtonNorth.Click += new System.EventHandler(this.myCustomButtonNorth_Click);
            // 
            // textBoxNavControl
            // 
            this.textBoxNavControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNavControl.Location = new System.Drawing.Point(52, 0);
            this.textBoxNavControl.Name = "textBoxNavControl";
            this.textBoxNavControl.Size = new System.Drawing.Size(246, 29);
            this.textBoxNavControl.TabIndex = 0;
            this.textBoxNavControl.Text = "Navigation Controls";
            this.textBoxNavControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxAreaInformation
            // 
            this.groupBoxAreaInformation.BackColor = System.Drawing.Color.Cyan;
            this.groupBoxAreaInformation.Controls.Add(this.textBoxAreaDescription);
            this.groupBoxAreaInformation.Controls.Add(this.textBoxAreaName);
            this.groupBoxAreaInformation.Controls.Add(this.labelAreaDescription);
            this.groupBoxAreaInformation.Controls.Add(this.labelAreaName);
            this.groupBoxAreaInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAreaInformation.Location = new System.Drawing.Point(808, 406);
            this.groupBoxAreaInformation.Name = "groupBoxAreaInformation";
            this.groupBoxAreaInformation.Size = new System.Drawing.Size(320, 269);
            this.groupBoxAreaInformation.TabIndex = 8;
            this.groupBoxAreaInformation.TabStop = false;
            // 
            // textBoxAreaDescription
            // 
            this.textBoxAreaDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxAreaDescription.Location = new System.Drawing.Point(22, 84);
            this.textBoxAreaDescription.Multiline = true;
            this.textBoxAreaDescription.Name = "textBoxAreaDescription";
            this.textBoxAreaDescription.Size = new System.Drawing.Size(292, 176);
            this.textBoxAreaDescription.TabIndex = 4;
            this.textBoxAreaDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAreaName
            // 
            this.textBoxAreaName.Location = new System.Drawing.Point(79, 32);
            this.textBoxAreaName.Name = "textBoxAreaName";
            this.textBoxAreaName.Size = new System.Drawing.Size(209, 26);
            this.textBoxAreaName.TabIndex = 5;
            this.textBoxAreaName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAreaDescription
            // 
            this.labelAreaDescription.AutoSize = true;
            this.labelAreaDescription.ForeColor = System.Drawing.Color.Red;
            this.labelAreaDescription.Location = new System.Drawing.Point(110, 61);
            this.labelAreaDescription.Name = "labelAreaDescription";
            this.labelAreaDescription.Size = new System.Drawing.Size(143, 20);
            this.labelAreaDescription.TabIndex = 2;
            this.labelAreaDescription.Text = "Area Description";
            // 
            // labelAreaName
            // 
            this.labelAreaName.AutoSize = true;
            this.labelAreaName.ForeColor = System.Drawing.Color.Red;
            this.labelAreaName.Location = new System.Drawing.Point(129, 9);
            this.labelAreaName.Name = "labelAreaName";
            this.labelAreaName.Size = new System.Drawing.Size(98, 20);
            this.labelAreaName.TabIndex = 1;
            this.labelAreaName.Text = "Area Name";
            // 
            // text_Effect2
            // 
            this.text_Effect2.AutoSize = true;
            this.text_Effect2.BackColor = System.Drawing.Color.Black;
            this.text_Effect2.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Effect2.ForeColor = System.Drawing.Color.Lime;
            this.text_Effect2.Location = new System.Drawing.Point(271, 11);
            this.text_Effect2.Name = "text_Effect2";
            this.text_Effect2.Set_Speed = 5;
            this.text_Effect2.Size = new System.Drawing.Size(744, 87);
            this.text_Effect2.TabIndex = 10;
            this.text_Effect2.Text = "Welcome to An Dinh Palace";
            this.text_Effect2.UseCompatibleTextRendering = true;
            // 
            // buttonLinkNewForm
            // 
            this.buttonLinkNewForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonLinkNewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinkNewForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLinkNewForm.Location = new System.Drawing.Point(386, 174);
            this.buttonLinkNewForm.Name = "buttonLinkNewForm";
            this.buttonLinkNewForm.Size = new System.Drawing.Size(192, 41);
            this.buttonLinkNewForm.TabIndex = 11;
            this.buttonLinkNewForm.Text = "Linked New Form";
            this.buttonLinkNewForm.UseVisualStyleBackColor = false;
            this.buttonLinkNewForm.Click += new System.EventHandler(this.buttonLinkNewForm_Click);
            // 
            // RSmainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::An_Dinh_Palace.Properties.Resources.mainHall2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 709);
            this.Controls.Add(this.buttonLinkNewForm);
            this.Controls.Add(this.text_Effect2);
            this.Controls.Add(this.groupBoxAreaInformation);
            this.Controls.Add(this.groupBoxNavControl);
            this.Controls.Add(this.groupBoxAnDinhDescription);
            this.Controls.Add(this.groupBoxPalaceDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RSmainForm";
            this.Text = "An Dinh Palace";
            this.Load += new System.EventHandler(this.RSmainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RSmainForm_Paint);
            this.groupBoxPalaceDirectory.ResumeLayout(false);
            this.groupBoxPalaceDirectory.PerformLayout();
            this.groupBoxAnDinhDescription.ResumeLayout(false);
            this.groupBoxAnDinhDescription.PerformLayout();
            this.groupBoxNavControl.ResumeLayout(false);
            this.groupBoxNavControl.PerformLayout();
            this.groupBoxAreaInformation.ResumeLayout(false);
            this.groupBoxAreaInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPalaceDirectory;
        private System.Windows.Forms.Label labelPalaceDirectory;
        private System.Windows.Forms.ListBox listBoxListofArea;
        private System.Windows.Forms.TextBox textBoxAboutPalace;
        private System.Windows.Forms.GroupBox groupBoxAnDinhDescription;
        private System.Windows.Forms.RichTextBox richTextBoxAnDinhDescription;
        private System.Windows.Forms.GroupBox groupBoxNavControl;
        private System.Windows.Forms.TextBox textBoxNavControl;
        private MyCustomButton.MyCustomButton myCustomButtonNorth;
        private MyCustomButton.MyCustomButton myCustomButtonSouth;
        private MyCustomButton.MyCustomButton myCustomButtonEast;
        private MyCustomButton.MyCustomButton myCustomButtonWest;
        private System.Windows.Forms.GroupBox groupBoxAreaInformation;
        private System.Windows.Forms.TextBox textBoxAreaName;
        private System.Windows.Forms.Label labelAreaDescription;
        private System.Windows.Forms.Label labelAreaName;
        private System.Windows.Forms.TextBox textBoxAreaDescription;
        private System.Windows.Forms.Button buttonMainHall;
        private Text_Effect text_Effect2;
        private System.Windows.Forms.Button buttonLinkNewForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}