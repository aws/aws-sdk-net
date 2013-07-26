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
    /// Container for the parameters to the AttachElasticLoadBalancer operation.
    /// <para>Attaches an Elastic Load Balancing load balancer to a specified layer.</para> <para><b>NOTE:</b>You must create the Elastic Load
    /// Balancing load balancer separately, by using the Elastic Load Balancing console, API, or CLI. For more information, see Elastic Load
    /// Balancing Developer Guide.</para>
    /// </summary>
    public partial class AttachElasticLoadBalancerRequest : AmazonWebServiceRequest
    {
        private string elasticLoadBalancerName;
        private string layerId;

        /// <summary>
        /// The Elastic Load Balancing load balancer's name.
        ///  
        /// </summary>
        public string ElasticLoadBalancerName
        {
            get { return this.elasticLoadBalancerName; }
            set { this.elasticLoadBalancerName = value; }
        }

        // Check to see if ElasticLoadBalancerName property is set
        internal bool IsSetElasticLoadBalancerName()
        {
            return this.elasticLoadBalancerName != null;
        }

        /// <summary>
        /// The ID of the layer that the Elastic Load Balancing load balancer is to be attached to.
        ///  
        /// </summary>
        public string LayerId
        {
            get { return this.layerId; }
            set { this.layerId = value; }
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
        }

    }
}
    
