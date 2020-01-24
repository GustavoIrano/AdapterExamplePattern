using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternExample
{
    //Adaptee Class
    public class ManagementUserMasterService : IManagementUserMaster
    {
        public void ManagementUserMasterError(Exception exception)
        {
            Console.WriteLine("Error - " + exception.Message);
        }

        public void ManagementUserMaster(string message)
        {
            Console.WriteLine("Management User Master - " + message);
        }
    }
}
