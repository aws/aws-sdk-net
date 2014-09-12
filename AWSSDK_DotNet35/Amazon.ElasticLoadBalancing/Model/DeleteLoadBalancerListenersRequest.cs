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
    /// Container for the parameters to the DeleteLoadBalancerListeners operation.
    /// Deletes listeners from the load balancer for the specified port.
    /// </summary>
    public partial class DeleteLoadBalancerListenersRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private List<int> _loadBalancerPorts = new List<int>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteLoadBalancerListenersRequest() { }

        /// <summary>
        /// Instantiates DeleteLoadBalancerListenersRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The mnemonic name associated with the load balancer. </param>
        /// <param name="loadBalancerPorts"> The client port number(s) of the load balancer listener(s) to be removed. </param>
        public DeleteLoadBalancerListenersRequest(string loadBalancerName, List<int> loadBalancerPorts)
        {
            _loadBalancerName = loadBalancerName;
            _loadBalancerPorts = loadBalancerPorts;
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
        /// Gets and sets the property LoadBalancerPorts. 
        /// <para>
        ///  The client port number(s) of the load balancer listener(s) to be removed. 
        /// </para>
        /// </summary>
        public List<int> LoadBalancerPorts
        {
            get { return this._loadBalancerPorts; }
            set { this._loadBalancerPorts = value; }
        }

        // Check to see if LoadBalancerPorts property is set
        internal bool IsSetLoadBalancerPorts()
        {
            return this._loadBalancerPorts != null && this._loadBalancerPorts.Count > 0; 
        }

    }
}