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

using Amazon.ElastiCache.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   NodeSnapshot Unmarshaller
     /// </summary>
    internal class NodeSnapshotUnmarshaller : IUnmarshaller<NodeSnapshot, XmlUnmarshallerContext>, IUnmarshaller<NodeSnapshot, JsonUnmarshallerContext> 
    {
        public NodeSnapshot Unmarshall(XmlUnmarshallerContext context) 
        {
            NodeSnapshot nodeSnapshot = new NodeSnapshot();
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
                    if (context.TestExpression("CacheNodeId", targetDepth))
                    {
                        nodeSnapshot.CacheNodeId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheSize", targetDepth))
                    {
                        nodeSnapshot.CacheSize = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CacheNodeCreateTime", targetDepth))
                    {
                        nodeSnapshot.CacheNodeCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SnapshotCreateTime", targetDepth))
                    {
                        nodeSnapshot.SnapshotCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return nodeSnapshot;
                }
            }
                        


            return nodeSnapshot;
        }

        public NodeSnapshot Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static NodeSnapshotUnmarshaller instance;

        public static NodeSnapshotUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new NodeSnapshotUnmarshaller();

            return instance;
        }
    }
}
    
