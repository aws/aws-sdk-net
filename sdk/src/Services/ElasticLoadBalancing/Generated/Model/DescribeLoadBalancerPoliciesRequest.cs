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
    /// Container for the parameters to the DescribeLoadBalancerPolicies operation.
    /// Returns detailed descriptions of the policies. If you specify a load balancer name,
    /// the action returns the descriptions of all the policies created for the load balancer.
    /// If you specify a policy name associated with your load balancer, the action returns
    /// the description of that policy. If you don't specify a load balancer name, the action
    /// returns descriptions of the specified sample policies, or descriptions of all the
    /// sample policies. The names of the sample policies have the <code>ELBSample-</code>
    /// prefix.
    /// </summary>
    public partial class DescribeLoadBalancerPoliciesRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private List<string> _policyNames = new List<string>();

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The mnemonic name associated with the load balancer. If no name is specified, the
        /// operation returns the attributes of either all the sample policies pre-defined by
        /// Elastic Load Balancing or the specified sample polices. 
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
        /// Gets and sets the property PolicyNames. 
        /// <para>
        ///  The names of load balancer policies you've created or Elastic Load Balancing sample
        /// policy names. 
        /// </para>
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this._policyNames; }
            set { this._policyNames = value; }
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this._policyNames != null && this._policyNames.Count > 0; 
        }

    }
}