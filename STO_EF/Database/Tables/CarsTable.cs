using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace STO_EF.Databse.Tables
{
    [PrimaryKey(nameof(Id))]
    public  class CarsTable
    {
        [Key]
        public int Id { get; set; }
        public string Name {  get; set; }
    }
}
