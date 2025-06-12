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
    /// Container for the parameters to the CreateDbCluster operation.
    /// Creates a new Timestream for InfluxDB cluster.
    /// </summary>
    public partial class CreateDbClusterRequest : AmazonTimestreamInfluxDBRequest
    {
        private int? _allocatedStorage;
        private string _bucket;
        private DbInstanceType _dbInstanceType;
        private string _dbParameterGroupIdentifier;
        private DbStorageType _dbStorageType;
        private ClusterDeploymentType _deploymentType;
        private FailoverMode _failoverMode;
        private LogDeliveryConfiguration _logDeliveryConfiguration;
        private string _name;
        private NetworkType _networkType;
        private string _organization;
        private string _password;
        private int? _port;
        private bool? _publiclyAccessible;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _username;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage to allocate for your DB storage type in GiB (gibibytes).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=15360)]
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
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the initial InfluxDB bucket. All InfluxDB data is stored in a bucket.
        /// A bucket combines the concept of a database and a retention period (the duration of
        /// time that each data point persists). A bucket belongs to an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// The Timestream for InfluxDB DB instance type to run InfluxDB on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DbParameterGroupIdentifier. 
        /// <para>
        /// The ID of the DB parameter group to assign to your DB cluster. DB parameter groups
        /// specify how the database is configured. For example, DB parameter groups can specify
        /// the limit for query concurrency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string DbParameterGroupIdentifier
        {
            get { return this._dbParameterGroupIdentifier; }
            set { this._dbParameterGroupIdentifier = value; }
        }

        // Check to see if DbParameterGroupIdentifier property is set
        internal bool IsSetDbParameterGroupIdentifier()
        {
            return this._dbParameterGroupIdentifier != null;
        }

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
        /// Specifies the type of cluster to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterDeploymentType DeploymentType
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
        /// Gets and sets the property FailoverMode. 
        /// <para>
        /// Specifies the behavior of failure recovery when the primary node of the cluster fails.
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
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// Configuration for sending InfluxDB engine logs to a specified S3 bucket.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that uniquely identifies the DB cluster when interacting with the Amazon
        /// Timestream for InfluxDB API and CLI commands. This name will also be a prefix included
        /// in the endpoint. DB cluster names must be unique per customer and per region.
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
        /// Specifies whether the network type of the Timestream for InfluxDB cluster is IPv4,
        /// which can communicate over IPv4 protocol only, or DUAL, which can communicate over
        /// both IPv4 and IPv6 protocols.
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
        /// Gets and sets the property Organization. 
        /// <para>
        /// The name of the initial organization for the initial admin user in InfluxDB. An InfluxDB
        /// organization is a workspace for a group of users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Organization
        {
            get { return this._organization; }
            set { this._organization = value; }
        }

        // Check to see if Organization property is set
        internal bool IsSetOrganization()
        {
            return this._organization != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password of the initial admin user created in InfluxDB. This password will allow
        /// you to access the InfluxDB UI to perform various administrative tasks and also use
        /// the InfluxDB CLI to create an operator token. These attributes will be stored in a
        /// secret created in Secrets Manager in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=8, Max=64)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

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
        /// Default: 8086
        /// </para>
        ///  
        /// <para>
        /// Constraints: The value can't be 2375-2376, 7788-7799, 8090, or 51678-51680
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
        /// Configures the Timestream for InfluxDB cluster with a public IP to facilitate access
        /// from outside the VPC.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the DB instance.
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
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the initial admin user created in InfluxDB. Must start with a letter
        /// and can't end with a hyphen or contain two consecutive hyphens. For example, my-user1.
        /// This username will allow you to access the InfluxDB UI to perform various administrative
        /// tasks and also use the InfluxDB CLI to create an operator token. These attributes
        /// will be stored in a secret created in Secrets Manager in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security group IDs to associate with the Timestream for InfluxDB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
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
        /// A list of VPC subnet IDs to associate with the DB cluster. Provide at least two VPC
        /// subnet IDs in different Availability Zones when deploying with a Multi-AZ standby.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
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