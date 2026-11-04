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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes cluster attributes that are in a pending state. A change to one or more
    /// the attributes was requested and is in progress or will be applied.
    /// </summary>
    public partial class PendingModifiedValues
    {
        /// <summary>
        /// Gets and sets the property AutomatedSnapshotRetentionPeriod. 
        /// <para>
        /// The pending or in-progress change of the automated snapshot retention period.
        /// </para>
        /// </summary>
        public int? AutomatedSnapshotRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the AutomatedSnapshotRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetAutomatedSnapshotRetentionPeriod() => this.AutomatedSnapshotRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The pending or in-progress change of the new identifier for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The pending or in-progress change of the cluster type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterType property is set.
        /// </summary>
        internal bool IsSetClusterType() => this.ClusterType != null;

        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        /// The pending or in-progress change of the service version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// Checks to see if the ClusterVersion property is set.
        /// </summary>
        internal bool IsSetClusterVersion() => this.ClusterVersion != null;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type for a cluster. Possible values are: KMS and None. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// An option that specifies whether to create the cluster with enhanced VPC routing enabled.
        /// To create a cluster that uses enhanced VPC routing, the cluster must be in a VPC.
        /// For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/enhanced-vpc-routing.html">Enhanced
        /// VPC Routing</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        ///  
        /// <para>
        /// If this option is <c>true</c>, enhanced VPC routing is enabled. 
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? EnhancedVpcRouting { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedVpcRouting property is set.
        /// </summary>
        internal bool IsSetEnhancedVpcRouting() => this.EnhancedVpcRouting.HasValue;

        /// <summary>
        /// Gets and sets the property MaintenanceTrackName. 
        /// <para>
        /// The name of the maintenance track that the cluster will change to during the next
        /// maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string MaintenanceTrackName { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceTrackName property is set.
        /// </summary>
        internal bool IsSetMaintenanceTrackName() => this.MaintenanceTrackName != null;

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The pending or in-progress change of the admin user password for the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string MasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserPassword property is set.
        /// </summary>
        internal bool IsSetMasterUserPassword() => this.MasterUserPassword != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The pending or in-progress change of the cluster's node type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The pending or in-progress change of the number of nodes in the cluster.
        /// </para>
        /// </summary>
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// The pending or in-progress change of the ability to connect to the cluster from the
        /// public network.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;
    }
}
