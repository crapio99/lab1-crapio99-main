<div align="center">  
    <img src="Images/logo.jpg" alt="Logo">
    <h2>Renton Technical College</h2>
    <h3>CSI-250</h3>
</div>
<br>

# Assignment Title Lab 1 Using MVC and Services

## Purpose - The goal of this assignment is to develop your undserstanding of:
- The Model View Controller design pattern
- The Services Collection and Dependency Injection

# Instructions

## Task 1: Clone this repository to your local machine and open the included .Net 6 MVC project (10 pts)

## Task 2: Create a Model to represent a vehicle based on the following criteria: (10 pts)

- int Id
- Year, Make, Model, Price, Mileage and MPG all need to be recorded. Choose the data type for each that you think is best

## Task 3: Create a Vehicle Controller with Two Actions Index() and Details(int id) (15 pts)

- On load of the Controller create a List of Vehicles and add at least three vehicles to the list.
- In the Index Action pass the full list of vehicles to a View and display the info about them
- In the Details Action take in an ID parameter and pass the vehicle with the matching ID to the View and display the info about that vehicle
    - If no vehicle is found matching that ID return NotFound()

## Task 4: Create a service that calculates annual cost of ownership of a vehicle (15 pts)

- Create an IVehicleCostCalculator interface
- The IVehicleCostCalculator interface has one method
    - decimal CalculateCost(Vehicle vehicle, int milesDriven)
- Create a Concrete VehicleCostCalculator class that implements IVehicleCostCalculator
    - The CalculateCost method should return the annual cost of fuel based on the miles driven of the car (choose a reasonable price for a gallon of gas) + 10% of the Price of the car as a depreciation estimate.
- Register this service with the service collection.
- Inject this service into the VehicleController
    - Create a CalculateCost(int id, int milesDriven) endpoint in the vehicle controller 
    - When the endpoint is hit use the service and pass the Vehicle with the matching ID and milesDriven to the VehicleCostCalculator Service
    - Display the result. You can create a view or you can simply return Content() with the result

## Task 5: When complete create a commit with the note "Submission for Lab 1" and push the changes to the repository

# Tips for success
- Commit early and often. As you complete each step create a new commit.
- Refer to the example code and the weekly powerpoint
- Office Hours are Mondays and Fridays from 11a-1pm, if you are struggling with any of the assignments please come by.


Feel free to message your instructor or the TA on Canvas if you have any questions.
