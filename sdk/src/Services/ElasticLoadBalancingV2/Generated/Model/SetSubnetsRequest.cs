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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the SetSubnets operation.
    /// Enables the Availability Zone for the specified public subnets for the specified Application
    /// Load Balancer. The specified subnets replace the previously enabled subnets.
    /// 
    ///  
    /// <para>
    /// Note that you can't change the subnets for a Network Load Balancer.
    /// </para>
    /// </summary>
    public partial class SetSubnetsRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _loadBalancerArn;
        private List<SubnetMapping> _subnetMappings = new List<SubnetMapping>();
        private List<string> _subnets = new List<string>();

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerArn
        {
            get { return this._loadBalancerArn; }
            set { this._loadBalancerArn = value; }
        }

        // Check to see if LoadBalancerArn property is set
        internal bool IsSetLoadBalancerArn()
        {
            return this._loadBalancerArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetMappings. 
        /// <para>
        /// The IDs of the public subnets. You must specify subnets from at least two Availability
        /// Zones. You can specify only one subnet per Availability Zone. You must specify either
        /// subnets or subnet mappings.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify Elastic IP addresses for your subnets.
        /// </para>
        /// </summary>
        public List<SubnetMapping> SubnetMappings
        {
            get { return this._subnetMappings; }
            set { this._subnetMappings = value; }
        }

        // Check to see if SubnetMappings property is set
        internal bool IsSetSubnetMappings()
        {
            return this._subnetMappings != null && this._subnetMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of the public subnets. You must specify subnets from at least two Availability
        /// Zones. You can specify only one subnet per Availability Zone. You must specify either
        /// subnets or subnet mappings.
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