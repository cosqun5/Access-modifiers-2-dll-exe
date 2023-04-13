using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Custom
{
    public class Validator1
    {

        public void ValidatorUserName(string username)
        {
            if (username.Length >= 2)
            {
                Console.WriteLine("UserName:" + " " + username);
                return;
            }
            Console.WriteLine("UserName  must be at least 2 characters long. ");
        }
        public void ValidatorName(string name)
        {
            if (name.Length >= 2)
            {
                Console.WriteLine("Name:" + " " + name);
                return;
            }
            Console.WriteLine("Name  must be at least 2 characters long. ");
        }
        public void ValidatorSurname(string surname)
        {
            if (surname.Length >= 2)
            {
                Console.WriteLine("Surname:" + " " + surname);
                return;
            }
            Console.WriteLine("Surname must be at least 2 characters long. ");
        }
        public void ValidatorAge(int age)
        {
            if (age > 0)
            {
                Console.WriteLine("Age:" + " " + age);
                return;
            }
            Console.WriteLine("Enter your age");

        }
        public void ValidatorBirthDay(int birthday)
        {
            if (birthday >= 1970)
            {
                Console.WriteLine("Birthday:" + " " + birthday);
                return;
            }
            Console.WriteLine("Year should not be less than 1970.");

        }
        
        public void ValidatorPassword(string password,string regexPattern)
        {
            if (Regex.IsMatch(password, regexPattern))
            {
                Console.WriteLine("Password :"+" "+password);
                return;
            }
            Console.WriteLine("Password is not salt.");
           
       
        }



    }
}