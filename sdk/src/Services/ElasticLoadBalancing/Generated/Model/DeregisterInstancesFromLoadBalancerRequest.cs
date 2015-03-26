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
    /// Container for the parameters to the DeregisterInstancesFromLoadBalancer operation.
    /// Deregisters instances from the load balancer. Once the instance is deregistered,
    /// it will stop receiving traffic from the load balancer. 
    /// 
    ///  
    /// <para>
    ///  In order to successfully call this API, the same account credentials as those used
    /// to create the load balancer must be provided. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">De-register
    /// and Register Amazon EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can use <a>DescribeLoadBalancers</a> to verify if the instance is deregistered
    /// from the load balancer.
    /// </para>
    /// </summary>
    public partial class DeregisterInstancesFromLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private List<Instance> _instances = new List<Instance>();
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeregisterInstancesFromLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates DeregisterInstancesFromLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="instances"> A list of EC2 instance IDs consisting of all instances to be deregistered. </param>
        public DeregisterInstancesFromLoadBalancerRequest(string loadBalancerName, List<Instance> instances)
        {
            _loadBalancerName = loadBalancerName;
            _instances = instances;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        ///  A list of EC2 instance IDs consisting of all instances to be deregistered. 
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The name associated with the load balancer. 
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