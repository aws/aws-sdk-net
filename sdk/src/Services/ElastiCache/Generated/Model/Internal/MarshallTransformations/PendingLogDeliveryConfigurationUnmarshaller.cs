/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PendingLogDeliveryConfiguration Object
    /// </summary>  
    public class PendingLogDeliveryConfigurationUnmarshaller : IXmlUnmarshaller<PendingLogDeliveryConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PendingLogDeliveryConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            PendingLogDeliveryConfiguration unmarshalledObject = new PendingLogDeliveryConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DestinationDetails", targetDepth))
                    {
                        var unmarshaller = DestinationDetailsUnmarshaller.Instance;
                        unmarshalledObject.DestinationDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DestinationType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DestinationType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LogFormat", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogFormat = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LogType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogType = unmarshaller.Unmarshall(context);
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

        private static PendingLogDeliveryConfigurationUnmarshaller _instance = new PendingLogDeliveryConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PendingLogDeliveryConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}