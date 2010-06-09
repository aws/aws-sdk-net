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
    /// Updated healthcheck for the instances.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class ConfigureHealthCheckResult
    {
        private HealthCheck healthCheckField;

        /// <summary>
        /// Gets and sets the HealthCheck property.
        /// The LoadBalancer also monitors the health of your instances registered with your LoadBalancer.
        /// When the LoadBalancer detects a problem with an instance, it stops distributing traffic to it. When the
        /// instance is healthy again, the LoadBalancer restarts distributing traffic to it. This process allows your
        /// application to automatically react to issues that might affect your customers without your having to be involved
        /// beyond configuring the healthcheck.
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
        /// <param name="healthCheck">The LoadBalancer also monitors the health of your instances registered with your LoadBalancer.
        /// When the LoadBalancer detects a problem with an instance, it stops distributing traffic to it. When the
        /// instance is healthy again, the LoadBalancer restarts distributing traffic to it. This process allows your
        /// application to automatically react to issues that might affect your customers without your having to be involved
        /// beyond configuring the healthcheck.</param>
        /// <returns>this instance</returns>
        public ConfigureHealthCheckResult WithHealthCheck(HealthCheck healthCheck)
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
