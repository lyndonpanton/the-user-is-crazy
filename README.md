# the-user-is-crazy
Exercise 1 of the "Intermediate Object-Oriented Programming for Unity Games" course of the "C# Programming for Unity Game Development" Specialization by the University of Colorado via Coursera

## Description

Problem 1 – Get user input

Start up your IDE and create a new Console Application project named Exercise1. Save the project in a reasonable location on the computer.

Add code to the Main method to prompt for and read in an integer score from the user.

Run your code with a normal input, non-integer input (Bob, say), and a number larger than the maximum integer (2,147,483,647). See how the program throws exceptions for the second two inputs. You can use Ctrl+C in the Command Prompt window to get past the exception.

Problem 2 – Add try and catch blocks

Put the prompting and reading in code inside a try block.

Add a catch block for a FormatException, printing an appropriate error message inside the catch block. Run your code with non-integer input; you should see the error message.

Add a catch block for an OverflowException, printing an appropriate error message inside the catch block. Run your code with a number larger than the maximum integer (2,147,483,647); you should see the error message.

Problem 3 – Add a finally block

Add a finally block that prints a message.

Run your code with a normal input, non-integer input (Bob, say), and a number larger than the maximum integer (2,147,483,647). The error messages for the two invalid inputs should still be displayed and in the message from the finally block should be displayed for all three inputs.

## Getting Started

n/a

### Dependencies

* Windows 10
* Microsoft Visual Studio
* .NET

### Installing

* Download link: [Github Repository](https://github.com/lyndonpanton/the-user-is-crazy)

### Executing program

1. Go to the project's root directory
2. Go to the _Exercise1_ folder
3. Open _Exercise1.sln_
6. Run _Program.cs_

## Help

n/a

## Authors

Lyndon Mykal Panton
[lyndonpanton](https://github.com/lyndonpanton/)

## Version History

* 0.1
    * Initial Release

## License

n/a

## Acknowledgments

Problem provided by the _University of Colorado_ and _Coursera_
