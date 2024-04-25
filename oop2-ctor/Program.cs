namespace oop2_ctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation
            Hous house1= new Hous();
            //house1.price = 50000;
            //house1.color = "blue";
            //house1.NumOfRooms = 6; 

          //  Console.WriteLine(house1.price);//--> 50000 by defult 
        
          Hous house2= new Hous();   
         // Console.WriteLine(house2.color);

            //pramaterized ctor
            Hous house3= new Hous(100);
           // Console.WriteLine(house3.price);

            Hous house4= new Hous();
            Console.WriteLine(house4.price);
        }
    
     public class Hous
        {
            public string color;
            public int price;
            public int NumOfRooms;

            //create a constructor with the same name of class
            //type1: defualt ctor
            //constructor chaining
            public Hous() : this (11000)
            {
                // defult values assigned to any object you create 
                //price = 50000;
                //color = "blue";
                 NumOfRooms = 6;

            }

            //type2:  pramaterized ctor (parameters)

            public Hous(int price)
            {
               price = price;
            }

            public Hous(string color)
            {
                color = color;
            }
        }
    }
}
//ctor: have the same name of the class
//- doesnt have a return type
// if you dont create a ctor, compiler in c# will create it by default but empty
//ctor: build a new thing but it contain by defult a properties || values  insted of create them every time you create a new obj
// ctor work as soon as obj creation
//constructor chaining : make them work one by one 