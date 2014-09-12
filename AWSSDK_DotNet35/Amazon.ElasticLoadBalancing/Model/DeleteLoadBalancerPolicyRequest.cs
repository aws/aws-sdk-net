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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLoadBalancerPolicy operation.
    /// Deletes a policy from the load balancer. The specified policy must not be enabled
    /// for any listeners.
    /// </summary>
    public partial class DeleteLoadBalancerPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private string _policyName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteLoadBalancerPolicyRequest() { }

        /// <summary>
        /// Instantiates DeleteLoadBalancerPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The mnemonic name associated with the load balancer. </param>
        /// <param name="policyName"> The mnemonic name for the policy being deleted. </param>
        public DeleteLoadBalancerPolicyRequest(string loadBalancerName, string policyName)
        {
            _loadBalancerName = loadBalancerName;
            _policyName = policyName;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The mnemonic name associated with the load balancer. 
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        ///  The mnemonic name for the policy being deleted. 
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

    }
}