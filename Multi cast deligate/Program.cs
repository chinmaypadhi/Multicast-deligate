using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_cast_deligate
{
    public delegate void addDel(int x, int y);
    //Fi a  deligate is going to hold the adress of more than one method ,is known as multiclass deligate.
    class Program
    {
        public  void add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public  void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Main(string[] args)
        {
            Program objPro = new Program();
            addDel objDel = objPro.add;
            //Hear we have used the same Deligate object/referance To call both the method.
             objDel += objPro.sub;
            objDel.Invoke(12, 55);
            Console.Read();


        }
    }
}
