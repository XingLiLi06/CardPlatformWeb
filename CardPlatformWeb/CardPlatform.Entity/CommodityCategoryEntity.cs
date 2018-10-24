using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPlatform.Entity
{
    public class CommodityCategoryEntity
    {
        public string Id { get; set; }
        public int RowIndex { get; set; }
        public bool OnSale { get; set; }
        public string PaymentLink { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
