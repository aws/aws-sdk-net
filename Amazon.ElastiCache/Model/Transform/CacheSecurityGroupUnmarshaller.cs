/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElastiCache.Model.Transform
{
     /// <summary>
     ///   CacheSecurityGroup Unmarshaller
     /// </summary>
    internal class CacheSecurityGroupUnmarshaller : IUnmarshaller<CacheSecurityGroup, UnmarshallerContext> 
    {
        public CacheSecurityGroup Unmarshall(UnmarshallerContext context) 
        {
            CacheSecurityGroup cacheSecurityGroup = new CacheSecurityGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            if (context.IsStartOfDocument) 
               targetDepth++;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("OwnerId", targetDepth))
                    {
                        cacheSecurityGroup.OwnerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheSecurityGroupName", targetDepth))
                    {
                        cacheSecurityGroup.CacheSecurityGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        cacheSecurityGroup.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("EC2SecurityGroups/EC2SecurityGroup", targetDepth))
                    {
                        cacheSecurityGroup.EC2SecurityGroups.Add(EC2SecurityGroupUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheSecurityGroup;
                }
            }

            return cacheSecurityGroup;
        }

        private static CacheSecurityGroupUnmarshaller instance;

        public static CacheSecurityGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheSecurityGroupUnmarshaller();

            return instance;
        }
    }
}
    
