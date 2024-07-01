using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApp.Models
{
    public class MemberInfoViewModel
    {
        public Member Member { get; set; }
        public List<Product> Products { get; set; }
    }
}