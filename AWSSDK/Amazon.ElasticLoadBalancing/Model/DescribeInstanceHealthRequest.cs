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
    /// <para> Returns the current state of the instances of the specified LoadBalancer. If no instances are specified, the state of all the
    /// instances for the LoadBalancer is returned. </para> <para><b>NOTE:</b> The client must have created the specified input LoadBalancer in
    /// order to retrieve this information; the client must provide the same account credentials as those that were used to create the LoadBalancer.
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.DescribeInstanceHealth"/>
    public class DescribeInstanceHealthRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private List<Instance> instances = new List<Instance>();
        /// <summary>
        /// Default constructor for a new DescribeInstanceHealthRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public DescribeInstanceHealthRequest() {}
    
        /// <summary>
        /// Constructs a new DescribeInstanceHealthRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the LoadBalancer. The name must be unique within the client AWS account. </param>
        public DescribeInstanceHealthRequest(string loadBalancerName) 
        {
            this.loadBalancerName = loadBalancerName;
        }
    

        /// <summary>
        /// The name associated with the LoadBalancer. The name must be unique within the client AWS account.
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
        public DescribeInstanceHealthRequest WithLoadBalancerName(string loadBalancerName)
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
        /// A list of instance IDs whose states are being queried.
        ///  
        /// </summary>
        public List<Instance> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        public DescribeInstanceHealthRequest WithInstances(params Instance[] instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        public DescribeInstanceHealthRequest WithInstances(IEnumerable<Instance> instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;       
        }
    }
}
    
