namespace Rendeles_forms_gyakorlas
{
    partial class UgyfelForm
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
            dataGridView1 = new DataGridView();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelBindingSource = new BindingSource(components);
            New = new Button();
            Delete = new Button();
            Refresh = new Button();
            Save = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, lakcimIdDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ugyfelBindingSource;
            dataGridView1.Location = new Point(11, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(783, 356);
            dataGridView1.TabIndex = 0;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // lakcimIdDataGridViewTextBoxColumn
            // 
            lakcimIdDataGridViewTextBoxColumn.DataPropertyName = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.HeaderText = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.Name = "lakcimIdDataGridViewTextBoxColumn";
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // New
            // 
            New.Location = new Point(11, 414);
            New.Name = "New";
            New.Size = new Size(169, 24);
            New.TabIndex = 1;
            New.Text = "Új (minta)";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(205, 414);
            Delete.Name = "Delete";
            Delete.Size = new Size(176, 24);
            Delete.TabIndex = 2;
            Delete.Text = "Törlés";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(615, 414);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(173, 24);
            Refresh.TabIndex = 3;
            Refresh.Text = "Frissítés";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Save
            // 
            Save.Location = new Point(426, 414);
            Save.Name = "Save";
            Save.Size = new Size(170, 24);
            Save.TabIndex = 4;
            Save.Text = "Mentés";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // UgyfelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 459);
            Controls.Add(Save);
            Controls.Add(Refresh);
            Controls.Add(Delete);
            Controls.Add(New);
            Controls.Add(dataGridView1);
            Name = "UgyfelForm";
            Text = "UgyfelForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource ugyfelBindingSource;
        private Button New;
        private Button Delete;
        private Button Refresh;
        private Button Save;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimIdDataGridViewTextBoxColumn;
    }
}