using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bangazon.Models
{
  public class Customer
  {
    [Key]
    public int CustomerId {get;set;}

    [Required]
    // Validation has to accept input of the type "date"
    [DataType(DataType.Date)]
    // Database generates date if not input by the user
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DateCreated {get;set;}

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public ICollection<PaymentType> PaymentTypes;
  }
}