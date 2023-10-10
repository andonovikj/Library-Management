using System.ComponentModel.DataAnnotations;

namespace library_management_app.Models
{
    public class Customer
    {
        
            public int CustomerId { get; set; }
            [Required, MinLength(3), MaxLength(50)]
            public string Name { get; set; }
        
    }
}
