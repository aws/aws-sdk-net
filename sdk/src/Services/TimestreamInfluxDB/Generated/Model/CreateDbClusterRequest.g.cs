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
    /// Container for the parameters to the CreateDbCluster operation. Creates a new Timestream
    /// for InfluxDB cluster.
    /// </summary>
    public partial class CreateDbClusterRequest : AmazonTimestreamInfluxDBRequest
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 15360)]
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket.
        /// A bucket combines the concept of a database and a retention period (the duration of
        /// time that each data point persists). A bucket belongs to an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property DbBackupConfigurations. 
        /// <para>
        /// A list of backup configurations to enable automated backups for the DB cluster.
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
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DbInstanceType DbInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceType property is set.
        /// </summary>
        internal bool IsSetDbInstanceType() => this.DbInstanceType != null;

        /// <summary>
        /// Gets and sets the property DbParameterGroupIdentifier. 
        /// <para>
        /// The ID of the DB parameter group to assign to your DB cluster. DB parameter groups
        /// specify how the database is configured. For example, DB parameter groups can specify
        /// the limit for query concurrency.
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
        /// The Timestream for InfluxDB DB storage type to read and write InfluxDB data.
        /// </para>
        ///  
        /// <para>
        /// You can choose between three different types of provisioned Influx IOPS Included storage
        /// according to your workload requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Influx I/O Included 3000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Influx I/O Included 12000 IOPS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Influx I/O Included 16000 IOPS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DbStorageType DbStorageType { get; set; }

        /// <summary>
        /// Checks to see if the DbStorageType property is set.
        /// </summary>
        internal bool IsSetDbStorageType() => this.DbStorageType != null;

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Specifies the type of cluster to create.
        /// </para>
        /// </summary>
        public ClusterDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        /// Specifies the behavior of failure recovery when the primary node of the cluster fails.
        /// </para>
        /// </summary>
        public FailoverMode FailoverMode { get; set; }

        /// <summary>
        /// Checks to see if the FailoverMode property is set.
        /// </summary>
        internal bool IsSetFailoverMode() => this.FailoverMode != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier to use for encryption of the DB cluster.
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
        /// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
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
        /// Specifies the maintenance schedule for the DB cluster, including the preferred maintenance
        /// window and timezone.
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
        /// The name that uniquely identifies the DB cluster when interacting with the Amazon
        /// Timestream for InfluxDB API and CLI commands. This name will also be a prefix included
        /// in the endpoint. DB cluster names must be unique per customer and per region.
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
        /// Gets and sets the property Organization. 
        /// <para>
        /// The name of the initial organization for the initial admin user in InfluxDB. An InfluxDB
        /// organization is a workspace for a group of users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password of the initial admin user created in InfluxDB. This password will allow
        /// you to access the InfluxDB UI to perform various administrative tasks and also use
        /// the InfluxDB CLI to create an operator token. These attributes will be stored in a
        /// secret created in Secrets Manager in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 8, Max = 64)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which InfluxDB accepts connections.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 1024-65535
        /// </para>
        ///  
        /// <para>
        /// Default: 8086 for InfluxDB v2, 8181 for InfluxDB v3
        /// </para>
        ///  
        /// <para>
        /// Constraints: The value can't be 2375-2376, 7788-7799, 8090, or 51678-51680
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
        /// Configures the Timestream for InfluxDB cluster with a public IP to facilitate access
        /// from outside the VPC.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the DB instance.
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
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the initial admin user created in InfluxDB. Must start with a letter
        /// and can't end with a hyphen or contain two consecutive hyphens. For example, my-user1.
        /// This username will allow you to access the InfluxDB UI to perform various administrative
        /// tasks and also use the InfluxDB CLI to create an operator token. These attributes
        /// will be stored in a secret created in Secrets Manager in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<string> VpcSecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroupIds() => this.VpcSecurityGroupIds != null && (this.VpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// A list of VPC subnet IDs to associate with the DB cluster. Provide at least two VPC
        /// subnet IDs in different Availability Zones when deploying with a Multi-AZ standby.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 6)]
        public List<string> VpcSubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSubnetIds property is set.
        /// </summary>
        internal bool IsSetVpcSubnetIds() => this.VpcSubnetIds != null && (this.VpcSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
