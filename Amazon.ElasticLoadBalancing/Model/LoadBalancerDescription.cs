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
    ///<summary>
    ///A LoadBalancer is represented by a DNS name and a set of ports and provides the destination to which all requests intended
    ///for your application should be directed. Each LoadBalancer can distribute requests to multiple application instances.
    ///LoadBalancers can span multiple Availability Zones within an EC2 region, but cannot span multiple regions.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class LoadBalancerDescription
    {
        private string loadBalancerNameField;
        private string DNSNameField;
        private List<Listener> listenersField;
        private List<string> availabilityZonesField;
        private List<Instance> instancesField;
        private HealthCheck healthCheckField;
        private string createdTimeField;

        /// <summary>
        /// Gets and sets the LoadBalancerName property.
        /// The mnemonic name associated with the LoadBalancer.
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
        /// <param name="loadBalancerName">The mnemonic name associated with the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithLoadBalancerName(string loadBalancerName)
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
        /// Gets and sets the DNSName property.
        /// External DNS name associated with the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "DNSName")]
        public string DNSName
        {
            get { return this.DNSNameField ; }
            set { this.DNSNameField= value; }
        }

        /// <summary>
        /// Sets the DNSName property
        /// </summary>
        /// <param name="DNSName">External DNS name associated with the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithDNSName(string DNSName)
        {
            this.DNSNameField = DNSName;
            return this;
        }

        /// <summary>
        /// Checks if DNSName property is set
        /// </summary>
        /// <returns>true if DNSName property is set</returns>
        public bool IsSetDNSName()
        {
            return  this.DNSNameField != null;
        }
        /// <summary>
        /// Gets and sets the Listeners property.
        /// A listener is a set of protocol, load balancer port, and instance port to which requests are forwarded.
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
        /// <param name="list">A listener is a set of protocol, load balancer port, and instance port to which requests are forwarded.</param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithListeners(params Listener[] list)
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
        /// List of Availability Zones.
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
        /// <param name="list">List of Availability Zones.</param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithAvailabilityZones(params string[] list)
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
        /// <summary>
        /// Gets and sets the Instances property.
        /// List of instance IDs. EC2 instances comprise the instances for the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "Instances")]
        public List<Instance> Instances
        {
            get
            {
                if (this.instancesField == null)
                {
                    this.instancesField = new List<Instance>();
                }
                return this.instancesField;
            }
            set { this.instancesField = value; }
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="list">List of instance IDs. EC2 instances comprise the instances for the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithInstances(params Instance[] list)
        {
            foreach (Instance item in list)
            {
                Instances.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Instances property is set
        /// </summary>
        /// <returns>true if Instances property is set</returns>
        public bool IsSetInstances()
        {
            return (Instances.Count > 0);
        }

        /// <summary>
        /// Gets and sets the HealthCheck property.
        /// Structure containing the various health probes conducted on the LoadBalancer.
        /// </summary>
        [XmlElementAttribute(ElementName = "HealthCheck")]
        public HealthCheck HealthCheck
        {
            get { return this.healthCheckField ; }
            set { this.healthCheckField = value; }
        }

        /// <summary>
        /// Sets the HealthCheck property
        /// </summary>
        /// <param name="healthCheck">Structure containing the various health probes conducted on the LoadBalancer.</param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithHealthCheck(HealthCheck healthCheck)
        {
            this.healthCheckField = healthCheck;
            return this;
        }

        /// <summary>
        /// Checks if HealthCheck property is set
        /// </summary>
        /// <returns>true if HealthCheck property is set</returns>
        public bool IsSetHealthCheck()
        {
            return this.healthCheckField != null;
        }

        /// <summary>
        /// Gets and sets the CreatedTime property.
        /// Time that the LoadBalancer was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreatedTime")]
        public string CreatedTime
        {
            get { return this.createdTimeField ; }
            set { this.createdTimeField= value; }
        }

        /// <summary>
        /// Sets the CreatedTime property
        /// </summary>
        /// <param name="createdTime">Time that the LoadBalancer was created.</param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithCreatedTime(string createdTime)
        {
            this.createdTimeField = createdTime;
            return this;
        }

        /// <summary>
        /// Checks if CreatedTime property is set
        /// </summary>
        /// <returns>true if CreatedTime property is set</returns>
        public bool IsSetCreatedTime()
        {
            return  this.createdTimeField != null;
        }

    }
}
