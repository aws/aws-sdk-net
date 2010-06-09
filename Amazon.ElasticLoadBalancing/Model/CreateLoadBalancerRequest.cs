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
    /// Creates a new LoadBalancer.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class CreateLoadBalancerRequest
    {
        private string loadBalancerNameField;
        private List<Listener> listenersField;
        private List<string> availabilityZonesField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The mnemonic name associated with the LoadBalancer. The name must be unique within your set of LoadBalancers
        /// requests on the specified protocol and received by Elastic Load Balancing on the LoadBalancerPort are load balanced
        /// across the registered instances and sent to port InstancePort.
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
        /// <param name="loadBalancerName">The mnemonic name associated with the LoadBalancer. The name must be unique within your set of LoadBalancers
        /// requests on the specified protocol and received by Elastic Load Balancing on the LoadBalancerPort are load balanced
        /// across the registered instances and sent to port InstancePort.</param>
        /// <returns>this instance</returns>
        public CreateLoadBalancerRequest WithLoadBalancerName(string loadBalancerName)
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
        /// Gets and sets the Listeners property.
        /// This parameter is used to denote a list of the following tuples LoadBalancerPort, InstancePort, and Protocol.
        /// </summary>
        [XmlElementAttribute(ElementName = "Listeners")]
        public List<Listener> Listeners
        {
            get
            {
                if (this.listenersField == null)
                {
                    this.listenersField = new List<Listener>();
                }
                return this.listenersField;
            }
            set { this.listenersField = value; }
        }

        /// <summary>
        /// Sets the Listeners property
        /// </summary>
        /// <param name="list">This parameter is used to denote a list of the following tuples LoadBalancerPort, InstancePort, and Protocol.</param>
        /// <returns>this instance</returns>
        public CreateLoadBalancerRequest WithListeners(params Listener[] list)
        {
            foreach (Listener item in list)
            {
                Listeners.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Listeners property is set
        /// </summary>
        /// <returns>true if Listeners property is set</returns>
        public bool IsSetListeners()
        {
            return (Listeners.Count > 0);
        }

        /// <summary>
        /// Gets and sets the AvailabilityZones property.
        /// List of Availability Zones. This list can be modified after the creation of the LoadBalancer. The Availability
        /// Zones specified must be in the same EC2 region as the LoadBalancer. You must specify at least one Availability Zone.
        /// Traffic will be equally distributed across all zones.
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
        /// <param name="list">List of Availability Zones. This list can be modified after the creation of the LoadBalancer. The Availability
        /// Zones specified must be in the same EC2 region as the LoadBalancer. You must specify at least one Availability Zone.
        /// Traffic will be equally distributed across all zones.</param>
        /// <returns>this instance</returns>
        public CreateLoadBalancerRequest WithAvailabilityZones(params string[] list)
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
