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
    /// This is the response object from the DeleteDbBackup operation.
    /// </summary>
    public partial class DeleteDbBackupResponse : AmazonWebServiceResponse
    {
        private int? _allocatedStorage;
        private string _arn;
        private ClusterConfiguration _clusterConfiguration;
        private DateTime? _createdAt;
        private DbInstanceType _dbInstanceType;
        private string _dbParameterGroupId;
        private string _dbResourceId;
        private DbStorageType _dbStorageType;
        private ResourceDeploymentType _deploymentType;
        private EngineType _engineType;
        private string _expiresAfter;
        private FailoverMode _failoverMode;
        private string _id;
        private string _influxAuthParametersSecretArn;
        private string _kmsKeyId;
        private LogDeliveryConfiguration _logDeliveryConfiguration;
        private MaintenanceSchedule _maintenanceSchedule;
        private string _name;
        private NetworkType _networkType;
        private int? _port;
        private bool? _publiclyAccessible;
        private DbBackupStatus _status;
        private DbBackupType _type;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The allocated storage of the resource at the time of backup, in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=15360)]
        public int? AllocatedStorage
        {
            get { return this._allocatedStorage; }
            set { this._allocatedStorage = value; }
        }

        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this._allocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deleted backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterConfiguration. 
        /// <para>
        /// The cluster configuration of the resource at the time of backup.
        /// </para>
        /// </summary>
        public ClusterConfiguration ClusterConfiguration
        {
            get { return this._clusterConfiguration; }
            set { this._clusterConfiguration = value; }
        }

        // Check to see if ClusterConfiguration property is set
        internal bool IsSetClusterConfiguration()
        {
            return this._clusterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the backup was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// The DB instance type of the resource at the time of backup.
        /// </para>
        /// </summary>
        public DbInstanceType DbInstanceType
        {
            get { return this._dbInstanceType; }
            set { this._dbInstanceType = value; }
        }

        // Check to see if DbInstanceType property is set
        internal bool IsSetDbInstanceType()
        {
            return this._dbInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property DbParameterGroupId. 
        /// <para>
        /// The identifier of the DB parameter group associated with the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string DbParameterGroupId
        {
            get { return this._dbParameterGroupId; }
            set { this._dbParameterGroupId = value; }
        }

        // Check to see if DbParameterGroupId property is set
        internal bool IsSetDbParameterGroupId()
        {
            return this._dbParameterGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property DbResourceId. 
        /// <para>
        /// The identifier of the DB resource that the backup was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string DbResourceId
        {
            get { return this._dbResourceId; }
            set { this._dbResourceId = value; }
        }

        // Check to see if DbResourceId property is set
        internal bool IsSetDbResourceId()
        {
            return this._dbResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DbStorageType. 
        /// <para>
        /// The storage type of the resource at the time of backup.
        /// </para>
        /// </summary>
        public DbStorageType DbStorageType
        {
            get { return this._dbStorageType; }
            set { this._dbStorageType = value; }
        }

        // Check to see if DbStorageType property is set
        internal bool IsSetDbStorageType()
        {
            return this._dbStorageType != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the resource that the backup was created from.
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
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The engine type of the resource that the backup was created from.
        /// </para>
        /// </summary>
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAfter. 
        /// <para>
        /// The date after which the backup was set to be automatically deleted.
        /// </para>
        /// </summary>
        public string ExpiresAfter
        {
            get { return this._expiresAfter; }
            set { this._expiresAfter = value; }
        }

        // Check to see if ExpiresAfter property is set
        internal bool IsSetExpiresAfter()
        {
            return this._expiresAfter != null;
        }

        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        /// The failover mode of the resource at the time of backup.
        /// </para>
        /// </summary>
        public FailoverMode FailoverMode
        {
            get { return this._failoverMode; }
            set { this._failoverMode = value; }
        }

        // Check to see if FailoverMode property is set
        internal bool IsSetFailoverMode()
        {
            return this._failoverMode != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Service-generated unique identifier of the deleted backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InfluxAuthParametersSecretArn. 
        /// <para>
        /// The ARN of the Secrets Manager secret containing the InfluxDB auth parameters.
        /// </para>
        /// </summary>
        public string InfluxAuthParametersSecretArn
        {
            get { return this._influxAuthParametersSecretArn; }
            set { this._influxAuthParametersSecretArn = value; }
        }

        // Check to see if InfluxAuthParametersSecretArn property is set
        internal bool IsSetInfluxAuthParametersSecretArn()
        {
            return this._influxAuthParametersSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key ARN used for encryption of the resource at the time
        /// of backup.
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
        /// The log delivery configuration of the resource at the time of backup.
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
        /// The maintenance schedule of the resource at the time of backup.
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
        /// The customer-provided name of the deleted backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=40)]
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
        /// The network type of the resource at the time of backup.
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
        /// The port number of the resource at the time of backup.
        /// </para>
        /// </summary>
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
        /// Indicates whether the resource was publicly accessible at the time of backup.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the backup.
        /// </para>
        /// </summary>
        public DbBackupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of backup.
        /// </para>
        /// </summary>
        public DbBackupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// The VPC security group IDs associated with the resource at the time of backup.
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
        /// The VPC subnet IDs associated with the resource at the time of backup.
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