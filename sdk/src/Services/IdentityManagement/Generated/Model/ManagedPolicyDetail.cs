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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a managed policy, including the policy's ARN, versions,
    /// and the number of principal entities (users, groups, and roles) that the policy is
    /// attached to.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>GetAccountAuthorizationDetails</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>Using IAM</i> guide. 
    /// </para>
    /// </summary>
    public partial class ManagedPolicyDetail
    {
        private string _arn;
        private int? _attachmentCount;
        private DateTime? _createDate;
        private string _defaultVersionId;
        private string _description;
        private bool? _isAttachable;
        private string _path;
        private string _policyId;
        private string _policyName;
        private List<PolicyVersion> _policyVersionList = new List<PolicyVersion>();
        private DateTime? _updateDate;

        /// <summary>
        /// Gets and sets the property Arn.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentCount. 
        /// <para>
        /// The number of principal entities (users, groups, and roles) that the policy is attached
        /// to.
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
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the policy was created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultVersionId. 
        /// <para>
        /// The identifier for the version of the policy that is set as the default (operative)
        /// version.
        /// </para>
        ///  
        /// <para>
        /// For more information about policy versions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for Managed Policies</a> in the <i>Using IAM</i> guide. 
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
        /// A friendly description of the policy.
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
        /// Specifies whether the policy can be attached to an IAM user, group, or role.
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
        ///  
        /// <para>
        /// For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide.
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
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The stable and unique string identifying the policy.
        /// </para>
        ///  
        /// <para>
        /// For more information about IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide.
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
        /// The friendly name (not ARN) identifying the policy.
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
        /// A list containing information about the versions of the policy.
        /// </para>
        /// </summary>
        public List<PolicyVersion> PolicyVersionList
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
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the policy was last updated.
        /// </para>
        ///  
        /// <para>
        /// When a policy has only one version, this field contains the date and time when the
        /// policy was created. When a policy has more than one version, this field contains the
        /// date and time when the most recent policy version was created.
        /// </para>
        /// </summary>
        public DateTime UpdateDate
        {
            get { return this._updateDate.GetValueOrDefault(); }
            set { this._updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this._updateDate.HasValue; 
        }

    }
}