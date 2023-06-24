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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DBInstance Object
    /// </summary>  
    public class DBInstanceUnmarshaller : IUnmarshaller<DBInstance, XmlUnmarshallerContext>, IUnmarshaller<DBInstance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBInstance Unmarshall(XmlUnmarshallerContext context)
        {
            DBInstance unmarshalledObject = new DBInstance();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ActivityStreamEngineNativeAuditFieldsIncluded", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.ActivityStreamEngineNativeAuditFieldsIncluded = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ActivityStreamKinesisStreamName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ActivityStreamKinesisStreamName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ActivityStreamKmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ActivityStreamKmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ActivityStreamMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ActivityStreamMode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ActivityStreamPolicyStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ActivityStreamPolicyStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ActivityStreamStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ActivityStreamStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AllocatedStorage", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.AllocatedStorage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AssociatedRoles/DBInstanceRole", targetDepth))
                    {
                        var unmarshaller = DBInstanceRoleUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AssociatedRoles.Add(item);
                        continue;
                    }
                    if (context.TestExpression("AutomaticRestartTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.AutomaticRestartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AutomationMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AutomationMode = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("AwsBackupRecoveryPointArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AwsBackupRecoveryPointArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BackupRetentionPeriod", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.BackupRetentionPeriod = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BackupTarget", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BackupTarget = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CACertificateIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CACertificateIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CertificateDetails", targetDepth))
                    {
                        var unmarshaller = CertificateDetailsUnmarshaller.Instance;
                        unmarshalledObject.CertificateDetails = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("CustomerOwnedIpEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.CustomerOwnedIpEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomIamInstanceProfile", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CustomIamInstanceProfile = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceAutomatedBackupsReplications/DBInstanceAutomatedBackupsReplication", targetDepth))
                    {
                        var unmarshaller = DBInstanceAutomatedBackupsReplicationUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.DBInstanceAutomatedBackupsReplications.Add(item);
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
                    if (context.TestExpression("DBInstanceStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceStatus = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("DBParameterGroups/DBParameterGroup", targetDepth))
                    {
                        var unmarshaller = DBParameterGroupStatusUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.DBParameterGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("DBSecurityGroups/DBSecurityGroup", targetDepth))
                    {
                        var unmarshaller = DBSecurityGroupMembershipUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.DBSecurityGroups.Add(item);
                        continue;
                    }
                    if (context.TestExpression("DBSubnetGroup", targetDepth))
                    {
                        var unmarshaller = DBSubnetGroupUnmarshaller.Instance;
                        unmarshalledObject.DBSubnetGroup = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBSystemId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBSystemId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DeletionProtection", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.DeletionProtection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DomainMemberships/DomainMembership", targetDepth))
                    {
                        var unmarshaller = DomainMembershipUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.DomainMemberships.Add(item);
                        continue;
                    }
                    if (context.TestExpression("EnabledCloudwatchLogsExports/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.EnabledCloudwatchLogsExports.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        var unmarshaller = EndpointUnmarshaller.Instance;
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
                        var unmarshaller = DateTimeUnmarshaller.Instance;
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
                        var unmarshaller = DateTimeUnmarshaller.Instance;
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
                        var unmarshaller = EndpointUnmarshaller.Instance;
                        unmarshalledObject.ListenerEndpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterUsername", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MasterUsername = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterUserSecret", targetDepth))
                    {
                        var unmarshaller = MasterUserSecretUnmarshaller.Instance;
                        unmarshalledObject.MasterUserSecret = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("MultiAZ", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.MultiAZ = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NcharCharacterSetName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NcharCharacterSetName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NetworkType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OptionGroupMemberships/OptionGroupMembership", targetDepth))
                    {
                        var unmarshaller = OptionGroupMembershipUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.OptionGroupMemberships.Add(item);
                        continue;
                    }
                    if (context.TestExpression("PendingModifiedValues", targetDepth))
                    {
                        var unmarshaller = PendingModifiedValuesUnmarshaller.Instance;
                        unmarshalledObject.PendingModifiedValues = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PerformanceInsightsEnabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.PerformanceInsightsEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PerformanceInsightsKMSKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PerformanceInsightsKMSKeyId = unmarshaller.Unmarshall(context);
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
                    if (context.TestExpression("ProcessorFeatures/ProcessorFeature", targetDepth))
                    {
                        var unmarshaller = ProcessorFeatureUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ProcessorFeatures.Add(item);
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
                    if (context.TestExpression("ReadReplicaDBClusterIdentifiers/ReadReplicaDBClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ReadReplicaDBClusterIdentifiers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ReadReplicaDBInstanceIdentifiers/ReadReplicaDBInstanceIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ReadReplicaDBInstanceIdentifiers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ReadReplicaSourceDBClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReadReplicaSourceDBClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReadReplicaSourceDBInstanceIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReadReplicaSourceDBInstanceIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReplicaMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReplicaMode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResumeFullAutomationModeTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.ResumeFullAutomationModeTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SecondaryAvailabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SecondaryAvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusInfos/DBInstanceStatusInfo", targetDepth))
                    {
                        var unmarshaller = DBInstanceStatusInfoUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.StatusInfos.Add(item);
                        continue;
                    }
                    if (context.TestExpression("StorageEncrypted", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.StorageEncrypted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageThroughput", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.StorageThroughput = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TagList/Tag", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TagList.Add(item);
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
                    if (context.TestExpression("VpcSecurityGroups/VpcSecurityGroupMembership", targetDepth))
                    {
                        var unmarshaller = VpcSecurityGroupMembershipUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.VpcSecurityGroups.Add(item);
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
        public DBInstance Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static DBInstanceUnmarshaller _instance = new DBInstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DBInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}