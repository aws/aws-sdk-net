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
    /// Container for the parameters to the AttachLoadBalancerToSubnets operation.
    /// Adds one or more subnets to the set of configured subnets in the Amazon Virtual Private
    /// Cloud (Amazon VPC) for the load balancer. 
    /// 
    ///  
    /// <para>
    ///  The load balancers evenly distribute requests across all of the registered subnets.
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenariosForVPC.html">Deploy
    /// Elastic Load Balancing in Amazon VPC</a> in the <i>Elastic Load Balancing Developer
    /// Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AttachLoadBalancerToSubnetsRequest : AmazonElasticLoadBalancingRequest
    {
        private string _loadBalancerName;
        private List<string> _subnets = new List<string>();

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The name associated with the load balancer. The name must be unique within the set
        /// of load balancers associated with your AWS account. 
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

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        ///  A list of subnet IDs to add for the load balancer. You can add only one subnet per
        /// Availability Zone. 
        /// </para>
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

    }
}