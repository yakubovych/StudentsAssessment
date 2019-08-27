namespace test
{
    public class Student
    {
        public int Id { get; set; }
        private string name;
        private string specials;
        private int absent;
        private double avgmark;
        private int year;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string Specials
        {
            get { return specials; }
            set
            {
                specials = value;
            }
        }
        public int Absent
        {
            get { return absent; }
            set
            {
                absent = value;
            }
        }
        public double Avgmark
        {
            get { return avgmark; }
            set
            {
                avgmark = value;
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
            }
        }
    }
}