using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakharov.Origin.Model {
    public class COriginContext:  DbContext {
        public DbSet<CPerson> Persons { get; set; }
    }
}
