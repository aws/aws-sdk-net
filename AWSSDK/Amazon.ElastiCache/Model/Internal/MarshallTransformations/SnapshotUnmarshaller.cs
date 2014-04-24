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
     ///   Snapshot Unmarshaller
     /// </summary>
    internal class SnapshotUnmarshaller : IUnmarshaller<Snapshot, XmlUnmarshallerContext>, IUnmarshaller<Snapshot, JsonUnmarshallerContext> 
    {
        public Snapshot Unmarshall(XmlUnmarshallerContext context) 
        {
            Snapshot snapshot = new Snapshot();
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
                    if (context.TestExpression("SnapshotName", targetDepth))
                    {
                        snapshot.SnapshotName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheClusterId", targetDepth))
                    {
                        snapshot.CacheClusterId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SnapshotStatus", targetDepth))
                    {
                        snapshot.SnapshotStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SnapshotSource", targetDepth))
                    {
                        snapshot.SnapshotSource = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheNodeType", targetDepth))
                    {
                        snapshot.CacheNodeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        snapshot.Engine = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        snapshot.EngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NumCacheNodes", targetDepth))
                    {
                        snapshot.NumCacheNodes = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PreferredAvailabilityZone", targetDepth))
                    {
                        snapshot.PreferredAvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheClusterCreateTime", targetDepth))
                    {
                        snapshot.CacheClusterCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                    {
                        snapshot.PreferredMaintenanceWindow = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TopicArn", targetDepth))
                    {
                        snapshot.TopicArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Port", targetDepth))
                    {
                        snapshot.Port = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheParameterGroupName", targetDepth))
                    {
                        snapshot.CacheParameterGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheSubnetGroupName", targetDepth))
                    {
                        snapshot.CacheSubnetGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        snapshot.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                    {
                        snapshot.AutoMinorVersionUpgrade = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SnapshotRetentionLimit", targetDepth))
                    {
                        snapshot.SnapshotRetentionLimit = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SnapshotWindow", targetDepth))
                    {
                        snapshot.SnapshotWindow = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NodeSnapshots/NodeSnapshot", targetDepth))
                    {
                        snapshot.NodeSnapshots.Add(NodeSnapshotUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return snapshot;
                }
            }
                        


            return snapshot;
        }

        public Snapshot Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SnapshotUnmarshaller instance;

        public static SnapshotUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SnapshotUnmarshaller();

            return instance;
        }
    }
}
    
