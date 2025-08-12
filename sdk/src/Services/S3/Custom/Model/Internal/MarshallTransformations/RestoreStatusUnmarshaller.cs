using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RestoreStatus Object
    /// </summary>  
    public class RestoreStatusUnmarshaller : IXmlUnmarshaller<RestoreStatus, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RestoreStatus Unmarshall(XmlUnmarshallerContext context)
        {
            RestoreStatus unmarshalledObject = new RestoreStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("IsRestoreInProgress", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.IsRestoreInProgress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RestoreExpiryDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.RestoreExpiryDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }
            return unmarshalledObject;
        }

        private static RestoreStatusUnmarshaller _instance = new RestoreStatusUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}

