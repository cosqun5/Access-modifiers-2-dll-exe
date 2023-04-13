using Access_modifiers_2_dll_exe.Models;
using Custom;
using System.Text.RegularExpressions;

Person person = new Person();
Validator1 validator1 = new Validator1();

person.UserName = "CosqunSalahov";
person.Name = "Cosqun";
person.Surname = "Salahov";
person.Age = 21;
person.Birthday = 2002;
person.Password = "YourPassword123!";
string regexPattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\W_]).{8,}$";

validator1.ValidatorUserName(person.UserName);
validator1.ValidatorName(person.Name);
validator1.ValidatorSurname(person.Surname);
validator1.ValidatorAge(person.Age);
validator1.ValidatorBirthDay(person.Birthday);
validator1.ValidatorPassword(person.Password,regexPattern);  

