/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifySnapshotAttribute operation.
    /// Adds or removes permission settings for the specified snapshot. You may add or remove
    /// specified AWS account IDs from a snapshot's list of create volume permissions, but
    /// you cannot do both in a single API call. If you need to both add and remove account
    /// IDs for a snapshot, you must use multiple API calls.
    /// 
    ///  
    /// <para>
    /// For more information on modifying snapshot permissions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing
    /// Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Snapshots with AWS Marketplace product codes cannot be made public.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifySnapshotAttributeRequest : AmazonEC2Request
    {
        private SnapshotAttributeName _attribute;
        private CreateVolumePermissionModifications _createVolumePermission;
        private List<string> _groupNames = new List<string>();
        private string _operationType;
        private string _snapshotId;
        private List<string> _userIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifySnapshotAttributeRequest() { }

        /// <summary>
        /// Instantiates ModifySnapshotAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="snapshotId">The ID of the snapshot.</param>
        /// <param name="attribute">The snapshot attribute to modify.</param>
        /// <param name="operationType">The type of operation to perform to the attribute.</param>
        public ModifySnapshotAttributeRequest(string snapshotId, SnapshotAttributeName attribute, string operationType)
        {
            _snapshotId = snapshotId;
            _attribute = attribute;
            _operationType = operationType;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The snapshot attribute to modify.
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
        /// Gets and sets the property GroupNames. 
        /// <para>
        /// The group to modify for the snapshot.
        /// </para>
        /// </summary>
        public List<string> GroupNames
        {
            get { return this._groupNames; }
            set { this._groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this._groupNames != null && this._groupNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The type of operation to perform to the attribute.
        /// </para>
        /// </summary>
        public string OperationType
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
        /// </summary>
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && this._userIds.Count > 0; 
        }

    }
}