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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains details for the version of a policy. Policies define what operations a team
    /// that define the permissions for team resources.
    /// 
    ///  
    /// <para>
    /// The protected operation for a service integration might require specific permissions.
    /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
    /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class PolicyVersionSummary
    {
        private string _arn;
        private DateTime? _creationTime;
        private bool? _isDefault;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _policyArn;
        private PolicyType _policyType;
        private PolicyStatus _status;
        private int? _versionId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1224)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Timestamp when the policy was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Determines if the specified policy is the default for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Timestamp when the policy was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the policy
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
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
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1224)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the policy. For example, if the policy is <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_groups_manage_attach-policy.html">attachable</a>
        /// or <a href="https://docs.aws.amazon.com/access_policies_managed-deprecated.html">deprecated</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID for the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId.HasValue; 
        }

    }
}