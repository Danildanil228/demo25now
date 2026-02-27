namespace demo25now
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
            panelproduct = new Panel();
            add = new Button();
            SuspendLayout();
            // 
            // panelproduct
            // 
            panelproduct.AutoScroll = true;
            panelproduct.Location = new Point(10, 9);
            panelproduct.Margin = new Padding(3, 2, 3, 2);
            panelproduct.Name = "panelproduct";
            panelproduct.Size = new Size(494, 320);
            panelproduct.TabIndex = 0;
            // 
            // add
            // 
            add.Location = new Point(557, 147);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 1;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(add);
            Controls.Add(panelproduct);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelproduct;
        private Button add;
    }
}
