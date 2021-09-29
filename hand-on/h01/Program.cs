// See https://aka.ms/new-console-template for more information
using System;using h01;

string FizzBuzz(int value) => value % 3 == 0 && value % 5 == 0 ? "FizzBuzz" : value % 3 == 0 ? "Fizz" : value % 5 == 0 ? "Buzz" : "";

FizzBuzz(21).WriteLine();
FizzBuzz(25).WriteLine();
FizzBuzz(45).WriteLine();