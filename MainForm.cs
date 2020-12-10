using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_WF_TEST.modules;
namespace DB_WF_TEST
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeMyControl();
            GenForms GenForms = new GenForms();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TextLogin.Text) || string.IsNullOrEmpty(TextPass.Text))
            {
                MessageBox.Show("Логин или пароль не введены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            using (var db = new rndnappEntities())
            {
                var usr = db.users.AsNoTracking().FirstOrDefault(u => u.login == TextLogin.Text && u.pass == TextPass.Text);
                if (usr == null)
                {
                    MessageBox.Show("Пользователя не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                MessageBox.Show("Авторизация пройдена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.Visible = false;
                switch (usr.urole)
                {
                    case 0:
                        GenForms.AdminWindow();
                        break;
                    case 1:
                        GenForms.MemberWindow();
                        break;
                    
                }
            }
        }
        

    

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void InitializeMyControl()
        {
            TextPass.Text = "";
            TextPass.PasswordChar = '*';
            TextPass.MaxLength = 14;
        }
    }

}
