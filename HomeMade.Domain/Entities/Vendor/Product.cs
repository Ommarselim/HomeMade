using HomeMade.Domain.Entities.Customer;
using HomeMade.Domain.Entities.Order;
using HomeMade.Domain.Entities.Setting;
using HomeMade.Domain.Entities.Site;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMade.Domain.Entities.Vendor
{

    [Table("Product", Schema = "Vendor")]
    public class Product : BaseEntity
    {
        public Product()
        {
            ProductGuid = Guid.NewGuid();
            ProductQuestion = new HashSet<ProductQuestion>();
            ProductImage = new HashSet<ProductImage>();
            CustomerFavourites = new HashSet<CustomerFavourites>();
            ProdQuestion = new HashSet<ProdQuestion>();
            CartDetails = new HashSet<CartDetails>();
            OrderItems = new HashSet<OrderItems>();
            QuantitiesRequestProduct = new HashSet<QuantitiesRequestProduct>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public Guid ProductGuid { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescAr { get; set; }
        public string DescEn { get; set; }
        public string Logo { get; set; }
        public string SKU { get; set; } //رقم التخزين
        private decimal price;
        private decimal quantity;
        private decimal weight;

        private const decimal MaxPrice = 1000000m;    // Define your maximum acceptable value
        private const decimal MaxQuantity = 1000000m; // Define your maximum acceptable value
        private const decimal MaxWeight = 1000000m;   // Define your maximum acceptable value

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > MaxPrice)
                {
                    throw new ArgumentOutOfRangeException(nameof(Price), $"Value for {nameof(Price)} cannot exceed {MaxPrice}.");
                }
                price = value;
            }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set
            {
                if (value > MaxQuantity)
                {
                    throw new ArgumentOutOfRangeException(nameof(Quantity), $"Value for {nameof(Quantity)} cannot exceed {MaxQuantity}.");
                }
                quantity = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > MaxWeight)
                {
                    throw new ArgumentOutOfRangeException(nameof(Weight), $"Value for {nameof(Weight)} cannot exceed {MaxWeight}.");
                }
                weight = value;
            }
        }

        public bool IsLimited { get; set; }
        public decimal DailyQuantity { get; set; }
        public string Size { get; set; }
        public string PiecesAr { get; set; }
        public string PiecesEn { get; set; }
        public decimal Discount { get; set; } //Percent
        public DateTime? StartDiscountDate { get; set; }
        public DateTime? EndDiscountDate { get; set; }
        public bool IsFixed { get; set; } //هل ثابت
        public bool IsHidden { get; set; }
        public bool IsAccepted { get; set; }
        public string KeyWords { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductOrder { get; set; } = 100;
        public decimal ProductRate { get; set; } = 5;
        public int ProductQuantity { get; set; }
        public int ProductQuantityType { get; set; }
        public decimal TimeTakenProcess { get; set; }
        public int MeasurementId { get; set; }   // MeasurementEnum
        #region FK
        public int VendorsID { get; set; } //fk
        public int DepartmentsID { get; set; } //fk
        public bool IsFavourite { get; set; }
        public virtual User User { get; set; }
        public virtual Departments Departments { get; set; }
        public virtual Vendors Vendors { get; set; }
        public virtual ICollection<CustomerFavourites> CustomerFavourites { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
        public virtual ICollection<ProductQuestion> ProductQuestion { get; set; }
        public virtual ICollection<ProdQuestion> ProdQuestion { get; set; }
        public virtual ICollection<CartDetails> CartDetails { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
        public virtual ICollection<QuantitiesRequestProduct> QuantitiesRequestProduct { get; set; }


        #endregion
    }
}
