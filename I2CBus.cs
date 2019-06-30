using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroControllerDrivers
{
    class I2CBus : DeviceDriverFunctions
    {
        public string HardwareName { get; set; }
        public bool I2CBusinitializedRegister { get; set; }
        public bool StartConditionRegister { get; set; }
        public bool SDAActiveRegister { get; set; }

        public bool SCLActiveRegister { get; set; }
        public bool I2CbusAcquiredRegister { get; set; }

        public bool StopConditionRegister { get; set; }

        public bool I2CBusReleasedRegister { get; set; }

        public int I2CBusEnabled { get; set; }


        public I2CBus()
        {
            I2CBusinitializedRegister = false;
            StartConditionRegister = false;  // active low, HW logic low
            SDAActiveRegister = false;        // active low, HW logic low
            SCLActiveRegister = false;        //  active low, hw logic low
            I2CbusAcquiredRegister = false;
            I2CBusReleasedRegister = true;
            I2CBusEnabled = 1;
            HardwareName = "I2C Bus";
        }

        public override int HardwareStartup()
        {

            try
            {
                Console.WriteLine($" Execute Hardware startup routine to initialize the I2C bus ");
                I2CBusinitializedRegister = true;
            }
            catch (FormatException formatexception)
            {
                Console.WriteLine(formatexception.Message + "{HardwareName}");
                I2CBusinitializedRegister = false;
            }

            return 0;
        }
        public override int HardwareShutdown()
        {
            Console.WriteLine($" Execute Hardware startup routine to shutdown the I2C bus ");
            return 0;
        }
        public override int HardwareUnmapping()
        {
            Console.WriteLine($" Execute Hardware unmapping routine to reset I2C bus registers ");
            return 0;

        }
        public override int HardwareMapping()
        {
            Console.WriteLine($" Execute Hardware mapping routine to set the I2C bus registers ");
            return 0;

        }
        public override int HardwareEnable()
        {
            if (I2CBusinitializedRegister)
            {
                I2CBusEnabled = ValidateI2CBusSelfTest();

                if (I2CBusEnabled == 0)
                    Console.WriteLine(" Execute enable and self test I2C bus has passed ");
                else
                    Console.WriteLine(" Execute enable and self test I2C bus has failed ");
            }
 
            return 0;

        }
        public override int HardwareDisable()
        {
            I2CBusinitializedRegister = false;
            StartConditionRegister = false;  
            SDAActiveRegister = false;        
            SCLActiveRegister = false;       
            I2CbusAcquiredRegister = false;
            I2CBusReleasedRegister = true;

            Console.WriteLine($" Execute Hardware disable routine ");

            return 0;
        }
        public override int HardwareAcquire()
        {
            if (I2CBusEnabled == 0)
            {
                if (I2CBusReleasedRegister)
                {
                    StartConditionRegister = true;  // active low, HW logic low
                    SDAActiveRegister = true;        // active low, HW logic low
                    SCLActiveRegister = true;        //  active low, hw logic low

                    I2CbusAcquiredRegister = true;

                    Console.WriteLine(" The I2C bus has been successfully acquired ");
                }
            }

            return 0;

        }
        public override int HardwareRelease()
        {
            if (I2CbusAcquiredRegister)
            {
                StopConditionRegister = true; // active low, HW logic low
                SDAActiveRegister = false;   // HW logic low to high
                StartConditionRegister = false;  // transation is done
                SCLActiveRegister = false;      // Remains HW logic high

                Console.WriteLine(" The I2C bus has been successfully released ");


                I2CBusReleasedRegister = true;

            }
            return 0;

        }
        public override int HardwareRead()
        {
            if (I2CbusAcquiredRegister)
                Console.WriteLine(" Execute read transactions on the I2C bus ");

            return 0;

        }
        public override int HardwareWrite()
        {
            if (I2CbusAcquiredRegister)
                Console.WriteLine(" Execute write transactions on the I2C bus ");

            return 0;

        }
        public override int HardwareInstall()
        {
            Console.WriteLine(" Install Updates for the I2C bus");
            return 0;
        }
        public override string getInformation()
        {
            if (I2CBusinitializedRegister)
            {
                if (I2CBusEnabled == 0)
                    return $" \n I2C Bus Information \n\t The I2C bus has been successfully enabled  \n\t The start condition register value is {StartConditionRegister} \n\t The SDA value is {SDAActiveRegister}  \n\t The SCL value is {SCLActiveRegister} \n\t The SCL value is {SCLActiveRegister} \n\t The I2C bus acquired register value is {I2CbusAcquiredRegister} \n\t The I2C bus released register value is {I2CBusReleasedRegister}  ";
                else
                    return $" I2C Bus Information Error in the self test for the I2C Bus";
            }
            return $"\n I2C Bus Information  Error in initialization, throw an exception";
        }

        private int ValidateI2CBusSelfTest()
        {
            Console.WriteLine(" Check functionality of I2C Bus ");
            return 0;
        }

    }
}

