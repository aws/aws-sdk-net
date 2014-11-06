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
    /// Container for the parameters to the SetLoadBalancerPoliciesForBackendServer operation.
    /// Replaces the current set of policies associated with a port on which the back-end
    /// server is listening with a new set of policies. After the policies have been created
    /// using <a>CreateLoadBalancerPolicy</a>, they can be applied here as a list. At this
    /// time, only the back-end server authentication policy type can be applied to the back-end
    /// ports; this policy type is composed of multiple public key policies. 
    /// 
    ///  <note> 
    /// <para>
    /// The <i>SetLoadBalancerPoliciesForBackendServer</i> replaces the current set of policies
    /// associated with the specified instance port. Every time you use this action to enable
    /// the policies, use the <code>PolicyNames</code> parameter to list all the policies
    /// you want to enable.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeLoadBalancerPolicies</a> action
    /// to verify that the policy has been associated with the back-end server.
    /// </para>
    /// </summary>
    public partial class SetLoadBalancerPoliciesForBackendServerRequest : AmazonElasticLoadBalancingRequest
    {
        private int? _instancePort;
        private string _loadBalancerName;
        private List<string> _policyNames = new List<string>();

        /// <summary>
        /// Gets and sets the property InstancePort. 
        /// <para>
        ///  The port number associated with the back-end server. 
        /// </para>
        /// </summary>
        public int InstancePort
        {
            get { return this._instancePort.GetValueOrDefault(); }
            set { this._instancePort = value; }
        }

        // Check to see if InstancePort property is set
        internal bool IsSetInstancePort()
        {
            return this._instancePort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The mnemonic name associated with the load balancer. This name must be unique within
        /// the set of your load balancers. 
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
        ///  List of policy names to be set. If the list is empty, then all current polices are
        /// removed from the back-end server. 
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