/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HealthCheckConfig Object
    /// </summary>  
    public class HealthCheckConfigUnmarshaller : IUnmarshaller<HealthCheckConfig, XmlUnmarshallerContext>
    {
        public HealthCheckConfig Unmarshall(XmlUnmarshallerContext context)
        {
            HealthCheckConfig unmarshalledObject = new HealthCheckConfig();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("IPAddress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IPAddress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Type", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourcePath", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourcePath = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FullyQualifiedDomainName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FullyQualifiedDomainName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SearchString", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SearchString = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestInterval", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.RequestInterval = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FailureThreshold", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.FailureThreshold = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MeasureLatency", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.MeasureLatency = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Inverted", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.Inverted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HealthThreshold", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.HealthThreshold = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChildHealthChecks/ChildHealthCheck", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChildHealthChecks.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("EnableSNI", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.EnableSNI = unmarshaller.Unmarshall(context);
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

        private static HealthCheckConfigUnmarshaller _instance = new HealthCheckConfigUnmarshaller();        

        public static HealthCheckConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}