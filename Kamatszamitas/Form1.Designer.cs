namespace Kamatszamitas
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbHitelÖsszege = new TextBox();
            tbHaviKamat = new TextBox();
            btnOK = new Button();
            label1 = new Label();
            label2 = new Label();
            cbHaviTörlesztő = new CheckBox();
            SuspendLayout();
            // 
            // tbHitelÖsszege
            // 
            tbHitelÖsszege.Location = new Point(206, 161);
            tbHitelÖsszege.Name = "tbHitelÖsszege";
            tbHitelÖsszege.Size = new Size(150, 31);
            tbHitelÖsszege.TabIndex = 0;
            // 
            // tbHaviKamat
            // 
            tbHaviKamat.Location = new Point(206, 213);
            tbHaviKamat.Name = "tbHaviKamat";
            tbHaviKamat.Size = new Size(150, 31);
            tbHaviKamat.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(538, 229);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 160);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 4;
            label1.Text = "Hitel összege";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 216);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 5;
            label2.Text = "Havi kamat";
            // 
            // cbHaviTörlesztő
            // 
            cbHaviTörlesztő.AutoSize = true;
            cbHaviTörlesztő.Location = new Point(205, 274);
            cbHaviTörlesztő.Name = "cbHaviTörlesztő";
            cbHaviTörlesztő.Size = new Size(147, 29);
            cbHaviTörlesztő.TabIndex = 6;
            cbHaviTörlesztő.Text = "Havi törlesztő";
            cbHaviTörlesztő.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbHaviTörlesztő);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Controls.Add(tbHaviKamat);
            Controls.Add(tbHitelÖsszege);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbHitelÖsszege;
        private TextBox tbHaviKamat;
        private Button btnOK;
        private Label label1;
        private Label label2;
        private CheckBox cbHaviTörlesztő;
    }
}
