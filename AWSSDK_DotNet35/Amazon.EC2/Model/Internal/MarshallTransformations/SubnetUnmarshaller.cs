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
     ///   Subnet Unmarshaller
     /// </summary>
    internal class SubnetUnmarshaller : IUnmarshaller<Subnet, XmlUnmarshallerContext>, IUnmarshaller<Subnet, JsonUnmarshallerContext> 
    {
        public Subnet Unmarshall(XmlUnmarshallerContext context) 
        {
            Subnet subnet = new Subnet();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("subnetId", targetDepth))
                    {
                        subnet.SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        subnet.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        subnet.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("cidrBlock", targetDepth))
                    {
                        subnet.CidrBlock = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availableIpAddressCount", targetDepth))
                    {
                        subnet.AvailableIpAddressCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        subnet.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("defaultForAz", targetDepth))
                    {
                        subnet.DefaultForAz = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("mapPublicIpOnLaunch", targetDepth))
                    {
                        subnet.MapPublicIpOnLaunch = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        subnet.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return subnet;
                }
            }
                        


            return subnet;
        }

        public Subnet Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SubnetUnmarshaller instance;

        public static SubnetUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SubnetUnmarshaller();

            return instance;
        }
    }
}
    
