# MicroController Drivers

Provides an example of driver API for a microcontroller. Detailed implementation is not included. For details please click on the program.cs. Confidential information is not displayed . All images are either custom by Alpa D Desai or a reference name is included. Most of the images are custom. 


### Output of the program

/* Output 
 * 
 * 
 EXECUTE INITIAL START UP ROUTINE FOR EACH DEVICE DRIVER

 Execute Hardware startup routine Interrupt hardware variable is set to active
 Install Updates for Interrupt Handling
 Execute Memory map for interrupt handling
 Execute enable and self test interrupt handling
 Check functionality of Interrupt Handling by creating an internal hardware interrupt
 Check functionality of Interrupt Handling by creating an external software interrupt


 Execute Hardware Startup Routine for Memory Management
 Install Updates for Memroy Management
 Execute Memory map this may include internal RAM, flash memory, system control registers,
         external peripheral bus, external RAM, components internal to the uController
 Check functionality of Memory Management
 Execute Enable and Self Test Memory Allocation Passed


 Execute Hardware startup routine to initialize the I2C bus
 Install Updates for the I2C bus
 Execute Hardware mapping routine to set the I2C bus registers
 Check functionality of I2C Bus
 Execute enable and self test I2C bus has passed


 Execute Hardware startup routine for the ethernet controller
 Install Updates for Ethernet Controller
 Execute Memory map for Ethernet Controller
 Check functionality of Ethernet Controller
 Execute enable and Self Test for Ethernet Controller passed


 EXECUTE FUNCTIONAL FOR EACH DEVICE DRIVER
 Execute Hardware Acquire Sub Routine process event handler
 Internal Hardware Interrupt Read Event is being executed where the Hardware has already been acquired
 Internal Hardware Interrupt Write Event
 Execute Hardware Release Sub Routine, event handler has been processed interrupt acknowledge signal is active


 Interrupt Handling Information:
         Hardware initialized is set to True
         Enable Interrupts is set to True
         Interrupt Processed is set to True
         Interrupt acknowledgement is set to True
         Received Hardware Interrupt is set to True

 Execute Acquire Memory Mapping Resources
 Execute Read for the internal RAM, flash memory, system control registers,
         external peripheral bus, external RAM, or for the components internal to the uController
 Execute Write for the internal RAM, flash memory, system control registers,
         external peripheral bus, external RAM, or for the components internal to the uController
 Execute Release Memory Mapping Resources

 Memory Management Information:
         The memory management was enabled successfully and self test passed


 The I2C bus has been successfully acquired
 Execute read transactions on the I2C bus
 Execute write transactions on the I2C bus
 The I2C bus has been successfully released


 I2C Bus Information
         The I2C bus has been successfully enabled
         The start condition register value is False
         The SDA value is False
         The SCL value is False
         The SCL value is False
         The I2C bus acquired register value is True
         The I2C bus released register value is True


 Execute Acquire for Ethernet Controller for transactions on the specific transceiver
 Execute Read for Ethernet Controller
 Execute Write for Ethernet Controller
 Execute Release for Ethernet Controller to complete transactions for a specific transceiver


 Execute Ethernet Controller Information
         The controller  enable and self passed
         Successful transactions, the Transceiver Active Register is set to False


 EXECUTE SHUTDOWN ROUTINE FOR EACH DEVICE DRIVER
 Unmap the Memory map for interrupt handling
 Execute Hardware Disable Interrupts SubRoutine
 Execute Interrupt Handling Hardware Shutdown SubRoutine


 Unmap the Memory Map, Deallocate Memory
 Execute Hardware Disable Memory Management SubRoutine
 Execute Hardware Shut Down Routine for Memory Management


 Execute Hardware unmapping routine to reset I2C bus registers
 Execute Hardware disable routine
 Execute Hardware startup routine to shutdown the I2C bus


 Unmap the Memory map for  Ethernet Controller
 Execute Hardware Disable  Ethernet Controller SubRoutine
 Execute ethernet controller Hardware Shutdown SubRoutine
    */

