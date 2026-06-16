using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dudelang
{
    public enum TokenType
    {
        // Keywords
        DUDE,
        MARK,
        SAY,
        
        // Literals
        Identifier,
        StringLiteral,
        Number,
        
        // Symbols
        Assign,      // =
        Semicolon,    // ;
        Colon,        // :
        QuotationMark, // "
        
        // Whitespace
        Newline,
        Indent,
        Dedent,
        
        // Errors
        InvalidToken
    }

    public class Token
    {
        public TokenType Type { get; }
        public string Value { get; }
        public int LineNumber { get; }
        public int ColumnNumber { get; }

        public Token(TokenType type, string value, int lineNumber, int columnNumber)
        {
            Type = type;
            Value = value;
            LineNumber = lineNumber;
            ColumnNumber = columnNumber;
        }
    }

    public class Lexer
    {
        private readonly string _sourceCode;
        private List<Token> _tokens = new();
        private int _position;
        private int _lineNumber;
        private int _columnNumber;

        // Token patterns
        private static readonly Dictionary<string, TokenType> Keywords = new()
        {
            {"DUDE", TokenType.DUDE},
            {"MARK", TokenType.MARK},
            {"SAY", TokenType.SAY}
        };

        // Regex patterns for token matching
        private static readonly Dictionary<TokenType, string> Patterns = new()
        {
            [TokenType.StringLiteral] = "\"((\\\")|[^\"])*)\"",
            [TokenType.Identifier] = "[a-zA-Z_][a-zA-Z0-9_]*",
            [TokenType.Number] = "(\d+(\.\d+)?)",
            [TokenType.Assign] = "=",
            [TokenType.Semicolon] = ";",
            [TokenType.Colon] = ":",
            [TokenType.Newline] = "
"
        };

        public Lexer(string sourceCode)
        {
            _sourceCode = sourceCode;
            _position = 0;
            _lineNumber = 1;
            _columnNumber = 1;
        }

        public List<Token> Tokenize()
        {
            while (_position < _sourceCode.Length)
            {
                if (char.IsWhitespace(_sourceCode[_position]))
                {
                    HandleWhitespace();
                    continue;
                }

                // Check for keywords first
                if (IsKeyword(out string keyword))
                {
                    AddToken(Keywords[keyword]);
                    continue;
                }

                // Match other token types using regex patterns
                bool matched = false;
                foreach (var pattern in Patterns)
                {
                    if (Match(pattern.Key, pattern.Value, out string value))
                    {
                        AddToken(pattern.Key, value);
                        matched = true;
                        break;
                    }
                }

                if (!matched)
                {
                    throw new ArgumentException($"Invalid token at line {LineNumber}, column {ColumnNumber}: '{_sourceCode[_position]}'");
                }
            }

            // Add end-of-file marker
            _tokens.Add(new Token(TokenType.Newline, "\n", _lineNumber, _columnNumber));
            return _tokens;
        }

        private void HandleWhitespace()
        {
            char current = _sourceCode[_position];
            if (current == '\n')
            {
                AddToken(TokenType.Newline);
                _lineNumber++;
                _columnNumber = 1;
            }
            else
            {
                // Handle spaces and tabs
                while (_position < _sourceCode.Length && char.IsWhiteSpace(_sourceCode[_position]))
                {
                    if (_sourceCode[_position] == ' ')
                    {
                        AddToken(TokenType.Indent);
                    }
                    _position++;
                }
            }
        }

        private bool IsKeyword(out string keyword)
        {
            int start = _position;
            while (_position < _sourceCode.Length && char.IsLetter(_sourceCode[_position]))
            {
                _position++;
            }

            if (start != _position)
            {
                string text = _sourceCode.Substring(start, _position - start);
                if (Keywords.ContainsKey(text))
                {
                    keyword = text;
                    return true;
                }
            }

            keyword = null;
            return false;
        }

        private bool Match(TokenType type, string pattern, out string value)
        {
            var regex = new Regex($"^({pattern})");
            var match = regex.Match(_sourceCode.Substring(_position));
            if (match.Success)
            {
                value = match.Groups[1].Value;
                _position += match.Length;
                return true;
            }

            value = null;
            return false;
        }

        private void AddToken(TokenType type, string value = null)
        {
            _tokens.Add(new Token(type, value ?? "", _lineNumber, _columnNumber));
            _columnNumber += (value?.Length) ?? 1;
        }
    }
}