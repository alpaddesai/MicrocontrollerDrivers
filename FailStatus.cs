using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroControllerDrivers
{
    public class FailStatus : Exception
    {
        public FailStatus() : base(" Fail Flag Status is Active, Failure to initialize ")
        {
        }

    }
}


