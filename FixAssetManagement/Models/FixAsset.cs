
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FixAssetManagement.Models
{
    [Table("Employees",Schema ="dbo")]
    public class FixAsset
    {
        [Key]
        [Display(Name="ID")]
        public int? EmployeeId { get; set; }




        [Display(Name="Purchase of year")]
        public int YearOfPurchase { get; set; }




        [Display(Name ="Historical Cost")]
        public string HistoricalCost { get; set; }





        [Display(Name = "Purchase Order")]
        public string PurchaseOrder { get; set; }




       
        [Display(Name ="User Name")]
        public string UserName { get; set; }





        [Display(Name ="Location")]
        public string Location { get; set; }





        [Display(Name ="Specification")]
        public string Specification { get; set; }





        //[Display(Name ="Description")]
        //public string Description { get; set; }






        [Display(Name ="Rate")]
        public decimal Rate { get; set; }






        [Display(Name ="Accumulated Balance")]
        public decimal AccumulatedBalance { get; set; }






        //[Display(Name="Name")]
        //[Column(TypeName ="varchar(250")]
        //public string EmployeeName { get; set; } = string.Empty;





        
        [Display(Name="Product Image")]
        [Column(TypeName ="varchar(250)")]
        public string? ImageUser { get; set; }





        

        //[Display(Name ="Birth Date")][DataType(DataType.Date)]
        //public DateTime BirthDate { get; set; }


        //[Display(Name = "Salary")]
        //[Column(TypeName ="decimal(12,2)")]
        //public decimal Salary { get; set; }


        //[Display(Name = "Hiring Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString ="{0:dd-MMMM-yyyy}")]
        //public DateTime HiringDate { get; set; }


        //[Required]
        //[Display(Name ="National ID")]
        //[MaxLength(14)]
        //[MinLength(14)]
        //[Column(TypeName ="varchar(14)")]
        //public string NationalId { get; set; }
    }
}
