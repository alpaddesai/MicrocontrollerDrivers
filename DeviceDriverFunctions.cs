
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroControllerDrivers
{
    public abstract class DeviceDriverFunctions
    {
       public DeviceDriverFunctions()
        {
        }

        public abstract int HardwareStartup();
        public abstract int HardwareShutdown();
        public abstract int HardwareUnmapping();
        public abstract int HardwareMapping();
        public abstract int HardwareEnable();
        public abstract int HardwareDisable();
        public abstract int HardwareAcquire();
        public abstract int HardwareRelease();
        public abstract int HardwareRead();
        public abstract int HardwareWrite();
        public abstract int HardwareInstall();
        public abstract string getInformation();

    }
}
