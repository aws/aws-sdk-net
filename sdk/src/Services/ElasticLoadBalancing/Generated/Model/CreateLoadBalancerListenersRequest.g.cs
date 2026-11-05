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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateLoadBalancerListeners operation. Creates
    /// one or more listeners for the specified load balancer. If a listener with the specified
    /// port does not already exist, it is created; otherwise, the properties of the new listener
    /// must match the properties of the existing listener. <para> For more information, see
    /// <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html">Listeners
    /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancers Guide</i>. </para>
    /// </summary>
    public partial class CreateLoadBalancerListenersRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateLoadBalancerListenersRequest() { }

        /// <summary>
        /// Instantiates CreateLoadBalancerListenersRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        /// <param name="listeners">The listeners.</param>
        public CreateLoadBalancerListenersRequest(string loadBalancerName, List<Listener> listeners)
        {
            this.LoadBalancerName = loadBalancerName;
            this.Listeners = listeners;
        }

        /// <summary>
        /// Gets and sets the property Listeners. 
        /// <para>
        /// The listeners.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Listener> Listeners { get; set; } = AWSConfigs.InitializeCollections ? new List<Listener>() : null;

        /// <summary>
        /// Checks to see if the Listeners property is set.
        /// </summary>
        internal bool IsSetListeners() => this.Listeners != null && (this.Listeners.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;
    }
}
