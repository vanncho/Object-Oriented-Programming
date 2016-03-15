namespace _01.Define_Class
{
    using System;

    public class Owner
    {
        private string firstName;
        private string lastName;

        public Owner()
        {

        }
        public Owner(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty or null!");
                }
                if (value.Length < 3 || !char.IsLetter(value[0]))
                {
                    throw new ArgumentOutOfRangeException("First name cannot be shorter than 3 letters or not letters!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty or null!");
                }
                if (value.Length < 3 || !char.IsLetter(value[0]))
                {
                    throw new ArgumentOutOfRangeException("First name cannot be shorter than 3 letters or not letters!");
                }
                this.lastName = value;
            }
        }
    }
}
