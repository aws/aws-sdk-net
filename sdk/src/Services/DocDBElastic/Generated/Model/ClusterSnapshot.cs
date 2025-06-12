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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
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
namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// Returns information about a specific elastic cluster snapshot.
    /// </summary>
    public partial class ClusterSnapshot
    {
        private string _adminUserName;
        private string _clusterArn;
        private string _clusterCreationTime;
        private string _kmsKeyId;
        private string _snapshotArn;
        private string _snapshotCreationTime;
        private string _snapshotName;
        private SnapshotType _snapshotType;
        private Status _status;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdminUserName. 
        /// <para>
        /// The name of the elastic cluster administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdminUserName
        {
            get { return this._adminUserName; }
            set { this._adminUserName = value; }
        }

        // Check to see if AdminUserName property is set
        internal bool IsSetAdminUserName()
        {
            return this._adminUserName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The ARN identifier of the elastic cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterCreationTime. 
        /// <para>
        /// The time when the elastic cluster was created in Universal Coordinated Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterCreationTime
        {
            get { return this._clusterCreationTime; }
            set { this._clusterCreationTime = value; }
        }

        // Check to see if ClusterCreationTime property is set
        internal bool IsSetClusterCreationTime()
        {
            return this._clusterCreationTime != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key identifier is the Amazon Resource Name (ARN) for the KMS encryption key.
        /// If you are creating a cluster using the same Amazon account that owns this KMS encryption
        /// key, you can use the KMS key alias instead of the ARN as the KMS encryption key. If
        /// an encryption key is not specified here, Amazon DocumentDB uses the default encryption
        /// key that KMS creates for your account. Your account has a different default encryption
        /// key for each Amazon Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The ARN identifier of the elastic cluster snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCreationTime. 
        /// <para>
        /// The time when the elastic cluster snapshot was created in Universal Coordinated Time
        /// (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotCreationTime
        {
            get { return this._snapshotCreationTime; }
            set { this._snapshotCreationTime = value; }
        }

        // Check to see if SnapshotCreationTime property is set
        internal bool IsSetSnapshotCreationTime()
        {
            return this._snapshotCreationTime != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the elastic cluster snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of cluster snapshots to be returned. You can specify one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>automated</c> - Return all cluster snapshots that Amazon DocumentDB has automatically
        /// created for your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>manual</c> - Return all cluster snapshots that you have manually created for your
        /// Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SnapshotType SnapshotType
        {
            get { return this._snapshotType; }
            set { this._snapshotType = value; }
        }

        // Check to see if SnapshotType property is set
        internal bool IsSetSnapshotType()
        {
            return this._snapshotType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the elastic cluster snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The Amazon EC2 subnet IDs for the elastic cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// A list of EC2 VPC security groups to associate with the elastic cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}