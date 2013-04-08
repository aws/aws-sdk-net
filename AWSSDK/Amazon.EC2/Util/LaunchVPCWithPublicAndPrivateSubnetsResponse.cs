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

using Amazon.EC2.Model;

namespace Amazon.EC2.Util
{
    /// <summary>
    /// This object contains the VPC objects that were created as part of the launch VPC with public and private subnets operation.
    /// </summary>
    public class LaunchVPCWithPublicAndPrivateSubnetsResponse : LaunchVPCWithPublicSubnetResponse
    {
        /// <summary>
        /// The private subnet created.
        /// </summary>
        public Subnet PrivateSubnet
        {
            get;
            set;
        }

        /// <summary>
        /// The NAT EC2 instance created.
        /// </summary>
        public RunningInstance NATInstance
        {
            get;
            set;
        }

        /// <summary>
        /// The NAT security group created if the ConfigureDefaultVPCGroupForNAT property is set to true.
        /// </summary>
        public SecurityGroup NATSecurityGroup
        {
            get;
            set;
        }
    }
}
