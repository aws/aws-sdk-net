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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
    /// Container for the parameters to the RestoreFromDbBackup operation.
    /// Restores a Timestream for InfluxDB resource from a backup. By default, a new resource
    /// is created. You can optionally restore to the same resource using the REPLACE_EXISTING
    /// restore mode.
    /// </summary>
    public partial class RestoreFromDbBackupRequest : AmazonTimestreamInfluxDBRequest
    {
        private List<DbBackupConfiguration> _dbBackupConfigurations = AWSConfigs.InitializeCollections ? new List<DbBackupConfiguration>() : null;
        private string _dbBackupId;
        private ResourceDeploymentType _deploymentType;
        private string _kmsKeyId;
        private LogDeliveryConfiguration _logDeliveryConfiguration;
        private MaintenanceSchedule _maintenanceSchedule;
        private string _name;
        private NetworkType _networkType;
        private int? _port;
        private bool? _publiclyAccessible;
        private RestoreMode _restoreMode;
        private DateTime? _restoreToTime;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DbBackupConfigurations. 
        /// <para>
        /// A list of backup configurations to apply to the restored resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<DbBackupConfiguration> DbBackupConfigurations
        {
            get { return this._dbBackupConfigurations; }
            set { this._dbBackupConfigurations = value; }
        }

        // Check to see if DbBackupConfigurations property is set
        internal bool IsSetDbBackupConfigurations()
        {
            return this._dbBackupConfigurations != null && (this._dbBackupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DbBackupId. 
        /// <para>
        /// The identifier of the backup to restore from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string DbBackupId
        {
            get { return this._dbBackupId; }
            set { this._dbBackupId = value; }
        }

        // Check to see if DbBackupId property is set
        internal bool IsSetDbBackupId()
        {
            return this._dbBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the deployment type of the restored resource. Valid values are SINGLE_AZ,
        /// WITH_MULTIAZ_STANDBY, and MULTI_NODE_READ_REPLICAS.
        /// </para>
        /// </summary>
        public ResourceDeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier to use for encryption of the restored resource.
        /// Can be a key ID, key ARN, alias name, or alias ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// Configuration for sending InfluxDB engine logs to the specified S3 bucket for the
        /// restored resource.
        /// </para>
        /// </summary>
        public LogDeliveryConfiguration LogDeliveryConfiguration
        {
            get { return this._logDeliveryConfiguration; }
            set { this._logDeliveryConfiguration = value; }
        }

        // Check to see if LogDeliveryConfiguration property is set
        internal bool IsSetLogDeliveryConfiguration()
        {
            return this._logDeliveryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceSchedule. 
        /// <para>
        /// The maintenance schedule for the restored resource.
        /// </para>
        /// </summary>
        public MaintenanceSchedule MaintenanceSchedule
        {
            get { return this._maintenanceSchedule; }
            set { this._maintenanceSchedule = value; }
        }

        // Check to see if MaintenanceSchedule property is set
        internal bool IsSetMaintenanceSchedule()
        {
            return this._maintenanceSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new resource to create from the restore. If restoring to an existing
        /// resource, the name must match the existing resource name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=40)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Specifies the network type of the restored resource. Valid values are IPV4 and DUAL.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the restored InfluxDB resource accepts connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=65535)]
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies whether the restored resource is publicly accessible.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreMode. 
        /// <para>
        /// Specifies whether to restore to a new resource or replace the existing resource. Valid
        /// values are NEW_RESOURCE (default) and REPLACE_EXISTING.
        /// </para>
        /// </summary>
        public RestoreMode RestoreMode
        {
            get { return this._restoreMode; }
            set { this._restoreMode = value; }
        }

        // Check to see if RestoreMode property is set
        internal bool IsSetRestoreMode()
        {
            return this._restoreMode != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreToTime. 
        /// <para>
        /// The point in time to restore to, for continuous backups. Must be within the backup's
        /// retention window.
        /// </para>
        /// </summary>
        public DateTime? RestoreToTime
        {
            get { return this._restoreToTime; }
            set { this._restoreToTime = value; }
        }

        // Check to see if RestoreToTime property is set
        internal bool IsSetRestoreToTime()
        {
            return this._restoreToTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the restored resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security group IDs for the restored resource. If not specified, the
        /// restored resource uses the same security groups as the backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// A list of VPC subnet IDs for the restored resource. If not specified, the restored
        /// resource uses the same subnets as the backup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public List<string> VpcSubnetIds
        {
            get { return this._vpcSubnetIds; }
            set { this._vpcSubnetIds = value; }
        }

        // Check to see if VpcSubnetIds property is set
        internal bool IsSetVpcSubnetIds()
        {
            return this._vpcSubnetIds != null && (this._vpcSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}