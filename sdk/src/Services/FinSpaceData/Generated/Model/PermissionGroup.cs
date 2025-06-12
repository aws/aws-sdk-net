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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// The structure for a permission group.
    /// </summary>
    public partial class PermissionGroup
    {
        private List<string> _applicationPermissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// When assigning application permissions, be aware that the permission <c>ManageUsersAndGroups</c>
        /// allows users to grant themselves or others access to any functionality in their FinSpace
        /// environment's application. It should only be granted to trusted users.
        /// </para>
        ///  </important> <ul> <li> 
        /// <para>
        ///  <c>CreateDataset</c> – Group members can create new datasets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ManageClusters</c> – Group members can manage Apache Spark clusters from FinSpace
        /// notebooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ManageUsersAndGroups</c> – Group members can manage users and permission groups.
        /// This is a privileged permission that allows users to grant themselves or others access
        /// to any functionality in the application. It should only be granted to trusted users.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ManageAttributeSets</c> – Group members can manage attribute sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ViewAuditData</c> – Group members can view audit data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessNotebooks</c> – Group members will have access to FinSpace notebooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GetTemporaryCredentials</c> – Group members can get temporary API credentials.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplicationPermissions
        {
            get { return this._applicationPermissions; }
            set { this._applicationPermissions = value; }
        }

        // Check to see if ApplicationPermissions property is set
        internal bool IsSetApplicationPermissions()
        {
            return this._applicationPermissions != null && (this._applicationPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp at which the group was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. 
        /// </para>
        /// </summary>
        public long? CreateTime
        {
            get { return this._createTime; }
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
        public long? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
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
        /// Indicates the status of the user within a permission group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ADDITION_IN_PROGRESS</c> – The user is currently being added to the permission
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADDITION_SUCCESS</c> – The user is successfully added to the permission group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVAL_IN_PROGRESS</c> – The user is currently being removed from the permission
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