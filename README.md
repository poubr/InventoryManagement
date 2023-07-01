# Inventory Management
An inventory managment system with made with C# and the .NET framwork which provides basic inventory functionality.

[![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-%235C2D91.svg?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)


## Table of content

- [Technologies](#technologies)
- [Features](#features)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Credits](#credits)

## Technologies

Project was made with C# and .NET Framework.

## Features

- Create items with barcode, name, and amount
- Create an inventory with maximum capacity
- Inventory checks that each item's barcode is unique
- Add and remove items, with checks to ensure the quantity doesn't go below zero
- Increase amount of items with checks to ensure that maximum capacity isn't exceeded
- Decrease amount of itmes with checks to ensure the quantity doesn't go below zero
- View the inventory, displaying the total number of items and the number of unique items
- Print item details, including the barcode, name, and quantity
- Destructor (finalizer) to handle the cleanup of the inventory object when it becomes unreachable


## Getting Started

1. Ensure that you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
2. Clone the reposutory and navigate to it.
3. Run `dotnet run`. The application will start running in the console.


## Project Structure

```
.
├── Inventory.csproj
├── README.md
├── example_output.png
└── src
    ├── InventoryManagement
    │   ├── Inventory.cs
    │   ├── Item.cs
    │   └── Printer.cs
    └── Program.cs

```


## Credits

© Pavla Oubret 2023.