/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   VpnGateway Unmarshaller
     /// </summary>
    internal class VpnGatewayUnmarshaller : IUnmarshaller<VpnGateway, XmlUnmarshallerContext>, IUnmarshaller<VpnGateway, JsonUnmarshallerContext> 
    {
        public VpnGateway Unmarshall(XmlUnmarshallerContext context) 
        {
            VpnGateway vpnGateway = new VpnGateway();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("vpnGatewayId", targetDepth))
                    {
                        vpnGateway.VpnGatewayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        vpnGateway.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("type", targetDepth))
                    {
                        vpnGateway.Type = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        vpnGateway.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("attachments/item", targetDepth))
                    {
                        vpnGateway.VpcAttachments.Add(VpcAttachmentUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        vpnGateway.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return vpnGateway;
                }
            }
                        


            return vpnGateway;
        }

        public VpnGateway Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static VpnGatewayUnmarshaller instance;

        public static VpnGatewayUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new VpnGatewayUnmarshaller();

            return instance;
        }
    }
}
    
