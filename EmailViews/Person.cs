using System.Collections.Generic;

namespace EmailViews
{
    public class Person
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public List<string> PurchasedItems { get; set; }
    }
}
