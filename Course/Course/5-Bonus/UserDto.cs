using System;
using System.Collections.Generic;
using System.Text;

namespace Course._5_Bonus
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
        public DateTime? Birth { get; set; }
    }
}
