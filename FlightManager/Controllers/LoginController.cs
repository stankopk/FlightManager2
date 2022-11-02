using FlightManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManager.Controllers
{
    internal class LoginController
    {
        public string ShowMessage(string username, string pass)
        {
            using (FlightsDBEntities adbe = new FlightsDBEntities())
            {
                var exsistingAccount = adbe.Accounts.Where(s => s.Username == username).FirstOrDefault();
                if (exsistingAccount != null)
                {
                    if (exsistingAccount.Password == pass)
                    {
                        if (exsistingAccount.IsAdmin == true)
                        {
                            return "Admin";
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return "Wrong Password!";
                    }
                }
                else
                {
                    return "No such user!";
                }
            }
        }
    }
}
