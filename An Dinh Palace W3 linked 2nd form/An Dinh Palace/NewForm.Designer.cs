namespace An_Dinh_Palace
{
    partial class NewForm
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
            this.components = new System.ComponentModel.Container();
            this.labelBlinkingText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonLinkThirdForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBlinkingText
            // 
            this.labelBlinkingText.AutoSize = true;
            this.labelBlinkingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlinkingText.Location = new System.Drawing.Point(50, 35);
            this.labelBlinkingText.Name = "labelBlinkingText";
            this.labelBlinkingText.Size = new System.Drawing.Size(795, 39);
            this.labelBlinkingText.TabIndex = 0;
            this.labelBlinkingText.Text = "This page is still in progress. Please visit again.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonLinkThirdForm
            // 
            this.buttonLinkThirdForm.Location = new System.Drawing.Point(259, 194);
            this.buttonLinkThirdForm.Name = "buttonLinkThirdForm";
            this.buttonLinkThirdForm.Size = new System.Drawing.Size(231, 76);
            this.buttonLinkThirdForm.TabIndex = 1;
            this.buttonLinkThirdForm.Text = "Linked 3rd Form";
            this.buttonLinkThirdForm.UseVisualStyleBackColor = true;
            this.buttonLinkThirdForm.Click += new System.EventHandler(this.buttonLinkThirdForm_Click);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.buttonLinkThirdForm);
            this.Controls.Add(this.labelBlinkingText);
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBlinkingText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonLinkThirdForm;
    }
}