using System;

    class Triangle
        {
            private double a;
            private double b;
            private double c;

            public double Aside()
            {
                return a;
            }
            public double Bside()
            {
                return b;
            }
            public double Cside()
            {
                return c;
            }
            public void Populate(double Aside, double Bside, double Cside)
            {
                a = Aside;
                b = Bside;
                c = Cside;
            }
            public bool Exist()
            {
                bool ok;
                if (a+b > c && a + c > b && b + c > a) ok = true;
                else ok = false;
                return ok;
            }
            public double Perimetr()
            {
                double p = a + b + c;
                return p;
            }
            public double Square()
            {
                double p = 0.5*(a + b + c);
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }

}

