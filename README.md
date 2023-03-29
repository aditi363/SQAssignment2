# SQAssignment2

--TEAM MATES- ADITI SAINI, RAHUL PARIHAR--

For this assignment, we are going to develop a simple C# console application (.NET Framework) and to then assess the quality of that application by developing and executing unit tests on it.  The requirement for the application is that it allows a user to work with and modify the attributes associated with a rectangle. You will also use Git as source control for this project.
Begin by creating a new console application project in Visual Studio, select a location on your harddrive. Make note of the folder where you created the Solution. Once this has been completed, use Git Bash to initialize a git repository within the Solution folder you just created. You know you are within the correct folder if you run an ls command in Git Bash and see a <SolutionName>.sln file and the folder <ProjectName> (there may be a few other files and folders, but these two will definitely be there). Do your first, initial commit of your solution folder in git.
Return to Visual Studio and begin work on your application. Begin by creating a new Rectangle class as a separate file. The Rectangle class should have two private integer attributes which hold the length and width of the rectangle object. The Rectangle class should contain a default constructor which sets the length and width each to the value of 1, and a non-default constructor which sets the length and width to whatever the user inputs.
The Rectangle class must be public, and should contain six methods, plus a default and non-default Constructor. The six methods are:
public int GetCurrentLength()

public int SetNewLength(int length) 
public int GetCurrentWidth()
public int SetNewWidth(int width) 
public int GetPerimeter() 
public int GetArea()
Each method should do the action as described by its method name. Do not change the names from what is shown above in your solution. 
The SetNewLength method overwrites the old length with the new length. Similarly, the SetNewWidth method overwrites the old width with the new width.
When you have completed work on the Rectangle class return to Git Bash. Stage and commit your entire solution, and label the commit as containing the completed Rectangle class.

 
Return to Visual Studio and continue work on your application. You must now create a console application to allow a user to create and work with a single rectangle object. By default, when the program loads, it asks the user to please enter the length and width of the rectangle. Each side must be an integer greater than zero. If any incorrect input is provided, the user is informed of their mistake and asked to please enter a value again. This error handling and input validation can be done within the console application, rather than the Rectangle class methods.
The program should then present the user with a menu with 7 options:
1.	Get Rectangle Length
2.	Change Rectangle Length
3.	Get Rectangle Width
4.	Change Rectangle Width
5.	Get Rectangle Perimeter
6.	Get Rectangle Area
7.	Exit
If any incorrect input is given, the menu is shown again. Each of the first six options should work as described.
The exit option quits the program and is the only way to exit the program (other than closing the window). The length and width of the rectangle cannot be changed to a value less than one.
When you have completed work on the console application return to Git Bash. Stage and commit your entire solution, and label the commit as containing the completed console application.
Return to Visual Studio and begin work on creating unit tests for each of the six regular methods within the Rectangle class. You do not need to test the constructors. This work should be done within its own Project, as described in class. Your solution in Visual Studio should look something like the following:


Figure 1. Example Assignment 02 Solution
You have your Main Project, which contains the console app code (Program.cs in Figure 1) and the Rectangle class (Rectangle.cs in Figure 1). You will have a second project in the same solution containing the test cases. Remember the naming conventions for the Test Project, the Test Class, and the Test Methods.  Develop three (3) unit test cases for each of the above six methods for a total of 18 unit tests.  Each of your tests MUST use the Assert.AreEqual() assert method using the appropriate expected and actual variables.
When you have completed work on the unit tests return to Git Bash. Stage and commit your entire solution, and label the commit as containing the completed unit tests.
Provide a single screenshot of all 18 Unit cases being run (can take a screenshot of the Visual Studio Test Explorer after a run) – do not submit 18 separate screen shots of each individual unit test.  All of your unit tests should pass and be based on correct inputs and expected results.  Your screenshot must also show the full name of each of your test cases (if need be, you can increase the size by resizing the column at the top using your mouse)
Provide a screenshot or output from a git log command showing your three commits. Feel free to run more commits as it makes sense for your particular project and your work schedule. But at minimum there should be the three commits as described in the assignment.
