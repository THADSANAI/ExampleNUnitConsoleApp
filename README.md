# ExampleNUnitConsoleApp

A sample .NET console application demonstrating the integration and usage of [NUnit](https://nunit.org/) for unit testing. This repository serves as an educational resource and a starting point for developers who wish to add automated tests to their .NET console projects using NUnit.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Setup](#setup)
  - [Running the Application](#running-the-application)
  - [Running Tests](#running-tests)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements](#acknowledgements)

---

## Overview

**ExampleNUnitConsoleApp** is designed to help you understand how to create, organize, and execute unit tests in a .NET console application using NUnit. It contains both application code and corresponding test cases, illustrating best practices for test-driven development and continuous integration.

---

## Features

- Simple .NET Console Application
- Example NUnit test project
- Demonstrates common NUnit assertions and test setup/teardown
- Organized and easy-to-read code structure
- Extendable for more complex testing scenarios

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (Core or later)
- [NUnit](https://nunit.org/) NuGet package
- [NUnit3TestAdapter](https://github.com/nunit/nunit3-vs-adapter) NuGet package (for test discovery in IDEs like Visual Studio)

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/THADSANAI/ExampleNUnitConsoleApp.git
   cd ExampleNUnitConsoleApp
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

### Running the Application

Navigate to the main project directory and run:
```bash
dotnet run --project ExampleNUnitConsoleApp
```

### Running Tests

To execute the tests:
```bash
dotnet test
```

---

## Project Structure

```
ExampleNUnitConsoleApp/
│
├── ExampleNUnitConsoleApp/           # Main application code
│   ├── Program.cs                    # Entry point
│   └── ...                           # Other source files
│
├── ExampleNUnitConsoleApp.Tests/     # NUnit test project
│   ├── ExampleTests.cs               # Example test cases
│   └── ...                           # Additional tests
│
├── README.md
├── .gitignore
└── ... (solution files, configs)
```

---

## Contributing

Contributions are welcome!  
Feel free to open issues for bugs or suggestions, and submit pull requests for improvements.

1. Fork the repository.
2. Create a new branch for your feature or bugfix.
3. Commit your changes.
4. Open a pull request with a clear description of your changes.

---

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.

---

## Acknowledgements

- [NUnit Documentation](https://docs.nunit.org/)
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [NUnit3TestAdapter](https://github.com/nunit/nunit3-vs-adapter)
