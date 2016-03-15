namespace _01.Define_Class
{
    using System;

    public class Calls
    {
        private DateTime dayTimeCall;
        private string callNumber;
        private int callDuration;

        public Calls(DateTime dayTimeCall, string callNumber, int callDuration)
        {
            this.DayTimeCall = dayTimeCall;
            this.CallNumber = callNumber;
            this.CallDuration = callDuration;
        }

        public DateTime DayTimeCall
        {
            get { return this.dayTimeCall; }
            set
            {
                if (value.GetType() != typeof(DateTime))
                {
                    throw new ArgumentException("Not valid date input, should be date time format!");
                }
                this.dayTimeCall = value;
            }
        }

        public string CallNumber
        {
            get { return this.callNumber; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("The phone number length is too short!");
                }
                this.callNumber = value;
            }
        }

        public int CallDuration
        {
            get { return this.callDuration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The call duration cannot be negative number!");
                }
                this.callDuration = value;
            }
        }
    }
}
