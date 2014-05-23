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
    /// Container for the parameters to the CreateInstance operation.
    /// Creates an instance in a specified stack. For more information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-add.html">Adding
    /// an Instance to a Layer</a>.
    /// 
    ///     
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached       policy that explicitly grants permissions.
    /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class CreateInstanceRequest : AmazonWebServiceRequest
    {
        private string _amiId;
        private string _architecture;
        private string _autoScalingType;
        private string _availabilityZone;
        private bool? _ebsOptimized;
        private string _hostname;
        private bool? _installUpdatesOnBoot;
        private string _instanceType;
        private List<string> _layerIds = new List<string>();
        private string _os;
        private string _rootDeviceType;
        private string _sshKeyName;
        private string _stackId;
        private string _subnetId;
        private string _virtualizationType;


        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// A custom AMI ID to be used to create the instance. The AMI should be based on one
        /// of the standard AWS OpsWorks APIs:         Amazon Linux or Ubuntu 12.04 LTS. For more
        /// information, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances.html">Instances</a>
        /// </para>
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }


        /// <summary>
        /// Sets the AmiId property
        /// </summary>
        /// <param name="amiId">The value to set for the AmiId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithAmiId(string amiId)
        {
            this._amiId = amiId;
            return this;
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }


        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The instance architecture. The default option is <code>x86_64</code>. Instance types
        /// do not necessarily support both architectures.         For a list of the architectures
        /// that are supported by the different instance types, see  <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Families and Types</a>.
        /// </para>
        /// </summary>
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }


        /// <summary>
        /// Sets the Architecture property
        /// </summary>
        /// <param name="architecture">The value to set for the Architecture property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithArchitecture(string architecture)
        {
            this._architecture = architecture;
            return this;
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }


        /// <summary>
        /// Gets and sets the property AutoScalingType. 
        /// <para>
        /// The instance auto scaling type, which has three possible values:
        /// </para>
        ///   <ul>  <li><b>AlwaysRunning</b>:  A 24/7 instance, which is not affected by auto
        /// scaling.</li>  <li><b>TimeBasedAutoScaling</b>: A time-based auto scaling instance,
        /// which is started and stopped based on a specified schedule.            To specify
        /// the schedule, call <a>SetTimeBasedAutoScaling</a>.</li>  <li><b>LoadBasedAutoScaling</b>:
        /// A load-based auto scaling instance, which is started and stopped based on load metrics.
        ///            To use load-based auto scaling, you must enable it for the instance layer
        /// and configure the thresholds by calling  <a>SetLoadBasedAutoScaling</a>.</li>  </ul>
        /// </summary>
        public string AutoScalingType
        {
            get { return this._autoScalingType; }
            set { this._autoScalingType = value; }
        }


        /// <summary>
        /// Sets the AutoScalingType property
        /// </summary>
        /// <param name="autoScalingType">The value to set for the AutoScalingType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithAutoScalingType(string autoScalingType)
        {
            this._autoScalingType = autoScalingType;
            return this;
        }

        // Check to see if AutoScalingType property is set
        internal bool IsSetAutoScalingType()
        {
            return this._autoScalingType != null;
        }


        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The instance Availability Zone. For more information, see  <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }


        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithAvailabilityZone(string availabilityZone)
        {
            this._availabilityZone = availabilityZone;
            return this;
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Whether to create an Amazon EBS-optimized instance.
        /// </para>
        /// </summary>
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
            set { this._ebsOptimized = value; }
        }


        /// <summary>
        /// Sets the EbsOptimized property
        /// </summary>
        /// <param name="ebsOptimized">The value to set for the EbsOptimized property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithEbsOptimized(bool ebsOptimized)
        {
            this._ebsOptimized = ebsOptimized;
            return this;
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The instance host name.
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }


        /// <summary>
        /// Sets the Hostname property
        /// </summary>
        /// <param name="hostname">The value to set for the Hostname property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithHostname(string hostname)
        {
            this._hostname = hostname;
            return this;
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }


        /// <summary>
        /// Gets and sets the property InstallUpdatesOnBoot. 
        /// <para>
        /// Whether to install operating system and package updates when the instance boots. The
        /// default value is <code>true</code>.         To control when updates are installed,
        /// set this value to <code>false</code>. You must then update your instances manually
        /// by         using <a>CreateDeployment</a> to run the <code>update_dependencies</code>
        /// stack command or         manually running <code>yum</code> (Amazon Linux) or <code>apt-get</code>
        /// (Ubuntu) on the instances.  
        /// </para>
        ///   <note>      
        /// <para>
        /// We strongly recommend using the default value of <code>true</code> to ensure that
        /// your        instances have the latest security updates.
        /// </para>
        ///     </note>
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this._installUpdatesOnBoot.GetValueOrDefault(); }
            set { this._installUpdatesOnBoot = value; }
        }


        /// <summary>
        /// Sets the InstallUpdatesOnBoot property
        /// </summary>
        /// <param name="installUpdatesOnBoot">The value to set for the InstallUpdatesOnBoot property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithInstallUpdatesOnBoot(bool installUpdatesOnBoot)
        {
            this._installUpdatesOnBoot = installUpdatesOnBoot;
            return this;
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this._installUpdatesOnBoot.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. AWS OpsWorks supports all instance types except Cluster Compute,
        /// Cluster GPU, and High Memory Cluster.         For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Families and Types</a>.         The parameter values that you use to specify the various
        /// types are in the API Name column of the Available Instance Types table.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }


        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithInstanceType(string instanceType)
        {
            this._instanceType = instanceType;
            return this;
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }


        /// <summary>
        /// Gets and sets the property LayerIds. 
        /// <para>
        /// An array that contains the instance layer IDs.
        /// </para>
        /// </summary>
        public List<string> LayerIds
        {
            get { return this._layerIds; }
            set { this._layerIds = value; }
        }

        /// <summary>
        /// Sets the LayerIds property
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithLayerIds(params string[] layerIds)
        {
            foreach (var element in layerIds)
            {
                this._layerIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the LayerIds property
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithLayerIds(IEnumerable<string> layerIds)
        {
            foreach (var element in layerIds)
            {
                this._layerIds.Add(element);
            }
            return this;
        }
        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this._layerIds != null && this._layerIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Os. 
        /// <para>
        /// The instance operating system, which must be set to one of the following.
        /// </para>
        ///   <ul>  <li>Standard operating systems: <code>Amazon Linux</code> or <code>Ubuntu
        /// 12.04 LTS</code></li>  <li>Custom AMIs: <code>Custom</code></li>  </ul>  
        /// <para>
        /// The default option is <code>Amazon Linux</code>. If you set this parameter to <code>Custom</code>,
        /// you must use the  <a>CreateInstance</a> action's AmiId parameter to specify      
        ///   the custom AMI that you want to use. For more information on the standard operating
        /// systems, see  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-os.html">Operating
        /// Systems</a>For more information         on how to use custom AMIs with OpsWorks, see
        ///  <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-custom-ami.html">Using
        /// Custom AMIs</a>.
        /// </para>
        /// </summary>
        public string Os
        {
            get { return this._os; }
            set { this._os = value; }
        }


        /// <summary>
        /// Sets the Os property
        /// </summary>
        /// <param name="os">The value to set for the Os property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithOs(string os)
        {
            this._os = os;
            return this;
        }

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this._os != null;
        }


        /// <summary>
        /// Gets and sets the property RootDeviceType. 
        /// <para>
        /// The instance root device type. For more information, see   <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage
        /// for the Root Device</a>.
        /// </para>
        /// </summary>
        public string RootDeviceType
        {
            get { return this._rootDeviceType; }
            set { this._rootDeviceType = value; }
        }


        /// <summary>
        /// Sets the RootDeviceType property
        /// </summary>
        /// <param name="rootDeviceType">The value to set for the RootDeviceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithRootDeviceType(string rootDeviceType)
        {
            this._rootDeviceType = rootDeviceType;
            return this;
        }

        // Check to see if RootDeviceType property is set
        internal bool IsSetRootDeviceType()
        {
            return this._rootDeviceType != null;
        }


        /// <summary>
        /// Gets and sets the property SshKeyName. 
        /// <para>
        /// The instance SSH key name.
        /// </para>
        /// </summary>
        public string SshKeyName
        {
            get { return this._sshKeyName; }
            set { this._sshKeyName = value; }
        }


        /// <summary>
        /// Sets the SshKeyName property
        /// </summary>
        /// <param name="sshKeyName">The value to set for the SshKeyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithSshKeyName(string sshKeyName)
        {
            this._sshKeyName = sshKeyName;
            return this;
        }

        // Check to see if SshKeyName property is set
        internal bool IsSetSshKeyName()
        {
            return this._sshKeyName != null;
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
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
        public CreateInstanceRequest WithStackId(string stackId)
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
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the instance's subnet. If the stack is running in a VPC, you can use this
        /// parameter         to override the stack's default subnet ID value and direct AWS OpsWorks
        /// to launch the instance in a different subnet.  
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }


        /// <summary>
        /// Sets the SubnetId property
        /// </summary>
        /// <param name="subnetId">The value to set for the SubnetId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithSubnetId(string subnetId)
        {
            this._subnetId = subnetId;
            return this;
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }


        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The instance's virtualization type, <code>paravirtual</code> or <code>hvm</code>.
        /// </para>
        /// </summary>
        public string VirtualizationType
        {
            get { return this._virtualizationType; }
            set { this._virtualizationType = value; }
        }


        /// <summary>
        /// Sets the VirtualizationType property
        /// </summary>
        /// <param name="virtualizationType">The value to set for the VirtualizationType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInstanceRequest WithVirtualizationType(string virtualizationType)
        {
            this._virtualizationType = virtualizationType;
            return this;
        }

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this._virtualizationType != null;
        }

    }
}