using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<Users>
    {
        public UserConfiguration()
        {
            ToTable("Users");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
