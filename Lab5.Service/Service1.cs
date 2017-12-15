namespace Lab5.Service
{
    public class Service1 : IService1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public string Concat(string s, double d)
        {
            return s + d;
        }

        public A Sum(A a1, A a2)
        {
            return new A
            {
                s = a1.s + a2.s,
                k = a1.k + a2.k,
                f = a1.f + a2.f
            };
        }
    }
    
    public class A
    {
        public string s { get; set; }
        public int k { get; set; }
        public float f { get; set; }
    }
}
