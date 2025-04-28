using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using RestarauntReservation.Forms;
using RestarauntReservation.Models;
using RestarauntReservation.Validation;
using System.Security.Policy;

namespace RestarauntReservation
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var getHash = new Hashing();

            try
            {
                using (RestarauntContext context = new RestarauntContext())
                {
                    var staffs = context.Staffs.AsNoTracking().ToList();
                    var clients = context.Clients.AsNoTracking().ToList();
                    string hash = getHash.Hash(Passguna2TextBox.Text);
                    Staff staff = staffs.FirstOrDefault(s => s.Name == Userguna2TextBox.Text && s.Phone_Number == Numguna2TextBox.Text && s.Password == hash);
                    Client client = clients.FirstOrDefault(c => c.Name == Userguna2TextBox.Text && c.Phone_Number == Numguna2TextBox.Text && c.Password == hash);
                    if (staff != null)
                    {
                        StaffMenu staffMenu = new StaffMenu();
                        Hide();
                        staffMenu.Show();
                    }
                    else
                    {
                        if (client != null)
                        {
                            MainMenu mainMenu = new MainMenu(client);
                            Hide();
                            mainMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль, номер телефона. Попробуйте ещё раз", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Не подключена БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegistryButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}
