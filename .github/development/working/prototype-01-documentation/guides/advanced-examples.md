```markdown
# Advanced Dudelang Examples

This guide demonstrates complex scenarios and best practices for advanced Dudelang usage.

## Arithmetic Operations
### Calculator with Multiple Operations
```du
MARK calculator_example
DUDE math_operations (COLON object)
    SAY "Result of 2 + 3 * 4: " + (2 + 3 * 4)
    SAY "Result of (5 - 1) / 2: " + ((5 - 1) / 2)
```

## String Manipulation
### Dynamic Greetings
```du
MARK string_example
DUDE greeting_builder (COLON object)
    DUDE name (COLON string) "Alice"
        SAY "Hello, " + name + "! Welcome to Dudelang."
    DUDE name (COLON string) "Bob"
        SAY "Hello, " + name + "! Happy coding!"
```

## Conditional Logic
### Basic Conditionals
```du
MARK condition_example
DUDE conditional_check (COLON object)
    DUDE temperature (COLON number) 25
        IF temperature > 20
            SAY "It's warm outside"
        ELSE
            SAY "It's cool outside"
```

## Object Operations
### Working with Properties
```du
MARK object_example
DUDE person (COLON object)
    DUDE name (COLON string) "John"
    DUDE age (COLON number) 30
        SAY "Person details: " + name + ", " + age
```
