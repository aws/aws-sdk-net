/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes an Elastic Load Balancing instance.
    /// </summary>
    public partial class ElasticLoadBalancer
    {
        private List<string> _availabilityZones = new List<string>();
        private string _dnsName;
        private List<string> _ec2InstanceIds = new List<string>();
        private string _elasticLoadBalancerName;
        private string _layerId;
        private string _region;
        private string _stackId;
        private List<string> _subnetIds = new List<string>();
        private string _vpcId;


        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZones property
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithAvailabilityZones(params string[] availabilityZones)
        {
            foreach (var element in availabilityZones)
            {
                this._availabilityZones.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AvailabilityZones property
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithAvailabilityZones(IEnumerable<string> availabilityZones)
        {
            foreach (var element in availabilityZones)
            {
                this._availabilityZones.Add(element);
            }
            return this;
        }
        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The instance's public DNS name.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }


        /// <summary>
        /// Sets the DnsName property
        /// </summary>
        /// <param name="dnsName">The value to set for the DnsName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithDnsName(string dnsName)
        {
            this._dnsName = dnsName;
            return this;
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }


        /// <summary>
        /// Gets and sets the property Ec2InstanceIds. 
        /// <para>
        /// A list of the EC2 instances that the Elastic Load Balancing instance is managing traffic
        /// for.
        /// </para>
        /// </summary>
        public List<string> Ec2InstanceIds
        {
            get { return this._ec2InstanceIds; }
            set { this._ec2InstanceIds = value; }
        }

        /// <summary>
        /// Sets the Ec2InstanceIds property
        /// </summary>
        /// <param name="ec2InstanceIds">The values to add to the Ec2InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithEc2InstanceIds(params string[] ec2InstanceIds)
        {
            foreach (var element in ec2InstanceIds)
            {
                this._ec2InstanceIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Ec2InstanceIds property
        /// </summary>
        /// <param name="ec2InstanceIds">The values to add to the Ec2InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithEc2InstanceIds(IEnumerable<string> ec2InstanceIds)
        {
            foreach (var element in ec2InstanceIds)
            {
                this._ec2InstanceIds.Add(element);
            }
            return this;
        }
        // Check to see if Ec2InstanceIds property is set
        internal bool IsSetEc2InstanceIds()
        {
            return this._ec2InstanceIds != null && this._ec2InstanceIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ElasticLoadBalancerName. 
        /// <para>
        /// The Elastic Load Balancing instance's name.
        /// </para>
        /// </summary>
        public string ElasticLoadBalancerName
        {
            get { return this._elasticLoadBalancerName; }
            set { this._elasticLoadBalancerName = value; }
        }


        /// <summary>
        /// Sets the ElasticLoadBalancerName property
        /// </summary>
        /// <param name="elasticLoadBalancerName">The value to set for the ElasticLoadBalancerName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithElasticLoadBalancerName(string elasticLoadBalancerName)
        {
            this._elasticLoadBalancerName = elasticLoadBalancerName;
            return this;
        }

        // Check to see if ElasticLoadBalancerName property is set
        internal bool IsSetElasticLoadBalancerName()
        {
            return this._elasticLoadBalancerName != null;
        }


        /// <summary>
        /// Gets and sets the property LayerId. 
        /// <para>
        /// The ID of the layer that the instance is attached to.
        /// </para>
        /// </summary>
        public string LayerId
        {
            get { return this._layerId; }
            set { this._layerId = value; }
        }


        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithLayerId(string layerId)
        {
            this._layerId = layerId;
            return this;
        }

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this._layerId != null;
        }


        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The instance's AWS region.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }


        /// <summary>
        /// Sets the Region property
        /// </summary>
        /// <param name="region">The value to set for the Region property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithRegion(string region)
        {
            this._region = region;
            return this;
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack that the instance is associated with.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }


        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithStackId(string stackId)
        {
            this._stackId = stackId;
            return this;
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }


        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs, if the stack is running in a VPC.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        /// <summary>
        /// Sets the SubnetIds property
        /// </summary>
        /// <param name="subnetIds">The values to add to the SubnetIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithSubnetIds(params string[] subnetIds)
        {
            foreach (var element in subnetIds)
            {
                this._subnetIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SubnetIds property
        /// </summary>
        /// <param name="subnetIds">The values to add to the SubnetIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithSubnetIds(IEnumerable<string> subnetIds)
        {
            foreach (var element in subnetIds)
            {
                this._subnetIds.Add(element);
            }
            return this;
        }
        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }


        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ElasticLoadBalancer WithVpcId(string vpcId)
        {
            this._vpcId = vpcId;
            return this;
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}