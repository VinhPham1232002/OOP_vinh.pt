using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vinh.pt.Entity
{
    public class Product: BaseEntity
    {
        public int CategoryId { get; set; }

        internal static List<Product> FindAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }

}
