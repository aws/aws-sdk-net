using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Wrapper around string builder to help emit properly indented code
    /// </summary>
    public class CodeBuilder
    {
        StringBuilder sb;

        int tabWidth;
        int currentIndent;

        string indentSpaces;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="sb">StringBuilder instance to wrap</param>
        /// <param name="startingIndent">Staring indent width (in spaces)</param>
        /// <param name="tabWidth">Additional indent width (in spaces)</param>
        public CodeBuilder(StringBuilder sb, int startingIndent, int tabWidth = 4)
        {
            this.sb = sb;
            this.tabWidth = tabWidth;
            this.currentIndent = startingIndent;
            this.indentSpaces = new string(' ', currentIndent);
        }

        /// <summary>
        /// Append a formatted string at the current location.
        /// </summary>
        /// <param name="format">Format string</param>
        /// <param name="p">Parameters</param>
        /// <returns>This CodeBuilder instance for chaining</returns>
        public CodeBuilder AppendFormat(string format, params object[] p)
        {
            sb.AppendFormat(format, p);
            return this;
        }

        /// <summary>
        /// Append a string at the current location
        /// </summary>
        /// <param name="s">a string</param>
        /// <returns>This CodeBuilder instance for chaining</returns>
        public CodeBuilder Append(string s)
        {
            sb.Append(s);
            return this;
        }

        /// <summary>
        /// Append a string at the current location, add a newline and indent to the current indent.
        /// </summary>
        /// <param name="line"></param>
        /// <returns>This CodeBuilder instance for chaining</returns>
        public CodeBuilder AppendLine(string line)
        {
            sb.AppendLine(line);
            sb.Append(indentSpaces);
            return this;
        }

        /// <summary>
        /// Add a newline, and indent to the current indent
        /// </summary>
        /// <returns>This CodeBuilder instance for chaining</returns>
        public CodeBuilder AppendLine()
        {
            return this.AppendLine("");
        }

        /// <summary>
        /// Increase the indent and open a block, adding a '{' and a newline and indent.
        /// </summary>
        /// <remarks>
        /// The current position will be on a new line at the newly increased indent.
        /// </remarks>
        /// <returns>This CodeBuilder instance for chaining</returns>
        public CodeBuilder OpenBlock()
        {
            this.currentIndent += this.tabWidth;
            this.indentSpaces = new string(' ', currentIndent);
            this.AppendLine("{");

            return this;
        }

        /// <summary>
        /// Add a newline, reduce the indent by the tab width, and add a '}'
        /// </summary>
        /// <returns>This CodeBuilder instance for chaining</returns>
        public CodeBuilder CloseBlock()
        {
            this.currentIndent -= this.tabWidth;
            if (currentIndent < 0)
                throw new InvalidOperationException("Can't indent below 0");
            this.indentSpaces = new string(' ', currentIndent);
            this.AppendLine();
            this.Append("}");
            return this;
        }

        /// <summary>
        /// Append a string with quotes around it.
        /// </summary>
        /// <param name="s">The string</param>
        /// <param name="open">The opening quote character. Defaults to double quotes.</param>
        /// <param name="close">The closing quote character. Defaults to the open character.</param>
        /// <returns>This CodeBuilder instance for chaining</returns>
        public CodeBuilder AppendQuote(string s, string open = @"""", string close = null)
        {
            sb.Append(open).Append(s.Replace("\"", "\\\"")).Append(null == close ? open : close);
            return this;
        }
    }
}
