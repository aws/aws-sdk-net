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
    /// Contains information about an IAM role, including all of the role's policies.
    /// </summary>
    public partial class AwsIamRoleDetails
    {
        private string _assumeRolePolicyDocument;
        private List<AwsIamAttachedManagedPolicy> _attachedManagedPolicies = AWSConfigs.InitializeCollections ? new List<AwsIamAttachedManagedPolicy>() : null;
        private string _createDate;
        private List<AwsIamInstanceProfile> _instanceProfileList = AWSConfigs.InitializeCollections ? new List<AwsIamInstanceProfile>() : null;
        private int? _maxSessionDuration;
        private string _path;
        private AwsIamPermissionsBoundary _permissionsBoundary;
        private string _roleId;
        private string _roleName;
        private List<AwsIamRolePolicy> _rolePolicyList = AWSConfigs.InitializeCollections ? new List<AwsIamRolePolicy>() : null;

        /// <summary>
        /// Gets and sets the property AssumeRolePolicyDocument. 
        /// <para>
        /// The trust policy that grants permission to assume the role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string AssumeRolePolicyDocument
        {
            get { return this._assumeRolePolicyDocument; }
            set { this._assumeRolePolicyDocument = value; }
        }

        // Check to see if AssumeRolePolicyDocument property is set
        internal bool IsSetAssumeRolePolicyDocument()
        {
            return this._assumeRolePolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property AttachedManagedPolicies. 
        /// <para>
        /// The list of the managed policies that are attached to the role.
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
        /// Indicates when the role was created.
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
        /// Gets and sets the property InstanceProfileList. 
        /// <para>
        /// The list of instance profiles that contain this role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamInstanceProfile> InstanceProfileList
        {
            get { return this._instanceProfileList; }
            set { this._instanceProfileList = value; }
        }

        // Check to see if InstanceProfileList property is set
        internal bool IsSetInstanceProfileList()
        {
            return this._instanceProfileList != null && (this._instanceProfileList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum session duration (in seconds) that you want to set for the specified role.
        /// </para>
        /// </summary>
        public int? MaxSessionDuration
        {
            get { return this._maxSessionDuration; }
            set { this._maxSessionDuration = value; }
        }

        // Check to see if MaxSessionDuration property is set
        internal bool IsSetMaxSessionDuration()
        {
            return this._maxSessionDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the role.
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
        /// Gets and sets the property RoleId. 
        /// <para>
        /// The stable and unique string identifying the role.
        /// </para>
        /// </summary>
        public string RoleId
        {
            get { return this._roleId; }
            set { this._roleId = value; }
        }

        // Check to see if RoleId property is set
        internal bool IsSetRoleId()
        {
            return this._roleId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The friendly name that identifies the role.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property RolePolicyList. 
        /// <para>
        /// The list of inline policies that are embedded in the role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsIamRolePolicy> RolePolicyList
        {
            get { return this._rolePolicyList; }
            set { this._rolePolicyList = value; }
        }

        // Check to see if RolePolicyList property is set
        internal bool IsSetRolePolicyList()
        {
            return this._rolePolicyList != null && (this._rolePolicyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}