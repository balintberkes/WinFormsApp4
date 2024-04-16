namespace futoverseny
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
            dataGridView1 = new DataGridView();
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonNewItem = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1325, 351);
            dataGridView1.TabIndex = 0;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(1260, 249);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(150, 46);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Betöltés";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1075, 249);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 46);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonNewItem
            // 
            buttonNewItem.Location = new Point(1260, 704);
            buttonNewItem.Name = "buttonNewItem";
            buttonNewItem.Size = new Size(150, 46);
            buttonNewItem.TabIndex = 3;
            buttonNewItem.Text = "Új Sor";
            buttonNewItem.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1075, 704);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 46);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 865);
            Controls.Add(buttonDelete);
            Controls.Add(buttonNewItem);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonNewItem;
        private Button buttonDelete;
    }
}
