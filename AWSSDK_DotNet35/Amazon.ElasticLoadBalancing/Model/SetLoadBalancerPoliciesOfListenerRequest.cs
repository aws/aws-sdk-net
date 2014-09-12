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
    /// Container for the parameters to the SetLoadBalancerPoliciesOfListener operation.
    /// Associates, updates, or disables a policy with a listener on the load balancer. You
    /// can associate multiple policies with a listener.
    /// </summary>
    public partial class SetLoadBalancerPoliciesOfListenerRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private int? _loadBalancerPort;
        private List<string> _policyNames = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SetLoadBalancerPoliciesOfListenerRequest() { }

        /// <summary>
        /// Instantiates SetLoadBalancerPoliciesOfListenerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="loadBalancerPort"> The external port of the load balancer to associate the policy. </param>
        /// <param name="policyNames"> List of policies to be associated with the listener. If the list is empty, the current policy is removed from the listener. </param>
        public SetLoadBalancerPoliciesOfListenerRequest(string loadBalancerName, int loadBalancerPort, List<string> policyNames)
        {
            _loadBalancerName = loadBalancerName;
            _loadBalancerPort = loadBalancerPort;
            _policyNames = policyNames;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The name of the load balancer. 
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
        /// Gets and sets the property LoadBalancerPort. 
        /// <para>
        ///  The external port of the load balancer to associate the policy. 
        /// </para>
        /// </summary>
        public int LoadBalancerPort
        {
            get { return this._loadBalancerPort.GetValueOrDefault(); }
            set { this._loadBalancerPort = value; }
        }

        // Check to see if LoadBalancerPort property is set
        internal bool IsSetLoadBalancerPort()
        {
            return this._loadBalancerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        ///  List of policies to be associated with the listener. If the list is empty, the current
        /// policy is removed from the listener. 
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