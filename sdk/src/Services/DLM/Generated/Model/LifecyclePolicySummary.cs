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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
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
namespace Amazon.DLM.Model
{
    /// <summary>
    /// Summary information about a lifecycle policy.
    /// </summary>
    public partial class LifecyclePolicySummary
    {
        private bool? _defaultPolicy;
        private string _description;
        private string _policyId;
        private PolicyTypeValues _policyType;
        private GettablePolicyStateValues _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DefaultPolicy. 
        /// <para>
        ///  <b>[Default policies only]</b> The type of default policy. Values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VOLUME</c> - Default policy for EBS snapshots
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE</c> - Default policy for EBS-backed AMIs
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? DefaultPolicy
        {
            get { return this._defaultPolicy; }
            set { this._defaultPolicy = value; }
        }

        // Check to see if DefaultPolicy property is set
        internal bool IsSetDefaultPolicy()
        {
            return this._defaultPolicy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The identifier of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
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
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of policy. <c>EBS_SNAPSHOT_MANAGEMENT</c> indicates that the policy manages
        /// the lifecycle of Amazon EBS snapshots. <c>IMAGE_MANAGEMENT</c> indicates that the
        /// policy manages the lifecycle of EBS-backed AMIs. <c>EVENT_BASED_POLICY</c> indicates
        /// that the policy automates cross-account snapshot copies for snapshots that are shared
        /// with your account.
        /// </para>
        /// </summary>
        public PolicyTypeValues PolicyType
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
        /// Gets and sets the property State. 
        /// <para>
        /// The activation state of the lifecycle policy.
        /// </para>
        /// </summary>
        public GettablePolicyStateValues State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}