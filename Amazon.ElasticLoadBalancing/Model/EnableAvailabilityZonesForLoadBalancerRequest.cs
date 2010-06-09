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
    /// This API is used to add one or more EC2 Availability Zones to the LoadBalancer. The LoadBalancer evenly distributes requests
    /// across all its registered Availability Zones that contain instances. As a result, you must ensure that your LoadBalancer is
    /// appropriately scaled for each registered Availability Zone. The new EC2 Availability Zones to be added must be in the same
    /// EC2 region as the Availability Zones for which the LoadBalancer was created. In order to successfully call this API, you must
    /// provide the same account credentials as those that were used to create the LoadBalancer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class EnableAvailabilityZonesForLoadBalancerRequest
    {
        private string loadBalancerNameField;
        private List<string> availabilityZonesField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The mnemonic name associated with the LoadBalancer. The name must be unique within your AWS account.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerName")]
        public string LoadBalancerName
        {
            get { return this.loadBalancerNameField ; }
            set { this.loadBalancerNameField= value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The mnemonic name associated with the LoadBalancer. The name must be unique within your AWS account.</param>
        /// <returns>this instance</returns>
        public EnableAvailabilityZonesForLoadBalancerRequest WithLoadBalancerName(string loadBalancerName)
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
            return  this.loadBalancerNameField != null;
        }

        /// <summary>
        /// Gets and sets the AvailabilityZones property.
        /// List of new Availability Zones for the LoadBalancer. The Availability Zone must be in the same region as
        /// the LoadBalancer.
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
        /// <param name="list">List of new Availability Zones for the LoadBalancer. The Availability Zone must be in the same region as
        /// the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public EnableAvailabilityZonesForLoadBalancerRequest WithAvailabilityZones(params string[] list)
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
