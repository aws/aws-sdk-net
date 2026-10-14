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
    /// Describes a summary of a Timestream for InfluxDB cluster.
    /// </summary>
    public partial class DbClusterSummary
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
        /// Gets and sets the property DbInstanceType. 
        /// <para>
        /// The Timestream for InfluxDB DB instance type that InfluxDB runs on.
        /// </para>
        /// </summary>
        public DbInstanceType DbInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceType property is set.
        /// </summary>
        internal bool IsSetDbInstanceType() => this.DbInstanceType != null;

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
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// Deployment type of the DB cluster
        /// </para>
        /// </summary>
        public ClusterDeploymentType DeploymentType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentType property is set.
        /// </summary>
        internal bool IsSetDeploymentType() => this.DeploymentType != null;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// Customer supplied name of the Timestream for InfluxDB cluster.
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
        /// Specifies whether the network type of the Timestream for InfluxDB Cluster is IPv4,
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
    }
}
