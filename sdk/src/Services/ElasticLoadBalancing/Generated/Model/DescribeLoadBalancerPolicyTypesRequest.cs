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
    /// Container for the parameters to the DescribeLoadBalancerPolicyTypes operation.
    /// Describes the specified load balancer policy types or all load balancer policy types.
    /// 
    ///  
    /// <para>
    /// The description of each type indicates how it can be used. For example, some policies
    /// can be used only with layer 7 listeners, some policies can be used only with layer
    /// 4 listeners, and some policies can be used only with your EC2 instances.
    /// </para>
    ///  
    /// <para>
    /// You can use <a>CreateLoadBalancerPolicy</a> to create a policy configuration for any
    /// of these policy types. Then, depending on the policy type, use either <a>SetLoadBalancerPoliciesOfListener</a>
    /// or <a>SetLoadBalancerPoliciesForBackendServer</a> to set the policy.
    /// </para>
    /// </summary>
    public partial class DescribeLoadBalancerPolicyTypesRequest : AmazonElasticLoadBalancingRequest
    {
        private List<string> _policyTypeNames = new List<string>();

        /// <summary>
        /// Gets and sets the property PolicyTypeNames. 
        /// <para>
        /// The names of the policy types. If no names are specified, describes all policy types
        /// defined by Elastic Load Balancing.
        /// </para>
        /// </summary>
        public List<string> PolicyTypeNames
        {
            get { return this._policyTypeNames; }
            set { this._policyTypeNames = value; }
        }

        // Check to see if PolicyTypeNames property is set
        internal bool IsSetPolicyTypeNames()
        {
            return this._policyTypeNames != null && this._policyTypeNames.Count > 0; 
        }

    }
}