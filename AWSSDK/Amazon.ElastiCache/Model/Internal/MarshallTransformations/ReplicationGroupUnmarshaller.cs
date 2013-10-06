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
     ///   ReplicationGroup Unmarshaller
     /// </summary>
    internal class ReplicationGroupUnmarshaller : IUnmarshaller<ReplicationGroup, XmlUnmarshallerContext>, IUnmarshaller<ReplicationGroup, JsonUnmarshallerContext> 
    {
        public ReplicationGroup Unmarshall(XmlUnmarshallerContext context) 
        {
            ReplicationGroup replicationGroup = new ReplicationGroup();
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
                    if (context.TestExpression("ReplicationGroupId", targetDepth))
                    {
                        replicationGroup.ReplicationGroupId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Description", targetDepth))
                    {
                        replicationGroup.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        replicationGroup.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PendingModifiedValues", targetDepth))
                    {
                        replicationGroup.PendingModifiedValues = ReplicationGroupPendingModifiedValuesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MemberClusters/ClusterId", targetDepth))
                    {
                        replicationGroup.MemberClusters.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("NodeGroups/NodeGroup", targetDepth))
                    {
                        replicationGroup.NodeGroups.Add(NodeGroupUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return replicationGroup;
                }
            }
                        


            return replicationGroup;
        }

        public ReplicationGroup Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ReplicationGroupUnmarshaller instance;

        public static ReplicationGroupUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ReplicationGroupUnmarshaller();

            return instance;
        }
    }
}
    
