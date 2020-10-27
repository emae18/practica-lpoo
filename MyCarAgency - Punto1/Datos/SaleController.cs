using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SaleController
    {
        public List<Sale> GetSales()
        {
            using (db_agencyEntities db = new db_agencyEntities())
            {
                //db.Configuration.LazyLoadingEnabled = false;
                return db.Sales.ToList();

            }
        }

        public List<ViewSales> SearchSale(DateTime start, DateTime end)
        {
            using (db_agencyEntities db = new db_agencyEntities())
            {

                return db.Sales.Where(x => x.dateSale <= end && x.dateSale >= start).Select(
                    m => new ViewSales
                    {
                        idSale = m.idSale,
                        firstNameClient = m.Client.firstName,
                        lastNameClient = m.Client.lastName,
                        firstNameEmployee = m.Employee.firstName,
                        lastNameEmployee = m.Employee.lastName,
                        priceSale = m.priceSale,
                        numberPatent = m.Vehicle.numberPatent
                    }).ToList();
            }
        }

        public List<ViewSales> GetSalesTwo()
        {
            using (db_agencyEntities db = new db_agencyEntities())
            {
                return db.Clients.Select(c => c.Sales).First().Select(s =>
                new ViewSales
                {
                    idSale = s.idSale,
                    firstNameClient = s.Client.firstName,
                    lastNameClient = s.Client.lastName,
                    firstNameEmployee = s.Employee.firstName,
                    lastNameEmployee = s.Employee.lastName,
                    priceSale = s.priceSale,
                    numberPatent = s.Vehicle.numberPatent

                }).ToList();
            }
        }

        public void InsertSale(Sale oSale)
        {
            using (db_agencyEntities db = new db_agencyEntities())
            {
                db.Sales.Add(oSale);
                db.SaveChanges();
            }
        }
    }
}
