# Create the solution
dotnet new sln -n LabyrinthGameSolution


# Create the core library project (for game logic)
dotnet new classlib -n LabyrinthGame.Core
# Verkare inte behövas --> dotnet add LabyrinthGame.Core package System.Collections.Immutable


# Create the console application project
dotnet new console -n LabyrinthGame.ConsoleApp


# Create the test project using xUnit
dotnet new xunit -n LabyrinthGame.Tests
dotnet add LabyrinthGame.Tests package Shouldly


# Add project references
dotnet add LabyrinthGame.ConsoleApp reference LabyrinthGame.Core
dotnet add LabyrinthGame.Tests reference LabyrinthGame.Core


# Add the projects to the solution
dotnet sln LabyrinthGameSolution.sln add LabyrinthGame.Core/LabyrinthGame.Core.csproj
dotnet sln LabyrinthGameSolution.sln add LabyrinthGame.ConsoleApp/LabyrinthGame.ConsoleApp.csproj
dotnet sln LabyrinthGameSolution.sln add LabyrinthGame.Tests/LabyrinthGame.Tests.csproj
