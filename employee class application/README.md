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
