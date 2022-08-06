using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Core.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public Product Product { get; set; }
    }
}
