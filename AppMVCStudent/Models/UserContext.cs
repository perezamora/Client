using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppMVCStudent.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")
        {

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<UserModel> Users { get; set; }
    }
}