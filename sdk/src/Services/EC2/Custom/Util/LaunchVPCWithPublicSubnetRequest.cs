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
    /// The properties used to create a VPC with a subnet that will have an internet gateway attached making instances available to the internet.
    /// </summary>
    public class LaunchVPCWithPublicSubnetRequest
    {
        string vpcName;
        string vpcCidrBlock = "10.0.0.0/16";
        string instanceTenancy = "default";

        string publicSubnetCiderBlock = "10.0.0.0/24";
        string publicSubnetAvailabilityZone;

        bool? enableDnsHostnames;
        bool? enableDnsSupport;

        /// <summary>
        /// Gets and sets a name that will be assigned the VPC's Name tag.  This is an optional field.
        /// </summary>
        public string VPCName
        {
            get { return this.vpcName; }
            set { this.vpcName = value; }
        }

        /// <summary>
        /// Gets and sets the CIDR block you want the VPC to cover.  The default value is "10.0.0.0/16".
        /// </summary>
        public string VPCCidrBlock
        {
            get { return this.vpcCidrBlock; }
            set { this.vpcCidrBlock = value; }
        }

        /// <summary>
        /// The supported tenancy of instances launched into the VPC.  The default value is "default".
        /// </summary>
        /// <remarks>
        /// A value of "default" means instances can be launched with any tenancy;
        /// a value of "dedicated" means all instances launched into the VPC will
        /// be launched as dedicated tenancy instances regardless of the tenancy
        /// assigned to the instance at launch.
        /// 
        /// Setting the instance's tenancy attribute to dedicated specifies that your
        /// instance will run on single-tenant hardware.
        /// </remarks>
        public string InstanceTenancy
        {
            get { return this.instanceTenancy; }
            set { this.instanceTenancy = value; }
        }

        /// <summary>
        /// Gets and sets the CIDR block you want the public subnet to cover.  The default value is "10.0.0.0/24".
        /// </summary>
        public string PublicSubnetCiderBlock
        {
            get { return this.publicSubnetCiderBlock; }
            set { this.publicSubnetCiderBlock = value; }
        }


        /// <summary>
        /// Gets and sets the Availability Zone you want the public subnet in.
        /// </summary>
        public string PublicSubnetAvailabilityZone
        {
            get { return this.publicSubnetAvailabilityZone; }
            set { this.publicSubnetAvailabilityZone = value; }
        }

        /// <summary>
        /// A callback delegate used to get progress messages as the VPC environment is being created.
        /// </summary>
        public Amazon.EC2.Util.VPCUtilities.Progress ProgressCallback
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates whether the instances launched in the VPC get DNS hostnames. If this attribute is true, instances in the VPC get DNS hostnames; 
        /// otherwise, they do not. If you want your instances to get DNS hostnames, you must also set the enableDnsSupport attribute to true. 
        /// </summary>
        public bool EnableDnsHostnames
        {
            get { return enableDnsHostnames.GetValueOrDefault(); }
            set { enableDnsHostnames = value; }
        }

        // Check to see if EnableDnsHostnames property is set
        internal bool IsSetEnableDnsHostnames()
        {
            return enableDnsHostnames.HasValue;
        }

        /// <summary>
        /// Indicates whether the DNS resolution is supported for the VPC. If this attribute is false, the Amazon provided DNS service in the VPC that 
        /// resolves public DNS hostnames to IP addresses is not enabled. If this attribute is true, queries to the Amazon provided DNS server at the 
        /// 169.254.169.253 IP address, or the reserved IP address at the base of the VPC network range "plus two" will succeed. For more information, 
        /// see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html#AmazonDNS">Amazon DNS Server</a>.
        /// </summary>
        public bool EnableDnsSupport
        {
            get { return enableDnsSupport.GetValueOrDefault(); }
            set { enableDnsSupport = value; }
        }

        // Check to see if EnableDnsSupport property is set
        internal bool IsSetEnableDnsSupport()
        {
            return enableDnsSupport.HasValue;
        }
    }
}
