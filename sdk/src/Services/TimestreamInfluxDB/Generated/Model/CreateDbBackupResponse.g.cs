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
    /// This is the response object from the CreateDbBackup operation.
    /// </summary>
    public partial class CreateDbBackupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The allocated storage of the resource at the time of backup, in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 15360)]
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClusterConfiguration. 
        /// <para>
        /// The cluster configuration of the resource at the time of backup.
        /// </para>
        /// </summary>
        public ClusterConfiguration ClusterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ClusterConfiguration property is set.
        /// </summary>
        internal bool IsSetClusterConfiguration() => this.ClusterConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the backup was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// The DB instance type of the resource at the time of backup.
        /// </para>
        /// </summary>
        public DbInstanceType DbInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceType property is set.
        /// </summary>
        internal bool IsSetDbInstanceType() => this.DbInstanceType != null;

        /// <summary>
        /// Gets and sets the property DbParameterGroupId. 
        /// <para>
        /// The identifier of the DB parameter group associated with the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string DbParameterGroupId { get; set; }

        /// <summary>
        /// Checks to see if the DbParameterGroupId property is set.
        /// </summary>
        internal bool IsSetDbParameterGroupId() => this.DbParameterGroupId != null;

        /// <summary>
        /// Gets and sets the property DbResourceId. 
        /// <para>
        /// The identifier of the DB resource that the backup was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string DbResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbResourceId property is set.
        /// </summary>
        internal bool IsSetDbResourceId() => this.DbResourceId != null;

        /// <summary>
        /// Gets and sets the property DbStorageType. 
        /// <para>
        /// The storage type of the resource at the time of backup.
        /// </para>
        /// </summary>
        public DbStorageType DbStorageType { get; set; }

        /// <summary>
        /// Checks to see if the DbStorageType property is set.
        /// </summary>
        internal bool IsSetDbStorageType() => this.DbStorageType != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the resource that the backup was created from.
        /// </para>
        /// </summary>
        public ResourceDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The engine type of the resource that the backup was created from.
        /// </para>
        /// </summary>
        public EngineType EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property ExpiresAfter. 
        /// <para>
        /// The date after which the backup will be automatically deleted.
        /// </para>
        /// </summary>
        public string ExpiresAfter { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAfter property is set.
        /// </summary>
        internal bool IsSetExpiresAfter() => this.ExpiresAfter != null;

        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        /// The failover mode of the resource at the time of backup.
        /// </para>
        /// </summary>
        public FailoverMode FailoverMode { get; set; }

        /// <summary>
        /// Checks to see if the FailoverMode property is set.
        /// </summary>
        internal bool IsSetFailoverMode() => this.FailoverMode != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Service-generated unique identifier of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InfluxAuthParametersSecretArn. 
        /// <para>
        /// The ARN of the Secrets Manager secret containing the InfluxDB auth parameters.
        /// </para>
        /// </summary>
        public string InfluxAuthParametersSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the InfluxAuthParametersSecretArn property is set.
        /// </summary>
        internal bool IsSetInfluxAuthParametersSecretArn() => this.InfluxAuthParametersSecretArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key ARN used for encryption of the resource at the time
        /// of backup.
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
        /// The log delivery configuration of the resource at the time of backup.
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
        /// The maintenance schedule of the resource at the time of backup.
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
        /// The customer-provided name of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the resource at the time of backup.
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
        /// The port number of the resource at the time of backup.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Indicates whether the resource was publicly accessible at the time of backup.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the backup.
        /// </para>
        /// </summary>
        public DbBackupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of backup.
        /// </para>
        /// </summary>
        public DbBackupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// The VPC security group IDs associated with the resource at the time of backup.
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
        /// The VPC subnet IDs associated with the resource at the time of backup.
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
