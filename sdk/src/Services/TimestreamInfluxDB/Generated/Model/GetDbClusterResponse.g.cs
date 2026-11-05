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
    /// This is the response object from the GetDbCluster operation.
    /// </summary>
    public partial class GetDbClusterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage allocated for your DB storage type (in gibibytes).
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
        /// The Amazon Resource Name (ARN) of the DB cluster.
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
        /// Configuration for node modes in the DbCluster.
        /// </para>
        ///  
        /// <para>
        /// Deprecated. Use deploymentConfiguration to view the cluster topology instead.
        /// </para>
        /// </summary>
        [Obsolete("Use deploymentConfiguration instead.")]
        public ClusterConfiguration ClusterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ClusterConfiguration property is set.
        /// </summary>
        internal bool IsSetClusterConfiguration() => this.ClusterConfiguration != null;

        /// <summary>
        /// Gets and sets the property DbBackupConfigurations. 
        /// <para>
        /// The backup configurations for the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DbBackupConfigurationOutput> DbBackupConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<DbBackupConfigurationOutput>() : null;

        /// <summary>
        /// Checks to see if the DbBackupConfigurations property is set.
        /// </summary>
        internal bool IsSetDbBackupConfigurations() => this.DbBackupConfigurations != null && (this.DbBackupConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// The Timestream for InfluxDB instance type that InfluxDB runs on.
        /// </para>
        /// </summary>
        public DbInstanceType DbInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceType property is set.
        /// </summary>
        internal bool IsSetDbInstanceType() => this.DbInstanceType != null;

        /// <summary>
        /// Gets and sets the property DbParameterGroupIdentifier. 
        /// <para>
        /// The ID of the DB parameter group assigned to your DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string DbParameterGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbParameterGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetDbParameterGroupIdentifier() => this.DbParameterGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbStorageType. 
        /// <para>
        /// The Timestream for InfluxDB DB storage type that InfluxDB stores data on.
        /// </para>
        /// </summary>
        public DbStorageType DbStorageType { get; set; }

        /// <summary>
        /// Checks to see if the DbStorageType property is set.
        /// </summary>
        internal bool IsSetDbStorageType() => this.DbStorageType != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// The current compute topology of the cluster, as a set of node groups. The returned
        /// topology reflects the cluster's actual provisioned nodes.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Deployment type of the DB cluster.
        /// </para>
        /// </summary>
        public ClusterDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property EffectiveDbParameterGroupIdentifier. 
        /// <para>
        /// The ID of the DB parameter group actually applied to your DB cluster. When the service
        /// applies optimized defaults, it creates a service-managed DB parameter group and this
        /// field reflects that group, while dbParameterGroupIdentifier reflects the customer-provided
        /// DB parameter group. When no service-managed DB parameter group is applied, this value
        /// matches dbParameterGroupIdentifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string EffectiveDbParameterGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDbParameterGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetEffectiveDbParameterGroupIdentifier() => this.EffectiveDbParameterGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint used to connect to the Timestream for InfluxDB cluster for write and
        /// read operations.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The engine type of your DB cluster.
        /// </para>
        /// </summary>
        public EngineType EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        /// The configured failover mode for the DB cluster.
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
        /// Service-generated unique identifier of the DB cluster to retrieve.
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
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret containing the initial
        /// InfluxDB authorization parameters. The secret value is a JSON formatted key-value
        /// pair holding InfluxDB authorization values: organization, bucket, username, and password.
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
        /// The Amazon Web Services KMS key ARN used for encryption of the DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastMaintenanceTime. 
        /// <para>
        /// The timestamp of the last completed maintenance operation on the DB cluster.
        /// </para>
        /// </summary>
        public DateTime? LastMaintenanceTime { get; set; }

        /// <summary>
        /// Checks to see if the LastMaintenanceTime property is set.
        /// </summary>
        internal bool IsSetLastMaintenanceTime() => this.LastMaintenanceTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// Configuration for sending InfluxDB engine logs to send to specified S3 bucket.
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
        /// The maintenance schedule for the DB cluster.
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
        /// Customer-supplied name of the Timestream for InfluxDB cluster.
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
        /// Specifies whether the network type of the Timestream for InfluxDB cluster is IPv4,
        /// which can communicate over IPv4 protocol only, or DUAL, which can communicate over
        /// both IPv4 and IPv6 protocols.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property NextMaintenanceTime. 
        /// <para>
        /// The timestamp of the next scheduled maintenance operation on the DB cluster.
        /// </para>
        /// </summary>
        public DateTime? NextMaintenanceTime { get; set; }

        /// <summary>
        /// Checks to see if the NextMaintenanceTime property is set.
        /// </summary>
        internal bool IsSetNextMaintenanceTime() => this.NextMaintenanceTime.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which InfluxDB accepts connections.
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
        /// Indicates if the DB cluster has a public IP to facilitate access from outside the
        /// VPC.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property ReaderEndpoint. 
        /// <para>
        /// The endpoint used to connect to the Timestream for InfluxDB cluster for read-only
        /// operations.
        /// </para>
        /// </summary>
        public string ReaderEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ReaderEndpoint property is set.
        /// </summary>
        internal bool IsSetReaderEndpoint() => this.ReaderEndpoint != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security group IDs associated with the DB cluster.
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
        /// A list of VPC subnet IDs associated with the DB cluster.
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
