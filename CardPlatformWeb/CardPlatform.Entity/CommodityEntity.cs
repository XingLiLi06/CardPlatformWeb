using CardPlatform.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPlatform.Entity
{
    public class CommodityEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        /// <summary>
        /// 销售单价
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// 商品成本
        /// </summary>
        public decimal CostPrice { get; set; }
        /// <summary>
        /// 最低限购
        /// </summary>
        public int MinPurchase { get; set; }
        /// <summary>
        /// 最高限购
        /// </summary>
        public int MaxPurchase { get; set; }
        /// <summary>
        /// 库存显示
        /// </summary>
        public InventoryShowType InventoryShowType { get; set; }
        /// <summary>
        /// 发货方式
        /// </summary>
        public DeliveryType DeliveryType { get; set; }
        /// <summary>
        /// 购买密码
        /// </summary>
        public string BuyPassword { get; set; }
        /// <summary>
        /// 购买备注
        /// </summary>
        public string BuyNote { get; set; }
        /// <summary>
        /// 库存预警数量
        /// </summary>
        public int InventoryWarnQuantity { get; set; }
        /// <summary>
        /// 启用阶梯批发价
        /// </summary>
        public bool EnableStepWholesalePrice { get; set; }
        /// <summary>
        /// 联系方式格式	
        /// </summary>
        public int ContactFormatType { get; set; }
        /// <summary>
        /// 商户QQ
        /// </summary>
        public string MerchantsQQ { get; set; }
        /// <summary>
        /// 商品说明
        /// </summary>
        public string CommodityDescription { get; set; }
        /// <summary>
        /// 使用说明
        /// </summary>
        public string UseDescription { get; set; }

    }
}
