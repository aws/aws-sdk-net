using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKDocGenerator.Syntax
{
    public class SyntaxWriter
    {
        static Func<string, string> wrapHighlight = (x) => string.Format("<span style=\"color:Blue;\">{0}</span>", x);

        FrameworkVersion _version;
        StringBuilder _builder = new StringBuilder();
        bool _inCommaDelimitedList = false;

        public SyntaxWriter(FrameworkVersion version)
        {
            this._version = version;
        }

        public void WriteToken(string token)
        {
            if(this._builder.Length > 0)
                this._builder.Append(" ");

            WriteValue(wrapHighlight(token));
        }

        public void WriteTypeName(TypeWrapper type)
        {
            if (this._builder.Length > 0)
                this._builder.Append(" ");

            string typeName = type.GetDisplayName(false);
            if (typeName == "Void")
                typeName = "void";

            WriteValue(typeName);
        }

        public void WriteRaw(string value)
        {
            this._builder.Append(value);
        }

        private void WriteValue(string value)
        {
            this._builder.Append(value);

            if (this._inCommaDelimitedList)
                this._builder.Append(",");
        }

        public void WriteNewLineWithTab()
        {
            this._builder.Append("\n        ");
        }

        public void Reset()
        {
            this._builder = new StringBuilder();
        }

        public string CurrentSyntax
        {
            get{return this._builder.ToString();}
        }

        public override string ToString()
        {
            return this._builder.ToString();
        }

        public void BeginCommaDelimitedList()
        {
            this._inCommaDelimitedList = true;
        }

        public void EndCommaDelimitedList()
        {
            this._inCommaDelimitedList = false;

            if (this._builder[this._builder.Length - 1] == ',')
            {
                this._builder.Remove(this._builder.Length - 1, 1);
            }
        }
    }
}
