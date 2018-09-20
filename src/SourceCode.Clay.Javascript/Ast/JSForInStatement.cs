using System.Collections.Generic;

namespace SourceCode.Clay.Javascript.Ast
{
    public class JSForInStatement : JSBodyStatement
    {
        public override JSNodeType Type => JSNodeType.ForInStatement;

        public Discriminated<JSVariableDeclaration, IJSPattern> Left { get; set; }

        public JSExpression Right { get; set; }

        public JSForInStatement()
        { }

        public JSForInStatement(Discriminated<JSVariableDeclaration, IJSPattern> left, JSExpression right)
        {
            Left = left;
            Right = right;
        }

        public JSForInStatement(Discriminated<JSVariableDeclaration, IJSPattern> left, JSExpression right, JSStatement body)
            : base(body)
        {
            Left = left;
            Right = right;
        }

        public new JSForInStatement Add(JSStatement body) => (JSForInStatement)base.Add(body);
        public new JSForInStatement Add(params JSStatement[] body) => (JSForInStatement)base.Add(body);
        public new JSForInStatement Add(IEnumerable<JSStatement> body) => (JSForInStatement)base.Add(body);
    }
}