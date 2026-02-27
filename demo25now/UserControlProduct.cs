using demo25now.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace demo25now
{
    public partial class UserControlProduct : UserControl
    {
        private Form1 form1;
        private Product product;

        public UserControlProduct(Form1 _form1, Product _product)
        {
            InitializeComponent();
            this.form1 = _form1;
            this.product = _product;

            try
            {
                if (product.IsActive == false)
                    label3.Text = "не активен";
                else
                    label3.Hide();
                label3.ForeColor = Color.Red;
                label1.Text = product.ProductName;
                label2.Text = product.Cost.ToString("N0") + " руб.";
                label4.Text = product.ManufactureName;

                string fullPath = Path.Combine(Application.StartupPath,
                    product.MainImagePath);
                if (File.Exists(fullPath))
                    pictureBox1.Image = Image.FromFile(fullPath);


                this.DoubleClick += UserControlProduct_DoubleClick;
                pictureBox1.DoubleClick += UserControlProduct_DoubleClick;
                label1.DoubleClick += UserControlProduct_DoubleClick;
                label2.DoubleClick += UserControlProduct_DoubleClick;
                label3.DoubleClick += UserControlProduct_DoubleClick;
                label4.DoubleClick += UserControlProduct_DoubleClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void UserControlProduct_DoubleClick(object sender, EventArgs e)
        {
            form1.EditProduct(product);
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы хотите удалить {product.ProductName}?",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            using (Demo25nowContext db = new Demo25nowContext())
            {
                try
                {
                    pictureBox1.Image?.Dispose();

                    // Важно: прикрепляем продукт к новому контексту
                    db.Products.Attach(product);
                    db.Products.Remove(product);
                    db.SaveChanges();

                    string imagePath = Path.Combine(Application.StartupPath, product.MainImagePath ?? "");
                    if (File.Exists(imagePath))
                        File.Delete(imagePath);

                    form1.UpdateForms(db.Products.ToList());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Этот товар есть в заказах, вы пока не можете его удалить.\n"
                        + ex.Message);
                }
            }
        }

    }
}
