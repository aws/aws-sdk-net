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
     ///   CacheNode Unmarshaller
     /// </summary>
    internal class CacheNodeUnmarshaller : IUnmarshaller<CacheNode, XmlUnmarshallerContext>, IUnmarshaller<CacheNode, JsonUnmarshallerContext> 
    {
        public CacheNode Unmarshall(XmlUnmarshallerContext context) 
        {
            CacheNode cacheNode = new CacheNode();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CacheNodeId", targetDepth))
                    {
                        cacheNode.CacheNodeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheNodeStatus", targetDepth))
                    {
                        cacheNode.CacheNodeStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheNodeCreateTime", targetDepth))
                    {
                        cacheNode.CacheNodeCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        cacheNode.Endpoint = EndpointUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ParameterGroupStatus", targetDepth))
                    {
                        cacheNode.ParameterGroupStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SourceCacheNodeId", targetDepth))
                    {
                        cacheNode.SourceCacheNodeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheNode;
                }
            }
                        


            return cacheNode;
        }

        public CacheNode Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CacheNodeUnmarshaller instance;

        public static CacheNodeUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheNodeUnmarshaller();

            return instance;
        }
    }
}
    
