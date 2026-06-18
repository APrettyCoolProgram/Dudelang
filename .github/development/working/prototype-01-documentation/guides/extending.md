```markdown
# Extending Dudelang

This guide explains how to extend and customize the Dudelang language for your specific use case.

## Understanding the Structure
A Dudelang program consists of:
```
MARK program_name
DUDE entity_name (COLON type)
    PROPERTY property1 (COLON type) value
    METHOD method1 ()
        ACTION action1
        ACTION action2
```

### Custom Entities
You can create custom entities by extending the base `object` type:
```du
MARK custom_entity_example
DUDE myCustomEntity (COLON object)
    PROPERTY name (COLON string) "My Entity"
    METHOD greet ()
        SAY "Hello from " + name
```

## Best Practices for Extensions
### 1. Organize Code Properly
- Group related entities together
- Use meaningful names
- Keep methods focused on single responsibilities

### 2. Handle Dependencies
Always check dependencies before executing critical operations:
```du
DUDE validator (COLON object)
    METHOD validateInput (input: any)
        IF input IS NULL
            THROW "Invalid input"
```

### 3. Testing
Write unit tests for your custom logic:
```bash
dude test my_extension_tests.du
```

### 4. Configuration
Store configuration settings in separate files:
```du
MARK config_example
DUDE settings (COLON object)
    PROPERTY debugMode (COLON boolean) false
    PROPERTY maxAttempts (COLON number) 3
```

### 5. Error Handling
Implement robust error handling:
```du
DUDE errorHandler (COLON object)
    METHOD handle (error: string)
        SAY "An error occurred: " + error
        RETURN false
```

## Implementing Custom Operations
You can create custom operations by extending core functionality:
```du
MARK custom_operation_example
DUDE mathHelper (COLON object)
    METHOD sum (a: number, b: number)
        RETURN a + b
    METHOD multiply (a: number, b: number)
        RETURN a * b
```

## Integration Testing
Test your extensions thoroughly with:
```bash
dude test my_extension.du
```
Verify all methods and properties work as expected.
