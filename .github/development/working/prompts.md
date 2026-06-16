# Prompts



## 2. Casing

In Dudelang:

* Keywords and identifiers should be in UPPERCASE, for example, "DUDE, SAY"
* Variable names should be in camelCase, starting with a lowercase letter and capitalizing subsequent words without spaces. For example, `myVariableName`.



























* Comments should start with `REM` and can be single-line or multi-line block comments. Inline comments are not valid.
* Numeric literals should be written as-is without quotes.
* Boolean literals should be written as `TRUE` or `FALSE` without quotes.
* Array literals should be enclosed in square brackets, with elements separated by commas.
* Object literals should be enclosed in curly braces, with key-value pairs separated by commas, and keys and values separated by colons.
* Null literals should be written as `NULL` without quotes.
* Parentheses should be used for grouping expressions and function calls, similar to other programming languages.
* Parentheses should be used for grouping expressions and function calls, similar to other programming languages. For example, `DUDE, SAY ("Hello world")` is equivalent to `DUDE, SAY "Hello world"`.
* Semicolons are used to terminate statements, similar to other programming languages. Each statement should end with a semicolon.
* Whitespace is generally ignored in Dudelang, except when it is used to separate keywords, identifiers, and literals. Proper indentation is encouraged for readability, but it does not affect the behavior of the program.
* Line breaks are generally ignored in Dudelang, except when they are used to separate statements. You can write multiple statements on a single line separated by semicolons, or spread a single statement across multiple lines for readability.
* Escape sequences in string literals should be supported, similar to other programming languages. For example, `\n` for a newline, `\t` for a tab, and `\"` for a double quote within a string literal.
* String concatenation should be supported using the `+` operator, similar to other programming languages. For example, `"Hello " + "world"` would result in `"Hello world"`.
* Comparison operators should be supported, similar to other programming languages. For example, `==` for equality, `!=` for inequality, `<` for less than, `>` for greater than, `<=` for less than or equal to, and `>=` for greater than or equal to.
* Logical operators should be supported, similar to other programming languages. For example, `&&` for logical AND, `||` for logical OR, and `!` for logical NOT.
* Assignment operators should be supported, similar to other programming languages. For example, `=` for assignment, `+=` for addition assignment, `-=` for subtraction assignment, `*=` for multiplication assignment, and `/=` for division assignment.
* Ternary conditional operator should be supported, similar to other programming languages. For example, `condition ? expr1 : expr2` should evaluate `expr1` if `condition` is true, and `expr2` otherwise.
* The language should support function definitions and calls, similar to other programming languages. For example, `DUDE, DEFINE myFunction(param1, param2) [ DUDE, SAY param1; DUDE, SAY param2; ]` defines a function named `myFunction` with two parameters, and it can be called using `DUDE, CALL myFunction("Hello", "World");`.
* The language should support control flow statements, similar to other programming languages. For example, `DUDE, IF condition [ DUDE, SAY "Condition is true"; ] ELSE [ DUDE, SAY "Condition is false"; ]` should execute the appropriate block based on the evaluation of `condition`.
* The language should support loop statements, similar to other programming languages. For example, `DUDE, WHILE condition [ DUDE, SAY "Looping"; ]` should repeatedly execute the block as long as the `condition` is true, and `DUDE, FOR i = 0 TO 10 [ DUDE, SAY i; ]` should execute the block for each value of `i` from 0 to 10.
* The language should support error handling mechanisms, similar to other programming languages. For example, `DUDE, TRY [ DUDE, SAY "Trying"; ] CATCH [ DUDE, SAY "An error occurred"; ]` should execute the `TRY` block and if an error occurs, the `CATCH` block should be executed.
* The language should support module or library imports, similar to other programming languages. For example, `DUDE, IMPORT myLibrary;` should import the module or library named `myLibrary` and make its functions and variables available for use in the current program.
* The language should support comments, similar to other programming languages. For example, `REM This is a comment` should be ignored by the interpreter and can be used to add notes or explanations within the code.
* The language should support block comments, similar to other programming languages. For example, `REM [ This is a block comment spanning multiple lines ]` should be ignored by the interpreter and can be used to add notes or explanations within the code across multiple lines.
* The language should support case-insensitive keywords and variable names, similar to some other programming languages. For example, `Dude, mark i "Hello world"` is equivalent to `dude, MARK i "Hello world"`. You can use any combination of uppercase and lowercase letters for keywords and variable names without affecting the behavior of the program.
* The language should support string interpolation, similar to some other programming languages. For example, `DUDE, SAY "Hello ${name}"` should replace `${name}` with the value of the variable `name` within the string.
* The language should support array and list data structures, similar to other programming languages. For example, `DUDE, MARK myArray [1, 2, 3, 4, 5];` should create an array named `myArray` with the elements 1, 2, 3, 4, and 5, and `DUDE, SAY myArray[0];` should output the first element of the array.
* The language should support dictionary or map data structures, similar to some other programming languages. For example, `DUDE, MARK myDict { "key1": "value1", "key2": "value2" };` should create a dictionary named `myDict` with the keys "key1" and "key2" and their corresponding values, and `DUDE, SAY myDict["key1"];` should output the value associated with the key "key1".
* The language should support set data structures, similar to some other programming languages. For example, `DUDE, MARK mySet {1, 2, 3, 4, 5};` should create a set named `mySet` with the elements 1, 2, 3, 4, and 5, and `DUDE, SAY mySet.has(3);` should output `true` if the set contains the element 3, and `false` otherwise.
* The language should support tuple data structures, similar to some other programming languages. For example, `DUDE, MARK myTuple (1, 2, 3);` should create a tuple named `myTuple` with the elements 1, 2, and 3, and `DUDE, SAY myTuple[0];` should output the first element of the tuple.
* The language should support function as first-class citizens, similar to some other programming languages. For example, `DUDE, MARK myFunction = FUN(param1, param2) [ DUDE, SAY param1; DUDE, SAY param2; ];` should create a function named `myFunction` and assign it to a variable, and `DUDE, CALL myFunction("Hello", "World");` should call the function using the variable.
* The language should support higher-order functions, similar to some other programming languages. For example, `DUDE, MARK applyFunction = FUN(f, x) [ DUDE, CALL f(x); ];` should create a function named `applyFunction` that takes a function `f` and an argument `x`, and calls `f` with `x` as the argument. This demonstrates that functions can be passed as arguments to other functions.
* The language should support anonymous functions or lambda expressions, similar to some other programming languages. For example, `DUDE, MARK myLambda = FUN(x) [ DUDE, SAY x; ];` should create an anonymous function that takes an argument `x` and outputs it, and it can be assigned to a variable like `myLambda` and called using `DUDE, CALL myLambda("Hello");`.
* The language should support closures, similar to some other programming languages. For example, `DUDE, MARK makeCounter = FUN() [ DUDE, MARK count 0; RETURN FUN() [ DUDE, MARK count count + 1; DUDE, SAY count; ]; ];` should create a function named `makeCounter` that returns a function which increments and outputs a counter variable. The inner function maintains access to the `count` variable even after `makeCounter` has finished executing, demonstrating the concept of closures.


This means that `Dude, mark i "Hello world"` is equivalent to `dude, MARK i "Hello world"`. You can use any combination of uppercase and lowercase letters for keywords and variable names without affecting the behavior of the program.


## 2. Comments

In Dudelang, comments start with `REM`.

Comments can be single line:

```
REM This is an example of a single-line comment.
```

or multi-line block comments:

```
REM This is
REM an example of
REM a block comment.
```

Inline comments are not valid in Dudelang. You cannot place a comment after a statement on the same line.

## 3. The `mark` keyword



So thi

REM Inline comments are not valid.

REM About the following syntax:
REM 1. Statements may optionally start with "Dude, ". This is just for fun, and is ignored.
REM 1. The keyword "mark" is equivalent to "print" in other languages, and prints something to the console.
REMD

Dude, mark aVariable "Hello world";

Dude, if aVariable is "Hello world"
[
    Dude, say aVariable;
]
else
[
    Dude, say "Goodbye cruel world!";
]
