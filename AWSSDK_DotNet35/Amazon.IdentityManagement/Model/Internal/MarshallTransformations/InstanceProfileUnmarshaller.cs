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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   InstanceProfile Unmarshaller
     /// </summary>
    internal class InstanceProfileUnmarshaller : IUnmarshaller<InstanceProfile, XmlUnmarshallerContext>, IUnmarshaller<InstanceProfile, JsonUnmarshallerContext> 
    {
        public InstanceProfile Unmarshall(XmlUnmarshallerContext context) 
        {
            InstanceProfile instanceProfile = new InstanceProfile();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Path", targetDepth))
                    {
                        instanceProfile.Path = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("InstanceProfileName", targetDepth))
                    {
                        instanceProfile.InstanceProfileName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("InstanceProfileId", targetDepth))
                    {
                        instanceProfile.InstanceProfileId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Arn", targetDepth))
                    {
                        instanceProfile.Arn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CreateDate", targetDepth))
                    {
                        instanceProfile.CreateDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Roles/member", targetDepth))
                    {
                        instanceProfile.Roles.Add(RoleUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return instanceProfile;
                }
            }
                        


            return instanceProfile;
        }

        public InstanceProfile Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static InstanceProfileUnmarshaller instance;

        public static InstanceProfileUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new InstanceProfileUnmarshaller();

            return instance;
        }
    }
}
    
