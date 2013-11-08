/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.EC2.Util
{
    /// <summary>
    /// The properties used to create a VPC, a public subnet, private subnet and a NAT EC2 instance to allow EC2 instances in the private
    /// subnet to establish outbound connections to the internet.
    /// </summary>
    public class LaunchVPCWithPublicAndPrivateSubnetsRequest : LaunchVPCWithPublicSubnetRequest
    {
        string privateSubnetCiderBlock = "10.0.1.0/24";
        string privateSubnetAvailabilityZone;

        string instanceType = "m1.small";
        string keyName;

        /// <summary>
        /// Gets and sets the CIDR block you want the private subnet to cover.  The default value is "10.0.1.0/24".
        /// </summary>
        public string PrivateSubnetCiderBlock
        {
            get { return this.privateSubnetCiderBlock; }
            set { this.privateSubnetCiderBlock = value; }
        }

        /// <summary>
        /// Gets and sets the Availability Zone you want the private subnet in.
        /// </summary>
        public string PrivateSubnetAvailabilityZone
        {
            get { return this.privateSubnetAvailabilityZone; }
            set { this.privateSubnetAvailabilityZone = value; }
        }

        /// <summary>
        /// Gets and sets the instance type of the NAT instance.  The default value is "m1.small".
        /// </summary>
        public string InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        /// <summary>
        /// Gets and sets the key name of the NAT instance.
        /// </summary>
        public string KeyName
        {
            get { return this.keyName; }
            set { this.keyName = value; }
        }

        /// <summary>
        /// Gets and sets whether the default security group for the VPC should be configured to allow traffic from the EC2 instances to the NAT instance.
        /// This means another security group with the name "NATGroup" will be created and a new permission allowing all inbound traffic will be added to the default security group for the VPC.
        /// If this VPC is going to be used for AWS Elastic Beanstalk deployments then used this security group as the security group specified for the environment.
        /// </summary>
        public bool ConfigureDefaultVPCGroupForNAT
        {
            get;
            set;
        }
    }
}
