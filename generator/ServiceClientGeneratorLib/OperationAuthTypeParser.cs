using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    public enum OperationAuthType { None, V4, V4UnsignedBody, Bearer }

    public static class OperationAuthTypeParser
    {
        private static readonly Dictionary<string, OperationAuthType> OperationAuthTypeMap = new Dictionary<string, OperationAuthType>
        {
            { "none", OperationAuthType.None },
            { "v4", OperationAuthType.V4 },
            { "v4-unsigned-body", OperationAuthType.V4UnsignedBody },
            { "bearer", OperationAuthType.Bearer }

        };
        public static OperationAuthType? Parse(JsonData authTypeNode)
        {
            OperationAuthType authType;

            if (authTypeNode == null)
                return null;
            else if (OperationAuthTypeMap.TryGetValue(authTypeNode.ToString(), out authType))
                return authType;
            else
                throw new ArgumentException("authTypeNode does not contain a valid value for OperationAuthType valid values include: " +
                    String.Join(", ", OperationAuthTypeMap.Values.ToArray()));
        }
    }
}
