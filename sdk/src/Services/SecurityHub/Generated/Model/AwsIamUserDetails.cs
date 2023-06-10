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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an IAM user.
    /// </summary>
    public partial class AwsIamUserDetails
    {
        private List<AwsIamAttachedManagedPolicy> _attachedManagedPolicies = new List<AwsIamAttachedManagedPolicy>();
        private string _createDate;
        private List<string> _groupList = new List<string>();
        private string _path;
        private AwsIamPermissionsBoundary _permissionsBoundary;
        private string _userId;
        private string _userName;
        private List<AwsIamUserPolicy> _userPolicyList = new List<AwsIamUserPolicy>();

        /// <summary>
        /// Gets and sets the property AttachedManagedPolicies. 
        /// <para>
        /// A list of the managed policies that are attached to the user.
        /// </para>
        /// </summary>
        public List<AwsIamAttachedManagedPolicy> AttachedManagedPolicies
        {
            get { return this._attachedManagedPolicies; }
            set { this._attachedManagedPolicies = value; }
        }

        // Check to see if AttachedManagedPolicies property is set
        internal bool IsSetAttachedManagedPolicies()
        {
            return this._attachedManagedPolicies != null && this._attachedManagedPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Indicates when the user was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate != null;
        }

        /// <summary>
        /// Gets and sets the property GroupList. 
        /// <para>
        /// A list of IAM groups that the user belongs to.
        /// </para>
        /// </summary>
        public List<string> GroupList
        {
            get { return this._groupList; }
            set { this._groupList = value; }
        }

        // Check to see if GroupList property is set
        internal bool IsSetGroupList()
        {
            return this._groupList != null && this._groupList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the user.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsBoundary. 
        /// <para>
        /// The permissions boundary for the user.
        /// </para>
        /// </summary>
        public AwsIamPermissionsBoundary PermissionsBoundary
        {
            get { return this._permissionsBoundary; }
            set { this._permissionsBoundary = value; }
        }

        // Check to see if PermissionsBoundary property is set
        internal bool IsSetPermissionsBoundary()
        {
            return this._permissionsBoundary != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier for the user.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

        /// <summary>
        /// Gets and sets the property UserPolicyList. 
        /// <para>
        /// The list of inline policies that are embedded in the user.
        /// </para>
        /// </summary>
        public List<AwsIamUserPolicy> UserPolicyList
        {
            get { return this._userPolicyList; }
            set { this._userPolicyList = value; }
        }

        // Check to see if UserPolicyList property is set
        internal bool IsSetUserPolicyList()
        {
            return this._userPolicyList != null && this._userPolicyList.Count > 0; 
        }

    }
}