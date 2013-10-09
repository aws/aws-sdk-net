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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstance operation.
    /// <para>Creates an instance in a specified stack. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html" >Adding an Instance to a Layer</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateInstance"/>
    public class CreateInstanceRequest : AmazonWebServiceRequest
    {
        private string stackId;
        private List<string> layerIds = new List<string>();
        private string instanceType;
        private string autoScalingType;
        private string hostname;
        private string os;
        private string amiId;
        private string sshKeyName;
        private string availabilityZone;
        private string subnetId;
        private string architecture;
        private string rootDeviceType;
        private bool? installUpdatesOnBoot;

        /// <summary>
        /// The stack ID.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithStackId(string stackId)
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
        /// An array that contains the instance layer IDs.
        ///  
        /// </summary>
        public List<string> LayerIds
        {
            get { return this.layerIds; }
            set { this.layerIds = value; }
        }
        /// <summary>
        /// Adds elements to the LayerIds collection
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithLayerIds(params string[] layerIds)
        {
            foreach (string element in layerIds)
            {
                this.layerIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the LayerIds collection
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithLayerIds(IEnumerable<string> layerIds)
        {
            foreach (string element in layerIds)
            {
                this.layerIds.Add(element);
            }

            return this;
        }

        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this.layerIds.Count > 0;
        }

        /// <summary>
        /// The instance type. AWS OpsWorks supports all instance types except Cluster Compute, Cluster GPU, and High Memory Cluster. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance Families and Types</a>. The
        /// parameter values that you use to specify the various types are in the API Name column of the Available Instance Types table.
        ///  
        /// </summary>
        public string InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithInstanceType(string instanceType)
        {
            this.instanceType = instanceType;
            return this;
        }
            

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// The instance auto scaling type, which has three possible values: <ul> <li><b>AlwaysRunning</b>: A 24/7 instance, which is not affected by
        /// auto scaling.</li> <li><b>TimeBasedAutoScaling</b>: A time-based auto scaling instance, which is started and stopped based on a specified
        /// schedule. To specify the schedule, call <a>SetTimeBasedAutoScaling</a>.</li> <li><b>LoadBasedAutoScaling</b>: A load-based auto scaling
        /// instance, which is started and stopped based on load metrics. To use load-based auto scaling, you must enable it for the instance layer and
        /// configure the thresholds by calling <a>SetLoadBasedAutoScaling</a>.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>load, timer</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingType
        {
            get { return this.autoScalingType; }
            set { this.autoScalingType = value; }
        }

        /// <summary>
        /// Sets the AutoScalingType property
        /// </summary>
        /// <param name="autoScalingType">The value to set for the AutoScalingType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithAutoScalingType(string autoScalingType)
        {
            this.autoScalingType = autoScalingType;
            return this;
        }
            

        // Check to see if AutoScalingType property is set
        internal bool IsSetAutoScalingType()
        {
            return this.autoScalingType != null;
        }

        /// <summary>
        /// The instance host name.
        ///  
        /// </summary>
        public string Hostname
        {
            get { return this.hostname; }
            set { this.hostname = value; }
        }

        /// <summary>
        /// Sets the Hostname property
        /// </summary>
        /// <param name="hostname">The value to set for the Hostname property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithHostname(string hostname)
        {
            this.hostname = hostname;
            return this;
        }
            

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this.hostname != null;
        }

        /// <summary>
        /// The instance operating system, which must be set to one of the following. <ul> <li>Standard operating systems: <c>Amazon Linux</c> or
        /// <c>Ubuntu 12.04 LTS</c></li> <li>Custom AMIs: <c>Custom</c></li> </ul> The default option is <c>Amazon Linux</c>. If you set this parameter
        /// to <c>Custom</c>, you must use the <a>CreateInstance</a> action's AmiId parameter to specify the custom AMI that you want to use. For more
        /// information on the standard operating systems, see <a
        /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-os.html">Operating Systems</a>For more information on how to use
        /// custom AMIs with OpsWorks, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-custom-ami.html">Using Custom
        /// AMIs</a>.
        ///  
        /// </summary>
        public string Os
        {
            get { return this.os; }
            set { this.os = value; }
        }

        /// <summary>
        /// Sets the Os property
        /// </summary>
        /// <param name="os">The value to set for the Os property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithOs(string os)
        {
            this.os = os;
            return this;
        }
            

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this.os != null;
        }

        /// <summary>
        /// A custom AMI ID to be used to create the instance. The AMI should be based on one of the standard AWS OpsWorks APIs: Amazon Linux or Ubuntu
        /// 12.04 LTS. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances.html">Instances</a>
        ///  
        /// </summary>
        public string AmiId
        {
            get { return this.amiId; }
            set { this.amiId = value; }
        }

        /// <summary>
        /// Sets the AmiId property
        /// </summary>
        /// <param name="amiId">The value to set for the AmiId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithAmiId(string amiId)
        {
            this.amiId = amiId;
            return this;
        }
            

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this.amiId != null;
        }

        /// <summary>
        /// The instance SSH key name.
        ///  
        /// </summary>
        public string SshKeyName
        {
            get { return this.sshKeyName; }
            set { this.sshKeyName = value; }
        }

        /// <summary>
        /// Sets the SshKeyName property
        /// </summary>
        /// <param name="sshKeyName">The value to set for the SshKeyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithSshKeyName(string sshKeyName)
        {
            this.sshKeyName = sshKeyName;
            return this;
        }
            

        // Check to see if SshKeyName property is set
        internal bool IsSetSshKeyName()
        {
            return this.sshKeyName != null;
        }

        /// <summary>
        /// The instance Availability Zone. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions and
        /// Endpoints</a>.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The ID of the instance's subnet. If the stack is running in a VPC, you can use this parameter to override the stack's default subnet ID
        /// value and direct AWS OpsWorks to launch the instance in a different subnet.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        /// <summary>
        /// Sets the SubnetId property
        /// </summary>
        /// <param name="subnetId">The value to set for the SubnetId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithSubnetId(string subnetId)
        {
            this.subnetId = subnetId;
            return this;
        }
            

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// The instance architecture. Instance types do not necessarily support both architectures. For a list of the architectures that are supported
        /// by the different instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance Families and
        /// Types</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>x86_64, i386</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Architecture
        {
            get { return this.architecture; }
            set { this.architecture = value; }
        }

        /// <summary>
        /// Sets the Architecture property
        /// </summary>
        /// <param name="architecture">The value to set for the Architecture property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithArchitecture(string architecture)
        {
            this.architecture = architecture;
            return this;
        }
            

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this.architecture != null;
        }

        /// <summary>
        /// The instance root device type. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage for the Root Device</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ebs, instance-store</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RootDeviceType
        {
            get { return this.rootDeviceType; }
            set { this.rootDeviceType = value; }
        }

        /// <summary>
        /// Sets the RootDeviceType property
        /// </summary>
        /// <param name="rootDeviceType">The value to set for the RootDeviceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithRootDeviceType(string rootDeviceType)
        {
            this.rootDeviceType = rootDeviceType;
            return this;
        }
            

        // Check to see if RootDeviceType property is set
        internal bool IsSetRootDeviceType()
        {
            return this.rootDeviceType != null;
        }

        /// <summary>
        /// Whether to install operating system and package updates when the instance boots. The default value is <c>true</c>. To control when updates
        /// are installed, set this value to <c>false</c>. You must then update your instances manually by using <a>CreateDeployment</a> to run the
        /// <c>update_dependencies</c> stack command or manually running <c>yum</c> (Amazon Linux) or <c>apt-get</c> (Ubuntu) on the instances. <note>We
        /// strongly recommend using the default value of <c>true</c>, to ensure that your instances have the latest security updates.</note>
        ///  
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this.installUpdatesOnBoot ?? default(bool); }
            set { this.installUpdatesOnBoot = value; }
        }

        /// <summary>
        /// Sets the InstallUpdatesOnBoot property
        /// </summary>
        /// <param name="installUpdatesOnBoot">The value to set for the InstallUpdatesOnBoot property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithInstallUpdatesOnBoot(bool installUpdatesOnBoot)
        {
            this.installUpdatesOnBoot = installUpdatesOnBoot;
            return this;
        }
            

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this.installUpdatesOnBoot.HasValue;
        }
    }
}
    
