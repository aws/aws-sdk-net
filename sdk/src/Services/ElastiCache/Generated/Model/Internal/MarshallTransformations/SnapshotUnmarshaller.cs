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

/*
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Snapshot Object
    /// </summary>  
    public class SnapshotUnmarshaller : IUnmarshaller<Snapshot, XmlUnmarshallerContext>, IUnmarshaller<Snapshot, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Snapshot Unmarshall(XmlUnmarshallerContext context)
        {
            Snapshot unmarshalledObject = new Snapshot();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AutoMinorVersionUpgrade = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheClusterCreateTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.CacheClusterCreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheClusterId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheClusterId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheNodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheNodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheParameterGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheParameterGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheSubnetGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheSubnetGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NodeSnapshots/NodeSnapshot", targetDepth))
                    {
                        var unmarshaller = NodeSnapshotUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NodeSnapshots.Add(item);
                        continue;
                    }
                    if (context.TestExpression("NumCacheNodes", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.NumCacheNodes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PreferredAvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PreferredAvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotRetentionLimit", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.SnapshotRetentionLimit = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotSource", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotSource = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotWindow", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotWindow = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TopicArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TopicArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Snapshot Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static SnapshotUnmarshaller _instance = new SnapshotUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnapshotUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}