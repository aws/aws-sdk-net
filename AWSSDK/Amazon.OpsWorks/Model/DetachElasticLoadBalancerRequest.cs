/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DetachElasticLoadBalancer operation.
    /// <para>Detaches a specified Elastic Load Balancing instance from its layer.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DetachElasticLoadBalancer"/>
    public class DetachElasticLoadBalancerRequest : AmazonWebServiceRequest
    {
        private string elasticLoadBalancerName;
        private string layerId;

        /// <summary>
        /// The Elastic Load Balancing instance's name.
        ///  
        /// </summary>
        public string ElasticLoadBalancerName
        {
            get { return this.elasticLoadBalancerName; }
            set { this.elasticLoadBalancerName = value; }
        }

        /// <summary>
        /// Sets the ElasticLoadBalancerName property
        /// </summary>
        /// <param name="elasticLoadBalancerName">The value to set for the ElasticLoadBalancerName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DetachElasticLoadBalancerRequest WithElasticLoadBalancerName(string elasticLoadBalancerName)
        {
            this.elasticLoadBalancerName = elasticLoadBalancerName;
            return this;
        }
            

        // Check to see if ElasticLoadBalancerName property is set
        internal bool IsSetElasticLoadBalancerName()
        {
            return this.elasticLoadBalancerName != null;
        }

        /// <summary>
        /// The ID of the layer that the Elastic Load Balancing instance is attached to.
        ///  
        /// </summary>
        public string LayerId
        {
            get { return this.layerId; }
            set { this.layerId = value; }
        }

        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DetachElasticLoadBalancerRequest WithLayerId(string layerId)
        {
            this.layerId = layerId;
            return this;
        }
            

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
        }
    }
}
    
