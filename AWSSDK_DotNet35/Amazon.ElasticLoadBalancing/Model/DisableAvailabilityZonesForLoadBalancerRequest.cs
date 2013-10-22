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
    /// There must be at least one Availability Zone registered with a load balancer at all times. A client cannot remove all the Availability Zones
    /// from a load balancer. Once an Availability Zone is removed, all the instances registered with the load balancer that are in the removed
    /// Availability Zone go into the OutOfService state. Upon Availability Zone removal, the load balancer attempts to equally balance the traffic
    /// among its remaining usable Availability Zones. Trying to remove an Availability Zone that was not associated with the load balancer does
    /// nothing. </para> <para><b>NOTE:</b> In order for this call to be successful, the client must have created the load balancer. The client must
    /// provide the same account credentials as those that were used to create the load balancer. </para>
    /// </summary>
    public partial class DisableAvailabilityZonesForLoadBalancerRequest : AmazonWebServiceRequest
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
        /// <param name="loadBalancerName"> The name associated with the load balancer. The name must be unique within the client AWS account. </param>
        /// <param name="availabilityZones"> A list of Availability Zones to be removed from the load balancer. <note> There must be at least one
        /// Availability Zone registered with a load balancer at all times. The client cannot remove all the Availability Zones from a load balancer.
        /// Specified Availability Zones must be in the same Region. </note> </param>
        public DisableAvailabilityZonesForLoadBalancerRequest(string loadBalancerName, List<string> availabilityZones)
        {
            this.loadBalancerName = loadBalancerName;
            this.availabilityZones = availabilityZones;
        }
    

        /// <summary>
        /// The name associated with the load balancer. The name must be unique within the client AWS account.
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
        /// load balancer at all times. The client cannot remove all the Availability Zones from a load balancer. Specified Availability Zones must be
        /// in the same Region. </note>
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
    
