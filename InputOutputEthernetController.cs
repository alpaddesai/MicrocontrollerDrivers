using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MicroControllerDrivers
{
    class InputOutputEthernetController : DeviceDriverFunctions
    {
        public string HardwareName { get; set; }
        public bool hardwareinitialized { get; set; }

        public bool TransceiverActiveRegister { get; set; }

        public int hardwareenabled { get; set; }
          public InputOutputEthernetController()
        {
            HardwareName = " Ethernet Controller";
            hardwareinitialized = false;
            hardwareenabled = 1;
            TransceiverActiveRegister = false;
        }

        public override int HardwareStartup()
        {
            hardwareinitialized = true;
            

            try
            {
                Console.WriteLine($" Execute Hardware startup routine for the ethernet controller ");
                hardwareinitialized = true;
            }
            catch (FormatException formatexception)
            {
                Console.WriteLine( formatexception.Message + "{HardwareName}");
                hardwareinitialized = false;
            }



            return 0;
        }
        public override int HardwareShutdown()
        {
            Console.WriteLine(" Execute ethernet controller Hardware Shutdown SubRoutine");
            return 0;
        }
        public override int HardwareUnmapping()
        {
            Console.WriteLine(" Unmap the Memory map for  Ethernet Controller ");
            return 0;

        }
        public override int HardwareMapping()
        {
            Console.WriteLine(" Execute Memory map for Ethernet Controller");
            return 0;

        }
        public override int HardwareEnable()
        {
            if (hardwareinitialized)
            {
                hardwareenabled = ValidateEthernetControllerSelfTest();

                if (hardwareenabled == 0)
                    Console.WriteLine(" Execute enable and Self Test for Ethernet Controller passed");
            }
            return 0;

        }
        public override int HardwareDisable()
        {
            Console.WriteLine(" Execute Hardware Disable  Ethernet Controller SubRoutine");

            return 0;
        }
        public override int HardwareAcquire()
        {
            if (hardwareenabled == 0)
            {
                Console.WriteLine(" Execute Acquire for Ethernet Controller for transactions on the specific transceiver ");
                TransceiverActiveRegister = true;
            }
            return 0;

        }
        public override int HardwareRelease()
        {
            if (hardwareenabled == 0)
            {
                Console.WriteLine(" Execute Release for Ethernet Controller to complete transactions for a specific transceiver ");
                TransceiverActiveRegister = false;
            }
            return 0;

        }
        public override int HardwareRead()
        {
            if(TransceiverActiveRegister)
            Console.WriteLine(" Execute Read for Ethernet Controller ");

            return 0;

        }
        public override int HardwareWrite()
        {
            if (TransceiverActiveRegister)
                Console.WriteLine(" Execute Write for Ethernet Controller ");

            return 0;

        }
        public override int HardwareInstall()
        {
            Console.WriteLine(" Install Updates for Ethernet Controller ");
            return 0;
        }
        public override string getInformation()
        {
            if (hardwareinitialized)
            {
                if (hardwareenabled == 0)
                    return $" \n Execute Ethernet Controller Information \n\t The controller  enable and self passed \n\t Successful transactions, the Transceiver Active Register is set to {TransceiverActiveRegister}  ";
                else
                    return $" \n Execute Ethernet Controller Information \n\t The controller  enable and self failed";

                 }
            else
                return $"\n Execute Ethernet Controller Information Hardware initialization failed  ";

        }


        private int ValidateEthernetControllerSelfTest()
        {
            Console.WriteLine(" Check functionality of Ethernet Controller   ");
            return 0;
        }

    }
}

