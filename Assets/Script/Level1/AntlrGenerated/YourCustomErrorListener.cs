using Antlr4.Runtime;
using System.IO;
using System.Collections.Generic;
using UnityEngine; // ��� Debug.LogError

// MyLexerErrorListener.cs
using Antlr4.Runtime;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System; // ��� char.IsControl
// using System; // ConsoleColor �� �������, ���� ������������� Debug.LogError

public class YourCustomErrorListener : BaseErrorListener
{
    public List<string> SyntaxErrors { get; } = new List<string>();
    public bool HadError => SyntaxErrors.Count > 0;

    // ��� ����� ���� ����������� �������� (�� TSymbol = IToken)
    public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        string errorMessage = $"Syntax Error (Parser): line {line}:{charPositionInLine} at '{offendingSymbol?.Text ?? "<unknown>"}' - {msg}";
        SyntaxErrors.Add(errorMessage);
        Debug.Log(errorMessage);
    }


    public void SyntaxError(IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        char offendingChar = (char)offendingSymbol;
        string offendingSymbolText = char.IsControl(offendingChar) ? $"<control char: {offendingSymbol}>" : offendingChar.ToString();

        string errorMessage = $"Syntax Error (Lexer): line {line}:{charPositionInLine} at '{offendingSymbolText}' - {msg}";
        SyntaxErrors.Add(errorMessage);
        Debug.Log(errorMessage);
    }

    public void PrintErrors()
    {
        if (HadError)
        {
            Debug.Log("\n--- Syntax Errors Summary ---");
            // ���� ������ ��������, �������������:
            /*
            foreach (var error in SyntaxErrors)
            {
                Debug.LogError(error);
            }
            */
            Debug.Log("---------------------------\n");
        }
    }
}

public class MyParserErrorListener : BaseErrorListener
{
    public List<string> SyntaxErrors { get; } = new List<string>();
    public bool HadError => SyntaxErrors.Count > 0;

    public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        string errorMessage = $"Syntax Error (Parser): line {line}:{charPositionInLine} at '{offendingSymbol?.Text ?? "<unknown>"}' - {msg}";
        SyntaxErrors.Add(errorMessage);
        Debug.Log(errorMessage);
    }

    public void PrintErrors()
    {
        if (HadError)
        {
            Debug.Log("\n--- Parser Syntax Errors Summary ---");
            foreach (var error in SyntaxErrors)
            {
                Debug.Log(error);
            }
            Debug.Log("----------------------------------\n");
        }
    }
}


public class MyLexerErrorListener : BaseErrorListener, IAntlrErrorListener<int>
{
    public List<string> SyntaxErrors { get; } = new List<string>();
    public bool HadError => SyntaxErrors.Count > 0;

    // ��� ����� ������� ����� ��������� �������� IAntlrErrorListener<int>.SyntaxError
    // ������� ����� �� 'TextWriter output' �� �������
    public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    {
        char offendingChar = (char)offendingSymbol;
        string offendingSymbolText = char.IsControl(offendingChar) ? $"<control char: {offendingSymbol}>" : offendingChar.ToString();

        string errorMessage = $"Syntax Error (Lexer): line {line}:{charPositionInLine} at '{offendingSymbolText}' - {msg}";
        SyntaxErrors.Add(errorMessage);
        Debug.Log(errorMessage);
    }

    public void PrintErrors()
    {
        if (HadError)
        {
            Debug.Log("\n--- Lexer Syntax Errors Summary ---");
            foreach (var error in SyntaxErrors)
            {
                Debug.Log(error);
            }
            Debug.Log("---------------------------------\n");
        }
    }
}