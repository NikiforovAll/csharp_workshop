#r "nuget: Colorful.Console, 1.2.11"
#load "pattern-matching-model.csx"

using Console = Colorful.Console;
using System.Drawing;

#nullable enable

// Null patterns

Rectangle? shape = default;

if (shape is null)
{
    // Console.WriteLine("null pattern - checked!", Color.Aquamarine);
    Checked("null pattern");
    shape ??= new Rectangle { Height = 0, Length = 3 };
}

// Constant patterns
if (shape.Height is 0)
{
    // Console.WriteLine("constant pattern - checked!", Color.Aquamarine);
    Checked("constant pattern");
    WriteLine("This rectangle has no height");
}

// Type patterns
object? shape2 = new Square() { Side = 2D };
if (shape2 is Square s)
{
    Checked("type pattern");
    WriteLine($"Square is found. side={s.Side}");
}

// Property pattern
if (shape2 is Square { Side: var side })
{
    Checked("property pattern");
    WriteLine($"Square is found. side={side}");
}

Circle? shape3 = new Circle() { Radius = 100 };

// Relational pattern
if (shape3 is Circle { Radius: >= 100 } s1)
{
    Checked("relational pattern");
    WriteLine($"Huge circle is found. radius={s1.Radius}");
}

// Negated pattern

// previously: if (!(shape is null))
// same as
// if(shape2 is {}) { }

if (shape3 is not null and Circle { Radius: not 0 })
{
    // shape is not null here
    Checked("negated pattern");
    _ = shape3.Radius;
}

// pattern combinators

// type pattern + property pattern + relational pattern + var pattern + recursive pattern + conjunctive pattern
if (shape3 is Circle { Radius: > 0 and <= 200 and var radius }
    && radius % 2 == 0)
{
    Checked("pattern combinators - v1");
}

object shape4 = new Rectangle() { Length = 1D, Height = 2D };

// type pattern + positional pattern + relational + var pattern + recursive pattern + co
if (shape4 is Rectangle(>= 1D, var height))
{
    Checked("pattern combinators - v2");
}

// Example: Area
WriteLine();
WriteLine("Area of:");
foreach (var s in new object[] { shape, shape2, shape3!, shape4 })
{
    Console.WriteLine(
        $"{s.GetType().Name,10}: {CalculateAreaSwitchExpressionNested(s),10:F2}", Color.RoyalBlue);
}

double CalculateAreaSwitchExpressionNested(object obj)
{
    return obj switch
    {
        null => throw new ArgumentNullException(nameof(obj)),

        Square sq => sq switch
        {
            { Side: 0 } => 0,
            { Side: var s } => s * s
        },

        Circle ci => ci switch
        {
            { Radius: 0 } => 0,
            { Radius: var r } => r * r * Math.PI
        },

        Rectangle re => re switch
        {
            { Length: 0 } or { Height: 0 } => 0,
            { Length: var l, Height: var h } => l * h
        },

        Triangle tr => tr switch
        {
            { Base: 0 } or { Height: 0 } => 0,
            { Base: var b, Height: var h } => b * h / 2
        },

        _ => throw new NotSupportedException()
    };
}

void Checked(string label)
{
    Console.Write("[checked]\t", Color.Green);
    Console.WriteLine(label, Color.Aquamarine);
}
