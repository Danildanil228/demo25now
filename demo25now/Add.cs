using demo25now.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace demo25now
{
    public partial class Add : Form
    {
        public string FilePath;
        public string FileName;
        public Add(Product product)
        {
            InitializeComponent();
            LoadMan();

            textBox1.Text = product.ProductName;
            textBox2.Text = product.Cost.ToString();
            richTextBox1.Text = product.Description;
            comboBox1.Text = product.ManufactureName;
            isActive.Checked = product.IsActive;
            if (!string.IsNullOrEmpty(product.MainImagePath))
            {
                string imagePath = Path.Combine(Application.StartupPath, product.MainImagePath);
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void LoadMan()
        {
            using (Demo25nowContext db = new Demo25nowContext())
            {
                var man = db.Manufactures.ToList();
                comboBox1.Items.Clear();
                foreach (var item in man)
                {
                    comboBox1.Items.Add(item.ManufactureName);
                }
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadimg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                FilePath = openFileDialog1.FileName;
                FileName = openFileDialog1.SafeFileName;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

