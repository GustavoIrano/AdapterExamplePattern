using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternExample
{
    public interface IManagementUser
    {
        void Management(string informations);
        void ManagementError(Exception exception);
    }
}
