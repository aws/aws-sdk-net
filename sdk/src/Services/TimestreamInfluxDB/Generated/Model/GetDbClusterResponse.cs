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
    /// This is the response object from the GetDbCluster operation.
    /// </summary>
    public partial class GetDbClusterResponse : AmazonWebServiceResponse
    {
        private int? _allocatedStorage;
        private string _arn;
        private DbInstanceType _dbInstanceType;
        private string _dbParameterGroupIdentifier;
        private DbStorageType _dbStorageType;
        private ClusterDeploymentType _deploymentType;
        private string _endpoint;
        private FailoverMode _failoverMode;
        private string _id;
        private string _influxAuthParametersSecretArn;
        private LogDeliveryConfiguration _logDeliveryConfiguration;
        private string _name;
        private NetworkType _networkType;
        private int? _port;
        private bool? _publiclyAccessible;
        private string _readerEndpoint;
        private ClusterStatus _status;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage allocated for your DB storage type (in gibibytes).
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
        /// The Amazon Resource Name (ARN) of the DB cluster.
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
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// The Timestream for InfluxDB instance type that InfluxDB runs on.
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
        /// Gets and sets the property DbParameterGroupIdentifier. 
        /// <para>
        /// The ID of the DB parameter group assigned to your DB cluster.
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
        /// The Timestream for InfluxDB DB storage type that InfluxDB stores data on.
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
        /// Deployment type of the DB cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint used to connect to the Timestream for InfluxDB cluster for write and
        /// read operations.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property FailoverMode. 
        /// <para>
        /// The configured failover mode for the DB cluster.
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
        /// Service-generated unique identifier of the DB cluster to retrieve.
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
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret containing the initial
        /// InfluxDB authorization parameters. The secret value is a JSON formatted key-value
        /// pair holding InfluxDB authorization values: organization, bucket, username, and password.
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
        /// Gets and sets the property LogDeliveryConfiguration. 
        /// <para>
        /// Configuration for sending InfluxDB engine logs to send to specified S3 bucket.
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
        /// Customer-supplied name of the Timestream for InfluxDB cluster.
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
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which InfluxDB accepts connections.
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
        /// Indicates if the DB cluster has a public IP to facilitate access from outside the
        /// VPC.
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
        /// Gets and sets the property ReaderEndpoint. 
        /// <para>
        /// The endpoint used to connect to the Timestream for InfluxDB cluster for read-only
        /// operations.
        /// </para>
        /// </summary>
        public string ReaderEndpoint
        {
            get { return this._readerEndpoint; }
            set { this._readerEndpoint = value; }
        }

        // Check to see if ReaderEndpoint property is set
        internal bool IsSetReaderEndpoint()
        {
            return this._readerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of VPC security group IDs associated with the DB cluster.
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
        /// A list of VPC subnet IDs associated with the DB cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
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