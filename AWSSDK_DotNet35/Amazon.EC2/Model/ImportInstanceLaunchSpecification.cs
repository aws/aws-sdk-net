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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImportInstanceLaunchSpecification
    {
        
        private ArchitectureValues architecture;
        private List<string> groupNames = new List<string>();
        private string additionalInfo;
        private string userData;
        private InstanceType instanceType;
        private Placement placement;
        private bool? monitoring;
        private string subnetId;
        private ShutdownBehavior instanceInitiatedShutdownBehavior;
        private string privateIpAddress;


        /// <summary>
        /// The architecture of the instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>i386, x86_64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ArchitectureValues Architecture
        {
            get { return this.architecture; }
            set { this.architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this.architecture != null;
        }

        /// <summary>
        /// One or more security group names.
        ///  
        /// </summary>
        public List<string> GroupNames
        {
            get { return this.groupNames; }
            set { this.groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this.groupNames.Count > 0;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string AdditionalInfo
        {
            get { return this.additionalInfo; }
            set { this.additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this.additionalInfo != null;
        }

        /// <summary>
        /// User data to be made available to the instance.
        ///  
        /// </summary>
        public string UserData
        {
            get { return this.userData; }
            set { this.userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this.userData != null;
        }

        /// <summary>
        /// The instance type. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>t1.micro, m1.small, m1.medium, m1.large, m1.xlarge, m3.xlarge, m3.2xlarge, m2.xlarge, m2.2xlarge, m2.4xlarge, cr1.8xlarge, i2.xlarge, i2.2xlarge, i2.4xlarge, i2.8xlarge, hi1.4xlarge, hs1.8xlarge, c1.medium, c1.xlarge, c3.large, c3.xlarge, c3.2xlarge, c3.4xlarge, c3.8xlarge, cc1.4xlarge, cc2.8xlarge, g2.2xlarge, cg1.4xlarge</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public Placement Placement
        {
            get { return this.placement; }
            set { this.placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this.placement != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public bool Monitoring
        {
            get { return this.monitoring ?? default(bool); }
            set { this.monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this.monitoring.HasValue;
        }

        /// <summary>
        /// [EC2-VPC] The ID of the subnet to launch the instance into.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// Indicates whether an instance stops or terminates when you initiate shutdown from the instance (using the operating system command for
        /// system shutdown).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>stop, terminate</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ShutdownBehavior InstanceInitiatedShutdownBehavior
        {
            get { return this.instanceInitiatedShutdownBehavior; }
            set { this.instanceInitiatedShutdownBehavior = value; }
        }

        // Check to see if InstanceInitiatedShutdownBehavior property is set
        internal bool IsSetInstanceInitiatedShutdownBehavior()
        {
            return this.instanceInitiatedShutdownBehavior != null;
        }

        /// <summary>
        /// [EC2-VPC] Optionally, you can use this parameter to assign the instance a specific available IP address from the IP address range of the
        /// subnet.
        ///  
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this.privateIpAddress; }
            set { this.privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddress != null;
        }
    }
}
