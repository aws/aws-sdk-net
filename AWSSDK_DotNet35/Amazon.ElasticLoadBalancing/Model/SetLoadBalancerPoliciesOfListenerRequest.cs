/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the SetLoadBalancerPoliciesOfListener operation.
    /// <para> Associates, updates, or disables a policy with a listener on the load balancer. You can associate multiple policies with a listener.
    /// </para>
    /// </summary>
    public partial class SetLoadBalancerPoliciesOfListenerRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private int? loadBalancerPort;
        private List<string> policyNames = new List<string>();

        /// <summary>
        /// Default constructor for a new SetLoadBalancerPoliciesOfListenerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public SetLoadBalancerPoliciesOfListenerRequest() {}
    
        /// <summary>
        /// Constructs a new SetLoadBalancerPoliciesOfListenerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="loadBalancerPort"> The external port of the load balancer to associate the policy. </param>
        /// <param name="policyNames"> List of policies to be associated with the listener. If the list is empty, the current policy is removed from the
        /// listener. </param>
        public SetLoadBalancerPoliciesOfListenerRequest(string loadBalancerName, int loadBalancerPort, List<string> policyNames)
        {
            this.loadBalancerName = loadBalancerName;
            this.loadBalancerPort = loadBalancerPort;
            this.policyNames = policyNames;
        }
    

        /// <summary>
        /// The name of the load balancer.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;
        }

        /// <summary>
        /// The external port of the load balancer to associate the policy.
        ///  
        /// </summary>
        public int LoadBalancerPort
        {
            get { return this.loadBalancerPort ?? default(int); }
            set { this.loadBalancerPort = value; }
        }

        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this.loadBalancerPort.HasValue;
        }

        /// <summary>
        /// List of policies to be associated with the listener. If the list is empty, the current policy is removed from the listener.
        ///  
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this.policyNames; }
            set { this.policyNames = value; }
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this.policyNames.Count > 0;
        }

    }
}
    
