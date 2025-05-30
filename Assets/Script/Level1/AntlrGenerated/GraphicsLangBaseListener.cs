//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from GraphicsLang.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Drawing.Parsing {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IGraphicsLangListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class GraphicsLangBaseListener : IGraphicsLangListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] GraphicsLangParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] GraphicsLangParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] GraphicsLangParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] GraphicsLangParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaration([NotNull] GraphicsLangParser.VariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaration([NotNull] GraphicsLangParser.VariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] GraphicsLangParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] GraphicsLangParser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] GraphicsLangParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] GraphicsLangParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] GraphicsLangParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] GraphicsLangParser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] GraphicsLangParser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] GraphicsLangParser.ForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] GraphicsLangParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] GraphicsLangParser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] GraphicsLangParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] GraphicsLangParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.startDrawStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStartDrawStatement([NotNull] GraphicsLangParser.StartDrawStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.startDrawStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStartDrawStatement([NotNull] GraphicsLangParser.StartDrawStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.drawStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrawStatement([NotNull] GraphicsLangParser.DrawStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.drawStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrawStatement([NotNull] GraphicsLangParser.DrawStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.drawControlStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrawControlStatement([NotNull] GraphicsLangParser.DrawControlStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.drawControlStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrawControlStatement([NotNull] GraphicsLangParser.DrawControlStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.colorSetStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColorSetStatement([NotNull] GraphicsLangParser.ColorSetStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.colorSetStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColorSetStatement([NotNull] GraphicsLangParser.ColorSetStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] GraphicsLangParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] GraphicsLangParser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] GraphicsLangParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] GraphicsLangParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] GraphicsLangParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] GraphicsLangParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.argumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgumentList([NotNull] GraphicsLangParser.ArgumentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.argumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgumentList([NotNull] GraphicsLangParser.ArgumentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.pointAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPointAccess([NotNull] GraphicsLangParser.PointAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.pointAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPointAccess([NotNull] GraphicsLangParser.PointAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayAccess([NotNull] GraphicsLangParser.ArrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayAccess([NotNull] GraphicsLangParser.ArrayAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] GraphicsLangParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] GraphicsLangParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.pointLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPointLiteral([NotNull] GraphicsLangParser.PointLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.pointLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPointLiteral([NotNull] GraphicsLangParser.PointLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.arrayLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayLiteral([NotNull] GraphicsLangParser.ArrayLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.arrayLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayLiteral([NotNull] GraphicsLangParser.ArrayLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.matrixLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatrixLiteral([NotNull] GraphicsLangParser.MatrixLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.matrixLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatrixLiteral([NotNull] GraphicsLangParser.MatrixLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterList([NotNull] GraphicsLangParser.ParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterList([NotNull] GraphicsLangParser.ParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="GraphicsLangParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType([NotNull] GraphicsLangParser.TypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="GraphicsLangParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType([NotNull] GraphicsLangParser.TypeContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Drawing.Parsing
