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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// The structure for a permission group.
    /// </summary>
    public partial class PermissionGroup
    {
        private List<string> _applicationPermissions = new List<string>();
        private long? _createTime;
        private string _description;
        private long? _lastModifiedTime;
        private PermissionGroupMembershipStatus _membershipStatus;
        private string _name;
        private string _permissionGroupId;

        /// <summary>
        /// Gets and sets the property ApplicationPermissions. 
        /// <para>
        /// Indicates the permissions that are granted to a specific group for accessing the FinSpace
        /// application.
        /// </para>
        ///  <important> 
        /// <para>
        /// When assigning application permissions, be aware that the permission <code>ManageUsersAndGroups</code>
        /// allows users to grant themselves or others access to any functionality in their FinSpace
        /// environment's application. It should only be granted to trusted users.
        /// </para>
        ///  </important> <ul> <li> 
        /// <para>
        ///  <code>CreateDataset</code> – Group members can create new datasets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ManageClusters</code> – Group members can manage Apache Spark clusters from
        /// FinSpace notebooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ManageUsersAndGroups</code> – Group members can manage users and permission
        /// groups. This is a privileged permission that allows users to grant themselves or others
        /// access to any functionality in the application. It should only be granted to trusted
        /// users.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ManageAttributeSets</code> – Group members can manage attribute sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ViewAuditData</code> – Group members can view audit data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccessNotebooks</code> – Group members will have access to FinSpace notebooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GetTemporaryCredentials</code> – Group members can get temporary API credentials.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> ApplicationPermissions
        {
            get { return this._applicationPermissions; }
            set { this._applicationPermissions = value; }
        }

        // Check to see if ApplicationPermissions property is set
        internal bool IsSetApplicationPermissions()
        {
            return this._applicationPermissions != null && this._applicationPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp at which the group was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. 
        /// </para>
        /// </summary>
        public long CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A brief description for the permission group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Describes the last time the permission group was updated. The value is determined
        /// as epoch time in milliseconds. 
        /// </para>
        /// </summary>
        public long LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MembershipStatus. 
        /// <para>
        /// Indicates the status of the user account within a permission group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ADDITION_IN_PROGRESS</code> – The user account is currently being added to
        /// the permission group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ADDITION_SUCCESS</code> – The user account is successfully added to the permission
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REMOVAL_IN_PROGRESS</code> – The user is currently being removed from the permission
        /// group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionGroupMembershipStatus MembershipStatus
        {
            get { return this._membershipStatus; }
            set { this._membershipStatus = value; }
        }

        // Check to see if MembershipStatus property is set
        internal bool IsSetMembershipStatus()
        {
            return this._membershipStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the permission group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property PermissionGroupId. 
        /// <para>
        ///  The unique identifier for the permission group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string PermissionGroupId
        {
            get { return this._permissionGroupId; }
            set { this._permissionGroupId = value; }
        }

        // Check to see if PermissionGroupId property is set
        internal bool IsSetPermissionGroupId()
        {
            return this._permissionGroupId != null;
        }

    }
}