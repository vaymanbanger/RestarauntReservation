using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using RestarauntReservation.Models;
using RestarauntReservation.Validation;

namespace RestarauntReservation.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Hashing hash = new Hashing();
            RestarauntContext context = new RestarauntContext();
            Client client = new Client
            {
                Name = Loginguna2TextBox.Text,
                Phone_Number = Numguna2TextBox3.Text,
                Email = Emailguna2TextBox.Text,
                Password = hash.Hash(Passguna2TextBox.Text)
            };
            context.Clients.Add(client);
            context.SaveChanges();

            Close();
            MessageBox.Show("Вы успешно зарегистрированы!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Loginguna2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Passguna2TextBox.Text != RepPassguna2TextBox.Text)
            {
                label5.Text = "Пароли не совпадают.";
            }
            else
            {
                label5.Text = "";
            }

            PassValidation Valid = new PassValidation();
            if (!Valid.PasswordValidation(Passguna2TextBox.Text, label4))
            {
            }
            else
            {
                label4.Text = "";
            }

            if ((Loginguna2TextBox.Text != "") && (Passguna2TextBox.Text != ""))
            {
                if (Loginguna2TextBox.Text == Passguna2TextBox.Text)
                {
                    label1.Text = "Пароль и логин не должны совпадать.";
                }
                else
                {
                    label1.Text = "";
                }
            }
            ValidationDataBaseLogin();

            EmailValidation emailValid = new EmailValidation();
            if (!emailValid.MailValidation(Emailguna2TextBox.Text, label2))
            {
            }
            else
            {
                label2.Text = "";
            }

            PhoneValidation phoneValidation = new PhoneValidation();
            if (!phoneValidation.NumberPhoneValidation(Numguna2TextBox3.Text, label3))
            {

            }
            else 
            {
                label3.Text = ""; 
            }

            if (label1.Text == "" && label2.Text == "" && label3.Text == "" && label4.Text == "" && label5.Text == "")
            {
                RegistrationButton.Enabled = true;
            }
        }

        /// <summary>
        /// Метод валидации логина по проходу БД
        /// </summary>
        /// <returns></returns>
        bool ValidationDataBaseLogin()
        {
            using (RestarauntContext context = new RestarauntContext())
            {
                var clients = context.Clients.AsNoTracking().ToList();
                Client client = clients.FirstOrDefault(c => c.Name == Loginguna2TextBox.Text);
                if (client == null)
                {
                    label1.Text = "";
                }
                else
                {
                    label1.Text = "Данный логин уже занят";
                    return false;
                }

                return true;
            }
        }
 
    }
    
}
