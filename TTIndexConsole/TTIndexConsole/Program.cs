using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTIndexConsole
{
    class Program
    {
        enum TIndex
        {
            SOVÁNY = 1,
            IDEÁLIS,
            TÚLSÚLYOS,
            ELHÍZOTT
        }
        static double MyValidate(string readValue)
        {
            double db;
            while(!Double.TryParse(readValue, out db))
            {
                Console.WriteLine("Kérem számot adjon meg!");
                readValue = System.Console.ReadLine();
            }
            return db;
        }

        static void Main(string[] args)
        {

            System.Console.WriteLine("Írja be a magasságát méterben:");
            double magasság = MyValidate( System.Console.ReadLine() );
            System.Console.WriteLine("Írja be testsúlyát kg-ban:");
            double súly = MyValidate(System.Console.ReadLine());
            double tIndex = Math.Round(súly /(magasság*magasság), 2);
            int val;
            if ( tIndex < 18 )
            {
                val = (int)TIndex.SOVÁNY;
            }
            else if( tIndex <= 25)
            {
                val = (int)TIndex.IDEÁLIS;
            }
            else if( tIndex <=30 )
            {
                val = (int)TIndex.TÚLSÚLYOS;
            }
            else
            {
                val = (int)TIndex.ELHÍZOTT;
            }
            
            switch (val)
            {
                case (int)TIndex.SOVÁNY:
                    System.Console.WriteLine("Ön túlzottan Sovány. Az Ön indexe: {0}", tIndex);
                    break;
                case (int)TIndex.IDEÁLIS:
                    System.Console.WriteLine("Ön ideális testsúlyú. Az Ön indexe: {0}", tIndex);
                    break;
                case (int)TIndex.TÚLSÚLYOS:
                    System.Console.WriteLine("Ön túlsúlyos. Az Ön indexe: {0}", tIndex);
                    break;
                case (int)TIndex.ELHÍZOTT:
                    System.Console.WriteLine("Ön veszélyesen túlsúlyos. Az Ön indexe: {0}", tIndex);
                    break;
                default:
                    System.Console.WriteLine("A program erre nem futhat!. Az Ön indexe: {0}", tIndex);
                    break;
            }
            Console.ReadKey();
        }
    }
}
