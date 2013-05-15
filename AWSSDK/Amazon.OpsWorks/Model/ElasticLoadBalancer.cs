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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes an Elastic Load Balancing instance.</para>
    /// </summary>
    public class ElasticLoadBalancer
    {
        
        private string elasticLoadBalancerName;
        private string region;
        private string dnsName;
        private string stackId;
        private string layerId;
        private List<string> availabilityZones = new List<string>();
        private List<string> ec2InstanceIds = new List<string>();

        /// <summary>
        /// The Elastic Load Balancing instance's name.
        ///  
        /// </summary>
        public string ElasticLoadBalancerName
        {
            get { return this.elasticLoadBalancerName; }
            set { this.elasticLoadBalancerName = value; }
        }

        /// <summary>
        /// Sets the ElasticLoadBalancerName property
        /// </summary>
        /// <param name="elasticLoadBalancerName">The value to set for the ElasticLoadBalancerName property </param>
        /// <returns>this instance</returns>
        public ElasticLoadBalancer WithElasticLoadBalancerName(string elasticLoadBalancerName)
        {
            this.elasticLoadBalancerName = elasticLoadBalancerName;
            return this;
        }
            

        // Check to see if ElasticLoadBalancerName property is set
        internal bool IsSetElasticLoadBalancerName()
        {
            return this.elasticLoadBalancerName != null;
        }

        /// <summary>
        /// The instance's AWS region.
        ///  
        /// </summary>
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        public ElasticLoadBalancer WithRegion(string region)
        {
            this.region = region;
            return this;
        }
            

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this.region != null;
        }

        /// <summary>
        /// The instance's public DNS name.
        ///  
        /// </summary>
        public string DnsName
        {
            get { return this.dnsName; }
            set { this.dnsName = value; }
        }

        /// <summary>
        /// Sets the DnsName property
        /// </summary>
        /// <param name="dnsName">The value to set for the DnsName property </param>
        /// <returns>this instance</returns>
        public ElasticLoadBalancer WithDnsName(string dnsName)
        {
            this.dnsName = dnsName;
            return this;
        }
            

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this.dnsName != null;
        }

        /// <summary>
        /// The ID of the stack that the instance is associated with.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        public ElasticLoadBalancer WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The ID of the layer that the instance is attached to.
        ///  
        /// </summary>
        public string LayerId
        {
            get { return this.layerId; }
            set { this.layerId = value; }
        }

        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        public ElasticLoadBalancer WithLayerId(string layerId)
        {
            this.layerId = layerId;
            return this;
        }
            

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
        }

        /// <summary>
        /// The instance's Availability Zones.
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
        public ElasticLoadBalancer WithAvailabilityZones(params string[] availabilityZones)
        {
            foreach (string element in availabilityZones)
            {
                this.availabilityZones.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AvailabilityZones collection
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        public ElasticLoadBalancer WithAvailabilityZones(IEnumerable<string> availabilityZones)
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
        /// A list of the EC2 instances that the Elastic Load Balancing instance is managing traffic for.
        ///  
        /// </summary>
        public List<string> Ec2InstanceIds
        {
            get { return this.ec2InstanceIds; }
            set { this.ec2InstanceIds = value; }
        }
        /// <summary>
        /// Adds elements to the Ec2InstanceIds collection
        /// </summary>
        /// <param name="ec2InstanceIds">The values to add to the Ec2InstanceIds collection </param>
        /// <returns>this instance</returns>
        public ElasticLoadBalancer WithEc2InstanceIds(params string[] ec2InstanceIds)
        {
            foreach (string element in ec2InstanceIds)
            {
                this.ec2InstanceIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Ec2InstanceIds collection
        /// </summary>
        /// <param name="ec2InstanceIds">The values to add to the Ec2InstanceIds collection </param>
        /// <returns>this instance</returns>
        public ElasticLoadBalancer WithEc2InstanceIds(IEnumerable<string> ec2InstanceIds)
        {
            foreach (string element in ec2InstanceIds)
            {
                this.ec2InstanceIds.Add(element);
            }

            return this;
        }

        // Check to see if Ec2InstanceIds property is set
        internal bool IsSetEc2InstanceIds()
        {
            return this.ec2InstanceIds.Count > 0;
        }
    }
}
