using Antlr4.Runtime;
using Drawing.Parsing;
using UnityEngine;

public class GraphicsLangRunner
{
    public static void RunScript(string script, IDrawingEngine drawingEngine)
    {
        Debug.Log("--- Parsing Script ---");
        AntlrInputStream inputStream = new AntlrInputStream(script);
        GraphicsLangLexer lexer = new GraphicsLangLexer(inputStream);
        CommonTokenStream tokenStream = new CommonTokenStream(lexer);
        GraphicsLangParser parser = new GraphicsLangParser(tokenStream);

        // ��������� ����� ������� ��� ������� �� �������
        var lexerErrorListener = new MyLexerErrorListener();
        var parserErrorListener = new MyParserErrorListener();

        // ��������� ��������� ������� ������� � ������ ����
        lexer.RemoveErrorListeners();
        lexer.AddErrorListener(lexerErrorListener); // ������ ������� ��� �������

        parser.RemoveErrorListeners();
        parser.AddErrorListener(parserErrorListener); // ������ ������� ��� �������

        GraphicsLangParser.ProgramContext tree = parser.program();

        // ����������, �� ���� ���������� �������
        bool hadSyntaxErrors = lexerErrorListener.HadError || parserErrorListener.HadError;

        if (hadSyntaxErrors)
        {
            Debug.Log("Parsing failed due to syntax errors. Script will not be executed.");
            lexerErrorListener.PrintErrors(); // �������� ������� �������
            parserErrorListener.PrintErrors(); // �������� ������� �������
        }
        else
        {
            Debug.Log("Parsing successful. No syntax errors found.");

            Debug.Log("\n--- Interpreting Script ---");
            GraphicsLangInterpreter interpreter = new GraphicsLangInterpreter(drawingEngine);
            try
            {
                interpreter.Visit(tree);
                Debug.Log("Interpretation finished successfully.");
            }
            catch (GraphicsLangInterpreterException ex)
            {
                Debug.Log($"Runtime Error: {ex.Message}");
                if (ex.InnerException != null)
                    Debug.Log($"Inner Exception: {ex.InnerException.Message}");
            }
            catch (System.Exception ex)
            {
                Debug.Log($"An unexpected system error occurred during interpretation: {ex.Message}");
                Debug.Log(ex.StackTrace);
            }
            Debug.Log("---------------------------\n");
        }
    }
}