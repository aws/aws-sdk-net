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
    /// Container for the parameters to the DeleteLoadBalancerListeners operation.
    /// <para> Deletes listeners from the load balancer for the specified port. </para>
    /// </summary>
    public partial class DeleteLoadBalancerListenersRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private List<int> loadBalancerPorts = new List<int>();

        /// <summary>
        /// Default constructor for a new DeleteLoadBalancerListenersRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DeleteLoadBalancerListenersRequest() {}
    
        /// <summary>
        /// Constructs a new DeleteLoadBalancerListenersRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The mnemonic name associated with the load balancer. </param>
        /// <param name="loadBalancerPorts"> The client port number(s) of the load balancer listener(s) to be removed. </param>
        public DeleteLoadBalancerListenersRequest(string loadBalancerName, List<int> loadBalancerPorts)
        {
            this.loadBalancerName = loadBalancerName;
            this.loadBalancerPorts = loadBalancerPorts;
        }
    

        /// <summary>
        /// The mnemonic name associated with the load balancer.
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
        /// The client port number(s) of the load balancer listener(s) to be removed.
        ///  
        /// </summary>
        public List<int> LoadBalancerPorts
        {
            get { return this.loadBalancerPorts; }
            set { this.loadBalancerPorts = value; }
        }

        // Check to see if LoadBalancerPorts property is set
        internal bool IsSetLoadBalancerPorts()
        {
            return this.loadBalancerPorts.Count > 0;
        }

    }
}
    
