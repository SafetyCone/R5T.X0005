using System;

using R5T.F0003;


namespace R5T.X0005
{
    public static class Instances
    {
        public static ISyntaxNodeOperator SyntaxNodeOperator { get; } = F0003.SyntaxNodeOperator.Instance;
        public static ISyntaxTokenOperator SyntaxTokenOperator { get; } = F0003.SyntaxTokenOperator.Instance;
        public static ISyntaxTriviaOperator SyntaxTriviaOperator { get; } = F0003.SyntaxTriviaOperator.Instance;
    }
}
