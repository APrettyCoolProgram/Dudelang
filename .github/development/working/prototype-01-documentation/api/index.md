```markdown
# Dudelang Parser API Reference

This document describes the public API for working with the Dudelang parser.

## Overview
The Dudelang parser converts source code into an abstract syntax tree (AST) that can be processed programmatically. The core functionality is exposed through a simple but flexible API that handles lexing, parsing, and AST generation.

## Core Components
### DudelangParser Class
```typescript
declare class DudelangParser {
  constructor(options?: ParserOptions);

  parse(source: string, filename?: string): Promise<ASTNode>;
}
```

#### Properties
- `options`: Configuration options for parsing (see below)

#### Methods
- `parse(source: string, filename?: string)`: Converts source code into an AST

## Syntax Elements
The parser supports the following constructs:

| Keyword     | Description                              |
|-------------|------------------------------------------|
| MARK        | Declares a program marker                |
| DUDE        | Defines a named entity                   |
| SAY         | Outputs a value                         |
| COLON       | Type annotation                          |
| OP          | Binary operations (+, -, *, /, etc.)    |

## Configuration Options
```typescript
type ParserOptions = {
  validateInput?: boolean; // Enables input validation (default: true)
  formatAST?: boolean;      // Pretty-prints the AST output (default: false)
};
```

## Usage Examples
### Basic Parsing
```typescript
const parser = new DudelangParser();
const sourceCode = "MARK my_program\nSAY \"Hello, world!\"";

const ast = await parser.parse(sourceCode);
console.log(ast);
```

### Configuring the Parser
```typescript
const parser = new DudelangParser({
  validateInput: true,
  formatAST: true
});
```

## Error Handling
The parser throws `SyntaxError` exceptions for invalid code. Use try-catch blocks to handle errors gracefully:

```typescript
try {
  const ast = await parser.parse(invalidCode);
} catch (error) {
  if (error instanceof SyntaxError) {
    console.error(`Parsing error: ${error.message}`);
  }
}
```

## Changelog
- **1.0.0**: Initial release of the parser API
- **1.1.0**: Added support for custom parser options
- **1.2.0**: Improved error handling and reporting
