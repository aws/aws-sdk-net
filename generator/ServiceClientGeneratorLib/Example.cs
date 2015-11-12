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

                result.Add(string.Format("{0} = {1}{2}{3}", member.PropertyName, GetSampleLiteral(member, param.Value),
                    param.Key != last ? "," : "",
                    InputComments.ContainsKey(param.Key) ? " // " + InputComments[param.Key] : ""));
            }

            return result;
        }

        private string GetSampleLiteral(Member member, JsonData data)
        {
            var typeName = member.DetermineType();

            if (data.IsString)
            {
                if (typeName == "string")
                    return string.Format("\"{0}\"", data.ToString());
                if (typeName == "bool")
                    return data.ToString().ToLower();
                if (typeName == "float" || typeName == "int" || typeName == "double" || typeName == "long")
                    return data.ToString();

                return member.VariableName;
            }
            else 
                return string.Format("new {0}{1}", typeName, "{...}");

        }

        
    }
}
