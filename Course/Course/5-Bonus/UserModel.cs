using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Course._5_Bonus
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }

        [Range(0, 130)]
        public DateTime? Birth { get; set; }
    }
}
