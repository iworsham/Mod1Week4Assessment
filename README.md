# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

## Setup

Fork this repository!

## Questions (12 Points Possible)
Edit this `README.md` file - answer the BLANK questions before moving on to the exercise.  Make sure to SAVE your changes to the README before moving on!

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  //C. This doesnt work because you are not using the class Chair to create this instance. I will create variable bench but not as a instance of Chair.
    D. `Chair bench = new(24, true);`  
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:
Object Oriented Programming, or better known as OOP is based on the concept of objects, each with its own properties and attributes and also its own methods

3. What is Automated Testing?
Making sure your program is working as expected with no errors before being used in the program

4. What are some benefits of creating tests for our projects?
Helps find and removed errors before running into them when you run your main code. It also helps if you are on a big dev team with a big company you wont be able to run your code over and over again to find errors as it may conflict with your team. 

5. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?
You must refer your test project to your main one. So the classes can be used, and mke sure they are public.
6. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working.
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; } ///WhenVehicleisMade_AreThePropertiesCorrect()
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Sumary() DoesMethod_ReturnSummaryOfTheCar()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive() ///DoesMethod_CalculateMilesDriven()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor) ///DoesMethod_ChangeColorOfCar()
        
        
        {
            Color = newColor;
        }
    }
```



## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When completed, commit the progress you have made, and push your project to GitHub.  Instructors will be following up with some video feedback!

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
