namespace Rendeles_forms_gyakorlas
{
    partial class TermekKategoriaForm
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
            treeViewKategoria = new TreeView();
            txtNev = new TextBox();
            txtLeiras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            UjTestv = new Button();
            Ujgyermek = new Button();
            Save = new Button();
            Delete = new Button();
            SuspendLayout();
            // 
            // treeViewKategoria
            // 
            treeViewKategoria.Location = new Point(12, 12);
            treeViewKategoria.Name = "treeViewKategoria";
            treeViewKategoria.Size = new Size(243, 426);
            treeViewKategoria.TabIndex = 0;
            // 
            // txtNev
            // 
            txtNev.Location = new Point(359, 12);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(408, 23);
            txtNev.TabIndex = 1;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(359, 53);
            txtLeiras.MinimumSize = new Size(0, 300);
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(408, 300);
            txtLeiras.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 187);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Leírás:";
            // 
            // UjTestv
            // 
            UjTestv.Location = new Point(359, 415);
            UjTestv.Name = "UjTestv";
            UjTestv.Size = new Size(119, 23);
            UjTestv.TabIndex = 5;
            UjTestv.Text = "Új testvér kat.";
            UjTestv.UseVisualStyleBackColor = true;
            // 
            // Ujgyermek
            // 
            Ujgyermek.Location = new Point(484, 415);
            Ujgyermek.Name = "Ujgyermek";
            Ujgyermek.Size = new Size(119, 23);
            Ujgyermek.TabIndex = 6;
            Ujgyermek.Text = "Új gyermek kat.";
            Ujgyermek.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.Location = new Point(629, 415);
            Save.Name = "Save";
            Save.Size = new Size(64, 23);
            Save.TabIndex = 7;
            Save.Text = "Mentés";
            Save.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(703, 415);
            Delete.Name = "Delete";
            Delete.Size = new Size(64, 23);
            Delete.TabIndex = 8;
            Delete.Text = "Törlés";
            Delete.UseVisualStyleBackColor = true;
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(Ujgyermek);
            Controls.Add(UjTestv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLeiras);
            Controls.Add(txtNev);
            Controls.Add(treeViewKategoria);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoria;
        private TextBox txtNev;
        private TextBox txtLeiras;
        private Label label1;
        private Label label2;
        private Button UjTestv;
        private Button Ujgyermek;
        private Button Save;
        private Button Delete;
    }
}