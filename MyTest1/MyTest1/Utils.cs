namespace ejemplo2
{
    class Utils
    {

        public static int GetMinValue(int a, int b)
        {
            if (a > b) 
            {
                return a;
            }
        else
            {
                return b;
            }

        }
        public static int GetMaxValue(int c, int d)
        {
            if (c < d)
            {
                return c;
            }
        else
            {
                return d;
            }

        }   
         
        public static bool IsEven( int value)
        {
            if ((value % 2) == 0)

                return true;

            else

                return false;
        
        }
  
        //función que nos devuelve si un número es primo o no.

        public static bool IsPrime( int number)
        {
            int i = 2;

             while ( i < number)
             {

                if ((number % i) ==0)
                return false;
                i++;
             }
            return true;
        }

        public static int comodin()
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine(" introduce un número");
                    int n1 = System.Convert.ToInt32(System.Console.ReadLine());
                    return n1;
                }
                catch
                {
                    System.Console.WriteLine("HAS INTRODUCIDO UN ERROR");
                }
            }
        }
    }



}
