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
    /// Response Unmarshaller for AwsRdsDbInstanceDetails Object
    /// </summary>  
    public class AwsRdsDbInstanceDetailsUnmarshaller : IUnmarshaller<AwsRdsDbInstanceDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsRdsDbInstanceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsRdsDbInstanceDetails IUnmarshaller<AwsRdsDbInstanceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsRdsDbInstanceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsRdsDbInstanceDetails unmarshalledObject = new AwsRdsDbInstanceDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AllocatedStorage", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.AllocatedStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AssociatedRoles", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbInstanceAssociatedRole, AwsRdsDbInstanceAssociatedRoleUnmarshaller>(AwsRdsDbInstanceAssociatedRoleUnmarshaller.Instance);
                    unmarshalledObject.AssociatedRoles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoMinorVersionUpgrade", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoMinorVersionUpgrade = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BackupRetentionPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BackupRetentionPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CACertificateIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CACertificateIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CharacterSetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CharacterSetName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CopyTagsToSnapshot", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTagsToSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DBClusterIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DBClusterIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DBInstanceClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DBInstanceClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DBInstanceIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DBInstanceIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbInstancePort", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DbInstancePort = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbInstanceStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbInstanceStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbiResourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbiResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DBName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DBName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbParameterGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbParameterGroup, AwsRdsDbParameterGroupUnmarshaller>(AwsRdsDbParameterGroupUnmarshaller.Instance);
                    unmarshalledObject.DbParameterGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DbSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbSubnetGroup", targetDepth))
                {
                    var unmarshaller = AwsRdsDbSubnetGroupUnmarshaller.Instance;
                    unmarshalledObject.DbSubnetGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeletionProtection", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeletionProtection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainMemberships", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbDomainMembership, AwsRdsDbDomainMembershipUnmarshaller>(AwsRdsDbDomainMembershipUnmarshaller.Instance);
                    unmarshalledObject.DomainMemberships = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnabledCloudWatchLogsExports", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EnabledCloudWatchLogsExports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = AwsRdsDbInstanceEndpointUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("EnhancedMonitoringResourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EnhancedMonitoringResourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IAMDatabaseAuthenticationEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IAMDatabaseAuthenticationEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceCreateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceCreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Iops", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Iops = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LatestRestorableTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LatestRestorableTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListenerEndpoint", targetDepth))
                {
                    var unmarshaller = AwsRdsDbInstanceEndpointUnmarshaller.Instance;
                    unmarshalledObject.ListenerEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MasterUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MasterUsername = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxAllocatedStorage", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxAllocatedStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MonitoringInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MonitoringRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiAz", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MultiAz = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OptionGroupMemberships", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbOptionGroupMembership, AwsRdsDbOptionGroupMembershipUnmarshaller>(AwsRdsDbOptionGroupMembershipUnmarshaller.Instance);
                    unmarshalledObject.OptionGroupMemberships = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PendingModifiedValues", targetDepth))
                {
                    var unmarshaller = AwsRdsDbPendingModifiedValuesUnmarshaller.Instance;
                    unmarshalledObject.PendingModifiedValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerformanceInsightsEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PerformanceInsightsEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerformanceInsightsKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PerformanceInsightsKmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PerformanceInsightsRetentionPeriod", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PerformanceInsightsRetentionPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredBackupWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredBackupWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreferredMaintenanceWindow", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreferredMaintenanceWindow = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessorFeatures", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbProcessorFeature, AwsRdsDbProcessorFeatureUnmarshaller>(AwsRdsDbProcessorFeatureUnmarshaller.Instance);
                    unmarshalledObject.ProcessorFeatures = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PromotionTier", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PromotionTier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PubliclyAccessible", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PubliclyAccessible = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadReplicaDBClusterIdentifiers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReadReplicaDBClusterIdentifiers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadReplicaDBInstanceIdentifiers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReadReplicaDBInstanceIdentifiers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadReplicaSourceDBInstanceIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReadReplicaSourceDBInstanceIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecondaryAvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecondaryAvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusInfos", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbStatusInfo, AwsRdsDbStatusInfoUnmarshaller>(AwsRdsDbStatusInfoUnmarshaller.Instance);
                    unmarshalledObject.StatusInfos = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageEncrypted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.StorageEncrypted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TdeCredentialArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TdeCredentialArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Timezone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsRdsDbInstanceVpcSecurityGroup, AwsRdsDbInstanceVpcSecurityGroupUnmarshaller>(AwsRdsDbInstanceVpcSecurityGroupUnmarshaller.Instance);
                    unmarshalledObject.VpcSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsRdsDbInstanceDetailsUnmarshaller _instance = new AwsRdsDbInstanceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsRdsDbInstanceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}