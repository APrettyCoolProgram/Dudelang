```markdown
# Debugging Dudelang Programs

This guide explains how to diagnose and fix issues in your Dudelang programs.

## Common Issues
### Syntax Errors
- **Missing Colons**: Ensure all type annotations use `COLON` syntax (e.g., `(COLON number)`).
- **Indentation**: Verify proper indentation using spaces, not tabs.
- **String Quotes**: Double-check string quotes are properly closed.

### Runtime Errors
- **Undefined Variables**: Check that all variables are declared before use.
- **Type Mismatches**: Ensure operations match the expected types (e.g., numbers for arithmetic).

## Debugging Tools
### `dude debug`
Run your program in debug mode with:
```bash
dude debug my_program.du
```
This will show execution step-by-step and highlight errors.

### Logging
Add logging statements to track program flow:
```du
DUDE logger (COLON object)
    SAY "Program started"
    ... existing code ...
    SAY "Program completed"
```

## Best Practices
- Break complex programs into smaller, testable parts.
- Use meaningful names for entities and variables.
- Regularly verify intermediate results with `SAY` statements.
