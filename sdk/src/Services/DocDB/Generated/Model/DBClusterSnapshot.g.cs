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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Detailed information about a cluster snapshot.
    /// </summary>
    public partial class DBClusterSnapshot
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// Provides the list of Amazon EC2 Availability Zones that instances in the cluster snapshot
        /// can be restored in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterCreateTime. 
        /// <para>
        /// Specifies the time when the cluster was created, in Universal Coordinated Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? ClusterCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the ClusterCreateTime property is set.
        /// </summary>
        internal bool IsSetClusterCreateTime() => this.ClusterCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// Specifies the cluster identifier of the cluster that this cluster snapshot was created
        /// from.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the cluster snapshot.
        /// </para>
        /// </summary>
        public string DBClusterSnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterSnapshotArn property is set.
        /// </summary>
        internal bool IsSetDBClusterSnapshotArn() => this.DBClusterSnapshotArn != null;

        /// <summary>
        /// Gets and sets the property DBClusterSnapshotIdentifier. 
        /// <para>
        /// Specifies the identifier for the cluster snapshot.
        /// </para>
        /// </summary>
        public string DBClusterSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterSnapshotIdentifier() => this.DBClusterSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Specifies the name of the database engine.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// Provides the version of the database engine for this cluster snapshot.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <c>StorageEncrypted</c> is <c>true</c>, the KMS key identifier for the encrypted
        /// cluster snapshot.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// Provides the master user name for the cluster snapshot.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// Specifies the percentage of the estimated data that has been transferred.
        /// </para>
        /// </summary>
        public int? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Specifies the port that the cluster was listening on at the time of the snapshot.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// Provides the time when the snapshot was taken, in UTC.
        /// </para>
        /// </summary>
        public DateTime? SnapshotCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreateTime property is set.
        /// </summary>
        internal bool IsSetSnapshotCreateTime() => this.SnapshotCreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// Provides the type of the cluster snapshot.
        /// </para>
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;

        /// <summary>
        /// Gets and sets the property SourceDBClusterSnapshotArn. 
        /// <para>
        /// If the cluster snapshot was copied from a source cluster snapshot, the ARN for the
        /// source cluster snapshot; otherwise, a null value.
        /// </para>
        /// </summary>
        public string SourceDBClusterSnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceDBClusterSnapshotArn property is set.
        /// </summary>
        internal bool IsSetSourceDBClusterSnapshotArn() => this.SourceDBClusterSnapshotArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of this cluster snapshot.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageEncrypted. 
        /// <para>
        /// Specifies whether the cluster snapshot is encrypted.
        /// </para>
        /// </summary>
        public bool? StorageEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncrypted property is set.
        /// </summary>
        internal bool IsSetStorageEncrypted() => this.StorageEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Storage type associated with your cluster snapshot
        /// </para>
        ///  
        /// <para>
        /// For information on storage types for Amazon DocumentDB clusters, see Cluster storage
        /// configurations in the <i>Amazon DocumentDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values for storage type - <c>standard | iopt1</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value is <c>standard </c> 
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides the virtual private cloud (VPC) ID that is associated with the cluster snapshot.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
