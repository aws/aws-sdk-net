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
    /// Container for the parameters to the DeleteLoadBalancer operation.
    /// <para> Deletes the specified load balancer. </para> <para> If attempting to recreate the load balancer, you must reconfigure all the
    /// settings. The DNS name associated with a deleted load balancer will no longer be usable. Once deleted, the name and associated DNS record of
    /// the load balancer no longer exist and traffic sent to any of its IP addresses will no longer be delivered to back-end instances. </para>
    /// <para> To successfully call this API, you must provide the same account credentials as were used to create the load balancer. </para>
    /// <para><b>NOTE:</b> By design, if the load balancer does not exist or has already been deleted, a call to DeleteLoadBalancer action still
    /// succeeds. </para>
    /// </summary>
    public partial class DeleteLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;

        /// <summary>
        /// Default constructor for a new DeleteLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DeleteLoadBalancerRequest() {}
    
        /// <summary>
        /// Constructs a new DeleteLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        public DeleteLoadBalancerRequest(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
        }
    

        /// <summary>
        /// The name associated with the load balancer.
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

    }
}
    
