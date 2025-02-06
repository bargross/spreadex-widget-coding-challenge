using SpreadEx.Widget.Coding.Challenge.Layouts;
using SpreadEx.Widget.Coding.Challenge.Models;

var layout = new Layout();

layout.AddWidget(new RectangleWidget(10, 10, 30, 40));
layout.AddWidget(new SquareWidget(15, 30, 35));
layout.AddWidget(new EllipseWidget(100, 150, 300, 200));
layout.AddWidget(new CircleWidget(1, 1, 300));
layout.AddWidget(new TextboxWidget("sample text",5, 5, 200, 100));

layout.Render();