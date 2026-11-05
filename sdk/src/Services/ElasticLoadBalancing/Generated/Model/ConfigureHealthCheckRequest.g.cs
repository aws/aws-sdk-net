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
    /// Container for the parameters to the ConfigureHealthCheck operation. Specifies the
    /// health check settings to use when evaluating the health state of your EC2 instances.
    /// <para> For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-healthchecks.html">Configure
    /// Health Checks for Your Load Balancer</a> in the <i>Classic Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class ConfigureHealthCheckRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ConfigureHealthCheckRequest() { }

        /// <summary>
        /// Instantiates ConfigureHealthCheckRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        /// <param name="healthCheck">The configuration information.</param>
        public ConfigureHealthCheckRequest(string loadBalancerName, HealthCheck healthCheck)
        {
            this.LoadBalancerName = loadBalancerName;
            this.HealthCheck = healthCheck;
        }

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The configuration information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthCheck HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;

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
