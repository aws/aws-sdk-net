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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PathComponent Object
    /// </summary>  
    public class PathComponentUnmarshaller : IUnmarshaller<PathComponent, XmlUnmarshallerContext>, IUnmarshaller<PathComponent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PathComponent Unmarshall(XmlUnmarshallerContext context)
        {
            PathComponent unmarshalledObject = new PathComponent();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("aclRule", targetDepth))
                    {
                        var unmarshaller = AnalysisAclRuleUnmarshaller.Instance;
                        unmarshalledObject.AclRule = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("component", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Component = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destinationVpc", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.DestinationVpc = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("inboundHeader", targetDepth))
                    {
                        var unmarshaller = AnalysisPacketHeaderUnmarshaller.Instance;
                        unmarshalledObject.InboundHeader = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("outboundHeader", targetDepth))
                    {
                        var unmarshaller = AnalysisPacketHeaderUnmarshaller.Instance;
                        unmarshalledObject.OutboundHeader = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("routeTableRoute", targetDepth))
                    {
                        var unmarshaller = AnalysisRouteTableRouteUnmarshaller.Instance;
                        unmarshalledObject.RouteTableRoute = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("securityGroupRule", targetDepth))
                    {
                        var unmarshaller = AnalysisSecurityGroupRuleUnmarshaller.Instance;
                        unmarshalledObject.SecurityGroupRule = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sequenceNumber", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.SequenceNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceVpc", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.SourceVpc = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("subnet", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Subnet = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpc", targetDepth))
                    {
                        var unmarshaller = AnalysisComponentUnmarshaller.Instance;
                        unmarshalledObject.Vpc = unmarshaller.Unmarshall(context);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PathComponent Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static PathComponentUnmarshaller _instance = new PathComponentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PathComponentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}