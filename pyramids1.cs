/*1>  *           2>     A
     * *                ABA
    * * *              ABCBA
   * * * *            ABCDCBA
  * * * * *          ABCDEDCBA */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyr_pttrn1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Pattern p1 = new Pattern();
            Console.WriteLine("Enter the n value:");
            p1.pyrchr();
            n = Console.Read();
            p1.set(n);
            Pattern.pyr();
            Console.Write(p1.get());
            Console.ReadLine();
            Console.Read();
        }
    }
    class Pattern
    {
        private static int i, j, k, n;
        public static void pyr()
        {
            for(i=1;i<=n;i++)
            {
                for(j=n-1;j>=i;j--)
                {
                    Console.Write(" ");
                }
                for(k=1;k<=i;k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public void pyrchr()
        {
            char alp = 'A';
            int i, j, k, l;
            for(i=1;i<=5;i++)
            {
                for (j = 5; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                { Console.Write(alp++); }
                --alp;
                for (l = 1; l < i; l++)
                { Console.Write(--alp); }
                alp = 'A';
                Console.WriteLine();
            }
            
        }
        public int get()
        {
            return n;
        }
        public void set(int n)
        {
            Pattern.n =n;
        }
        
        
    }
}
