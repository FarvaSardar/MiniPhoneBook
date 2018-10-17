using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MiniPhoneBook.Models
{
    public class PersonViewModel
    {
        [Required]
        [Display(Name = "PersonId")]
        public int PersonId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Added On")]
        public System.DateTime AddedOn { get; set; }
        [Required]
        [Display(Name = "Added By")]
        [Key]
        [ForeignKey("Person")]
        public string AddedBy { get; set; }
        [Required]
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }
        [Required]
        [Display(Name = "Home City")]
        public string HomeCity { get; set; }
        [Required]
        [Display(Name = "Facebook Account ID")]
        public string FaceBookAccountId { get; set; }
        [Required]
        [Display(Name = "LinkedIn ID")]
        public string LinkedInId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Update On")]
        public Nullable<System.DateTime> UpdateOn { get; set; }
        [Required]
        [Display(Name = "Twitter ID")]
        public string TwitterId { get; set; }
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }
        /* [Required]
[Display(Name = "PersonId")]
public int PersonId { get; set; }

[Required]
[Display(Name = "First Name")]
public String FirstName { get; set; }

[Required]
[Display(Name = "Middle Name")]
public String MiddleName { get; set; }

[Required]
[Display(Name = "Last Name")]
public String LastName { get; set; }

[DataType(DataType.Date)]
[Display(Name = "Date of Birth")]
public DateTime DateOfBirth { get; set; }

[DataType(DataType.Date)]
[Display(Name = "Added On")]
public DateTime AddedOn { get; set; }

[Required]
[Display(Name = "Added By")]
public String AddedBy { get; set; }

[Required]
[Display(Name = "Home Address")]
public String HomeAddress { get; set; }


[Required]
[Display(Name = "Home City")]
public String HomeCity { get; set; }


[Required]
[Display(Name = "FaceBook Account ID")]
public String FaceBookAccountId { get; set; }

[Required]
[Display(Name = "LinkedIn ID")]
public String LinkedInId { get; set; }

[DataType(DataType.Date)]
[Display(Name = "Update On")]
public DateTime UpdateOn { get; set; }

[Required]
[Display(Name = "Twitter ID")]
public String TwitterId { get; set; }

[EmailAddress]
public String EmailId { get; set; }
*/

    }
}