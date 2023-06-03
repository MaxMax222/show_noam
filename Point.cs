namespace Show_Noam_Git
{
    public class Point
    {
        private double x;
        private double y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}