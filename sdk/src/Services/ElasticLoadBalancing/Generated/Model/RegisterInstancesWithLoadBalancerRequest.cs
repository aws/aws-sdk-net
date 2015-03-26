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
    /// Container for the parameters to the RegisterInstancesWithLoadBalancer operation.
    /// Adds new instances to the load balancer. 
    /// 
    ///  
    /// <para>
    ///  Once the instance is registered, it starts receiving traffic and requests from the
    /// load balancer. Any instance that is not in any of the Availability Zones registered
    /// for the load balancer will be moved to the <i>OutOfService</i> state. It will move
    /// to the <i>InService</i> state when the Availability Zone is added to the load balancer.
    /// 
    /// </para>
    ///  
    /// <para>
    /// When an instance registered with a load balancer is stopped and then restarted, the
    /// IP addresses associated with the instance changes. Elastic Load Balancing cannot recognize
    /// the new IP address, which prevents it from routing traffic to the instances. We recommend
    /// that you de-register your Amazon EC2 instances from your load balancer after you stop
    /// your instance, and then register the load balancer with your instance after you've
    /// restarted. To de-register your instances from load balancer, use <a>DeregisterInstancesFromLoadBalancer</a>
    /// action.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">De-register
    /// and Register Amazon EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    ///  <note> In order for this call to be successful, you must provide the same account
    /// credentials as those that were used to create the load balancer. </note> <note> Completion
    /// of this API does not guarantee that operation has completed. Rather, it means that
    /// the request has been registered and the changes will happen shortly. </note> 
    /// <para>
    /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeInstanceHealth</a> action to
    /// check the state of the newly registered instances.
    /// </para>
    /// </summary>
    public partial class RegisterInstancesWithLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private List<Instance> _instances = new List<Instance>();
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RegisterInstancesWithLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates RegisterInstancesWithLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name associated with the load balancer. The name must be unique within your set of load balancers. </param>
        /// <param name="instances"> A list of instance IDs that should be registered with the load balancer.</param>
        public RegisterInstancesWithLoadBalancerRequest(string loadBalancerName, List<Instance> instances)
        {
            _loadBalancerName = loadBalancerName;
            _instances = instances;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        ///  A list of instance IDs that should be registered with the load balancer.
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
        ///  The name associated with the load balancer. The name must be unique within your set
        /// of load balancers. 
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