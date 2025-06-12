/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterInstancesFromLoadBalancer operation.
    /// Deregisters the specified instances from the specified load balancer. After the instance
    /// is deregistered, it no longer receives traffic from the load balancer.
    /// 
    ///  
    /// <para>
    /// You can use <a>DescribeLoadBalancers</a> to verify that the instance is deregistered
    /// from the load balancer.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-deregister-register-instances.html">Register
    /// or De-Register EC2 Instances</a> in the <i>Classic Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeregisterInstancesFromLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private List<Instance> _instances = AWSConfigs.InitializeCollections ? new List<Instance>() : null;
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeregisterInstancesFromLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates DeregisterInstancesFromLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        /// <param name="instances">The IDs of the instances.</param>
        public DeregisterInstancesFromLoadBalancerRequest(string loadBalancerName, List<Instance> instances)
        {
            _loadBalancerName = loadBalancerName;
            _instances = instances;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The IDs of the instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && (this._instances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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