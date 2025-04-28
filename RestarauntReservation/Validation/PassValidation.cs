using RestarauntReservation.Forms;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace RestarauntReservation.Validation
{
    public class PassValidation
    {
        public PassValidation() { }
        public bool PasswordValidation(string password, Label label4)
        {
            var input = password;
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(input))
            {
                errors.Add("Поле с паролем пустое");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasNumber.IsMatch(input))
            {
                errors.Add("* одно числовое значение");
                //return false;
            }
            if (!hasUpperChar.IsMatch(input))
            {
                errors.Add("* одна заглавная буква");
                //return false;
            }
            if (!hasLowerChar.IsMatch(input))
            {
                errors.Add("* одна строчная буква");
                //return false;
            }
            if (errors.Count > 0)
            {
                label4.Text = string.Join("\n", errors);
                return false;
            }

            label4.Text = "";
            return true;
        }
    }
}
