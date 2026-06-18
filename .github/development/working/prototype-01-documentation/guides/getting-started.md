```markdown
# Getting Started with Dudelang

## What is Dudelang?
Dudelang is a minimal domain-specific language designed for declaring and documenting simple systems. It combines readability with structure through its indentation-based syntax.

## Prerequisites
Before getting started, ensure you have:
- Basic understanding of programming concepts
- Familiarity with markdown-style syntax
- A text editor or IDE (VS Code recommended)

## Quick Start Guide
### 1. Installing Dudelang
Clone the repository and install dependencies:
```bash
$ git clone https://github.com/APCP/Dudelang.git
$ cd Dudelang
$ npm install
```

### 2. Writing Your First Dudelang Program
Create a new file `example.du` and add this program:
```du
MARK my_first_program
DUDE counter (COLON number)
SAY "Hello, Dudelang!"
```

### 3. Running the Program
Execute the program using Node.js:
```bash
$ node index.js example.du
```

### 4. Understanding the Output
The parser will generate an abstract syntax tree (AST) and output basic information about your program.

## Learning Resources
- [Language Specification](../spec.md)
- [API Reference](../../api/index.md)
- Tutorials coming soon!

## Community
Join our community to ask questions, share projects, and contribute:
- Discord: https://discord.gg/APCP
- GitHub Discussions: https://github.com/APCP/Dudelang/discussions
