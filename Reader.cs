using System;

namespace Extended
{
    public class Reader
    {
        
        public T Read<T>()
        {
            var input = Console.ReadLine();
            return Parse<T>(input);
        }

        public T Parse<T>(string input)
        {
            T ret = default(T);
            while (!MyTryParse<T>(input, out ret))
            {
                Console.WriteLine("Nesprávny vstup");
                input = Console.ReadLine();
            }
            return ret;
        }

        public bool MyTryParse<T>(string input, out T result)
        {
            result = default(T);
            object[] par = new object[] { input, result };
            var ret = typeof(T)
                .GetMethod("TryParse", new[] { typeof(string), typeof(T).MakeByRefType() })
                .Invoke(this, par);
            result = (T)par[1];
            return (bool) ret;
        }
    }
}
