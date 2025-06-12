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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about an IAM user.
    /// </summary>
    public partial class AwsIamUserDetails
    {
        private List<AwsIamAttachedManagedPolicy> _attachedManagedPolicies = AWSConfigs.InitializeCollections ? new List<AwsIamAttachedManagedPolicy>() : null;
        private string _createDate;
        private List<string> _groupList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _path;
        private AwsIamPermissionsBoundary _permissionsBoundary;
        private string _userId;
        private string _userName;
        private List<AwsIamUserPolicy> _userPolicyList = AWSConfigs.InitializeCollections ? new List<AwsIamUserPolicy>() : null;

        /// <summary>
        /// Gets and sets the property AttachedManagedPolicies. 
        /// <para>
        /// A list of the managed policies that are attached to the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamAttachedManagedPolicy> AttachedManagedPolicies
        {
            get { return this._attachedManagedPolicies; }
            set { this._attachedManagedPolicies = value; }
        }

        // Check to see if AttachedManagedPolicies property is set
        internal bool IsSetAttachedManagedPolicies()
        {
            return this._attachedManagedPolicies != null && (this._attachedManagedPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Indicates when the user was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroupList
        {
            get { return this._groupList; }
            set { this._groupList = value; }
        }

        // Check to see if GroupList property is set
        internal bool IsSetGroupList()
        {
            return this._groupList != null && (this._groupList.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamUserPolicy> UserPolicyList
        {
            get { return this._userPolicyList; }
            set { this._userPolicyList = value; }
        }

        // Check to see if UserPolicyList property is set
        internal bool IsSetUserPolicyList()
        {
            return this._userPolicyList != null && (this._userPolicyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}