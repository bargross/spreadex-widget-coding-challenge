# Spreadex Widget Coding Challenge

SpreadEx coding challenge to emulate a drawing package

## Testing

Right click the test assembly and run all tests.

Tests Naming format is the following [ClassName-If-No-Method/MethodName]_[State]_[Result]

## Decisions

### BaseWidget

The first decision I made was to create a base class for all shapes as they all have x,y coordinates and a name, as it is simpler to encapsulate the logic which outputs the name and location
in a single class. This also helps when creating new Widgets as it reduces the amount of code you have to insert via simple inheritance and it provides base logic for coordinates & shape name, which all widgets rely on.

### Circle & Ellipse

Although these shapes are quite similar and are based on similar principles, they are not the same shape, whilst a circle has a diameter, an ellipse has 2, so is best to keep them as separate shapes.

### Square & Rectangle

These two shapes like the decision above, I chose to keep them separate as they're unique items and rely on different details to form its shape.
    - Although the logic to check width can be inherited from Square (mainly just to avoid duplication), if the internal structure of Square ever changes, it'll force those changes onto the Rectangle Widget.

### Textbox & Rectangle

Well as for these two, A textbox is basically just a rectangle in which you can input text, so inheriting the properties from Rectangle seemed more appropriate to avoid duplication in the textbox class

### Guard

This was more of a personal choice, I do not like writing the same if statement multiple times just for simple checks, having it on a static class allows me to call these validation methods without the need to instantiate the class
    - the other advantage is that it allows you to test the validation logic in isolation

### Layout

Simple class to render all the widgets, this class has the logic which collects and displays the widgets, I thought it would be nicer to contain all this logic in a single class so using it in Program.cs is quite simple.

### Improvements

Well since I'm using inheritance here and widgets all have a base class, if this code lived on a live service, firstable in order to manage all of these objects:

- (to i.e.: instantiate shapes without the boiler plate code) I'd create a factory
  - inject it onto .NET DI as a singleton
- Split the rendering logic onto its own class as is not the responsability of the layout class to render itself :D
  - also add tests.
- SpreadEx - possible improvements
- Separate layout rendering from the actual layout as the rendering is not its responsibility and gives the object multiple responsibilities
- Have the layout use a hashmap or hashes where the key is dictated by its type and the content would just be a list of widgets but they’re all of the same type, which makes the search easier.
- I would add more unit tests for the validation logic (Guard) To ensure everything’s validated as expected.
- Textbox should always inherit from Square as updates/improvements to square would improve the performance of Textbox or usability.
- Add more tests that don’t cover the expected outcome of the widget implementation.
- Build a factory to ensure we can avoid adding boiler plate code to avoid the instantiation process and abstract that away in a factory. 

##### PS: The naming of classes and variables as well as the level of abstraction I've added improves code readability.
