using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternExample
{
    public interface IManagementUserMaster
    {
        void ManagementUserMaster(string message);
        void ManagementUserMasterError(Exception exception);
    }
}
