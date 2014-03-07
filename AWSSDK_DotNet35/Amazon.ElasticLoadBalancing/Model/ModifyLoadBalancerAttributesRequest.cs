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
    /// Container for the parameters to the ModifyLoadBalancerAttributes operation.
    /// <para>Modifies the attributes of a specified load balancer.</para> <para>You can modify the attributes, such as cross-zone load balancing
    /// and access logs, by either enabling or disabling them.</para> <para>For information on modifying the cross-zone load balancing attribute,
    /// see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/enable-disable-crosszone-lb.html" >Enable or Disable
    /// Cross-Zone Load Balancing for Your Load balancer</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para> <para>For information on
    /// modifying the access log attribute, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/access-log-collection.html" >Enable or Disable Access Log
    /// Collection for Your Load Balancer</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// </summary>
    public partial class ModifyLoadBalancerAttributesRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private LoadBalancerAttributes loadBalancerAttributes;


        /// <summary>
        /// The name of the load balancer.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;
        }

        /// <summary>
        /// Attributes of the load balancer.
        ///  
        /// </summary>
        public LoadBalancerAttributes LoadBalancerAttributes
        {
            get { return this.loadBalancerAttributes; }
            set { this.loadBalancerAttributes = value; }
        }

        // Check to see if LoadBalancerAttributes property is set
        internal bool IsSetLoadBalancerAttributes()
        {
            return this.loadBalancerAttributes != null;
        }

    }
}
    
