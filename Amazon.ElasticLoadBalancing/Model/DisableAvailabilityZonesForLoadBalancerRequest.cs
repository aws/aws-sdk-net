/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Removes the specified EC2 Availability Zones from the set of configured Availability Zones for the LoadBalancer. Once an
    /// Availability Zone is removed, all the instances registered with the LoadBalancer that are in the removed Availability Zone
    /// go into the OutOfService state. Upon Availability Zone removal, the LoadBalancer attempts to equally balance the traffic
    /// among its remaining usable Availability Zones. Trying to remove an Availability Zone that was not associated with the
    /// LoadBalancer does nothing.
    ///
    /// There must be at least one Availability Zone registered with a LoadBalancer at all times. You cannot remove all the Availability
    /// Zones from a LoadBalancer.
    ///
    /// In order for this call to be successful, you must have created the LoadBalancer. In other words, in order to successfully call
    /// this API, you must provide the same account credentials as those that were used to create the LoadBalancer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DisableAvailabilityZonesForLoadBalancerRequest
    {
        private string loadBalancerNameField;
        private List<string> availabilityZonesField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The mnemonic name associated with the LoadBalancer. The name must be unique within your AWS account.
        /// Must only use alphanumeric characters (case sensitive) and dash (-). Dash cannot be first or last character. Maximum
        /// length of name is 32 characters (characters are 16-bit Unicode).
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerName")]
        public string LoadBalancerName
        {
            get { return this.loadBalancerNameField; }
            set { this.loadBalancerNameField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The mnemonic name associated with the LoadBalancer. The name must be unique within your AWS account.
        /// Must only use alphanumeric characters (case sensitive) and dash (-). Dash cannot be first or last character. Maximum
        /// length of name is 32 characters (characters are 16-bit Unicode).</param>
        /// <returns>this instance</returns>
        public DisableAvailabilityZonesForLoadBalancerRequest WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerNameField = loadBalancerName;
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerName property is set
        /// </summary>
        /// <returns>true if LoadBalancerName property is set</returns>
        public bool IsSetLoadBalancerName()
        {
            return this.loadBalancerNameField != null;
        }

        /// <summary>
        /// Gets and sets the AvailabilityZones property.
        /// List of Availability Zones to be removed from the LoadBalancer. There must be at least one Availability Zone
        /// registered with a LoadBalancer at all times. You cannot remove all the Availability Zones from a LoadBalancer.
        /// Specified Availability Zones must be in the same region.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZones")]
        public List<string> AvailabilityZones
        {
            get
            {
                if (this.availabilityZonesField == null)
                {
                    this.availabilityZonesField = new List<string>();
                }
                return this.availabilityZonesField;
            }
            set { this.availabilityZonesField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZones property
        /// </summary>
        /// <param name="list">List of Availability Zones to be removed from the LoadBalancer. There must be at least one Availability Zone
        /// registered with a LoadBalancer at all times. You cannot remove all the Availability Zones from a LoadBalancer.
        /// Specified Availability Zones must be in the same region.</param>
        /// <returns>this instance</returns>
        public DisableAvailabilityZonesForLoadBalancerRequest WithAvailabilityZones(params string[] list)
        {
            foreach (string item in list)
            {
                AvailabilityZones.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZones property is set
        /// </summary>
        /// <returns>true if AvailabilityZones property is set</returns>
        public bool IsSetAvailabilityZones()
        {
            return (AvailabilityZones.Count > 0);
        }

    }
}
