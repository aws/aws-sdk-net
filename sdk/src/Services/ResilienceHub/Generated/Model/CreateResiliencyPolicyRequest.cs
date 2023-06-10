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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResiliencyPolicy operation.
    /// Creates a resiliency policy for an application.
    /// </summary>
    public partial class CreateResiliencyPolicyRequest : AmazonResilienceHubRequest
    {
        private string _clientToken;
        private DataLocationConstraint _dataLocationConstraint;
        private Dictionary<string, FailurePolicy> _policy = new Dictionary<string, FailurePolicy>();
        private string _policyDescription;
        private string _policyName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private ResiliencyPolicyTier _tier;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Used for an idempotency token. A client token is a unique, case-sensitive string of
        /// up to 64 ASCII characters. You should not reuse the same client token for other API
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataLocationConstraint. 
        /// <para>
        /// Specifies a high-level geographical location constraint for where your resilience
        /// policy data can be stored.
        /// </para>
        /// </summary>
        public DataLocationConstraint DataLocationConstraint
        {
            get { return this._dataLocationConstraint; }
            set { this._dataLocationConstraint = value; }
        }

        // Check to see if DataLocationConstraint property is set
        internal bool IsSetDataLocationConstraint()
        {
            return this._dataLocationConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The type of resiliency policy to be created, including the recovery time objective
        /// (RTO) and recovery point objective (RPO) in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, FailurePolicy> Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null && this._policy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyDescription. 
        /// <para>
        /// The description for the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string PolicyDescription
        {
            get { return this._policyDescription; }
            set { this._policyDescription = value; }
        }

        // Check to see if PolicyDescription property is set
        internal bool IsSetPolicyDescription()
        {
            return this._policyDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the resource. A tag is a label that you assign to an Amazon Web
        /// Services resource. Each tag consists of a key/value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier for this resiliency policy, ranging from the highest severity (<code>MissionCritical</code>)
        /// to lowest (<code>NonCritical</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResiliencyPolicyTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}