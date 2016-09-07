using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övningar_WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmÖvn1());
            //Application.Run(new frmÖvn2());
            //Application.Run(new frmÖvn4());
            //Application.Run(new frmÖvn5());
            //Application.Run(new frmÖvn6());
            //Application.Run(new frmÖvn7());
            //Application.Run(new frmÖvn8());
            Application.Run(new frmExc9());



            /*
             * public class Customer
             * {
             *      public string FirstName { get; set; }
             *      public string LastName { get; set; }
             *      public string Email { get; set; }
             *      public string UserName { get; set; }
             *      public int UserID { get; set; }
             * }
             * 
             * var jeffBadgers = new Customer()
             * {
             *      FirstName = "Jeff",
             *      LastName = "Badgers",
             *      Email = "jeff@badgermail.net",
             *      UserName = "JeffB",
             *      UserID = 15
             * };
             * 
             * alternativt:
             * var jeffBadgers = new Customer();
             * jeffBadgers.FirstName = "Jeff";
             * jeffBadgers.LastName = "Badgers";
             * jeffBadgers.Email = "jeff@badgermail.com";
             * jeffBadgers.UserName = "JeffB";
             * jeffBadgers.UserID = 15;
             * gör samma sak som det ovan
             * 
             * 
             * try/catch exempel
             * public bool CreateCustomer(Customer newCust)
             * {
             *      try
             *      {
             *          SaveCustomer(newCust);
             *          return true;
             *      }
             *      catch (Exception)
             *      {
             *          return false;
             *      }
             * }
             * 
             * */

        }
    }
}
