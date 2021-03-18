Part 1 - Hospital Charges (20 points)
Create an application that calculates the total cost of a hospital stay. The daily base charge is $350. The hospital also charges for medication, surgical fees, lab fees, and physical rehab. The application should accept the following input:

The number of days spent in the hospital
The amount of medication charges
The amount of surgical charges
The amount of lab fees
The amount of physical rehabilitation charges
Create and use the following value-returning methods in the application:

CalcStayCharges —calculates and returns the base charges for the hospital stay. This is computed as $350 times the number of days in the hospital.
CalcMiscCharges —calculates and returns the total of the medication, surgical, lab, and physical rehabilitation charges.
CalcTotalCharges —calculates and returns the total charges.
Requirements:

Submit a single zip file containing your solution folder using the following format:
username_module2activity1.zip

Part 2 – Employee Class (20 points)
In Visual Studio, create a new Windows Forms Application. Create a class named Employee (in its own file) that has the following properties:

 

Name —the Name property holds the employee’s name.
IdNumber —the IdNumber property holds the employee’s ID number.
Department —The Department property holds the name of the department in which the employee works.
Position —the Position property holds the employee’s job title.
The class should have the following overloaded constructors:

A constructor that accepts the following values as arguments and assigns them to the appropriate properties: employee’s name, employee’s ID number, department, and position.
A constructor that accepts the following values as arguments and assigns them to the appropriate properties: employee’s name and ID number. The Departmentand Position properties should be assigned an empty string ( "" ).
A parameterless constructor that assigns empty strings ( "" ) to the Name, Department, and Position properties, and 0 to the IdNumber property.
In your application, create three Employee objects to hold the following data:

Name                          ID Number      Department                Position

Susan Meyers             47899              Accounting                  Vice President

Mark Jones                  39119              IT                                 Programmer

Joy Rogers                   81774              Manufacturing            Engineer

The application should store this data in the three objects and display the data for each employee on the screen.
