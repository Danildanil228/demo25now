namespace demo25now
{
    partial class Add
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addBtn = new Button();
            cancel = new Button();
            loadimg = new Button();
            pictureBox1 = new PictureBox();
            isActive = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 190);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(258, 120);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 356);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 5;
            label1.Text = "Название продукта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 76);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 152);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 323);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 8;
            label4.Text = "Производитель";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(35, 417);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 9;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(147, 417);
            cancel.Name = "cancel";
            cancel.Size = new Size(94, 29);
            cancel.TabIndex = 10;
            cancel.Text = "Отмена";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // loadimg
            // 
            loadimg.Location = new Point(400, 417);
            loadimg.Name = "loadimg";
            loadimg.Size = new Size(94, 29);
            loadimg.TabIndex = 11;
            loadimg.Text = "Загрузить";
            loadimg.UseVisualStyleBackColor = true;
            loadimg.Click += loadimg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(322, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 370);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Location = new Point(192, 76);
            isActive.Name = "isActive";
            isActive.Size = new Size(100, 24);
            isActive.TabIndex = 13;
            isActive.Text = "Активный";
            isActive.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 467);
            Controls.Add(isActive);
            Controls.Add(pictureBox1);
            Controls.Add(loadimg);
            Controls.Add(cancel);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Add";
            Text = "Add";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button addBtn;
        private OpenFileDialog openFileDialog1;
        public TextBox textBox1;
        public TextBox textBox2;
        public RichTextBox richTextBox1;
        public ComboBox comboBox1;
        public Button cancel;
        public Button loadimg;
        public PictureBox pictureBox1;
        public CheckBox isActive;
    }
}