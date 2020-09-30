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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsRedshiftClusterDetails Object
    /// </summary>  
    public class AwsRedshiftClusterDetailsUnmarshaller : IUnmarshaller<AwsRedshiftClusterDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsRedshiftClusterDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsRedshiftClusterDetails IUnmarshaller<AwsRedshiftClusterDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsRedshiftClusterDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsRedshiftClusterDetails unmarshalledObject = new AwsRedshiftClusterDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllowVersionUpgrade", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllowVersionUpgrade = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutomatedSnapshotRetentionPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AutomatedSnapshotRetentionPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterAvailabilityStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterAvailabilityStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterCreateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterCreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterNodes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRedshiftClusterClusterNode, AwsRedshiftClusterClusterNodeUnmarshaller>(AwsRedshiftClusterClusterNodeUnmarshaller.Instance);
                    unmarshalledObject.ClusterNodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterParameterGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRedshiftClusterClusterParameterGroup, AwsRedshiftClusterClusterParameterGroupUnmarshaller>(AwsRedshiftClusterClusterParameterGroupUnmarshaller.Instance);
                    unmarshalledObject.ClusterParameterGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterPublicKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterPublicKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterRevisionNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterRevisionNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRedshiftClusterClusterSecurityGroup, AwsRedshiftClusterClusterSecurityGroupUnmarshaller>(AwsRedshiftClusterClusterSecurityGroupUnmarshaller.Instance);
                    unmarshalledObject.ClusterSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterSnapshotCopyStatus", targetDepth))
                {
                    var unmarshaller = AwsRedshiftClusterClusterSnapshotCopyStatusUnmarshaller.Instance;
                    unmarshalledObject.ClusterSnapshotCopyStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterSubnetGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterSubnetGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DBName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DBName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeferredMaintenanceWindows", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRedshiftClusterDeferredMaintenanceWindow, AwsRedshiftClusterDeferredMaintenanceWindowUnmarshaller>(AwsRedshiftClusterDeferredMaintenanceWindowUnmarshaller.Instance);
                    unmarshalledObject.DeferredMaintenanceWindows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElasticIpStatus", targetDepth))
                {
                    var unmarshaller = AwsRedshiftClusterElasticIpStatusUnmarshaller.Instance;
                    unmarshalledObject.ElasticIpStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElasticResizeNumberOfNodeOptions", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElasticResizeNumberOfNodeOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Encrypted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Encrypted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = AwsRedshiftClusterEndpointUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnhancedVpcRouting", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnhancedVpcRouting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedNextSnapshotScheduleTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpectedNextSnapshotScheduleTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedNextSnapshotScheduleTimeStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpectedNextSnapshotScheduleTimeStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HsmStatus", targetDepth))
                {
                    var unmarshaller = AwsRedshiftClusterHsmStatusUnmarshaller.Instance;
                    unmarshalledObject.HsmStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IamRoles", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRedshiftClusterIamRole, AwsRedshiftClusterIamRoleUnmarshaller>(AwsRedshiftClusterIamRoleUnmarshaller.Instance);
                    unmarshalledObject.IamRoles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaintenanceTrackName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaintenanceTrackName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManualSnapshotRetentionPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ManualSnapshotRetentionPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MasterUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterUsername = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NextMaintenanceWindowStartTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NextMaintenanceWindowStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NodeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NodeType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfNodes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfNodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PendingActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PendingActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PendingModifiedValues", targetDepth))
                {
                    var unmarshaller = AwsRedshiftClusterPendingModifiedValuesUnmarshaller.Instance;
                    unmarshalledObject.PendingModifiedValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PubliclyAccessible", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PubliclyAccessible = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResizeInfo", targetDepth))
                {
                    var unmarshaller = AwsRedshiftClusterResizeInfoUnmarshaller.Instance;
                    unmarshalledObject.ResizeInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RestoreStatus", targetDepth))
                {
                    var unmarshaller = AwsRedshiftClusterRestoreStatusUnmarshaller.Instance;
                    unmarshalledObject.RestoreStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotScheduleIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotScheduleIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotScheduleState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotScheduleState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRedshiftClusterVpcSecurityGroup, AwsRedshiftClusterVpcSecurityGroupUnmarshaller>(AwsRedshiftClusterVpcSecurityGroupUnmarshaller.Instance);
                    unmarshalledObject.VpcSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsRedshiftClusterDetailsUnmarshaller _instance = new AwsRedshiftClusterDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsRedshiftClusterDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}