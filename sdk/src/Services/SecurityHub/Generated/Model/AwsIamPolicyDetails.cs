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
    /// Represents an IAM permissions policy.
    /// </summary>
    public partial class AwsIamPolicyDetails
    {
        private int? _attachmentCount;
        private string _createDate;
        private string _defaultVersionId;
        private string _description;
        private bool? _isAttachable;
        private string _path;
        private int? _permissionsBoundaryUsageCount;
        private string _policyId;
        private string _policyName;
        private List<AwsIamPolicyVersion> _policyVersionList = new List<AwsIamPolicyVersion>();
        private string _updateDate;

        /// <summary>
        /// Gets and sets the property AttachmentCount. 
        /// <para>
        /// The number of users, groups, and roles that the policy is attached to.
        /// </para>
        /// </summary>
        public int AttachmentCount
        {
            get { return this._attachmentCount.GetValueOrDefault(); }
            set { this._attachmentCount = value; }
        }

        // Check to see if AttachmentCount property is set
        internal bool IsSetAttachmentCount()
        {
            return this._attachmentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// When the policy was created.
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
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The identifier of the default version of the policy.
        /// </para>
        /// </summary>
        public string DefaultVersionId
        {
            get { return this._defaultVersionId; }
            set { this._defaultVersionId = value; }
        }

        // Check to see if DefaultVersionId property is set
        internal bool IsSetDefaultVersionId()
        {
            return this._defaultVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the policy.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IsAttachable. 
        /// <para>
        /// Whether the policy can be attached to a user, group, or role.
        /// </para>
        /// </summary>
        public bool IsAttachable
        {
            get { return this._isAttachable.GetValueOrDefault(); }
            set { this._isAttachable = value; }
        }

        // Check to see if IsAttachable property is set
        internal bool IsSetIsAttachable()
        {
            return this._isAttachable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the policy.
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
        /// Gets and sets the property PermissionsBoundaryUsageCount. 
        /// <para>
        /// The number of users and roles that use the policy to set the permissions boundary.
        /// </para>
        /// </summary>
        public int PermissionsBoundaryUsageCount
        {
            get { return this._permissionsBoundaryUsageCount.GetValueOrDefault(); }
            set { this._permissionsBoundaryUsageCount = value; }
        }

        // Check to see if PermissionsBoundaryUsageCount property is set
        internal bool IsSetPermissionsBoundaryUsageCount()
        {
            return this._permissionsBoundaryUsageCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier of the policy.
        /// </para>
        /// </summary>
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyVersionList. 
        /// <para>
        /// List of versions of the policy.
        /// </para>
        /// </summary>
        public List<AwsIamPolicyVersion> PolicyVersionList
        {
            get { return this._policyVersionList; }
            set { this._policyVersionList = value; }
        }

        // Check to see if PolicyVersionList property is set
        internal bool IsSetPolicyVersionList()
        {
            return this._policyVersionList != null && this._policyVersionList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateDate. 
        /// <para>
        /// When the policy was most recently updated.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string UpdateDate
        {
            get { return this._updateDate; }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate != null;
        }

    }
}