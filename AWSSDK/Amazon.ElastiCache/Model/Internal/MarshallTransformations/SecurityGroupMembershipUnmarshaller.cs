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

using Amazon.ElastiCache.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   SecurityGroupMembership Unmarshaller
     /// </summary>
    internal class SecurityGroupMembershipUnmarshaller : IUnmarshaller<SecurityGroupMembership, XmlUnmarshallerContext>, IUnmarshaller<SecurityGroupMembership, JsonUnmarshallerContext> 
    {
        public SecurityGroupMembership Unmarshall(XmlUnmarshallerContext context) 
        {
            SecurityGroupMembership securityGroupMembership = new SecurityGroupMembership();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SecurityGroupId", targetDepth))
                    {
                        securityGroupMembership.SecurityGroupId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        securityGroupMembership.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return securityGroupMembership;
                }
            }
                        


            return securityGroupMembership;
        }

        public SecurityGroupMembership Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SecurityGroupMembershipUnmarshaller instance;

        public static SecurityGroupMembershipUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SecurityGroupMembershipUnmarshaller();

            return instance;
        }
    }
}
    
