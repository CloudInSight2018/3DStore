using System;
using System.Collections.Generic;

namespace _3DStore.Entities
{
    public class Store
    {
        public Int32 Id { get; set; }

        public string Name { get; set; }

        public IList<Category> Categories { get; set; }
    }
}
