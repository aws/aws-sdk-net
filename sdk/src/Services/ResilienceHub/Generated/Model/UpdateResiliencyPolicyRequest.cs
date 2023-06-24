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
    /// Container for the parameters to the UpdateResiliencyPolicy operation.
    /// Updates a resiliency policy.
    /// </summary>
    public partial class UpdateResiliencyPolicyRequest : AmazonResilienceHubRequest
    {
        private DataLocationConstraint _dataLocationConstraint;
        private Dictionary<string, FailurePolicy> _policy = new Dictionary<string, FailurePolicy>();
        private string _policyArn;
        private string _policyDescription;
        private string _policyName;
        private ResiliencyPolicyTier _tier;

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
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resiliency policy. The format for this ARN is:
        /// arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:resiliency-policy/<code>policy-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier for this resiliency policy, ranging from the highest severity (<code>MissionCritical</code>)
        /// to lowest (<code>NonCritical</code>).
        /// </para>
        /// </summary>
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