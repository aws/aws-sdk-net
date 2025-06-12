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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DisableAvailabilityZonesForLoadBalancer operation.
    /// Removes the specified Availability Zones from the set of Availability Zones for the
    /// specified load balancer in EC2-Classic or a default VPC.
    /// 
    ///  
    /// <para>
    /// For load balancers in a non-default VPC, use <a>DetachLoadBalancerFromSubnets</a>.
    /// </para>
    ///  
    /// <para>
    /// There must be at least one Availability Zone registered with a load balancer at all
    /// times. After an Availability Zone is removed, all instances registered with the load
    /// balancer that are in the removed Availability Zone go into the <c>OutOfService</c>
    /// state. Then, the load balancer attempts to equally balance the traffic among its remaining
    /// Availability Zones.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-az.html">Add
    /// or Remove Availability Zones</a> in the <i>Classic Load Balancers Guide</i>.
    /// </para>
    /// </summary>
    public partial class DisableAvailabilityZonesForLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DisableAvailabilityZonesForLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates DisableAvailabilityZonesForLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        /// <param name="availabilityZones">The Availability Zones.</param>
        public DisableAvailabilityZonesForLoadBalancerRequest(string loadBalancerName, List<string> availabilityZones)
        {
            _loadBalancerName = loadBalancerName;
            _availabilityZones = availabilityZones;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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