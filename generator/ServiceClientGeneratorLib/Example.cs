using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    /// <summary>
    /// Represents a code sample for an operation.
    /// </summary>
    public class Example : BaseModel
    {
        public const string
            IdKey = "id",
            TitleKey = "title",
            DescriptionKey = "description",
            InputKey = "input",
            OutputKey = "output",
            CommentsKey = "comments";

        public Example(ServiceModel model, string operationName, JsonData data) : base(model, data)
        {
            this.OperationName = operationName;
        }

        /// <summary>
        /// The name of the operation this sample is for
        /// </summary>
        public string OperationName { get; set; }

        /// <summary>
        /// The operation metadata associated with this example.
        /// </summary>
        public Operation Operation
        {
            get { return this.model.FindOperation(OperationName); }
        }

        /// <summary>
        /// The example id taken from the model.
        /// </summary>
        /// <remarks>
        /// This unique id is used for the region in the emitted code sample 
        /// that will be parsed to include the code in the documentation.
        /// </remarks>
        public string Id
        {
            get
            {
                return data.SafeGetString(IdKey);
            }
        }

        /// <summary>
        /// The title for the example.
        /// </summary>
        public string Title
        {
            get
            {
                return data.SafeGetString(TitleKey);
            }
        }

        /// <summary>
        /// Descriptive text for the example.
        /// </summary>
        public string Description
        {
            get
            {
                return data.SafeGetString(DescriptionKey);
            }
        }

        /// <summary>
        /// The sample data for the input parameters.
        /// </summary>
        public IDictionary<string, JsonData> InputParameters
        {
            get
            {
                var inputMap = data.SafeGet(InputKey);
                if (null == inputMap)
                    return new Dictionary<string, JsonData>();
                return inputMap.GetMap();
            }
        }

        /// <summary>
        /// The sample data for the output parameters.
        /// </summary>
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

        /// <summary>
        /// Comments for the sample input data.
        /// </summary>
        /// <remarks>
        /// A map of property name to comment text.
        /// </remarks>
        public IDictionary<string, string> InputComments
        {
            get
            {
                return GetComments(InputKey);
            }
        }

        /// <summary>
        /// Comments for the sample response data.
        /// </summary>
        /// <remarks>
        /// A map of property name to comment text.
        /// </remarks>
        public IDictionary<string, string> OutputComments
        {
            get
            {
                return GetComments(OutputKey);
            }
        }

        // Common to the InputComments and OutputComments properties
        private IDictionary<string, string> GetComments(string key)
        {
            var comments = this.data[CommentsKey];
            if (null != comments)
            {
                var map = comments.SafeGet(key);
                if (null != map)
                    return map.GetStringMap();
            }
            return new Dictionary<string, string>();
        }

        /// <summary>
        /// For the request, build the literals and/or instantiators to assign to each
        /// property in the request shape for which sample data was supplied in the example.
        /// </summary>
        /// <returns>A list of strings of the form 'PropertyName = value' with comments at the
        /// end, if present.</returns>
        public IList<string> GetRequestAssignments(int currentIndent)
        {
            var result = new List<string>();
            if (!InputParameters.Any())
                return result;

            var last = InputParameters.Last().Key;
            foreach (var param in InputParameters)
            {
                var member = Operation.RequestStructure.Members.GetMemberByName(param.Key);

                if (null == member)
                    continue;

                var sb = new StringBuilder();
                var cb = new CodeBuilder(sb, currentIndent);

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

        public IList<string> GetResponseAssignments()
        {
            var result = new List<string>();

            foreach (var param in OutputParameters)
            {
                var member = Operation.ResponseStructure.Members.GetMemberByName(param.Key);

                if (null == member)
                    continue;

                result.Add(string.Format("{0} {1} = response.{2};{3}",
                    ShapeType(member.Shape),
                    member.ArgumentName,
                    member.PropertyName,
                    OutputComments.ContainsKey(param.Key) ? " // " + OutputComments[param.Key] : ""));
            }

            return result;
        }
        

        /// <summary>
        /// Given a member and sample data, build a literal/instantation for the
        /// member's type with the sample data.
        /// </summary>
        /// <param name="member">The member in the model</param>
        /// <param name="data">Sample data to populate the literal with</param>
        /// <param name="cb">A CodeBuilder instance to write the code to.</param>
        public void GetSampleLiteral(Member member, JsonData data, CodeBuilder cb)
        {
            GetSampleLiteral(member.Shape, data, cb);
        }

        /// <summary>
        /// Given a Shape and sample data, build a literal/instantiation for the
        /// Shape's type with the sample data.
        /// </summary>
        /// <param name="shape">The Shape in the model</param>
        /// <param name="data">Sample data to populate the literal with</param>
        /// <param name="cb">A CodeBuilder instance to write the code to.</param>
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

                cb.AppendFormat("new List<{0}> ", ShapeType(itemType)).OpenBlock();

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

                cb.AppendFormat("new Dictionary<{0}, {1}> ", ShapeType(keyType), ShapeType(valType));

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
                cb.AppendFormat("new {0} ", ShapeType(shape));

                if (data.PropertyNames.Count() > 1)
                    cb.OpenBlock();
                else
                    cb.Append("{ ");

                foreach (var field in data.PropertyNames)
                {
                    var property = shape.Members.GetMemberByName(field);
 
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

        /// <summary>
        /// Return the type name for a shape
        /// </summary>
        /// <param name="shape">The shape to get the type name for</param>
        /// <returns></returns>
        private string ShapeType(Shape shape)
        {
            if (shape.IsBoolean)
                return "bool";
            if (shape.IsDateTime)
                return "DateTime";
            if (shape.IsPrimitiveType)
                return shape.Type;
            if (shape.IsMap)
                return string.Format("Dictionary<{0}, {1}>", ShapeType(shape.KeyShape), ShapeType(shape.ValueShape));
            if (shape.IsList)
                return string.Format("List<{0}>", ShapeType(shape.ListShape));
            if (shape.IsStructure)
                return shape.Name;
            if (shape.IsMemoryStream)
                return "MemoryStream";
            throw new InvalidOperationException(string.Format("Unable to resolve type for shape {0}", shape.Name));
        }
    }
}

