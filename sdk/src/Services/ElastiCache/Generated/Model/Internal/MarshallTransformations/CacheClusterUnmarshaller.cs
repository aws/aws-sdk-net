/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Response Unmarshaller for CacheCluster Object
    /// </summary>  
    public class CacheClusterUnmarshaller : IUnmarshaller<CacheCluster, XmlUnmarshallerContext>, IUnmarshaller<CacheCluster, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CacheCluster Unmarshall(XmlUnmarshallerContext context)
        {
            CacheCluster unmarshalledObject = new CacheCluster();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AtRestEncryptionEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AtRestEncryptionEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AuthTokenEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.AuthTokenEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AuthTokenLastModifiedDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.AuthTokenLastModifiedDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
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
                    if (context.TestExpression("CacheClusterStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheClusterStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheNodes/CacheNode", targetDepth))
                    {
                        var unmarshaller = CacheNodeUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.CacheNodes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CacheNodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheNodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheParameterGroup", targetDepth))
                    {
                        var unmarshaller = CacheParameterGroupStatusUnmarshaller.Instance;
                        unmarshalledObject.CacheParameterGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheSecurityGroups/CacheSecurityGroup", targetDepth))
                    {
                        var unmarshaller = CacheSecurityGroupMembershipUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.CacheSecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CacheSubnetGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheSubnetGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ClientDownloadLandingPage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientDownloadLandingPage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ConfigurationEndpoint", targetDepth))
                    {
                        var unmarshaller = EndpointUnmarshaller.Instance;
                        unmarshalledObject.ConfigurationEndpoint = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("IpDiscovery", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpDiscovery = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LogDeliveryConfigurations/LogDeliveryConfiguration", targetDepth))
                    {
                        var unmarshaller = LogDeliveryConfigurationUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LogDeliveryConfigurations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("NetworkType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NotificationConfiguration", targetDepth))
                    {
                        var unmarshaller = NotificationConfigurationUnmarshaller.Instance;
                        unmarshalledObject.NotificationConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NumCacheNodes", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.NumCacheNodes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PendingModifiedValues", targetDepth))
                    {
                        var unmarshaller = PendingModifiedValuesUnmarshaller.Instance;
                        unmarshalledObject.PendingModifiedValues = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("PreferredOutpostArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PreferredOutpostArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReplicationGroupId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReplicationGroupId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReplicationGroupLogDeliveryEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.ReplicationGroupLogDeliveryEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SecurityGroups/member", targetDepth))
                    {
                        var unmarshaller = SecurityGroupMembershipUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SnapshotRetentionLimit", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.SnapshotRetentionLimit = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SnapshotWindow", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotWindow = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TransitEncryptionEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.TransitEncryptionEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TransitEncryptionMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransitEncryptionMode = unmarshaller.Unmarshall(context);
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
        public CacheCluster Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static CacheClusterUnmarshaller _instance = new CacheClusterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CacheClusterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}