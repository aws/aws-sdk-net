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
    /// Container for the parameters to the CreateLoadBalancerListeners operation.
    /// Creates one or more listeners on a load balancer for the specified port. If a listener
    /// with the given port does not already exist, it will be created; otherwise, the properties
    /// of the new listener must match the properties of the existing listener. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/us-add-listener.html">Add
    /// a Listener to Your Load Balancer</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLoadBalancerListenersRequest : AmazonElasticLoadBalancingRequest
    {
        private List<Listener> _listeners = new List<Listener>();
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLoadBalancerListenersRequest() { }

        /// <summary>
        /// Instantiates CreateLoadBalancerListenersRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="listeners"> A list of <code>LoadBalancerPort</code>, <code>InstancePort</code>, <code>Protocol</code>, <code>InstanceProtocol</code>, and <code>SSLCertificateId</code> items. </param>
        public CreateLoadBalancerListenersRequest(string loadBalancerName, List<Listener> listeners)
        {
            _loadBalancerName = loadBalancerName;
            _listeners = listeners;
        }

        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        ///  A list of <code>LoadBalancerPort</code>, <code>InstancePort</code>, <code>Protocol</code>,
        /// <code>InstanceProtocol</code>, and <code>SSLCertificateId</code> items. 
        /// </para>
        /// </summary>
        public List<Listener> Listeners
        {
            get { return this._listeners; }
            set { this._listeners = value; }
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this._listeners != null && this._listeners.Count > 0; 
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

    }
}