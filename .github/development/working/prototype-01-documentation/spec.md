```markdown
# Dudelang Language Specification

## Overview
Dudelang is a minimal, domain-specific language designed for declaring and documenting simple systems. It combines readability with structure through its indentation-based syntax.

## Grammar Rules
### Program Structure
```
program → statement*
statement → MARK identifier NEWLINE
          | DUDE identifier (COLON type)? NEWLINE block
          | SAY expression NEWLINE
block → INDENT statement+ DEDENT
expression → value (OP value)*
value → NUMBER | STRING | IDENTIFIER
```

### MARK Statement
Marks a program with an identifier:
```du
MARK example_program
```

### DUDE Statement
Declares an entity with optional type annotation and body:
```du
DUDE counter (COLON number)
    SAY "Counting..."
```

### SAY Statement
Outputs a value or expression:
```du
SAY "Hello, world!"
SAY 123
SAY greeting + ", " + name
```

## Data Types
Dudelang supports the following basic types:
- `number`: Floating-point numbers (e.g., `42`, `-3.14`)
- `string`: Text literals enclosed in quotes (e.g., ""Hello""")
- `identifier`: Named references to entities or values

## Operators
Dudelang supports basic binary operations:
- Addition (+)
- Subtraction (-)
- Multiplication (*)
- Division (/)
- Concatenation (+ for strings)

## Example Program
```du
MARK my_program
DUDE calculator (COLON object)
    SAY "Result: " + (2 + 3 * 4)
```
