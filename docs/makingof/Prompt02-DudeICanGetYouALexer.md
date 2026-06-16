<div align="center">

  <h1>The Making of Dudelang</h1>
  <h3>02: Dude, I can get you a lexer</h3>

</div>

## Prompt

Let's start with the lexer implementation.

But before we do that, a few minor changes/tweaks:

1. Keywords  should be recognized as distinct tokens by the lexer, separate from identifiers and string literals.
2. Keywords should be in UPPERCASE (e.g., "DUDE", "MARK", "SAY")
3. String literals should be enclosed in double quotes (e.g., "Hello world")
4. The components (Lexer, Parser, Semantic Analysis, Code Generation, Runtime) should implemented in .NET 10 C#, using appropriate libraries and frameworks for each component.

Be sure to document *everything* thoroughly, including design decisions, implementation details, and any deviations from the original plan.

And make sure to create/update the following:

* Language Specification (docs/spec.md)
* Getting Started Guide (docs/guides/getting-started.md)
* API Reference (docs/api/)

Let's implement the lexer!

## Response
