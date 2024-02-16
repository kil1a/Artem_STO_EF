using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace STO_EF.Databse.Tables
{
    [PrimaryKey(nameof(Id))]
    public class BillTable
    {
        [Key]
        public int Id { get; set; }
        public int Price { get; set; }
    }
}
