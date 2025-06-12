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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifySnapshotAttribute operation.
    /// Adds or removes permission settings for the specified snapshot. You may add or remove
    /// specified Amazon Web Services account IDs from a snapshot's list of create volume
    /// permissions, but you cannot do both in a single operation. If you need to both add
    /// and remove account IDs for a snapshot, you must use multiple operations. You can make
    /// up to 500 modifications to a snapshot in a single operation.
    /// 
    ///  
    /// <para>
    /// Encrypted snapshots and snapshots with Amazon Web Services Marketplace product codes
    /// cannot be made public. Snapshots encrypted with your default KMS key cannot be shared
    /// with other accounts.
    /// </para>
    ///  
    /// <para>
    /// For more information about modifying snapshot permissions, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-modifying-snapshot-permissions.html">Share
    /// a snapshot</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifySnapshotAttributeRequest : AmazonEC2Request
    {
        private SnapshotAttributeName _attribute;
        private CreateVolumePermissionModifications _createVolumePermission;
        private bool? _dryRun;
        private List<string> _groupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private OperationType _operationType;
        private string _snapshotId;
        private List<string> _userIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifySnapshotAttributeRequest() { }

        /// <summary>
        /// Instantiates ModifySnapshotAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="snapshotId">The ID of the snapshot.</param>
        /// <param name="attribute">The snapshot attribute to modify. Only volume creation permissions can be modified.</param>
        /// <param name="operationType">The type of operation to perform to the attribute.</param>
        public ModifySnapshotAttributeRequest(string snapshotId, SnapshotAttributeName attribute, OperationType operationType)
        {
            _snapshotId = snapshotId;
            _attribute = attribute;
            _operationType = operationType;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The snapshot attribute to modify. Only volume creation permissions can be modified.
        /// </para>
        /// </summary>
        public SnapshotAttributeName Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property CreateVolumePermission. 
        /// <para>
        /// A JSON representation of the snapshot attribute modification.
        /// </para>
        /// </summary>
        public CreateVolumePermissionModifications CreateVolumePermission
        {
            get { return this._createVolumePermission; }
            set { this._createVolumePermission = value; }
        }

        // Check to see if CreateVolumePermission property is set
        internal bool IsSetCreateVolumePermission()
        {
            return this._createVolumePermission != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupNames. 
        /// <para>
        /// The group to modify for the snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroupNames
        {
            get { return this._groupNames; }
            set { this._groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this._groupNames != null && (this._groupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of operation to perform to the attribute.
        /// </para>
        /// </summary>
        public OperationType OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The account ID to modify for the snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && (this._userIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}