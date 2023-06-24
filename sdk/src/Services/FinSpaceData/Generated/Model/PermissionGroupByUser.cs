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
    /// The structure of a permission group associated with a user account.
    /// </summary>
    public partial class PermissionGroupByUser
    {
        private PermissionGroupMembershipStatus _membershipStatus;
        private string _name;
        private string _permissionGroupId;

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
        /// The unique identifier for the permission group.
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