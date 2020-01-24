using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternExample
{
    //Target Class
    public class ManagementUser : IManagementUser
    {
        public void Management(string informations)
        {
            Console.WriteLine("Management User Common - " + informations);
        }

        public void ManagementError(Exception exception)
        {
            Console.WriteLine("Error - " + exception.Message);
        }
    }
}
