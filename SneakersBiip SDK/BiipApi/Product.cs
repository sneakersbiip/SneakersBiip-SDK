using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakersBiip.BiipApi
{
    public class Product
    {
        public string Id { get; set; }

        public string ShopLink { get; set; }

        public string Link { get; set; }

        public string Title { get; set; }
        public string ImageLink { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }

        public NotificationType UpdateType { get; set; }

        public List<Variant> Variants { get; set; }

    }

    public enum NotificationType
    {
        Release,
        Restock,
    }

    public class Variant
    {
        public string Id { get; set; }

        public string Title { get; set; }
        public string Atc { get; set; }
        public string Sku { get; set; }
    }
}
