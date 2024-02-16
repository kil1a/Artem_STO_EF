using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace STO_EF.Databse.Tables
{
    [PrimaryKey(nameof(Id))]
    public class OrdersTable
    {
        [Key]
        public int Id { get; set; }
        public string Problem { get; set; }
        public int CarId {  get; set; }
        public int BillId {  get; set; }
    }
}
