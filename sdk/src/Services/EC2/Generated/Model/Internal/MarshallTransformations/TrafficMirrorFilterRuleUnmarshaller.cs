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
    /// Response Unmarshaller for TrafficMirrorFilterRule Object
    /// </summary>  
    public class TrafficMirrorFilterRuleUnmarshaller : IUnmarshaller<TrafficMirrorFilterRule, XmlUnmarshallerContext>, IUnmarshaller<TrafficMirrorFilterRule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TrafficMirrorFilterRule Unmarshall(XmlUnmarshallerContext context)
        {
            TrafficMirrorFilterRule unmarshalledObject = new TrafficMirrorFilterRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destinationCidrBlock", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DestinationCidrBlock = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destinationPortRange", targetDepth))
                    {
                        var unmarshaller = TrafficMirrorPortRangeUnmarshaller.Instance;
                        unmarshalledObject.DestinationPortRange = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("protocol", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ruleAction", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RuleAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ruleNumber", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.RuleNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceCidrBlock", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceCidrBlock = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourcePortRange", targetDepth))
                    {
                        var unmarshaller = TrafficMirrorPortRangeUnmarshaller.Instance;
                        unmarshalledObject.SourcePortRange = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("trafficDirection", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficDirection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("trafficMirrorFilterId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficMirrorFilterId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("trafficMirrorFilterRuleId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficMirrorFilterRuleId = unmarshaller.Unmarshall(context);
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
        public TrafficMirrorFilterRule Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static TrafficMirrorFilterRuleUnmarshaller _instance = new TrafficMirrorFilterRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrafficMirrorFilterRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}