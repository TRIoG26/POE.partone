using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace POE.partone
{
    internal class Class1
    {
        // private variables
        private String item;
        private int quant;
        private String units;
        private int unit_number;
        private int prep_step;
        private String step_number;
        private String name_of_recipee;
        public Boolean item_check;
        // global arraylists
        public ArrayList ingredient = new ArrayList();
        public ArrayList Quantity = new ArrayList();
        public ArrayList unit = new ArrayList();
        public ArrayList unit_num = new ArrayList();
        public ArrayList prep_steps = new ArrayList();
        public ArrayList step_num = new ArrayList();
        public ArrayList name_of_recipe = new ArrayList();
        public ArrayList reset = new ArrayList();
        // get methods
        public String Item
        {
            get{return item;}
        }
        public int Quant
        {
            get{return quant;}
        }
        public String Units
        {
            get { return units;}
        }
        public int Unit_number
        {
            get { return unit_number; }
        }
        public int Prep_step
        {
            get { return prep_step; }
        }
        public String Step_number
        {
            get { return step_number; }
        }
        public String Name_of_recipee
        {
            get { return name_of_recipee; }
        }
        //constractor with parameters
        public Class1 (String item, int quant, String units, int unit_number, int prep_step, String step_number, String name_of_recipee)
        {
            this.item = item;
            this.quant = quant;
            this.units = units;
            this.unit_number = unit_number;
            this.prep_step = prep_step;
            this.step_number = step_number;
            this.name_of_recipee = name_of_recipee;
        }
        
        public void menu()// first method that runs when code starts
        {
            //variables
            int option;
            Boolean con = false;// do while loop condition
            // checks if the system is empty or has a recipe 
            Console.WriteLine("*****************************************************************************" + "\n" +
            "                               Welcome to DELISH " + "\n" +
            "*****************************************************************************");

            do
            {
                Console.WriteLine("*********************************RECIPE MENU*********************************" +
                    "\nUse the numbers shown below to navigate the system" + "\n" +
                    "1.Create new Recipe \n" +
                    "2.Edit Recipe \n" +
                    "3.Delete Recipe \n" +
                    "4.Close Application");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option) // takes input and calls appropriate method corresponding to the input
                {
                    case 1: item_check = true; input(ingredient, Quantity, unit, unit_num, prep_steps, step_num, name_of_recipe); break;// item_check is assigned true since the item is being added.input method is called with parameters
                    case 2: if (item_check)
                        {
                            edit(ingredient, Quantity, unit, unit_num, prep_steps, step_num, name_of_recipe);break;// edit method is called with parameters
                        }
                        else
                        {
                            Console.WriteLine("You can't edit a recipe that does not exist, add a recipe first");menu();// appears when the system is empty
                        };break;
                    case 3:
                        if (item_check)
                        {
                            delete(ingredient, Quantity, unit, unit_num, prep_steps, step_num, name_of_recipe); break;
                        }
                        else
                        {
                            Console.WriteLine("You can not delete a recipe! The app recipe list is empty, add a recipe first");menu();// appears when the system is empty
                        }; break;
                    default: Console.WriteLine("thank you for using our app!");break; //closes the app
                }

            } while (con); // loops while con is true

        }
        public void input(ArrayList ingredient, ArrayList Quantity, ArrayList unit, ArrayList unit_num, ArrayList prep_steps, ArrayList step_num, ArrayList name_of_recipe) //takes the arraylist as parameters
        {
            Class1 cl = new Class1(item,quant,units,unit_number,prep_step,step_number,name_of_recipee); //object linked with Class1 class
            int count = 1;
            int index = 0;
            int whileloop = 0;
            Boolean con = true;
            if (cl.ingredient.Contains("a"))
            {
                {
                    ingredient.Remove(0);
                    Quantity.Remove(0);
                    unit.Remove(0);
                    unit_num.Remove(0);
                    prep_steps.Remove(0);
                    step_num.Remove(0);
                    name_of_recipe.Remove(0);
                }
            }
            do
            {
                Console.WriteLine("Enter the name of the recipe ");
                cl.name_of_recipee = Console.ReadLine(); // uses object to access the Class1's name_of_recipee
                Console.WriteLine("Enter the number of ingredients that you'll need");
                int control_loop = Convert.ToInt32(Console.ReadLine());
                while (whileloop < control_loop)
                {
                    name_of_recipe.Add(name_of_recipee);              
                    Console.WriteLine("Enter the name of ingredient no." + (whileloop+=1));
                    cl.item = Console.ReadLine();// uses object to access the Class1's
                    ingredient.Add(cl.item);
                    Console.WriteLine("how many " + cl.item + "(s) should i add: ");
                    cl.quant = Convert.ToInt32(Console.ReadLine());// uses object to access the Class1's
                    Quantity.Add(cl.quant);
                    Console.WriteLine("What unit should be used to measure the ingredient: ");
                    cl.units = Console.ReadLine();// uses object to access the Class1's
                    unit.Add(cl.units);// 
                    Console.WriteLine("What's the unit of ingredient " + cl.units);
                    cl.unit_number = Convert.ToInt32(Console.ReadLine());
                    unit_num.Add(cl.unit_number);
                    whileloop++;
                }
                Console.WriteLine("Enter the number of expected steps");
                cl.prep_step = Convert.ToInt32(Console.ReadLine());
                prep_steps.Add(cl.prep_step);
                Console.WriteLine("Enter step number " + count + " of " + cl.item +", and cancel to finish");
                while(con)
                {
                    if(cl.prep_step<count)
                    { 
                    count++;
                    cl.step_number = Console.ReadLine();
                    step_num.Add(cl.unit_number);
                    if (cl.step_number.Equals("cancel") && cl.step_number!= null)
                    {
                        break;
                    }
                    Console.WriteLine("Enter step number " + count + " of " + cl.item + ", and cancel to finish");
                    
                    }
                    else
                    {
                        Console.WriteLine("you've exceeded the limit of steps you've entered");
                        break;
                    }
                }

                Console.WriteLine("Recipe added");
            } while (count < 2);
        }
        public void recipe()
        {

        }
        public void display(ArrayList ingredient, ArrayList Quantity, ArrayList unit, ArrayList unit_num, ArrayList prep_steps, ArrayList step_num, ArrayList name_of_recipe)
        {

        }
        public void edit(ArrayList ingredient, ArrayList Quantity, ArrayList unit, ArrayList unit_num, ArrayList prep_steps, ArrayList step_num, ArrayList name_of_recipe)
        {
            int option;
            String search;
            double calc_num;
            double calc_quantity;
            Class1 cl = new Class1(item, quant, units, unit_number, prep_step, step_number, name_of_recipee);
            reset.Add(Quantity[0]);
            reset.Add(unit_num[0]);
            Console.WriteLine("List of ingredients: ");
            for (int i = 0; i < ingredient.Count; i++)
            {
                Console.WriteLine(ingredient[i]);
            }
            Console.WriteLine("Quantity: "+Quantity[0]);
            Console.WriteLine("Unit of measure: "+unit[0]);
            Console.WriteLine("Unit number"+unit_num[0]);
            Console.WriteLine("Preparation steps"+prep_steps[0]);
            Console.WriteLine("Steps"+step_num[0]);
            Console.WriteLine("Name of recipe: "+name_of_recipe[0]);

            Console.WriteLine("what scale should the recipe be scaled to: \n" +
                "1. 0.5 scale (halved)\n" +
                "2. 2 scale (doubled)\n" +
                "3. 3 scale (tripled)\n" +
                "4. Reset values\n"+
                "5. Cancel and go to menu");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    calc_num = Convert.ToInt32(unit_num[0]);
                    calc_quantity = Convert.ToInt32(Quantity[0]);
                    double total_unit = (calc_num * 0.5);
                    double total_Quantity = (calc_quantity * 0.5);
                    unit_num[0] = total_unit;
                    Quantity[0] = total_Quantity; break;
                case 2:
                    calc_num = Convert.ToInt32(unit_num[0]);
                    calc_quantity = Convert.ToInt32(Quantity[0]);
                    total_unit = (calc_num * 2);
                    total_Quantity = (calc_quantity * 2);
                    unit_num[0] = total_unit;
                    Quantity[0] = total_Quantity; break;
                case 3:
                    calc_num = Convert.ToInt32(unit_num[0]);
                    calc_quantity = Convert.ToInt32(Quantity[0]);
                    total_unit = (calc_num * 3);
                    total_Quantity = (calc_quantity * 3);
                    unit_num[0] = total_unit;
                    Quantity[0] = total_Quantity; break;
                case 4:
                    unit_num[0] = reset[1];
                    Quantity[0] = reset[0];
                    break;
            }
            menu();
        }
        public void delete(ArrayList ingredient, ArrayList Quantity, ArrayList unit, ArrayList unit_num, ArrayList prep_steps, ArrayList step_num, ArrayList name_of_recipe)
        {
            Console.WriteLine("Clear all?");
            String confirm  = Console.ReadLine();
            if (confirm.Equals("yes"))
            {
                ingredient.Remove(0);
                Quantity.Remove(0);
                unit.Remove(0);
                unit_num.Remove(0);
                prep_steps.Remove(0);
                step_num.Remove(0);
                name_of_recipe.Remove(0);
            }
            menu();
        }
    }
}
