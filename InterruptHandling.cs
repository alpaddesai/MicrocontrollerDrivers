using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroControllerDrivers
{
    class InterruptHandling: DeviceDriverFunctions
    {
        public string HardwareName { get; set; }
       public bool ReceivedHardwareInterrupt { get; set; }
       public bool interruptAcknowledgeSignal { get; set; }

       public bool hardwareinitialized { get; set; }

        public bool EnableInterrupts { get; set; }
        public bool InterruptProcessed { get; set; }

        public InterruptHandling()
        {
            hardwareinitialized = false;
            EnableInterrupts = false;
            InterruptProcessed = false;
            interruptAcknowledgeSignal = false;
            ReceivedHardwareInterrupt = false;
            HardwareName = "Interrupt Handling";
        }

        public  override int HardwareStartup()
        {
            try
            {
                Console.WriteLine($" Execute Hardware startup routine Interrupt hardware variable is set to active ");
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
            Console.WriteLine(" Execute Interrupt Handling Hardware Shutdown SubRoutine");
            return 0;
        }
        public override int HardwareUnmapping()
        {
            Console.WriteLine(" Unmap the Memory map for interrupt handling ");
            return 0;

        }
        public override int HardwareMapping()
        {
            Console.WriteLine(" Execute Memory map for interrupt handling ");
            return 0;

        }
        public override int HardwareEnable()
        {
            if (hardwareinitialized)
            {
                EnableInterrupts = true;  // edge triggered, level triggered based on a specific condition
                interruptAcknowledgeSignal = true;
                Console.WriteLine(" Execute enable and self test interrupt handling ");

                ValidateInterruptsSelfTest();
            }

                return 0;

        }
        public override int HardwareDisable()
        {
            Console.WriteLine(" Execute Hardware Disable Interrupts SubRoutine");

            return 0;
        }
        public override int HardwareAcquire()
        {
            ReceivedHardwareInterrupt = true;

            if (EnableInterrupts)
                Console.WriteLine(" Execute Hardware Acquire Sub Routine process event handler ");

            return 0;

        }
        public override int HardwareRelease()
        {
            if(InterruptProcessed && interruptAcknowledgeSignal)
                Console.WriteLine(" Execute Hardware Release Sub Routine, event handler has been processed interrupt acknowledge signal is active");
            return 0;

        }
        public override int HardwareRead()
        {
            if (ReceivedHardwareInterrupt && EnableInterrupts)
                Console.WriteLine(" Internal Hardware Interrupt Read Event is being executed where the Hardware has already been acquired ");
            // register based memory addressing read
            InterruptProcessed = true;
            return 0;

        }
        public override int HardwareWrite()
        {
            Console.WriteLine(" Internal Hardware Interrupt Write Event ");
            interruptAcknowledgeSignal = true;

            // register based memory addressing write
            return 0;

        }
        public override int HardwareInstall()
        {
            Console.WriteLine(" Install Updates for Interrupt Handling ");
            return 0;
        }
        public override string getInformation()
        {
            return $" \n Interrupt Handling Information: \n\t Hardware initialized is set to {hardwareinitialized} \n\t Enable Interrupts is set to {EnableInterrupts}  \n\t Interrupt Processed is set to { InterruptProcessed} \n\t Interrupt acknowledgement is set to { interruptAcknowledgeSignal} \n\t Received Hardware Interrupt is set to { ReceivedHardwareInterrupt} " ;

        }
              public int ExternalInterrupt()
        {
            Console.WriteLine(" Check functionality of Interrupt Handling by creating an external software interrupt ");
            return 0;
        }

        private int ValidateInterruptsSelfTest()
        {
            Console.WriteLine(" Check functionality of Interrupt Handling by creating an internal hardware interrupt ");
            return 0;
        }

    }
}
