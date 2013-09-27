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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Cluster Unmarshaller
     /// </summary>
    internal class ClusterUnmarshaller : IUnmarshaller<Cluster, XmlUnmarshallerContext>, IUnmarshaller<Cluster, JsonUnmarshallerContext> 
    {
        public Cluster Unmarshall(XmlUnmarshallerContext context) 
        {
            Cluster cluster = new Cluster();
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
                    if (context.TestExpression("ClusterIdentifier", targetDepth))
                    {
                        cluster.ClusterIdentifier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NodeType", targetDepth))
                    {
                        cluster.NodeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ClusterStatus", targetDepth))
                    {
                        cluster.ClusterStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ModifyStatus", targetDepth))
                    {
                        cluster.ModifyStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MasterUsername", targetDepth))
                    {
                        cluster.MasterUsername = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DBName", targetDepth))
                    {
                        cluster.DBName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        cluster.Endpoint = EndpointUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ClusterCreateTime", targetDepth))
                    {
                        cluster.ClusterCreateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AutomatedSnapshotRetentionPeriod", targetDepth))
                    {
                        cluster.AutomatedSnapshotRetentionPeriod = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ClusterSecurityGroups/ClusterSecurityGroup", targetDepth))
                    {
                        cluster.ClusterSecurityGroups.Add(ClusterSecurityGroupMembershipUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("VpcSecurityGroups/VpcSecurityGroup", targetDepth))
                    {
                        cluster.VpcSecurityGroups.Add(VpcSecurityGroupMembershipUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("ClusterParameterGroups/ClusterParameterGroup", targetDepth))
                    {
                        cluster.ClusterParameterGroups.Add(ClusterParameterGroupStatusUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("ClusterSubnetGroupName", targetDepth))
                    {
                        cluster.ClusterSubnetGroupName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        cluster.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AvailabilityZone", targetDepth))
                    {
                        cluster.AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                    {
                        cluster.PreferredMaintenanceWindow = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PendingModifiedValues", targetDepth))
                    {
                        cluster.PendingModifiedValues = PendingModifiedValuesUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ClusterVersion", targetDepth))
                    {
                        cluster.ClusterVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AllowVersionUpgrade", targetDepth))
                    {
                        cluster.AllowVersionUpgrade = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("NumberOfNodes", targetDepth))
                    {
                        cluster.NumberOfNodes = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PubliclyAccessible", targetDepth))
                    {
                        cluster.PubliclyAccessible = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Encrypted", targetDepth))
                    {
                        cluster.Encrypted = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cluster;
                }
            }
                        


            return cluster;
        }

        public Cluster Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ClusterUnmarshaller instance;

        public static ClusterUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ClusterUnmarshaller();

            return instance;
        }
    }
}
    
