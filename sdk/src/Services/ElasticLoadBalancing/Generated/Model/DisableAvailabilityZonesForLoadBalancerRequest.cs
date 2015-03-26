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
    /// Container for the parameters to the DisableAvailabilityZonesForLoadBalancer operation.
    /// Removes the specified EC2 Availability Zones from the set of configured Availability
    /// Zones for the load balancer. 
    /// 
    ///  
    /// <para>
    ///  There must be at least one Availability Zone registered with a load balancer at all
    /// times. Once an Availability Zone is removed, all the instances registered with the
    /// load balancer that are in the removed Availability Zone go into the <i>OutOfService</i>
    /// state. Upon Availability Zone removal, the load balancer attempts to equally balance
    /// the traffic among its remaining usable Availability Zones. Trying to remove an Availability
    /// Zone that was not associated with the load balancer does nothing. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_ShrinkLBApp04.html">Disable
    /// an Availability Zone from a Load-Balanced Application</a> in the <i>Elastic Load Balancing
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DisableAvailabilityZonesForLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private List<string> _availabilityZones = new List<string>();
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DisableAvailabilityZonesForLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates DisableAvailabilityZonesForLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="availabilityZones"> A list of Availability Zones to be removed from the load balancer.  <note> There must be at least one Availability Zone registered with a load balancer at all times. Specified Availability Zones must be in the same region. </note></param>
        public DisableAvailabilityZonesForLoadBalancerRequest(string loadBalancerName, List<string> availabilityZones)
        {
            _loadBalancerName = loadBalancerName;
            _availabilityZones = availabilityZones;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///  A list of Availability Zones to be removed from the load balancer. 
        /// </para>
        ///  <note> There must be at least one Availability Zone registered with a load balancer
        /// at all times. Specified Availability Zones must be in the same region. </note>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The name associated with the load balancer. 
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

    }
}