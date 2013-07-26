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
     ///   SecurityGroup Unmarshaller
     /// </summary>
    internal class SecurityGroupUnmarshaller : IUnmarshaller<SecurityGroup, XmlUnmarshallerContext>, IUnmarshaller<SecurityGroup, JsonUnmarshallerContext> 
    {
        public SecurityGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            SecurityGroup securityGroup = new SecurityGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        securityGroup.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("groupName", targetDepth))
                    {
                        securityGroup.GroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("groupId", targetDepth))
                    {
                        securityGroup.GroupId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("groupDescription", targetDepth))
                    {
                        securityGroup.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ipPermissions/item", targetDepth))
                    {
                        securityGroup.IpPermissions.Add(IpPermissionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("ipPermissionsEgress/item", targetDepth))
                    {
                        securityGroup.IpPermissionsEgress.Add(IpPermissionUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        securityGroup.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        securityGroup.Tags.Add(TagUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return securityGroup;
                }
            }
                        


            return securityGroup;
        }

        public SecurityGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SecurityGroupUnmarshaller instance;

        public static SecurityGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SecurityGroupUnmarshaller();

            return instance;
        }
    }
}
    
