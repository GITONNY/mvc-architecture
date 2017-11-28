using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store.Model
{
    public class Users
    {
        [Key]
        public Guid UserID { get; set; }
        public string Name { get; set; }
    }
}
