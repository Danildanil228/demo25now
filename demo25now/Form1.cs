using demo25now.Models;

namespace demo25now
{
    public partial class Form1 : Form
    {
        private List<Product> productList;
        private Demo25nowContext db;
        public Form1()
        {
            InitializeComponent();
            db = new Demo25nowContext();
            LoadProducts();
        }
        private void LoadProducts()
        {
            try
            {
                productList = db.Products.ToList();
                UpdateForms(productList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке продуктов"
                + ex.Message);
            }
        }
        public void UpdateForms(List<Product> products)
        {
            panelproduct.Controls.Clear();
            int yPosition = 0;
            foreach (Product product in products)
            {
                UserControlProduct productControl = new UserControlProduct(this, product);
                productControl.Top = yPosition;
                productControl.Left = 0;

                panelproduct.Controls.Add(productControl);
                yPosition += productControl.Height + 5;
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Instanse.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add formadd = new Add(new Product());
            if (formadd.ShowDialog() == DialogResult.OK)
            {
                Product product = new Product();
                product.ProductName = formadd.textBox1.Text;
                product.Cost = decimal.Parse(formadd.textBox2.Text);
                product.Description = formadd.richTextBox1.Text;
                product.ManufactureName = formadd.comboBox1.Text;
                product.IsActive = formadd.isActive.Checked ? true : false;

                if (formadd.FilePath != null && formadd.FileName != null)
                {
                    string photoDir = Path.Combine(Environment.CurrentDirectory, "Photo");
                    if (!Directory.Exists(photoDir))
                        Directory.CreateDirectory(photoDir);

                    string targetPath = Path.Combine(photoDir, formadd.FileName);
                    File.Copy(formadd.FilePath, targetPath, true);

                    product.MainImagePath = "Photo/" + formadd.FileName;
                }

                db.Products.Add(product);
                db.SaveChanges();
                UpdateForms(db.Products.ToList());
            }
        }
        public void EditProduct(Product product)
        {
            Add formadd = new Add(product);
            if (formadd.ShowDialog() == DialogResult.OK)
            {
                product.ProductName = formadd.textBox1.Text;
                product.Cost = decimal.Parse(formadd.textBox2.Text);
                product.Description = formadd.richTextBox1.Text;
                product.ManufactureName = formadd.comboBox1.Text;
                product.IsActive = formadd.isActive.Checked;

                if (formadd.FilePath != null && formadd.FileName != null)
                {
                    string photoDir = Path.Combine(Environment.CurrentDirectory, "Photo");
                    Directory.CreateDirectory(photoDir);

                    if (!string.IsNullOrEmpty(product.MainImagePath))
                    {
                        string oldImagePath = Path.Combine(Application.StartupPath, product.MainImagePath);
                        if (File.Exists(oldImagePath))
                            File.Delete(oldImagePath);
                    }

                    string targetPath = Path.Combine(photoDir, formadd.FileName);
                    File.Copy(formadd.FilePath, targetPath, true);
                    product.MainImagePath = "Photo/" + formadd.FileName;
                }

                db.SaveChanges();
                UpdateForms(db.Products.ToList());
            }
        }
    }
}
