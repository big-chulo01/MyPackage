Darlington Mboma Greeter Package

A simple NuGet package that sends greetings from Darlington Mboma.

- Installation
```bash
dotnet add package DarlingtonMbomaGreeter

-Usage
csharp
using DarlingtonMbomaGreeter;

// Basic greeting
Console.WriteLine(Greeter.Greet());

// Personalized greeting
Console.WriteLine(Greeter.Greet("John"));