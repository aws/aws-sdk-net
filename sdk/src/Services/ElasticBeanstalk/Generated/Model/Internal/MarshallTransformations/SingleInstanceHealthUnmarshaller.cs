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
    /// Response Unmarshaller for SingleInstanceHealth Object
    /// </summary>  
    public class SingleInstanceHealthUnmarshaller : IXmlUnmarshaller<SingleInstanceHealth, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SingleInstanceHealth Unmarshall(XmlUnmarshallerContext context)
        {
            SingleInstanceHealth unmarshalledObject = new SingleInstanceHealth();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ApplicationMetrics", targetDepth))
                    {
                        var unmarshaller = ApplicationMetricsUnmarshaller.Instance;
                        unmarshalledObject.ApplicationMetrics = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Causes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.Causes == null)
                        {
                            unmarshalledObject.Causes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Causes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Color", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Color = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Deployment", targetDepth))
                    {
                        var unmarshaller = DeploymentUnmarshaller.Instance;
                        unmarshalledObject.Deployment = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HealthStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HealthStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LaunchedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LaunchedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("System", targetDepth))
                    {
                        var unmarshaller = SystemStatusUnmarshaller.Instance;
                        unmarshalledObject.System = unmarshaller.Unmarshall(context);
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

        private static SingleInstanceHealthUnmarshaller _instance = new SingleInstanceHealthUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SingleInstanceHealthUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}