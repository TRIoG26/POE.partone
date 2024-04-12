using POE.partone;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
class poe
{
    static public void Main(String[] args)
    {
        String item = "a";// place holder for arraylist
        int quant = 1;
        String units = "a";
        int unit_number = 1;
        int prep_step = 1;
        String step_number = "a";
        String name_of_recipee = "a";
        Class1 cl = new Class1(item, quant, units, unit_number, prep_step, step_number, name_of_recipee);
        cl.menu();


    }
}