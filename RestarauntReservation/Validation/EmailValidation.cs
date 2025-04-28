using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestarauntReservation.Forms;
using RestarauntReservation.Models;

namespace RestarauntReservation.Validation
{
    public class EmailValidation
    {
        public bool MailValidation(string email, Label label2)
        {
            var input = email;

            if (string.IsNullOrEmpty(input))
            {
                label2.Text = "Поле пустое";
                return false;
            }

            Regex hasEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (!hasEmail.IsMatch(input))
            {
                label2.Text = "Почта введена некорректно.";
                return false;
            }

            using (RestarauntContext context = new RestarauntContext())
            {
                var clients = context.Clients.AsNoTracking().ToList();
                Client client = clients.FirstOrDefault(c => c.Email == input);
                if (client == null)
                {
                    label2.Text = "";
                }
                else
                {
                    label2.Text = "Данная почта уже занята";
                    return false;
                }

                return true;
            }
        }
    }
}
