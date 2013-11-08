/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Adds or remove permission settings for the specified snapshot. </para>
    /// </summary>
    public partial class ModifySnapshotAttributeRequest : AmazonEC2Request
    {
        private string snapshotId;
        private SnapshotAttributeName attribute;
        private string operationType;
        private List<string> userIds = new List<string>();
        private List<string> groupNames = new List<string>();
        private CreateVolumePermissionModifications createVolumePermission;


        /// <summary>
        /// The ID of the EBS snapshot whose attributes are being modified.
        ///  
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }

        /// <summary>
        /// The name of the attribute being modified. Available attribute names: <c>createVolumePermission</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>productCodes, createVolumePermission</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public SnapshotAttributeName Attribute
        {
            get { return this.attribute; }
            set { this.attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this.attribute != null;
        }

        /// <summary>
        /// The operation to perform on the attribute. Available operation names: <c>add</c>, <c>remove</c>
        ///  
        /// </summary>
        public string OperationType
        {
            get { return this.operationType; }
            set { this.operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this.operationType != null;
        }

        /// <summary>
        /// The AWS user IDs to add to or remove from the list of users that have permission to create EBS volumes from the specified snapshot.
        /// Currently supports "all". <note> Only valid when the <c>createVolumePermission</c> attribute is being modified. </note>
        ///  
        /// </summary>
        public List<string> UserIds
        {
            get { return this.userIds; }
            set { this.userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this.userIds.Count > 0;
        }

        /// <summary>
        /// The AWS group names to add to or remove from the list of groups that have permission to create EBS volumes from the specified snapshot.
        /// Currently supports "all". <note> Only valid when the <c>createVolumePermission</c> attribute is being modified. </note>
        ///  
        /// </summary>
        public List<string> GroupNames
        {
            get { return this.groupNames; }
            set { this.groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this.groupNames.Count > 0;
        }
        public CreateVolumePermissionModifications CreateVolumePermission
        {
            get { return this.createVolumePermission; }
            set { this.createVolumePermission = value; }
        }

        // Check to see if CreateVolumePermission property is set
        internal bool IsSetCreateVolumePermission()
        {
            return this.createVolumePermission != null;
        }

    }
}
    
