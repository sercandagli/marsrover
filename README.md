# Mars Rover Problem


A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on board cameras can get a complete view of the surrounding terrain to send back to Earth.
A rover's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.
In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point, and maintain the same heading.

Assume that the square directly North from (x, y) is (x, y+1).

# Input
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau.

The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation.
Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.

# Output
The output for each rover should be its final co-ordinates and heading.

# Example Cases

<b>Test Inputs</b></br>
5 5 </br>
1 2 N  </br>
LMLMLMLMM </br>
3 3 E  </br>
MMRMMRMRRM </br>

<b>Expected Outputs</b></br>
1 3 N </br>
5 1 E



# Get Started

There are 2 main type which Plateau and Rover on the solution.

Plateu has coordinates for check if target position which want to move has available on it. Also it have method for populate this coordinates. Every plateau can populate this coordinates with own styles such as Rectangle,Circle,Triangle etc. 

Rover has destination and direction mainly.This properties are holds rovers current destination and current direction for next operations and they are changes after each command step.After executing all commands this properties represent rover's last destination and direction.

Rover can have abilities. For this case, default rover can move forward and rotate herself. 

Solution has CommandManager for determine which direction will be next and how many step needs to move forward for each axis.

All these features are manages by Coordinator. Coordinator have responsible for plateau and rover creating,forwards command to CommandManager to get what is next direction or move step. After getting next step for rover checks if plateau has coordinate which want to move forward.If plateau has matched given coordinates with her own coordinates,Coordinator lets rover to move forward.Each rover has responsible for own move process.


You can test it first case easly with below code in Program.cs

```sh
var coordinator = new Coordinator(5,5);
var actualPosition = commander.ProcessMarsRoverProblem(1,2,'N',"LMLMLMLMM");
Console.WriteLine($"{actualPosition.Item1} {actualPosition.Item2} {actualPosition.Item3}");
```






