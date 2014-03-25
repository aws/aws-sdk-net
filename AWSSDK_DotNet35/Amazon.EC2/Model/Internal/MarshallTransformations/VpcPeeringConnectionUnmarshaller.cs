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
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   VpcPeeringConnection Unmarshaller
     /// </summary>
    internal class VpcPeeringConnectionUnmarshaller : IUnmarshaller<VpcPeeringConnection, XmlUnmarshallerContext>, IUnmarshaller<VpcPeeringConnection, JsonUnmarshallerContext> 
    {
        public VpcPeeringConnection Unmarshall(XmlUnmarshallerContext context) 
        {
            VpcPeeringConnection vpcPeeringConnection = new VpcPeeringConnection();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("accepterVpcInfo", targetDepth))
                    {
                        vpcPeeringConnection.AccepterVpcInfo = VpcPeeringConnectionVpcInfoUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("expirationTime", targetDepth))
                    {
                        vpcPeeringConnection.ExpirationTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("requesterVpcInfo", targetDepth))
                    {
                        vpcPeeringConnection.RequesterVpcInfo = VpcPeeringConnectionVpcInfoUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        vpcPeeringConnection.Status = VpcPeeringConnectionStateReasonUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        vpcPeeringConnection.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("vpcPeeringConnectionId", targetDepth))
                    {
                        vpcPeeringConnection.VpcPeeringConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return vpcPeeringConnection;
                }
            }
                        


            return vpcPeeringConnection;
        }

        public VpcPeeringConnection Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static VpcPeeringConnectionUnmarshaller instance;

        public static VpcPeeringConnectionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new VpcPeeringConnectionUnmarshaller();

            return instance;
        }
    }
}
    
