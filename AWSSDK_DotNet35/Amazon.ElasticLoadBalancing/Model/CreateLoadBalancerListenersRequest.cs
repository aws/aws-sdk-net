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
    /// Container for the parameters to the CreateLoadBalancerListeners operation.
    /// <para> Creates one or more listeners on a load balancer for the specified port. If a listener with the given port does not already exist, it
    /// will be created; otherwise, the properties of the new listener must match the properties of the existing listener. </para> <para>For more
    /// information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/us-add-listener.html" >Add a Listener to
    /// Your Load Balancer</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// </summary>
    public partial class CreateLoadBalancerListenersRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private List<Listener> listeners = new List<Listener>();

        /// <summary>
        /// Default constructor for a new CreateLoadBalancerListenersRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public CreateLoadBalancerListenersRequest() {}
    
        /// <summary>
        /// Constructs a new CreateLoadBalancerListenersRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="listeners"> A list of <c>LoadBalancerPort</c>, <c>InstancePort</c>, <c>Protocol</c>, and <c>SSLCertificateId</c> items.
        /// </param>
        public CreateLoadBalancerListenersRequest(string loadBalancerName, List<Listener> listeners)
        {
            this.loadBalancerName = loadBalancerName;
            this.listeners = listeners;
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
        /// A list of <c>LoadBalancerPort</c>, <c>InstancePort</c>, <c>Protocol</c>, and <c>SSLCertificateId</c> items.
        ///  
        /// </summary>
        public List<Listener> Listeners
        {
            get { return this.listeners; }
            set { this.listeners = value; }
        }

        // Check to see if Listeners property is set
        internal bool IsSetListeners()
        {
            return this.listeners.Count > 0;
        }

    }
}
    
