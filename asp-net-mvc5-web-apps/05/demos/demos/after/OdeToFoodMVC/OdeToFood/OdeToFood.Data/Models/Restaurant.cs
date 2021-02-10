using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required] // View validation
        // [RegularExpression("Regex")]
        // [Range(0, 100, "My error message")]
        public string Name { get; set; }

        [Display(Name="Type of food")]  // View validation
        // [DisplayFormat(DataFormatString = "")]
        // [DisplayFormat(NullDisplayText = "")]
        // [DataType(DataType.Password)]
        public CuisineType Cuisine { get; set; }
    }
}
