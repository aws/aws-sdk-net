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
    /// Contains a summary of a DB instance belonging to a DB cluster.
    /// </summary>
    public partial class DbInstanceForClusterSummary
    {
        private int? _allocatedStorage;
        private string _arn;
        private DbInstanceType _dbInstanceType;
        private DbStorageType _dbStorageType;
        private DeploymentType _deploymentType;
        private string _endpoint;
        private string _id;
        private InstanceMode _instanceMode;
        private string _name;
        private NetworkType _networkType;
        private int? _port;
        private Status _status;

        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage allocated for your DB storage type in GiB (gibibytes).
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
        /// The Amazon Resource Name (ARN) of the DB instance.
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
        /// The Timestream for InfluxDB instance type to run InfluxDB on.
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
        /// Gets and sets the property DbStorageType. 
        /// <para>
        /// The storage type for your DB instance.
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
        /// Specifies the deployment type if applicable.
        /// </para>
        /// </summary>
        public DeploymentType DeploymentType
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
        /// The endpoint used to connect to InfluxDB. The default InfluxDB port is 8086.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The service-generated unique identifier of the DB instance.
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
        /// Gets and sets the property InstanceMode. 
        /// <para>
        /// Specifies the DB instance's role in the cluster.
        /// </para>
        /// </summary>
        public InstanceMode InstanceMode
        {
            get { return this._instanceMode; }
            set { this._instanceMode = value; }
        }

        // Check to see if InstanceMode property is set
        internal bool IsSetInstanceMode()
        {
            return this._instanceMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A service-generated name for the DB instance based on the customer-supplied name for
        /// the DB cluster.
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
        /// Specifies whether the network type of the Timestream for InfluxDB instance is IPv4,
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB instance.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}