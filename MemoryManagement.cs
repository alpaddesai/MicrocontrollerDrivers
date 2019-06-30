using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MicroControllerDrivers
{
    class MemoryManagement : DeviceDriverFunctions
    {
        public string HardwareName { get; set; }

        public bool hardwareinitialized { get; set; }
        public int enableMemoryManagement { get; set; }
 
        public MemoryManagement()
        {
            HardwareName = "Memory Management";
            hardwareinitialized = false;
            enableMemoryManagement = 1;
        }

        public override int HardwareStartup()
        {

            try
            {
                Console.WriteLine($" Execute Hardware Startup Routine for Memory Management  ");
                hardwareinitialized = true;
            }
            catch (FormatException formatexception)
            {
                Console.WriteLine(formatexception.Message + "{HardwareName}");
                hardwareinitialized = false;
            }



            return 0;
        }
        public override int HardwareShutdown()
        {
            Console.WriteLine(" Execute Hardware Shut Down Routine for Memory Management ");
            return 0;
        }
        public override int HardwareUnmapping()
        {
            Console.WriteLine(" Unmap the Memory Map, Deallocate Memory ");
            return 0;

        }
        public override int HardwareMapping()
        {
            Console.WriteLine(" Execute Memory map this may include internal RAM, flash memory, system control registers, \n\t external peripheral bus, external RAM, components internal to the uController ");
            // specify the adddress for each element

            return 0;

        }
        public override int HardwareEnable()
        {
            if (hardwareinitialized)
            {
                enableMemoryManagement = ValidateInterruptsSelfTest();

                if (enableMemoryManagement == 0)
                    Console.WriteLine(" Execute Enable and Self Test Memory Allocation Passed ");
            }
            return 0;

        }
        public override int HardwareDisable()
        {
            Console.WriteLine(" Execute Hardware Disable Memory Management SubRoutine");

            return 0;
        }
        public override int HardwareAcquire()
        {
            if (enableMemoryManagement == 0)
                Console.WriteLine(" Execute Acquire Memory Mapping Resources ");


            return 0;

        }
        public override int HardwareRelease()
        {
            if (enableMemoryManagement == 0)
                Console.WriteLine(" Execute Release Memory Mapping Resources ");


            return 0;

        }
        public override int HardwareRead()
        {
            if (enableMemoryManagement == 0)
                Console.WriteLine(" Execute Read for the internal RAM, flash memory, system control registers, \n\t external peripheral bus, external RAM, or for the components internal to the uController  ");


            return 0;

        }
        public override int HardwareWrite()
        {
            if (enableMemoryManagement == 0)
                Console.WriteLine(" Execute Write for the internal RAM, flash memory, system control registers, \n\t external peripheral bus, external RAM, or for the components internal to the uController  ");

            return 0;

        }
        public override int HardwareInstall()
        {
            Console.WriteLine(" Install Updates for Memroy Management");
            return 0;
        }
        public override string getInformation()
        {
            if (hardwareinitialized)
            {
                if(enableMemoryManagement==0)
                return $" \n Memory Management Information: \n\t The memory management was enabled successfully and self test passed";
                else
                return $" Memory management Information self test failed";

            }
            else return $" Memory management Information initialization failed";
        }

        private int ValidateInterruptsSelfTest()
        {
            Console.WriteLine(" Check functionality of Memory Management ");
            return 0;
        }

    }
}

