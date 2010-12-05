/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Associates, updates, or disables a policy with a listener on
    /// the load balancer. Currently only zero (0) or one (1) policy can be
    /// associated with a listener. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.SetLoadBalancerPoliciesOfListener"/>
    public class SetLoadBalancerPoliciesOfListenerRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private int? loadBalancerPort;
        private List<string> policyNames = new List<string>();
        /// <summary>
        /// Default constructor for a new SetLoadBalancerPoliciesOfListenerRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public SetLoadBalancerPoliciesOfListenerRequest() {}
    
        /// <summary>
        /// Constructs a new SetLoadBalancerPoliciesOfListenerRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the
        /// LoadBalancer. The name must be unique within the client AWS account.
        /// </param>
        /// <param name="loadBalancerPort"> The external port of the LoadBalancer
        /// with which this policy has to be associated. </param>
        /// <param name="policyNames"> List of policies to be associated with the
        /// listener. Currently this list can have at most one policy. If the list
        /// is empty, the current policy is removed from the listener. </param>
        public SetLoadBalancerPoliciesOfListenerRequest(string loadBalancerName, int loadBalancerPort, List<string> policyNames) 
        {
            this.loadBalancerName = loadBalancerName;
            this.loadBalancerPort = loadBalancerPort;
            this.policyNames = policyNames;
        }
    

        /// <summary>
        /// The name associated with the LoadBalancer. The name must be unique
        /// within the client AWS account.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        public SetLoadBalancerPoliciesOfListenerRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            
        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;       
        }

        /// <summary>
        /// The external port of the LoadBalancer with which this policy has to be
        /// associated.
        ///  
        /// </summary>
        public int LoadBalancerPort
        {
            get { return this.loadBalancerPort ?? default(int); }
            set { this.loadBalancerPort = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerPort property
        /// </summary>
        /// <param name="loadBalancerPort">The value to set for the LoadBalancerPort property </param>
        /// <returns>this instance</returns>
        public SetLoadBalancerPoliciesOfListenerRequest WithLoadBalancerPort(int loadBalancerPort)
        {
            this.loadBalancerPort = loadBalancerPort;
            return this;
        }
            
        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this.loadBalancerPort.HasValue;      
        }

        /// <summary>
        /// List of policies to be associated with the listener. Currently this
        /// list can have at most one policy. If the list is empty, the current
        /// policy is removed from the listener.
        ///  
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this.policyNames; }
            set { this.policyNames = value; }
        }
        /// <summary>
        /// Adds elements to the PolicyNames collection
        /// </summary>
        /// <param name="policyNames">The values to add to the PolicyNames collection </param>
        /// <returns>this instance</returns>
        public SetLoadBalancerPoliciesOfListenerRequest WithPolicyNames(params string[] policyNames)
        {
            foreach (string element in policyNames)
            {
                this.policyNames.Add(element);
            }

            return this;
        }
        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this.policyNames.Count > 0;      
        }
    }
}
    
