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
    /// Container for the parameters to the DescribeInstanceHealth operation.
    /// <para> Returns the current state of the specified instances registered with the specified load balancer. If no instances are specified, the
    /// state of all the instances registered with the load balancer is returned. </para> <para><b>NOTE:</b> You must provide the same account
    /// credentials as those that were used to create the load balancer. </para>
    /// </summary>
    public partial class DescribeInstanceHealthRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private List<Instance> instances = new List<Instance>();

        /// <summary>
        /// Default constructor for a new DescribeInstanceHealthRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DescribeInstanceHealthRequest() {}
    
        /// <summary>
        /// Constructs a new DescribeInstanceHealthRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        public DescribeInstanceHealthRequest(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
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
        /// A list of instance IDs whose states are being queried.
        ///  
        /// </summary>
        public List<Instance> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;
        }

    }
}
    
