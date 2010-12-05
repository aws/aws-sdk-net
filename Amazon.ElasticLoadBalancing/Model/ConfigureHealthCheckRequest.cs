/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Enables the client to define an application healthcheck for the
    /// instances. </para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancing.ConfigureHealthCheck"/>
    public class ConfigureHealthCheckRequest : AmazonWebServiceRequest
    {
        private string loadBalancerName;
        private HealthCheck healthCheck;
        /// <summary>
        /// Default constructor for a new ConfigureHealthCheckRequest object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public ConfigureHealthCheckRequest() {}
    
        /// <summary>
        /// Constructs a new ConfigureHealthCheckRequest object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The mnemonic name associated with the
        /// LoadBalancer. This name must be unique within the client AWS account.
        /// </param>
        /// <param name="healthCheck"> A structure containing the configuration
        /// information for the new healthcheck. </param>
        public ConfigureHealthCheckRequest(string loadBalancerName, HealthCheck healthCheck) 
        {
            this.loadBalancerName = loadBalancerName;
            this.healthCheck = healthCheck;
        }
    

        /// <summary>
        /// The mnemonic name associated with the LoadBalancer. This name must be
        /// unique within the client AWS account.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        public ConfigureHealthCheckRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            
        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;       
        }

        /// <summary>
        /// A structure containing the configuration information for the new
        /// healthcheck.
        ///  
        /// </summary>
        public HealthCheck HealthCheck
        {
            get { return this.healthCheck; }
            set { this.healthCheck = value; }
        }

        /// <summary>
        /// Sets the HealthCheck property
        /// </summary>
        /// <param name="healthCheck">The value to set for the HealthCheck property </param>
        /// <returns>this instance</returns>
        public ConfigureHealthCheckRequest WithHealthCheck(HealthCheck healthCheck)
        {
            this.healthCheck = healthCheck;
            return this;
        }
            
        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this.healthCheck != null;        
        }
    }
}
    
