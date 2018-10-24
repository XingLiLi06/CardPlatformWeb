using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPlatform.Entity
{
    public class CommodityCardEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public string CardPassword { get; set; }
        public bool IsSell { get; set; }
        public bool Disable { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
