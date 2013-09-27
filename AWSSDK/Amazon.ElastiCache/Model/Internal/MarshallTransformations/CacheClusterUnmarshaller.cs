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
     ///   CacheCluster Unmarshaller
     /// </summary>
    internal class CacheClusterUnmarshaller : IUnmarshaller<CacheCluster, XmlUnmarshallerContext>, IUnmarshaller<CacheCluster, JsonUnmarshallerContext> 
    {
        public CacheCluster Unmarshall(XmlUnmarshallerContext context) 
        {
            CacheCluster cacheCluster = new CacheCluster();
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
                    if (context.TestExpression("CacheClusterId", targetDepth))
                    {
                        cacheCluster.CacheClusterId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ConfigurationEndpoint", targetDepth))
                    {
                        cacheCluster.ConfigurationEndpoint = EndpointUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ClientDownloadLandingPage", targetDepth))
                    {
                        cacheCluster.ClientDownloadLandingPage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheNodeType", targetDepth))
                    {
                        cacheCluster.CacheNodeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        cacheCluster.Engine = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        cacheCluster.EngineVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheClusterStatus", targetDepth))
                    {
                        cacheCluster.CacheClusterStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NumCacheNodes", targetDepth))
                    {
                        cacheCluster.NumCacheNodes = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PreferredAvailabilityZone", targetDepth))
                    {
                        cacheCluster.PreferredAvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheClusterCreateTime", targetDepth))
                    {
                        cacheCluster.CacheClusterCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                    {
                        cacheCluster.PreferredMaintenanceWindow = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PendingModifiedValues", targetDepth))
                    {
                        cacheCluster.PendingModifiedValues = PendingModifiedValuesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NotificationConfiguration", targetDepth))
                    {
                        cacheCluster.NotificationConfiguration = NotificationConfigurationUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheSecurityGroups/CacheSecurityGroup", targetDepth))
                    {
                        cacheCluster.CacheSecurityGroups.Add(CacheSecurityGroupMembershipUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheParameterGroup", targetDepth))
                    {
                        cacheCluster.CacheParameterGroup = CacheParameterGroupStatusUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheSubnetGroupName", targetDepth))
                    {
                        cacheCluster.CacheSubnetGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CacheNodes/CacheNode", targetDepth))
                    {
                        cacheCluster.CacheNodes.Add(CacheNodeUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                    {
                        cacheCluster.AutoMinorVersionUpgrade = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SecurityGroups/member", targetDepth))
                    {
                        cacheCluster.SecurityGroups.Add(SecurityGroupMembershipUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("ReplicationGroupId", targetDepth))
                    {
                        cacheCluster.ReplicationGroupId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cacheCluster;
                }
            }
                        


            return cacheCluster;
        }

        public CacheCluster Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CacheClusterUnmarshaller instance;

        public static CacheClusterUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CacheClusterUnmarshaller();

            return instance;
        }
    }
}
    
