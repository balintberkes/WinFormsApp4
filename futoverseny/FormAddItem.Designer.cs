namespace futoverseny
{
    partial class FormAddItem
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "VersenyzoID", true));
            textBox1.Location = new Point(79, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(676, 39);
            textBox1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(ClassVersenyzok);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox2.Location = new Point(79, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(676, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Nemzetiseg", true));
            textBox3.Location = new Point(79, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(676, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "EredmenyPerc", true));
            textBox4.Location = new Point(79, 303);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(676, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Kategoria", true));
            textBox5.Location = new Point(79, 396);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(676, 39);
            textBox5.TabIndex = 4;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(296, 563);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(150, 46);
            buttonOK.TabIndex = 5;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormAddItem
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 708);
            Controls.Add(buttonOK);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormAddItem";
            Text = "FormAddItem";
            Load += FormAddItem_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private BindingSource bindingSource1;
        private Button buttonOK;
    }
}