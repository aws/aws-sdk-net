using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Metrics unmarshaller
    /// </summary>
    public class MetricsUnmarshaller : IXmlUnmarshaller<Metrics, XmlUnmarshallerContext>, IXmlUnmarshaller<Metrics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Metrics Unmarshall(XmlUnmarshallerContext context)
        {
            Metrics metrics = new Metrics();
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
                        metrics.Status = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("EventThreshold", targetDepth))
                    {
                        metrics.EventThreshold = ReplicationTimeValueUnmarshaller.Instance.Unmarshall(context);
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return metrics;
                }
            }

            return metrics;
        }

        /// <summary>
        /// Not implemented and always returns null.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Metrics Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static MetricsUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static MetricsUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MetricsUnmarshaller();
                }
                return _instance;
            }
        }
    }
}

