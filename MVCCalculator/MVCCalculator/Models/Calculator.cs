using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCalculator.Models
{
    public class Calculator
    {
        [Display(Name = "Number #1")]
        [Range(-100, 100, ErrorMessage = "Enter number in range from -100 do 100.")]
        [Required(ErrorMessage = "Please enter valid number value!")]
        public int Number1 { get; set; }
        [Display(Name = "Number #2")]
        public int Number2 { get; set; }
        public double Result { get; set; }
        public string Operation { get; set; }
        public List<SelectListItem> OperationAvailable { get; set; }

        public Calculator()
        {
            OperationAvailable = new List<SelectListItem>
            {
                new SelectListItem { Text = "Add", Value = "+", Selected = true },
                new SelectListItem { Text = "Substruct", Value = "-" },
                new SelectListItem { Text = "Multiply", Value = "*" },
                new SelectListItem { Text = "Divide", Value = "/" }
            };
        }

        public void Calc() 
        {
            switch (Operation)
            {
                case "+": Result = Number1 + Number2; 
                    break;
                case "-": Result = Number1 - Number2;
                    break;
                case "*": Result = Number1 * Number2;
                    break;
                case "/": Result = (double)Number1 / (double)Number2;
                    break;
            }

        }
    }
}
