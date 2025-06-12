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
    /// Information about a lifecycle policy.
    /// </summary>
    public partial class LifecyclePolicy
    {
        private DateTime? _dateCreated;
        private DateTime? _dateModified;
        private bool? _defaultPolicy;
        private string _description;
        private string _executionRoleArn;
        private string _policyArn;
        private PolicyDetails _policyDetails;
        private string _policyId;
        private GettablePolicyStateValues _state;
        private string _statusMessage;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The local date and time when the lifecycle policy was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateModified. 
        /// <para>
        /// The local date and time when the lifecycle policy was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateModified
        {
            get { return this._dateModified; }
            set { this._dateModified = value; }
        }

        // Check to see if DateModified property is set
        internal bool IsSetDateModified()
        {
            return this._dateModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultPolicy. 
        /// <para>
        /// Indicates whether the policy is a default lifecycle policy or a custom lifecycle policy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c> - the policy is a default policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> - the policy is a custom policy.
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to run the operations specified
        /// by the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property PolicyDetails. 
        /// <para>
        /// The configuration of the lifecycle policy
        /// </para>
        /// </summary>
        public PolicyDetails PolicyDetails
        {
            get { return this._policyDetails; }
            set { this._policyDetails = value; }
        }

        // Check to see if PolicyDetails property is set
        internal bool IsSetPolicyDetails()
        {
            return this._policyDetails != null;
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The description of the status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
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