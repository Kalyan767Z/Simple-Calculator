# Simple Calculator Program

## Instructions for Running the Program

1. Open **Visual Studio** or any C# IDE of your choice.
2. Copy and paste the code from the provided source file into the IDE.
3. Compile and run the program.
4. Follow the on-screen instructions to perform calculations.

## Tasks Performed by the Program

- The program performs basic arithmetic operations: addition, subtraction, multiplication, and division.
- It validates the user input to ensure that only numerical values are accepted.
- It handles division by zero gracefully, displaying an appropriate error message.

## Description of the Program

This program functions as a basic calculator, allowing users to input two numbers and select an operation (addition, subtraction, multiplication, or division). The program then computes and displays the result of the chosen operation.

### Key Aspects:

- **Input validation**: Ensures both inputs are valid numbers.
- **Operation selection**: Supports the arithmetic operators (`+`, `-`, `*`, `/`).
- **Error handling**: Detects invalid inputs and handles division by zero.

## Features of the Program

### Step-by-Step Explanation:

1. The user is prompted to input the first number.
   - If the input is invalid, the program displays an error message and terminates.
2. The user is prompted to input the second number.
   - Similarly, invalid input leads to an error message and termination.
3. The user is asked to select an arithmetic operation by entering one of the symbols (`+`, `-`, `*`, `/`).
4. Depending on the operation:
   - **Addition (`+`)**: Adds the two numbers and displays the result.
   - **Subtraction (`-`)**: Subtracts the second number from the first and displays the result.
   - **Multiplication (`*`)**: Multiplies the two numbers and displays the result.
   - **Division (`/`)**: Divides the first number by the second and displays the result if the second number is not zero. If it is zero, an error message is displayed.
5. For invalid operation symbols, the program outputs "Invalid operation."

### Program Structure:

- **Input Handling**:
  - Both numbers are read using `Console.ReadLine()` and validated with `double.TryParse`.
  - The operation symbol is read and processed using a `switch` statement.

- **Operation Execution**:
  - The chosen arithmetic operation is executed based on the symbol provided by the user.

- **Output Messages**:
  - Clear and user-friendly messages display results or errors (e.g., invalid input, division by zero).

## Program Logic Summary

This calculator program is a simple yet powerful tool for performing basic arithmetic. It prioritizes user input validation and includes error handling to ensure smooth execution. The design is ideal for educational purposes and for users learning basic C# programming concepts.
