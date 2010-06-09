/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// This API enables you to define an application healthcheck for the instances.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class ConfigureHealthCheckRequest
    {
        private string loadBalancerNameField;
        private HealthCheck healthCheckField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The mnemonic name associated with the LoadBalancer. The name must be unique within your AWS account.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerName")]
        public string LoadBalancerName
        {
            get { return this.loadBalancerNameField ; }
            set { this.loadBalancerNameField= value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The mnemonic name associated with the LoadBalancer. The name must be unique within your AWS account.</param>
        /// <returns>this instance</returns>
        public ConfigureHealthCheckRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerNameField = loadBalancerName;
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerName property is set
        /// </summary>
        /// <returns>true if LoadBalancerName property is set</returns>
        public bool IsSetLoadBalancerName()
        {
            return  this.loadBalancerNameField != null;
        }

        /// <summary>
        /// Gets and sets the HealthCheck property.
        /// Structure containing the configuration information for the new healthcheck.
        /// </summary>
        [XmlElementAttribute(ElementName = "HealthCheck")]
        public HealthCheck HealthCheck
        {
            get { return this.healthCheckField ; }
            set { this.healthCheckField = value; }
        }

        /// <summary>
        /// Sets the HealthCheck property
        /// </summary>
        /// <param name="healthCheck">Structure containing the configuration information for the new healthcheck.</param>
        /// <returns>this instance</returns>
        public ConfigureHealthCheckRequest WithHealthCheck(HealthCheck healthCheck)
        {
            this.healthCheckField = healthCheck;
            return this;
        }

        /// <summary>
        /// Checks if HealthCheck property is set
        /// </summary>
        /// <returns>true if HealthCheck property is set</returns>
        public bool IsSetHealthCheck()
        {
            return this.healthCheckField != null;
        }

    }
}
