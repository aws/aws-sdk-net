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
    /// Container for the parameters to the ConfigureHealthCheck operation.
    /// Specifies the health check settings to use for evaluating the health state of your
    /// back-end instances. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/TerminologyandKeyConcepts.html#healthcheck">Health
    /// Check</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ConfigureHealthCheckRequest : AmazonElasticLoadBalancingRequest
    {
        private HealthCheck _healthCheck;
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ConfigureHealthCheckRequest() { }

        /// <summary>
        /// Instantiates ConfigureHealthCheckRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The mnemonic name associated with the load balancer. The name must be unique within the set of load balancers associated with your AWS account. </param>
        /// <param name="healthCheck"> A structure containing the configuration information for the new healthcheck. </param>
        public ConfigureHealthCheckRequest(string loadBalancerName, HealthCheck healthCheck)
        {
            _loadBalancerName = loadBalancerName;
            _healthCheck = healthCheck;
        }

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        ///  A structure containing the configuration information for the new healthcheck. 
        /// </para>
        /// </summary>
        public HealthCheck HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The mnemonic name associated with the load balancer. The name must be unique within
        /// the set of load balancers associated with your AWS account. 
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