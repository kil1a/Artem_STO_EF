using STO_EF.Databse.Tables;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
namespace STO_EF
{
    internal class DatabaseManager : IDisposable
    {
        STO _database = new STO();
        public void FillDataBase()
        {
            int choice = -1;
            while (true)
            {
                Console.WriteLine("1. Добавить счёт");
                Console.WriteLine("2. Добавить машину");
                Console.WriteLine("3. Добавить заказ");
                Console.Write("Введите ваш выбор >> ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        BillTable newBill = new BillTable();
                        Console.WriteLine("Ведите ID счёта");
                        newBill.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ведите сумму счёта");
                        newBill.Price = Convert.ToInt32(Console.ReadLine());
                        _database.billTable.Add(newBill);
                        _database.SaveChanges();
                        Console.Clear();
                        break;
                    case 2:
                        CarsTable newCar = new CarsTable();
                        Console.WriteLine("Введите марку машины >> ");
                        newCar.Name = Console.ReadLine();
                        _database.carsTable.Add(newCar);
                        _database.SaveChanges();
                        Console.Clear();
                        break;
                    case 3:
                        OrdersTable newOrder = new OrdersTable();
                        Console.WriteLine("Ввдеите ID заказа");
                        newOrder.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ввдеите выявленную проблему с машиной");
                        newOrder.Problem = Console.ReadLine();
                        Console.WriteLine("Ввдеите ID машины");
                        newOrder.CarId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ввдеите ID счёта ");
                        newOrder.BillId = Convert.ToInt32(Console.ReadLine());
                        _database.ordersTable.Add(newOrder);
                        _database.SaveChanges();
                        break;
                    default:
                        break;
                }

            }
        }
        public void Dispose()
        {

        }
    }
}
