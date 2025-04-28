using Microsoft.EntityFrameworkCore;
using RestarauntReservation.Forms;
using RestarauntReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestarauntReservation.Validation
{
    public class PhoneValidation
    {

        public bool NumberPhoneValidation(string phone, Label label3)
        {
            var input = phone;

            if (string.IsNullOrEmpty(input))
            {
                label3.Text = "Поле с номером телефона пустое";
                return false;
            }

            Regex hasPhone = new Regex(@"^(?:8|\+7)[\- ]?\(?\d{3}\)?[\- ]?\d{3}[\- ]?\d{2}[\- ]?\d{2}$");

            if (!hasPhone.IsMatch(phone))
            {
                label3.Text = "Номер телефона введен некорректно.";
                return false;
            }

            using (RestarauntContext context = new RestarauntContext())
            {
                var clients = context.Clients.AsNoTracking().ToList();
                Client client = clients.FirstOrDefault(c => c.Phone_Number == input);
                if (client == null)
                {
                    label3.Text = "";
                }
                else
                {
                    label3.Text = "Данный номер телефона уже занят";
                    return false;
                }

                return true;
            }
        }
    }
}
