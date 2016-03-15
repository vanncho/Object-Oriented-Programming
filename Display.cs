namespace _01.Define_Class
{
    public class Display
    {
        private string size;
        private int colors;

        public Display()
        {

        }
        public Display (string size, int colors) : this()
        {
            this.Size = size;
            this.Colors = colors;
        }

        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }
    }
}
