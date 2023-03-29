using System;
public class Program
{
    public static void Main()
    {
        var returnBack = true;
        do
        {
            int choice, r, l, w, b, h;
            double area = 0;
            double length = 0;
            double width = 0;
            double permimeter = 0;
            int len = 0;
            int wid = 0; 
            

            Console.Write("\n\n");
            Console.Write("Select one of the following option in the menu:\n");
            Console.Write("-----------------------------------------------");
            Console.Write("\n\n");


            Console.Write("1. Enter lenght of the rectangle\n");
            Console.Write("2. Edit lenght of the rectangle \n");
            Console.Write("3. Enter width of the rectangle\n");
            Console.Write("4. Edit width of the rectangle\n ");
            Console.Write("5. Calculate Area of rectangle\n ");
            Console.Write("6. Calculate Perimeter of rectangle\n ");
            Console.Write("7. Exit\n ");
            Console.Write("-----------------------------------------------\n");


            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Input length  of the rectangle : ");
                    len = Convert.ToInt32(Console.ReadLine());
                    length = len;
                    //Console.Write("The length entered is : \n", length);
                    break;
                case 2:
                    Console.Write("Add new length  of the rectangle : ");
                    len = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("The length entered is : \n", len);
                    break;
                case 3:
                    Console.Write("Input width  of the rectangle : ");
                    wid = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("The width entered is : \n", wid);
                    break;
                case 4:
                    Console.Write("Add new width  of the rectangle : ");
                    wid = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("The new width entered is : \n", wid);
                    break;
                case 5:
                    Console.Write("Input length  of the rectangle : \n");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l * w;
                    Console.Write("The area is : {0}\n", area);

                    break;
                case 6:
                    Console.Write("Input length  of the rectangle : \n");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    w = Convert.ToInt32(Console.ReadLine());
                    permimeter = (l + w) / 2;
                    Console.Write("The permimeter is : {0}\n", permimeter);
                   break;
                case 7:
                    return;
                default:
                    break;
            }



        } while (returnBack);
    }
}
