using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class ReplicationTimeValueUnmarshaller : IUnmarshaller<ReplicationTimeValue, XmlUnmarshallerContext>, IUnmarshaller<ReplicationTimeValue, JsonUnmarshallerContext>
    {
        public ReplicationTimeValue Unmarshall(XmlUnmarshallerContext context)
        {
            ReplicationTimeValue replicationTimeValue = new ReplicationTimeValue();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("EventThreshold", targetDepth))
                    {
                        replicationTimeValue.Minutes = IntUnmarshaller.Instance.Unmarshall(context);
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return replicationTimeValue;
                }
            }

            return replicationTimeValue;
        }

        public ReplicationTimeValue Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static ReplicationTimeValueUnmarshaller _instance;

        public static ReplicationTimeValueUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReplicationTimeValueUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
