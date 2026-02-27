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
    public partial class Login : Form
    {
        public static Login Instanse;
        public static User User { get; set; }
        public Login()
        {
            InitializeComponent();
            Instanse = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Demo25nowContext db=new Demo25nowContext())
            {
                User user = db.Users.FirstOrDefault(p => p.Login == textBox1.Text);
                if (user != null)
                {
                    User = user;
                    if (user.Password == textBox2.Text)
                    {
                        Form1 form = new Form1();
                        form.Show();
                        this.Hide();
                    }
                }
                else MessageBox.Show("Неверные данные");
            }
        }
    }
}
