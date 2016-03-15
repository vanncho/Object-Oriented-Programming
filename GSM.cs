namespace _01.Define_Class
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class GSM
    {
        private static GSM iPhone4S = new GSM("iPhone 4S", "Apple", 600.15m, "Pencho", "Petkov", BatteryType.LiIon, 10, 3, "680 x 240", 1000000);

        // Fields
        private string deviceModel;
        private string manufacturer;
        private decimal price;
        private Owner owner;
        private Battery battery;
        private Display display;
        private ICollection<Calls> callHistory;

        // Constructors
        public GSM(string deviceModel, string manufacturer)
        {
            this.DeviceModel = deviceModel;
            this.Manufacturer = manufacturer;
            this.Owner = new Owner();
            this.Battery = new Battery();
            this.Display = new Display();
            this.callHistory = new List<Calls>();
        }
        public GSM(string deviceModel, string manufacturer, decimal price, string ownerFirstName, string ownerLastName, BatteryType batteryType, int hoursIdle, int hoursTalk, string resolution, int colors) 
            : this(deviceModel, manufacturer)
        {
            this.Price = price;
            this.Owner = new Owner(ownerFirstName, ownerLastName);
            this.Battery = new Battery(batteryType, hoursIdle, hoursTalk);
            this.Display = new Display(resolution, colors);            
        }

        // Properties
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public string DeviceModel
        {
            get { return this.deviceModel; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Device model not set!");
                }
                this.deviceModel = value; 
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Manufacturer not set or invalid name length!");
                }
                this.manufacturer = value; 
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price of device cannot be negative!");
                }
                this.price = value; 
            }
        }
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public ICollection<Calls> CallHistory
        {
            get{ return this.callHistory; }
        }

        // Methods
        public void AddCalls(DateTime callTime, string callNumber, int callDuration)
        {
            this.callHistory.Add(new Calls(callTime, callNumber, callDuration));
        }

        public void DeleteCalls(Calls currentCall)
        {
            if (!this.callHistory.Contains(currentCall))
            {
                throw new ArgumentException("No calls input to remove!");
            }

            this.CallHistory.Remove(currentCall);
        }

        public decimal CalculateCallPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0m;

            foreach (var call in this.callHistory)
            {
                price += pricePerMinute * call.CallDuration / 60;
            }

            return totalPrice;
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public override string ToString()
        {
            StringBuilder gsmDetails = new StringBuilder();

            gsmDetails.Append(string.Format("Device Info:\nManufacturer - {0,11}\n", this.manufacturer));
            gsmDetails.Append(string.Format("Model - {0,16}\n", this.deviceModel));
            gsmDetails.Append(string.Format("Owner - {0,17} {1}\n\n", this.owner.FirstName, this.owner.LastName));
            gsmDetails.Append(string.Format("Battery Info:\nbattery type - {0,11}\nbattery idle - {1,8} hours\nbattery talk - {2,7} hours\n\n", this.Battery.BatteryType, this.Battery.HoursIdle, this.Battery.HoursTalk));
            gsmDetails.Append(string.Format("Display Info:\nResolution - {0,19}\nColors - {1,20} millions", this.Display.Size, this.Display.Colors));
            
            return gsmDetails.ToString();
        }
    }
}
