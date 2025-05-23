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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkInsightsPath Object
    /// </summary>  
    public class NetworkInsightsPathUnmarshaller : IXmlUnmarshaller<NetworkInsightsPath, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkInsightsPath Unmarshall(XmlUnmarshallerContext context)
        {
            NetworkInsightsPath unmarshalledObject = new NetworkInsightsPath();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("createdDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destination", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destinationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DestinationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destinationIp", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DestinationIp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destinationPort", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DestinationPort = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("filterAtDestination", targetDepth))
                    {
                        var unmarshaller = PathFilterUnmarshaller.Instance;
                        unmarshalledObject.FilterAtDestination = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("filterAtSource", targetDepth))
                    {
                        var unmarshaller = PathFilterUnmarshaller.Instance;
                        unmarshalledObject.FilterAtSource = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInsightsPathArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInsightsPathArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInsightsPathId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInsightsPathId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("protocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("source", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceIp", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceIp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
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

        private static NetworkInsightsPathUnmarshaller _instance = new NetworkInsightsPathUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkInsightsPathUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}