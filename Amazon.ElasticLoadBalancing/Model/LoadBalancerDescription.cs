/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The LoadBalancerDescription data type. </para>
    /// </summary>
    public class LoadBalancerDescription  
    {
        
        private string loadBalancerName;
        private string dNSName;
        private List<ListenerDescription> listenerDescriptions = new List<ListenerDescription>();
        private Policies policies;
        private List<string> availabilityZones = new List<string>();
        private List<Instance> instances = new List<Instance>();
        private HealthCheck healthCheck;
        private DateTime? createdTime;
        /// <summary>
        /// Default constructor for a new LoadBalancerDescription object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public LoadBalancerDescription() {}
    

        /// <summary>
        /// Specifies the name associated with the LoadBalancer.
        ///  
        /// </summary>
        public string LoadBalancerName
        {
            get { return this.loadBalancerName; }
            set { this.loadBalancerName = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerName property
        /// </summary>
        /// <param name="loadBalancerName">The value to set for the LoadBalancerName property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithLoadBalancerName(string loadBalancerName)
        {
            this.loadBalancerName = loadBalancerName;
            return this;
        }
            
        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this.loadBalancerName != null;       
        }

        /// <summary>
        /// Specifies the external DNS name associated with the LoadBalancer.
        ///  
        /// </summary>
        public string DNSName
        {
            get { return this.dNSName; }
            set { this.dNSName = value; }
        }

        /// <summary>
        /// Sets the DNSName property
        /// </summary>
        /// <param name="dNSName">The value to set for the DNSName property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithDNSName(string dNSName)
        {
            this.dNSName = dNSName;
            return this;
        }
            
        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this.dNSName != null;        
        }

        /// <summary>
        /// LoadBalancerPort, InstancePort, Protocol, and PolicyNames are returned
        /// in a list of tuples in the ListenerDescriptions element.
        ///  
        /// </summary>
        public List<ListenerDescription> ListenerDescriptions
        {
            get { return this.listenerDescriptions; }
            set { this.listenerDescriptions = value; }
        }
        /// <summary>
        /// Adds elements to the ListenerDescriptions collection
        /// </summary>
        /// <param name="listenerDescriptions">The values to add to the ListenerDescriptions collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithListenerDescriptions(params ListenerDescription[] listenerDescriptions)
        {
            foreach (ListenerDescription element in listenerDescriptions)
            {
                this.listenerDescriptions.Add(element);
            }

            return this;
        }
        // Check to see if ListenerDescriptions property is set
        internal bool IsSetListenerDescriptions()
        {
            return this.listenerDescriptions.Count > 0;         
        }

        /// <summary>
        /// Provides a list of policies defined for the LoadBalancer.
        ///  
        /// </summary>
        public Policies Policies
        {
            get { return this.policies; }
            set { this.policies = value; }
        }

        /// <summary>
        /// Sets the Policies property
        /// </summary>
        /// <param name="policies">The value to set for the Policies property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithPolicies(Policies policies)
        {
            this.policies = policies;
            return this;
        }
            
        // Check to see if Policies property is set
        internal bool IsSetPolicies()
        {
            return this.policies != null;       
        }

        /// <summary>
        /// Specifies a list of Availability Zones.
        ///  
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this.availabilityZones; }
            set { this.availabilityZones = value; }
        }
        /// <summary>
        /// Adds elements to the AvailabilityZones collection
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithAvailabilityZones(params string[] availabilityZones)
        {
            foreach (string element in availabilityZones)
            {
                this.availabilityZones.Add(element);
            }

            return this;
        }
        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this.availabilityZones.Count > 0;        
        }

        /// <summary>
        /// Provides a list of EC2 instance IDs for the LoadBalancer.
        ///  
        /// </summary>
        public List<Instance> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithInstances(params Instance[] instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
        }
        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;        
        }

        /// <summary>
        /// Specifies information regarding the various health probes conducted on
        /// the LoadBalancer.
        ///  
        /// </summary>
        public HealthCheck HealthCheck
        {
            get { return this.healthCheck; }
            set { this.healthCheck = value; }
        }

        /// <summary>
        /// Sets the HealthCheck property
        /// </summary>
        /// <param name="healthCheck">The value to set for the HealthCheck property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithHealthCheck(HealthCheck healthCheck)
        {
            this.healthCheck = healthCheck;
            return this;
        }
            
        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this.healthCheck != null;        
        }

        /// <summary>
        /// Provides the date and time the LoadBalancer was created.
        ///  
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this.createdTime ?? default(DateTime); }
            set { this.createdTime = value; }
        }

        /// <summary>
        /// Sets the CreatedTime property
        /// </summary>
        /// <param name="createdTime">The value to set for the CreatedTime property </param>
        /// <returns>this instance</returns>
        public LoadBalancerDescription WithCreatedTime(DateTime createdTime)
        {
            this.createdTime = createdTime;
            return this;
        }
            
        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this.createdTime.HasValue;       
        }
    }
}
