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
     ///   CacheSubnetGroup Unmarshaller
     /// </summary>
    internal class CacheSubnetGroupUnmarshaller : IUnmarshaller<CacheSubnetGroup, XmlUnmarshallerContext>, IUnmarshaller<CacheSubnetGroup, JsonUnmarshallerContext> 
    {
        public CacheSubnetGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            CacheSubnetGroup cacheSubnetGroup = new CacheSubnetGroup();
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
                    if (context.TestExpression("CacheSubnetGroupName", targetDepth))
                    {
                        cacheSubnetGroup.CacheSubnetGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheSubnetGroupDescription", targetDepth))
                    {
                        cacheSubnetGroup.CacheSubnetGroupDescription = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        cacheSubnetGroup.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Subnets/Subnet", targetDepth))
                    {
                        cacheSubnetGroup.Subnets.Add(SubnetUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheSubnetGroup;
                }
            }
                        


            return cacheSubnetGroup;
        }

        public CacheSubnetGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CacheSubnetGroupUnmarshaller instance;

        public static CacheSubnetGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheSubnetGroupUnmarshaller();

            return instance;
        }
    }
}
    
