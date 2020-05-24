using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RPDemoApp.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }

        [DisplayName("Order Name")]
        public string OrderName { get; set; }

    }
}
