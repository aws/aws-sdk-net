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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Latency Object
    /// </summary>  
    public class LatencyUnmarshaller : IXmlUnmarshaller<Latency, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Latency Unmarshall(XmlUnmarshallerContext context)
        {
            Latency unmarshalledObject = new Latency();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("P10", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.P10 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("P50", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.P50 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("P75", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.P75 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("P85", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.P85 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("P90", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.P90 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("P95", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.P95 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("P99", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.P99 = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("P999", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.P999 = unmarshaller.Unmarshall(context);
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

        private static LatencyUnmarshaller _instance = new LatencyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LatencyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}