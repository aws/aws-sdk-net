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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIpPools operation.
    /// [Application Load Balancers] Modify the IP pool associated to a load balancer.
    /// </summary>
    public partial class ModifyIpPoolsRequest : AmazonElasticLoadBalancingV2Request
    {
        private IpamPools _ipamPools;
        private string _loadBalancerArn;
        private List<string> _removeIpamPools = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IpamPools. 
        /// <para>
        /// The IPAM pools to be modified.
        /// </para>
        /// </summary>
        public IpamPools IpamPools
        {
            get { return this._ipamPools; }
            set { this._ipamPools = value; }
        }

        // Check to see if IpamPools property is set
        internal bool IsSetIpamPools()
        {
            return this._ipamPools != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RemoveIpamPools. 
        /// <para>
        /// Remove the IP pools in use by the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveIpamPools
        {
            get { return this._removeIpamPools; }
            set { this._removeIpamPools = value; }
        }

        // Check to see if RemoveIpamPools property is set
        internal bool IsSetRemoveIpamPools()
        {
            return this._removeIpamPools != null && (this._removeIpamPools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}