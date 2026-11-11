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
    /// Container for the parameters to the ModifyLoadBalancerAttributes operation. Modifies
    /// the attributes of the specified load balancer. <para> You can modify the load balancer
    /// attributes, such as <c>AccessLogs</c>, <c>ConnectionDraining</c>, and <c>CrossZoneLoadBalancing</c>
    /// by either enabling or disabling them. Or, you can modify the load balancer attribute
    /// <c>ConnectionSettings</c> by specifying an idle connection timeout value for your
    /// load balancer. </para> <para> For more information, see the following in the <i>Classic
    /// Load Balancers Guide</i>: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-crosszone-lb.html">Cross-Zone
    /// Load Balancing</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/config-conn-drain.html">Connection
    /// Draining</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/access-log-collection.html">Access
    /// Logs</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/config-idle-timeout.html">Idle
    /// Connection Timeout</a> </para> </li> </ul>
    /// </summary>
    public partial class ModifyLoadBalancerAttributesRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Gets and sets the property LoadBalancerAttributes. 
        /// <para>
        /// The attributes for the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LoadBalancerAttributes LoadBalancerAttributes { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerAttributes property is set.
        /// </summary>
        internal bool IsSetLoadBalancerAttributes() => this.LoadBalancerAttributes != null;

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
