
using System;
using System.Windows.Forms;

public class Straight_line_functions
{   public static void validate_start_point_x(TextBox inputx, int ui_width, out double p0x)
    {   try  //For data validation using try and catch see Gittleman book Chapter 11 Example 11.6.
           {p0x = Double.Parse(inputx.Text);    //For extracting numbers from a text box see Gittleman book, p. 341.
           }//End of try
        catch(FormatException)
           {p0x = 10.0;
            System.Console.WriteLine("Bad data found in the x-coordinate of the start point.  The value " + p0x + " is assumed");
           }//End of catch
        if(p0x<0.0)
           {p0x=25.0;
            System.Console.WriteLine("Invalid data found in the x-coordinate of the starting point.  The value " +p0x+ " will be used.");
           }
        else if(p0x>ui_width)
           {p0x=(double)(ui_width-25);
            System.Console.WriteLine("Invalid data found in the x-coordinate of the starting point.  The value " +p0x+ " will be used.");
           }
    }//End of function



public static void validate_start_point_y(TextBox inputy, int ui_height, int top_panel_height, int bottom_panel_height, out double p0y)
    {   try
           {p0y = Double.Parse(inputy.Text);    //For extracting numbers from a text box see Gittleman book, p. 341.
           }//End of try
        catch(FormatException)
           {p0y = 15.0;
            System.Console.WriteLine("Bad data found in the y-coordinate of the start point.  The value " + p0y + " is assumed");
           }//End of catch
        if(p0y<0.0)
           {p0y=(double)(top_panel_height+33);
            System.Console.WriteLine("Invalid data found in the y-coordinate of the starting point.  The value " +p0y+ " will be used.");
           }
        else if(p0y>ui_height)
           {p0y=(double)(ui_height-top_panel_height-bottom_panel_height-30);
            System.Console.WriteLine("Invalid data found in the y-coordinate of the starting point.  The value " +p0y+ " will be used.");
           }
    }//End of function



public static void validate_end_point_x(TextBox endx, int ui_width, out double p1x)
    {   try
           {p1x = Double.Parse(endx.Text);    //For extracting numbers from a text box see Gittleman book, p. 341.
           }//End of try
        catch(FormatException)
           {p1x = (double)(ui_width-25);
            System.Console.WriteLine("Bad data found in the x-coordinate of the end point.  The value " + p1x + " is assumed");
           }//End of catch
        if(p1x<0.0)
           {p1x=80.0;
            System.Console.WriteLine("Invalid data found in the x-coordinate of the end point.  The value " +p1x+ " will be used.");
           }
        else if(p1x>ui_width)
           {p1x=(double)(ui_width-50);
            System.Console.WriteLine("Invalid data found in the x-coordinate of the end point.  The value " +p1x+ " will be used.");
           }
    }//End of function

public static void validate_corner_point_x(TextBox cornerx, int ui_width, out double p2x)
{   
    try
    {   
        p2x = Double.Parse(cornerx.Text);  
    }//End of try
    catch(FormatException)
    {   
        p2x = (double)(ui_width / 2);  // Default to center of the UI width if format exception
        System.Console.WriteLine("Bad data found in the x-coordinate of the corner point. The value " + p2x + " is assumed");
    }//End of catch
    if(p2x < 0.0)
    {   
        p2x = 50.0;  // Some reasonable default
        System.Console.WriteLine("Invalid data found in the x-coordinate of the corner point. The value " + p2x + " will be used.");
    }
    else if(p2x > ui_width)
    {   
        p2x = (double)(ui_width - 50);  // Some reasonable default
        System.Console.WriteLine("Invalid data found in the x-coordinate of the corner point. The value " + p2x + " will be used.");
    }
}//End of function
// new corner addition, just a copy of the last 2
public static void validate_corner_point_y(TextBox cornery, int ui_height, int top_panel_height, int bottom_panel_height, out double p2y)
{   
    try
    {   
        p2y = Double.Parse(cornery.Text);
    }//End of try
    catch(FormatException)
    {   
        p2y = (double)(ui_height / 2);  // Default to center of the UI height if format exception
        System.Console.WriteLine("Bad data found in the y-coordinate of the corner point. The value " + p2y + " is assumed");
    }//End of catch
    if(p2y < top_panel_height)
    {   
        p2y = top_panel_height + 20.0;  // Some reasonable default
        System.Console.WriteLine("Invalid data found in the y-coordinate of the corner point. The value " + p2y + " will be used.");
    }
    else if(p2y > ui_height - bottom_panel_height)
    {   
        p2y = (double)(ui_height - bottom_panel_height - 20);  // Some reasonable default
        System.Console.WriteLine("Invalid data found in the y-coordinate of the corner point. The value " + p2y + " will be used.");
    }
}//End of function


public static void validate_end_point_y(TextBox endy, int ui_height, int top_panel_height, int bottom_panel_height, out double p1y)
    {   try
           {p1y = Double.Parse(endy.Text);
           }//End of try
        catch(FormatException)
           {p1y = (double)(ui_height-bottom_panel_height-top_panel_height-10);
            System.Console.WriteLine("Bad data found in the y-coordinate of the end point.  The value " + p1y + " is assumed");
           }//End of catch
        if(p1y<0.0)
           {p1y=top_panel_height+18.0;
            System.Console.WriteLine("Invalid data found in the y-coordinate of the end point.  The value " +p1y+ " will be used.");
           }
        else if(p1y>ui_height-bottom_panel_height)
           {p1y=(double)(ui_height-bottom_panel_height-35);
            System.Console.WriteLine("Invalid data found in the y-coordinate of the end point.  The value " +p1y+ " will be used.");
           }
    }//End of function

}//End of class Straight_line_function
