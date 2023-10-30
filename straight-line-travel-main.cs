




using System;
using System.Windows.Forms;            //Needed for "Application" near the end of Main function.
public class Straight_line_main
{  public static void Main()
   {  System.Console.WriteLine("The Straight Line Travel program has begun.");
      Straight_line_form straight_application = new Straight_line_form();
      Application.Run(straight_application);
      System.Console.WriteLine("The Straight Line Travel program has ended.  Bye.");
   }//End of Main function
}//End of Straight_line_main class




