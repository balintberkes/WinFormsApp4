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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            versenyzoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemzetisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eredmenyPercDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            classVersenyzokBindingSource = new BindingSource(components);
            buttonLoad = new Button();
            buttonSave = new Button();
            buttonNewItem = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classVersenyzokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { versenyzoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, nemzetisegDataGridViewTextBoxColumn, eredmenyPercDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = classVersenyzokBindingSource;
            dataGridView1.Location = new Point(85, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1325, 351);
            dataGridView1.TabIndex = 0;
            // 
            // versenyzoIDDataGridViewTextBoxColumn
            // 
            versenyzoIDDataGridViewTextBoxColumn.DataPropertyName = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.HeaderText = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            versenyzoIDDataGridViewTextBoxColumn.Name = "versenyzoIDDataGridViewTextBoxColumn";
            versenyzoIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 10;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 200;
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.MinimumWidth = 10;
            nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            nemzetisegDataGridViewTextBoxColumn.Width = 200;
            // 
            // eredmenyPercDataGridViewTextBoxColumn
            // 
            eredmenyPercDataGridViewTextBoxColumn.DataPropertyName = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.HeaderText = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.MinimumWidth = 10;
            eredmenyPercDataGridViewTextBoxColumn.Name = "eredmenyPercDataGridViewTextBoxColumn";
            eredmenyPercDataGridViewTextBoxColumn.Width = 200;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 10;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.Width = 200;
            // 
            // classVersenyzokBindingSource
            // 
            classVersenyzokBindingSource.DataSource = typeof(ClassVersenyzok);
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(1260, 249);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(150, 46);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Betöltés";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1075, 249);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 46);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonNewItem
            // 
            buttonNewItem.Location = new Point(1260, 704);
            buttonNewItem.Name = "buttonNewItem";
            buttonNewItem.Size = new Size(150, 46);
            buttonNewItem.TabIndex = 3;
            buttonNewItem.Text = "Új Sor";
            buttonNewItem.UseVisualStyleBackColor = true;
            buttonNewItem.Click += buttonNewItem_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(1075, 704);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 46);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(859, 249);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 46);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Szerkesztés";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 865);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonNewItem);
            Controls.Add(buttonSave);
            Controls.Add(buttonLoad);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)classVersenyzokBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonLoad;
        private Button buttonSave;
        private Button buttonNewItem;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource classVersenyzokBindingSource;
        private Button buttonEdit;
    }
}
