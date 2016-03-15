namespace _01.Define_Class
{
    using System;

    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    public class Battery
    {
        private BatteryType batteryType;
        private int hoursIdle;
        private int hoursTalk;

        public Battery()
        {

        }
        public Battery(BatteryType BatteryType, int hoursIdle, int hoursTalk) : this()
        {
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Battery hours idle is not a valid value!");
                }
                this.hoursIdle = value; 
            }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Battery hours talk must be more than 0!");
                }
                this.hoursTalk = value; 
            }
        }
    }
}
