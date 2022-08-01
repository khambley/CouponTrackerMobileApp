using System;

namespace CouponTrackerAPI.Models
{
    public class CouponItem
    {
        public int Id { get; set; }
        public string CouponType { get; set; }
        public string Category { get; set; }
        public string StoreName { get; set; }
        public string MfrName { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal SavingsAmount { get; set; }
        public int SavingsQty { get; set; }
        public string SavingsDescription { get; set; }
        public string ImageFilename { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
