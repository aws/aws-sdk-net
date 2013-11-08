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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the DisableAvailabilityZonesForLoadBalancer operation.
    /// <para> Removes the specified EC2 Availability Zones from the set of configured Availability Zones for the load balancer. </para> <para>
    /// There must be at least one Availability Zone registered with a load balancer at all times. Once an Availability Zone is removed, all the
    /// instances registered with the load balancer that are in the removed Availability Zone go into the <i>OutOfService</i> state. Upon
    /// Availability Zone removal, the load balancer attempts to equally balance the traffic among its remaining usable Availability Zones. Trying
    /// to remove an Availability Zone that was not associated with the load balancer does nothing. </para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_ShrinkLBApp04.html" >Disable an Availability Zone from a
    /// Load-Balanced Application</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// </summary>
    public partial class DisableAvailabilityZonesForLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private List<string> availabilityZones = new List<string>();

        /// <summary>
        /// Default constructor for a new DisableAvailabilityZonesForLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DisableAvailabilityZonesForLoadBalancerRequest() {}
    
        /// <summary>
        /// Constructs a new DisableAvailabilityZonesForLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="availabilityZones"> A list of Availability Zones to be removed from the load balancer. <note> There must be at least one
        /// Availability Zone registered with a load balancer at all times. Specified Availability Zones must be in the same region. </note> </param>
        public DisableAvailabilityZonesForLoadBalancerRequest(string loadBalancerName, List<string> availabilityZones)
        {
            this.loadBalancerName = loadBalancerName;
            this.availabilityZones = availabilityZones;
        }
    

        /// <summary>
        /// The name associated with the load balancer.
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
        /// A list of Availability Zones to be removed from the load balancer. <note> There must be at least one Availability Zone registered with a
        /// load balancer at all times. Specified Availability Zones must be in the same region. </note>
        ///  
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this.availabilityZones; }
            set { this.availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this.availabilityZones.Count > 0;
        }

    }
}
    
