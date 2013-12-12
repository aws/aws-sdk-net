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
        private string vpcId;
        private List<string> availabilityZones = new List<string>();
        private List<string> subnetIds = new List<string>();
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

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
        }

        /// <summary>
        /// The VPC ID.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// A list of Availability Zones.
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

        /// <summary>
        /// A list of subnet IDs, if the stack is running in a VPC.
        ///  
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this.subnetIds; }
            set { this.subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this.subnetIds.Count > 0;
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

        // Check to see if Ec2InstanceIds property is set
        internal bool IsSetEc2InstanceIds()
        {
            return this.ec2InstanceIds.Count > 0;
        }
    }
}
