# Design Patterns - Strategy

This repository showcases an implementation of the Strategy design pattern in C#. The code demonstrates how algorithms can be defined as separate classes and selected dynamically at runtime. This approach promotes flexibility and adheres to the Open/Closed Principle.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Strategy design pattern is a behavioral pattern that allows clients to choose algorithms dynamically at runtime. It encapsulates algorithms as separate classes, ensuring that they can vary independently of the context that uses them. This pattern is particularly useful for scenarios where multiple algorithms are interchangeable.

## Implementation Overview
This repository provides a C# implementation of the Strategy design pattern. Key components of the code include:

- **IStrategy Interface**: Defines the contract for all strategy implementations.
- **ConcreteStrategyA and ConcreteStrategyB Classes**: Concrete implementations of the strategy interface representing specific algorithms.
- **Context Class**: Maintains a reference to a strategy object and uses it to execute the desired algorithm.
- **Program Class**: Demonstrates how to use the pattern by setting and executing strategies dynamically.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Strategy.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Strategy
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Strategy pattern in action.
3. Customize the `ConcreteStrategyA` and `ConcreteStrategyB` classes or create new strategies to simulate different scenarios.

### Example Output:

```
Setting Strategy A:
Executing Strategy A

Setting Strategy B:
Executing Strategy B
```

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

