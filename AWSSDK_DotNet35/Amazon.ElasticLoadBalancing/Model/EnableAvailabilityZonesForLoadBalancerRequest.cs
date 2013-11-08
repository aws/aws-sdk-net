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
    /// Container for the parameters to the EnableAvailabilityZonesForLoadBalancer operation.
    /// <para> Adds one or more EC2 Availability Zones to the load balancer. </para> <para> The load balancer evenly distributes requests across all
    /// its registered Availability Zones that contain instances. </para> <para><b>NOTE:</b> The new EC2 Availability Zones to be added must be in
    /// the same EC2 Region as the Availability Zones for which the load balancer was created. </para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_AddLBAvailabilityZone.html" >Expand a Load Balanced
    /// Application to an Additional Availability Zone</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para>
    /// </summary>
    public partial class EnableAvailabilityZonesForLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private string loadBalancerName;
        private List<string> availabilityZones = new List<string>();

        /// <summary>
        /// Default constructor for a new EnableAvailabilityZonesForLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public EnableAvailabilityZonesForLoadBalancerRequest() {}
    
        /// <summary>
        /// Constructs a new EnableAvailabilityZonesForLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="availabilityZones"> A list of new Availability Zones for the load balancer. Each Availability Zone must be in the same region
        /// as the load balancer. </param>
        public EnableAvailabilityZonesForLoadBalancerRequest(string loadBalancerName, List<string> availabilityZones)
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
        /// A list of new Availability Zones for the load balancer. Each Availability Zone must be in the same region as the load balancer.
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
    
