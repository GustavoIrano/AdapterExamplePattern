using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternExample
{
    //Client
    public class ManagementService
    {
        private readonly IManagementUser _managementUser;

        public ManagementService(IManagementUser managementUser)
        {
            _managementUser = managementUser;
        }

        public void RealizeManagement()
        {
            _managementUser.Management("Management User");
        }
    }
}
