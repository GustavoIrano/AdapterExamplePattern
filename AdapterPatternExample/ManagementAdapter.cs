using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternExample
{
    //Adapter class
    public class ManagementAdapter : IManagementUser
    {
        private readonly IManagementUserMaster _managementUserMaster;

        public ManagementAdapter(IManagementUserMaster managementUserMaster)
        {
            _managementUserMaster = managementUserMaster;
        }

        public void Management(string informations)
        {
            _managementUserMaster.ManagementUserMaster(informations);
        }

        public void ManagementError(Exception exception)
        {
            _managementUserMaster.ManagementUserMasterError(exception);
        }
    }
}
