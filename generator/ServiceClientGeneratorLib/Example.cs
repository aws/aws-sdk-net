using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    public class Example : BaseModel
    {
        public const string
            IdKey          = "id",
            TitleKey       = "title",
            DescriptionKey = "description",
            InputKey       = "input",
            OutputKey      = "output",
            CommentsKey    = "comments";

        public Example(ServiceModel model, string operationName, JsonData data) : base(model, data)
        {
            this.OperationName = operationName;
        }

        public string OperationName {get; set;}

        public Operation Operation
        {
            get { return this.model.FindOperation(OperationName); }
        }

        public string Id
        {
            get
            {
                return data.SafeGetString(IdKey);
            }
        }

        public string Title
        {
            get
            {
                return data.SafeGetString(TitleKey);
            }
        }

        public string Description
        {
            get
            {
                return data.SafeGetString(DescriptionKey);
            }
        }

        public IDictionary<string,JsonData> InputParameters
        {
            get
            {
                var inputMap = data.SafeGet(InputKey);
                if (null == inputMap)
                    return new Dictionary<string, JsonData>();
                return inputMap.GetMap();
            }
        }

        public IDictionary<string, JsonData> OutputParameters
        {
            get
            {
                var outputMap = data.SafeGet(OutputKey);
                if (null == outputMap)
                    return new Dictionary<string, JsonData>();
                return outputMap.GetMap();
            }
        }

        public IDictionary<string, string> InputComments
        {
            get
            {
                return GetComments(InputKey);
            }
        }

        public IDictionary<string, string> OutputComments
        {
            get
            {
                return GetComments(OutputKey);
            }
        }

        private IDictionary<string, string> GetComments(string key)
        {
            var comments = this.data[CommentsKey];
            if (null == comments)
                return new Dictionary<string, string>();

            var map = comments.SafeGet(key);
            if (null == map)
                return new Dictionary<string, string>();
            return map.GetStringMap();
        }

        public IList<string> GetRequestAssignments()
        {
            var result = new List<string>();
            var last = InputParameters.Last().Key;
            foreach (var param in InputParameters)
            {
                var member = Operation.RequestStructure.Members
                    .Where(m => m.ModeledName.Equals(param.Key, StringComparison.OrdinalIgnoreCase))
                    .SingleOrDefault();
                
                if (null == member)
                    continue;

                var sb = new StringBuilder();
                var cb = new CodeBuilder(sb, 16);

                cb.Append(member.PropertyName).Append(" = ");
                GetSampleLiteral(member, param.Value, cb);
                if (param.Key != last)
                    cb.Append(",");
                if (InputComments.ContainsKey(param.Key))
                    cb.Append(" // ").Append(InputComments[param.Key]);

                result.Add(sb.ToString());
            }

            return result;
        }

        public void GetSampleLiteral(Member member, JsonData data, CodeBuilder cb)
        {
            GetSampleLiteral(member.Shape, data, cb);
        }

        public void GetSampleLiteral(Shape shape, JsonData data, CodeBuilder cb)
        {
            if (shape.IsString && data.IsString)
                cb.AppendQuote(data.ToString());
            if (shape.IsBoolean)
                cb.Append(data.ToString().ToLower());
            if (shape.IsFloat || shape.IsInt || shape.IsDouble || shape.IsLong)
                cb.Append(data.ToString());

            if (shape.IsList && data.IsArray)
            {
                var itemType = shape.ListShape;

                cb.AppendFormat("new List<{0}> ", itemType.Type).OpenBlock();

                for (int i = 0; i < data.Count; i++)
                { 
                    GetSampleLiteral(itemType, data[i], cb);
                    if (i < (data.Count - 1))
                        cb.AppendLine(",");
                }

                cb.CloseBlock();
            }

            if (shape.IsMap && data.IsObject)
            {
                var keyType = shape.KeyShape;
                var valType = shape.ValueShape;

                cb.AppendFormat("new Dictionary<{0}, {1}> ", keyType.Type, valType.ToString());

                cb.OpenBlock();

                foreach (var k in data.PropertyNames)
                {
                    cb.Append("{ ");

                    GetSampleLiteral(keyType, k, cb);
                    cb.Append(", ");
                    GetSampleLiteral(valType, data[k], cb);

                    cb.Append(" }");
                    if (k != data.PropertyNames.Last())
                        cb.AppendLine(",");
                }

                cb.CloseBlock();

            }

            if (shape.IsStructure && data.IsObject)
            {
                cb.AppendFormat("new {0} ", shape.Name);

                if (data.PropertyNames.Count() > 1)
                    cb.OpenBlock();
                else
                    cb.Append("{ ");

                foreach (var field in data.PropertyNames)
                {
                    var property = shape.Members
                        .Where(m => m.ModeledName.Equals(field, StringComparison.OrdinalIgnoreCase))
                        .SingleOrDefault();
                    if (null == property)
                        continue;

                    cb.AppendFormat("{0} = ", property.PropertyName);
                    GetSampleLiteral(property, data[field], cb);

                    if (field != data.PropertyNames.Last())
                        cb.AppendLine(",");

                }

                if (data.PropertyNames.Count() > 1)
                    cb.CloseBlock();
                else
                    cb.Append(" }");
            }
        }

        private string ShapeType(Shape shape)
        {
            if (shape.IsPrimitiveType)
                return shape.Type;
            if (shape.IsMap)
                return string.Format("Dictionary<{0}, {1}>", ShapeType(shape.KeyShape), ShapeType(shape.ValueShape));
            if (shape.IsList)
                return string.Format("List<0>", shape.ListShape);
            if (shape.IsStructure)
                return shape.Name;
            return "object";
        }
    }

    public class CodeBuilder
    {
        StringBuilder sb;

        int tabWidth;
        int currentIndent;

        string indentSpaces;

        public CodeBuilder(StringBuilder sb, int startingIndent, int tabWidth = 4)
        {
            this.sb = sb;
            this.tabWidth = tabWidth;
            this.currentIndent = startingIndent;
            this.indentSpaces = new string(' ', currentIndent);
        }

        public CodeBuilder AppendFormat(string format, params object[] p)
        {
            sb.AppendFormat(format, p);
            return this;
        }

        public CodeBuilder Append(string s)
        {
            sb.Append(s);
            return this;
        }


        public CodeBuilder AppendLine(string line)
        {
            sb.AppendLine(line);
            sb.Append(indentSpaces);
            return this;
        }

        public CodeBuilder AppendLine()
        {
            return this.AppendLine("");
        }

        public CodeBuilder AppendLines(IEnumerable<string> lines, string lineSeparator = "")
        {
            foreach(var line in lines)
            {
                sb.Append(indentSpaces);
                sb.Append(line);
                if (!line.Equals(lines.Last()))
                    sb.Append(",");
                sb.AppendLine();
            }
            return this;
        }

        public CodeBuilder OpenBlock()
        {
            this.currentIndent += this.tabWidth;
            this.indentSpaces = new string(' ', currentIndent);
            this.AppendLine("{");
            
            return this;
        }

        public CodeBuilder CloseBlock()
        {
            this.currentIndent -= this.tabWidth;
            if (currentIndent < 0)
                currentIndent = 0;
            this.indentSpaces = new string(' ', currentIndent);
            this.AppendLine();
            this.Append("}");
            return this;
        }

        public CodeBuilder AppendQuote(string s, string open = @"""", string close = null)
        {
            sb.Append(open).Append(s).Append(null == close ? open : close);
            return this;
        }

    

    }
}
