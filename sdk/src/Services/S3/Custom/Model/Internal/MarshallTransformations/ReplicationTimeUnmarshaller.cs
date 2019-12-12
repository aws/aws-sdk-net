using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class ReplicationTimeUnmarshaller : IUnmarshaller<ReplicationTime, XmlUnmarshallerContext>, IUnmarshaller<ReplicationTime, JsonUnmarshallerContext>
    {
        public ReplicationTime Unmarshall(XmlUnmarshallerContext context)
        {
            ReplicationTime replicationTime = new ReplicationTime();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Status", targetDepth))
                    {
                        replicationTime.Status = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("EventThreshold", targetDepth))
                    {
                        replicationTime.Time = ReplicationTimeValueUnmarshaller.Instance.Unmarshall(context);
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return replicationTime;
                }
            }

            return replicationTime;
        }

        public ReplicationTime Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static ReplicationTimeUnmarshaller _instance;

        public static ReplicationTimeUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReplicationTimeUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
