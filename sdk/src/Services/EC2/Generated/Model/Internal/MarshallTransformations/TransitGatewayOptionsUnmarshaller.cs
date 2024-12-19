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
    /// Response Unmarshaller for TransitGatewayOptions Object
    /// </summary>  
    public class TransitGatewayOptionsUnmarshaller : IXmlUnmarshaller<TransitGatewayOptions, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TransitGatewayOptions Unmarshall(XmlUnmarshallerContext context)
        {
            TransitGatewayOptions unmarshalledObject = new TransitGatewayOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("amazonSideAsn", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.AmazonSideAsn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("associationDefaultRouteTableId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AssociationDefaultRouteTableId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("autoAcceptSharedAttachments", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AutoAcceptSharedAttachments = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("defaultRouteTableAssociation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultRouteTableAssociation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("defaultRouteTablePropagation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultRouteTablePropagation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dnsSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DnsSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("multicastSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MulticastSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("propagationDefaultRouteTableId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PropagationDefaultRouteTableId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("securityGroupReferencingSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecurityGroupReferencingSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("transitGatewayCidrBlocks/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.TransitGatewayCidrBlocks == null)
                        {
                            unmarshalledObject.TransitGatewayCidrBlocks = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TransitGatewayCidrBlocks.Add(item);
                        continue;
                    }
                    if (context.TestExpression("vpnEcmpSupport", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpnEcmpSupport = unmarshaller.Unmarshall(context);
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

        private static TransitGatewayOptionsUnmarshaller _instance = new TransitGatewayOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransitGatewayOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}