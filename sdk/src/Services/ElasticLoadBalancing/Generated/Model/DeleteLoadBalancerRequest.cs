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
    /// Container for the parameters to the DeleteLoadBalancer operation.
    /// Deletes the specified load balancer.
    /// 
    ///  
    /// <para>
    /// If you are attempting to recreate a load balancer, you must reconfigure all settings.
    /// The DNS name associated with a deleted load balancer are no longer usable. The name
    /// and associated DNS record of the deleted load balancer no longer exist and traffic
    /// sent to any of its IP addresses is no longer delivered to your instances.
    /// </para>
    ///  
    /// <para>
    /// If the load balancer does not exist or has already been deleted, the call to <c>DeleteLoadBalancer</c>
    /// still succeeds.
    /// </para>
    /// </summary>
    public partial class DeleteLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates DeleteLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        public DeleteLoadBalancerRequest(string loadBalancerName)
        {
            _loadBalancerName = loadBalancerName;
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