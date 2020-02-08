using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class seedingService
    {
        private SalesWebMvcContext _context;


        public seedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Danilo Queiroz", "DaniloQueiroz@gmail.com", new DateTime(1988, 4, 15), 1000, d1);
            Seller s2 = new Seller(2, "Edson Carlos", "EdsonCarlos@gmail.com", new DateTime(1950, 1, 13), 4502, d2);
            Seller s3 = new Seller(3, "Davi Queiroz", "DaviQueiroz@gmail.com", new DateTime(2000, 1, 13), 4436, d3);
            Seller s4 = new Seller(4, "Solange Silva", "SolangeSilva@gmail.com", new DateTime(1994, 4, 25), 7043, d4);
            Seller s5 = new Seller(5, "Ana Maria", "AnaMaria@gmail.com", new DateTime(1997, 8, 14), 3431, d2);
            Seller s6 = new Seller(6, "João Pedro", "JoãoPedro@gmail.com", new DateTime(2000, 1, 13), 2364, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Fechado, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 09, 25), 15000.0, SaleStatus.Pendente, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 09, 25), 2000.0, SaleStatus.Cancelado, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2017, 09, 25), 15621.0, SaleStatus.Fechado, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 01, 25), 8541.0, SaleStatus.Pendente, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 25), 3500.0, SaleStatus.Cancelado, s6);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1,s2,s3,s4,s5,s6);
            _context.SalesRecord.AddRange(r1,r2,r3,r4,r5,r6);

            _context.SaveChanges();

        }
    }
}
