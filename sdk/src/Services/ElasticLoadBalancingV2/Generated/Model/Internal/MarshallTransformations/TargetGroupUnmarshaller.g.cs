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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TargetGroup Object
    /// </summary>
    public partial class TargetGroupUnmarshaller : IXmlUnmarshaller<TargetGroup, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TargetGroup Unmarshall(XmlUnmarshallerContext context)
        {
            TargetGroup unmarshalledObject = new TargetGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("HealthCheckEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("HealthCheckIntervalSeconds", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckIntervalSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("HealthCheckPath", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckPath = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("HealthCheckPort", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckPort = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("HealthCheckProtocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckProtocol = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("HealthCheckTimeoutSeconds", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.HealthCheckTimeoutSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("HealthyThresholdCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.HealthyThresholdCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("IpAddressType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpAddressType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("LoadBalancerArns/member", targetDepth))
                    {
                        if (unmarshalledObject.LoadBalancerArns == null)
                        {
                            unmarshalledObject.LoadBalancerArns = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerArns.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Matcher", targetDepth))
                    {
                        var unmarshaller = MatcherUnmarshaller.Instance;
                        unmarshalledObject.Matcher = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Protocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("ProtocolVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ProtocolVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TargetControlPort", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.TargetControlPort = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TargetGroupArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetGroupArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TargetGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("TargetType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("UnhealthyThresholdCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.UnhealthyThresholdCount = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
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

        private static TargetGroupUnmarshaller _instance = new TargetGroupUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TargetGroupUnmarshaller Instance => _instance;
    }
}
