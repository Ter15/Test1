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
         
        public static bool IsEver( int value)
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


    }



}
