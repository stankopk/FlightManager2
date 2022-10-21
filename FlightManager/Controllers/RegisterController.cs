using FlightManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Controllers
{
    internal class RegisterController
    {
        public int AccountCreate(Account acc)
        {
            using (FlightsDBEntities adbe = new FlightsDBEntities())
            {
                int lastUserId = adbe.Accounts.ToList().LastOrDefault().Id;
                var lastUser = adbe.Accounts.ToList().LastOrDefault();

                if (lastUser == null)
                {
                    lastUser = new Account();
                    lastUser.Id = 0;
                }

                acc.Id = lastUser.Id + 1;
                adbe.Accounts.Add(acc);
                adbe.SaveChanges();

                return lastUserId;
            }
        }
    }
}
