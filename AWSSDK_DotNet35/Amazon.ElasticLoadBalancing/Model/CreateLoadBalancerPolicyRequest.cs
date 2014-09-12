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
    /// Container for the parameters to the CreateLoadBalancerPolicy operation.
    /// Creates a new policy that contains the necessary attributes depending on the policy
    /// type. Policies are settings that are saved for your load balancer and that can be
    /// applied to the front-end listener, or the back-end application server, depending on
    /// your policy type.
    /// </summary>
    public partial class CreateLoadBalancerPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private List<PolicyAttribute> _policyAttributes = new List<PolicyAttribute>();
        private string _policyName;
        private string _policyTypeName;

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The name associated with the LoadBalancer for which the policy is being created.
        /// 
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
        /// Gets and sets the property PolicyAttributes. 
        /// <para>
        ///  A list of attributes associated with the policy being created. 
        /// </para>
        /// </summary>
        public List<PolicyAttribute> PolicyAttributes
        {
            get { return this._policyAttributes; }
            set { this._policyAttributes = value; }
        }

        // Check to see if PolicyAttributes property is set
        internal bool IsSetPolicyAttributes()
        {
            return this._policyAttributes != null && this._policyAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        ///  The name of the load balancer policy being created. The name must be unique within
        /// the set of policies for this load balancer. 
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
        /// Gets and sets the property PolicyTypeName. 
        /// <para>
        ///  The name of the base policy type being used to create this policy. To get the list
        /// of policy types, use the <a>DescribeLoadBalancerPolicyTypes</a> action. 
        /// </para>
        /// </summary>
        public string PolicyTypeName
        {
            get { return this._policyTypeName; }
            set { this._policyTypeName = value; }
        }

        // Check to see if PolicyTypeName property is set
        internal bool IsSetPolicyTypeName()
        {
            return this._policyTypeName != null;
        }

    }
}