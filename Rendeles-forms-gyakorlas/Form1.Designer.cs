namespace Rendeles_forms_gyakorlas
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
            User = new Button();
            button1 = new Button();
            xml = new Button();
            SuspendLayout();
            // 
            // User
            // 
            User.Location = new Point(100, 39);
            User.Name = "User";
            User.Size = new Size(164, 33);
            User.TabIndex = 0;
            User.Text = "Ügyfél kezelés";
            User.UseVisualStyleBackColor = true;
            User.Click += User_Click;
            // 
            // button1
            // 
            button1.Location = new Point(100, 78);
            button1.Name = "button1";
            button1.Size = new Size(164, 33);
            button1.TabIndex = 1;
            button1.Text = "Kategória kezelés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // xml
            // 
            xml.Location = new Point(100, 117);
            xml.Name = "xml";
            xml.Size = new Size(164, 33);
            xml.TabIndex = 2;
            xml.Text = "Xml";
            xml.UseVisualStyleBackColor = true;
            xml.Click += xml_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 437);
            Controls.Add(xml);
            Controls.Add(button1);
            Controls.Add(User);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button User;
        private Button button1;
        private Button xml;
    }
}
