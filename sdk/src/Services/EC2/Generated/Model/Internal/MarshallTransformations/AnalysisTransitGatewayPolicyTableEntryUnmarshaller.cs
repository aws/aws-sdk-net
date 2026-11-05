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
    /// Response Unmarshaller for AnalysisTransitGatewayPolicyTableEntry Object
    /// </summary>  
    public class AnalysisTransitGatewayPolicyTableEntryUnmarshaller : IXmlUnmarshaller<AnalysisTransitGatewayPolicyTableEntry, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AnalysisTransitGatewayPolicyTableEntry Unmarshall(XmlUnmarshallerContext context)
        {
            AnalysisTransitGatewayPolicyTableEntry unmarshalledObject = new AnalysisTransitGatewayPolicyTableEntry();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("destinationCidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DestinationCidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("destinationPortRange", targetDepth))
                    {
                        var unmarshaller = PortRangeUnmarshaller.Instance;
                        unmarshalledObject.DestinationPortRange = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("protocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ruleNumber", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.RuleNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourceCidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceCidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sourcePortRange", targetDepth))
                    {
                        var unmarshaller = PortRangeUnmarshaller.Instance;
                        unmarshalledObject.SourcePortRange = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("targetRouteTableId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetRouteTableId = unmarshaller.Unmarshall(context);
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

        private static AnalysisTransitGatewayPolicyTableEntryUnmarshaller _instance = new AnalysisTransitGatewayPolicyTableEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnalysisTransitGatewayPolicyTableEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}