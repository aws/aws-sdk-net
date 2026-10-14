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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreFromDbBackup operation. Restores a Timestream
    /// for InfluxDB resource from a backup. By default, a new resource is created. You can
    /// optionally restore to the same resource using the REPLACE_EXISTING restore mode.
    /// </summary>
    public partial class RestoreFromDbBackupRequest : AmazonTimestreamInfluxDBRequest
    {
        /// <summary>
        /// Gets and sets the property DbBackupConfigurations. 
        /// <para>
        /// A list of backup configurations to apply to the restored resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<DbBackupConfiguration> DbBackupConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<DbBackupConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DbBackupConfigurations property is set.
        /// </summary>
        internal bool IsSetDbBackupConfigurations() => this.DbBackupConfigurations != null && (this.DbBackupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DbBackupId. 
        /// <para>
        /// The identifier of the backup to restore from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string DbBackupId { get; set; }

        /// <summary>
        /// Checks to see if the DbBackupId property is set.
        /// </summary>
        internal bool IsSetDbBackupId() => this.DbBackupId != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the deployment type of the restored resource. Valid values are SINGLE_AZ,
        /// WITH_MULTIAZ_STANDBY, and MULTI_NODE_READ_REPLICAS.
        /// </para>
        /// </summary>
        public ResourceDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier to use for encryption of the restored resource.
        /// Can be a key ID, key ARN, alias name, or alias ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// Configuration for sending InfluxDB engine logs to the specified S3 bucket for the
        /// restored resource.
        /// </para>
        /// </summary>
        public LogDeliveryConfiguration LogDeliveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogDeliveryConfiguration property is set.
        /// </summary>
        internal bool IsSetLogDeliveryConfiguration() => this.LogDeliveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaintenanceSchedule. 
        /// <para>
        /// The maintenance schedule for the restored resource.
        /// </para>
        /// </summary>
        public MaintenanceSchedule MaintenanceSchedule { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceSchedule property is set.
        /// </summary>
        internal bool IsSetMaintenanceSchedule() => this.MaintenanceSchedule != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new resource to create from the restore. If restoring to an existing
        /// resource, the name must match the existing resource name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 40)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Specifies the network type of the restored resource. Valid values are IPV4 and DUAL.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the restored InfluxDB resource accepts connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the restored resource is publicly accessible.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property RestoreMode. 
        /// <para>
        /// Specifies whether to restore to a new resource or replace the existing resource. Valid
        /// values are NEW_RESOURCE (default) and REPLACE_EXISTING.
        /// </para>
        /// </summary>
        public RestoreMode RestoreMode { get; set; }

        /// <summary>
        /// Checks to see if the RestoreMode property is set.
        /// </summary>
        internal bool IsSetRestoreMode() => this.RestoreMode != null;

        /// <summary>
        /// Gets and sets the property RestoreToTime. 
        /// <para>
        /// The point in time to restore to, for continuous backups. Must be within the backup's
        /// retention window.
        /// </para>
        /// </summary>
        public DateTime? RestoreToTime { get; set; }

        /// <summary>
        /// Checks to see if the RestoreToTime property is set.
        /// </summary>
        internal bool IsSetRestoreToTime() => this.RestoreToTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the restored resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security group IDs for the restored resource. If not specified, the
        /// restored resource uses the same security groups as the backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> VpcSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupIds() => this.VpcSecurityGroupIds != null && (this.VpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// A list of VPC subnet IDs for the restored resource. If not specified, the restored
        /// resource uses the same subnets as the backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public List<string> VpcSubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSubnetIds property is set.
        /// </summary>
        internal bool IsSetVpcSubnetIds() => this.VpcSubnetIds != null && (this.VpcSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
