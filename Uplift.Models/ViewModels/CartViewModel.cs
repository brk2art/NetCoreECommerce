using System.Collections.Generic;

namespace Uplift.Models.ViewModels
{
    public class CartViewModel
    {
        public List<Service> ServiceList { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
