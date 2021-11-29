Please click on “Individual Components” and search for “Class Designer”, check the box and click install on the lower right-hand corner
Once that is complete you will have successfully installed the extension. Now please launch Visual Studio and make a new project as you would usually do for every single exercise.
Once your project is open, please right click the project file in the Solution Explorer on the right, hover over “Add”, and click “New Item” like shown in the below figure
Now, please make sure you select “Visual Studio Items” from the list on the left side and find “Class Diagram” which you should choose; give it a proper name and then click “Add”.
Once you do that, now you will have a new item in the Solution Explorer with the extension .cd, please double click that item to open the UML designer.
As you can see, on the left-hand side you will find different items you can select and put on the empty canvas in the middle. You should design your UML diagram; classes will be created automatically once you do so. 
.....................
In the Toolbox, under Class Designer, drag an Interface onto a class diagram and name it as IMap. 
Create operations in IMap. Right-click on the class IMap and select Add > Method from the popup menu.
Enter JumpToLocation(x:int, y:int): void to create a public operation JumpToLocation with parameter x, y and return void.
Press Enter to create another operation, Name it Clear() : void. Click on diagram to confirm editing.
We need to create a class for town map which inherits IMap. In the Toolbox, under Class Designer, drag a Class onto a class diagram. Name the class as TownMap and press Enter to confirm.
In the Toolbox, under Class Designer, click Inheritance. On the class diagram, draw an inheritance line between the types that you want, starting from an implementing class to the implemented interface. A lollipop appears attached to the class and a label with the interface name identifies the inheritance relationship.
As the TownMap class is implementing the interface IMap, we need to implement the operations defined in IMap. Double-click on class TownMap to generate code and then click on the screw driver (Quick actions) to see all the possible actions in the popup menu. Select ‘Implement interface’ from the list of possible actions. 
You can see that operations JumpToLocation and Clear are both inherited in classDiagram.
It is time to add properties to class. Right-click on class TownMap and select Add > Property or Field from the popup menu.
Enter ‘name’ to name the property as name, and set the type as string. Press Enter to proceed to the next property. Enter x of type double as property name and type. Then, press Enter and create property y of type double.
We need to create a new class Region with an aggregation (association) from class TownMap. Again, in the Toolbox, under Class Designer, drag a Class onto a class diagram. Name the class as Region and press Enter to confirm.
 In the Toolbox, under Class Designer, select Association. Draw a line between the two shapes you want to link with an association. A new property is created in the first class. This property displays as an association line (not as a property within a compartment in the shape) with a default name. Its type is the shape to which the association line points.
Follow the previous steps to create properties in class Region.
Up to now, the diagram should look like:

