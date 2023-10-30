# C--UI
A cool C# UI
This repository contains a C# project that demonstrates the movement of a ball along a straight line from a starting point to a corner point and then from the corner point to an ending point on a graphical user interface. The UI provides options to enter the coordinates for the starting, corner, and ending points, and then visualize the ball's movement along these points.
Features
Graphical Representation: The application provides a graphical user interface to visualize the ball's movement.
User Input: Users can specify the starting, corner, and ending points for the ball's movement.
Animation: The ball moves smoothly from the starting point to the corner and then to the ending point.
Customizability: The animation speed, ball size, and other parameters can be adjusted using the constants provided in the code.
Setup & Execution
Prerequisites
.NET Framework
A C# compiler 
Steps
Clone this repository to your local machine.
Open the solution file in your preferred C# development environment.
Build and run the solution.
On the UI, input the desired starting, corner, and ending coordinates for the ball's movement.
Click on the "Initialize" button to start the animation.
The ball will move from the starting point to the corner and then to the ending point.
You can pause the animation by clicking the "Pause" button and resume it by clicking the "Go" button.
Close the application by clicking the "Quit" button.
Code Overview
The code is structured around the Straight_line_form class, which inherits from the Form class. This class handles the UI display, user input, and animation logic.

Key features in the code:

Constants: Define parameters such as animation speed, ball size, and UI dimensions.
UI Elements: Labels, text boxes, and buttons for user interaction.
Timers: Two timers handle the UI refresh rate and ball position updates.
OnPaint Method: Handles the rendering of the ball and the straight line on the UI.
Event Handlers: Functions to handle user interactions like starting the animation, pausing it, and quitting the application.


This project is open-source. Feel free to use, modify, and distribute it as per your needs.




