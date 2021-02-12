using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

    }
}
