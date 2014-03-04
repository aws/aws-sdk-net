#pragma warning disable 1587
#region Header
///
/// ParserToken.cs
///   Internal representation of the tokens used by the lexer and the parser.
///
/// The authors disclaim copyright to this source code. For more details, see
/// the COPYING file included with this distribution.
///
#endregion


namespace ThirdParty.Json.LitJson
{
    internal enum ParserToken
    {
        // Lexer tokens
        None = System.Char.MaxValue + 1,
        Number,
        True,
        False,
        Null,
        CharSeq,
        // Single char
        Char,

        // Parser Rules
        Text,
        Object,
        ObjectPrime,
        Pair,
        PairRest,
        Array,
        ArrayPrime,
        Value,
        ValueRest,
        String,

        // End of input
        End,

        // The empty rule
        Epsilon
    }
}
