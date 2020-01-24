using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternExample
{
    public class AdapterExecution
    {
        public static void Execute()
        {
            new ManagementService(new ManagementUser()).RealizeManagement();

            new ManagementService(new ManagementAdapter(new ManagementUserMasterService())).RealizeManagement();
        }
    }
}
