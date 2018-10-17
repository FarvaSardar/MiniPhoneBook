using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniPhoneBook.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Contact ID")]
        public int ContactId { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Person ID")]
        public int PersonId { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}