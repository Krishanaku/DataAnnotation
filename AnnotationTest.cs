using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation
{
    public static  class AnnotationTest
    {
        public static void display()
        {
            Console.WriteLine("Employee class Validation");
            Employee employee = new Employee(); 
            employee.Name= "Krishna";
            employee.Age = 24;
            employee.PhoneNumber = "1234567890";
            employee.Email = "krishna@gmail.com";
            ValidationContext context = new ValidationContext(employee, null, null);
            List<ValidationResult> result = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, result, true);

            if(!valid)
            {
                foreach(ValidationResult validationResult in result)
                {
                    Console.WriteLine("Member Name : {0}", validationResult.MemberNames.First());
                    Console.WriteLine("Error Msg :{0}", validationResult.ErrorMessage);

                }
            }
            else
            {
                Console.WriteLine("Name : " + employee.Name + " Age : " + employee.Age + " PhoneNumber : " + employee.PhoneNumber + " Email: " + employee.Email);
            }
        }
    }
}
