using Json.LitJson;
using System;
using System.Linq;

namespace ServiceClientGenerator.Endpoints
{
    /// <summary>
    /// Object model for Function argument
    /// </summary>
    public class Argument
    {
        /// <summary>
        /// Builds typed function argument from json data
        /// </summary>
        public static Argument BuildFrom(JsonData node)
        {
            if (node.IsBoolean)
            {
                return new BoolArgument { Value = (bool)node };
            }
            if (node.IsString) 
            { 
                return new StringArgument { Value = (string)node };
            }
            if (node.IsInt)
            {
                return new IntegerArgument { Value = (int)node };
            }
            if (node.IsObject)
            {
                if (node.PropertyNames.Contains("ref"))
                {
                    return new ReferenceArgument() { ReferenceName = node.SafeGetString("ref") };
                }
                if (node.PropertyNames.Contains("fn"))
                {
                    return new FunctionArgument { Value = new Function(node.SafeGetString("fn"), node["argv"], node.SafeGetString("assign")) };
                }
            }
            throw new ArgumentException("Unknown argument type");
        }
    }

    public class StringArgument : Argument
    {
        public string Value { get; set; }
    }
    public class IntegerArgument : Argument
    {
        public int Value { get; set; }
    }
    public class BoolArgument : Argument
    {
        public bool Value { get; set; }
    }
    public class ReferenceArgument : Argument
    {
        public string ReferenceName { get; set; }
    }
    public class FunctionArgument : Argument
    {
        public Function Value { get; set; }
    }
}
