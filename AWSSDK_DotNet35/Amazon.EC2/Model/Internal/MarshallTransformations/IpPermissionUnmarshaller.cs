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
     ///   IpPermission Unmarshaller
     /// </summary>
    internal class IpPermissionUnmarshaller : IUnmarshaller<IpPermission, XmlUnmarshallerContext>, IUnmarshaller<IpPermission, JsonUnmarshallerContext> 
    {
        public IpPermission Unmarshall(XmlUnmarshallerContext context) 
        {
            IpPermission ipPermission = new IpPermission();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ipProtocol", targetDepth))
                    {
                        ipPermission.IpProtocol = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("fromPort", targetDepth))
                    {
                        ipPermission.FromPort = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("toPort", targetDepth))
                    {
                        ipPermission.ToPort = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("groups/item", targetDepth))
                    {
                        ipPermission.UserIdGroupPairs.Add(UserIdGroupPairUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("ipRanges/item/cidrIp", targetDepth))
                    {
                        ipPermission.IpRanges.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return ipPermission;
                }
            }
                        


            return ipPermission;
        }

        public IpPermission Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static IpPermissionUnmarshaller instance;

        public static IpPermissionUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new IpPermissionUnmarshaller();

            return instance;
        }
    }
}
    
