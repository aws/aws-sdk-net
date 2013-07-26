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
     ///   Vpc Unmarshaller
     /// </summary>
    internal class VpcUnmarshaller : IUnmarshaller<Vpc, XmlUnmarshallerContext>, IUnmarshaller<Vpc, JsonUnmarshallerContext> 
    {
        public Vpc Unmarshall(XmlUnmarshallerContext context) 
        {
            Vpc vpc = new Vpc();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        vpc.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("state", targetDepth))
                    {
                        vpc.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("cidrBlock", targetDepth))
                    {
                        vpc.CidrBlock = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("dhcpOptionsId", targetDepth))
                    {
                        vpc.DhcpOptionsId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        vpc.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("instanceTenancy", targetDepth))
                    {
                        vpc.InstanceTenancy = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("isDefault", targetDepth))
                    {
                        vpc.IsDefault = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return vpc;
                }
            }
                        


            return vpc;
        }

        public Vpc Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static VpcUnmarshaller instance;

        public static VpcUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new VpcUnmarshaller();

            return instance;
        }
    }
}
    
