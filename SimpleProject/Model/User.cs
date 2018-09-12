using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProject.Model
{
    public enum Sex
    {
        none,
        female,
        man

    }
    public class UserModel
    {
        [DisplayAttribute(Name ="Name")]
        [Required]
        public String Name { get; set; }

        [DisplayAttribute(Name = "Age")]
        public int Age { get; set; }

        [DisplayAttribute(Name = "Sex")]
        public Sex Sex { get; set; }

    }
}
