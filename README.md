# AdapterPattern
# AdapterPattern Project

## Overview
The **AdapterPattern Project** is a Windows Forms application designed to demonstrate the implementation of the Adapter Design Pattern. This pattern enables adapting an existing class to a new interface without modifying the original class. The project highlights how to provide a modernized interface (`INewMath`) for the existing class (`ExistingMathAdaptee`), allowing seamless integration and functionality extension.

---

## Features
- **ExistingMathAdaptee Class**: Contains legacy methods for computing averages and finding minimum values with fixed float inputs.
- **INewMath Interface**: Defines a modern interface that works with arrays of doubles.
- **AdapterMath Class**: Acts as a bridge between `INewMath` and `ExistingMathAdaptee`, implementing the new interface while reusing the existing methods.
- **ComputeAvgRound Method**: Adds functionality to calculate and return rounded averages.
- **Windows Forms Integration**: Features interactive buttons to test the adapter's methods and display results.

---

## Structure
### 1. ExistingMathAdaptee
The legacy class providing methods for:
- `ComputeAvg(float a, float b, float c)`
- `ComputeAvg(float a, float b, float c, float d)`
- `FindMin(float a, float b, float c)`
- `FindMin(float a, float b, float c, float d)`

### 2. INewMath Interface
Defines new methods:
- `double ComputeAvgNew(double[] Arr)`
- `double FindMinNew(double[] Arr)`
- `int ComputeAvgRound(double[] Arr)`

### 3. AdapterMath Class
Implements `INewMath` and inherits from `ExistingMathAdaptee`:
- Maps `ComputeAvgNew` and `FindMinNew` to legacy methods.
- Implements `ComputeAvgRound` to return rounded averages.

### 4. Windows Forms
Interactive buttons:
- **btnAdapterMath**: Computes average using `ComputeAvgNew`.
- **btnAdapterMath2**: Computes and rounds average using `ComputeAvgRound`.

---

## Installation and Usage
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/AdapterPattern.git
   ```
2. Open the solution in Visual Studio.
3. Build and run the application.
4. Use the provided buttons to test the adapter functionality.

---

## Example Usage
- **Compute Average (btnAdapterMath)**:
  - Input: `{ 3.7, 8.4, 6.3 }`
  - Output: `Result = 6.13`

- **Compute Rounded Average (btnAdapterMath2)**:
  - Input: `{ 3.7, 8.4, 6.3 }`
  - Output: `Result (Rounded Avg) = 6`

---

## Screenshots
### Compute Average:
![Compute Average Screenshot](path-to-your-screenshot1.png)

### Compute Rounded Average:
![Compute Rounded Average Screenshot](path-to-your-screenshot2.png)

---

## Key Concepts
- **Adapter Pattern**: Converts the interface of a class into another interface the client expects.
- **Object-Oriented Design**: Demonstrates inheritance and interface implementation.

---

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.

---

## Contact
For any questions or suggestions, feel free to reach out:
- **Author**: Ashwin Raj
- **Email**: your-email@example.com
- **GitHub**: [your-username](https://github.com/your-username)



