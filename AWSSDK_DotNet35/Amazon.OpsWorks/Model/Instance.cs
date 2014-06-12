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
    /// Describes an instance.
    /// </summary>
    public partial class Instance
    {
        private string _amiId;
        private Architecture _architecture;
        private AutoScalingType _autoScalingType;
        private string _availabilityZone;
        private string _createdAt;
        private bool? _ebsOptimized;
        private string _ec2InstanceId;
        private string _elasticIp;
        private string _hostname;
        private bool? _installUpdatesOnBoot;
        private string _instanceId;
        private string _instanceProfileArn;
        private string _instanceType;
        private string _lastServiceErrorId;
        private List<string> _layerIds = new List<string>();
        private string _os;
        private string _privateDns;
        private string _privateIp;
        private string _publicDns;
        private string _publicIp;
        private RootDeviceType _rootDeviceType;
        private string _rootDeviceVolumeId;
        private List<string> _securityGroupIds = new List<string>();
        private string _sshHostDsaKeyFingerprint;
        private string _sshHostRsaKeyFingerprint;
        private string _sshKeyName;
        private string _stackId;
        private string _status;
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

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }


        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The instance architecture, "i386" or "x86_64".
        /// </para>
        /// </summary>
        public Architecture Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }


        /// <summary>
        /// Gets and sets the property AutoScalingType. 
        /// <para>
        /// The instance's auto scaling type, which has three possible values:
        /// </para>
        ///   <ul>  <li><b>AlwaysRunning</b>: A 24/7 instance, which is not affected by auto scaling.</li>
        ///  <li><b>TimeBasedAutoScaling</b>: A time-based auto scaling instance, which is started
        /// and stopped based on a specified schedule.</li>  <li><b>LoadBasedAutoScaling</b>:
        /// A load-based auto scaling instance, which is started and stopped based on load metrics.</li>
        ///  </ul>
        /// </summary>
        public AutoScalingType AutoScalingType
        {
            get { return this._autoScalingType; }
            set { this._autoScalingType = value; }
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

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the instance was created.
        /// </para>
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }


        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Whether this is an Amazon EBS-optimized instance.
        /// </para>
        /// </summary>
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The ID of the associated Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this._ec2InstanceId; }
            set { this._ec2InstanceId = value; }
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this._ec2InstanceId != null;
        }


        /// <summary>
        /// Gets and sets the property ElasticIp. 
        /// <para>
        /// The instance <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP address </a>.
        /// </para>
        /// </summary>
        public string ElasticIp
        {
            get { return this._elasticIp; }
            set { this._elasticIp = value; }
        }

        // Check to see if ElasticIp property is set
        internal bool IsSetElasticIp()
        {
            return this._elasticIp != null;
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

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }


        /// <summary>
        /// Gets and sets the property InstallUpdatesOnBoot. 
        /// <para>
        /// Whether to install operating system and package updates when the instance boots. The
        /// default value is <code>true</code>.         If this value is set to <code>false</code>,
        /// you must then update your instances manually by         using <a>CreateDeployment</a>
        /// to run the <code>update_dependencies</code> stack command or         manually running
        /// <code>yum</code> (Amazon Linux) or <code>apt-get</code> (Ubuntu) on the instances.
        ///  
        /// </para>
        ///   <note>      
        /// <para>
        /// We strongly recommend using the default value of <code>true</code>, to ensure that
        /// your        instances have the latest security updates.
        /// </para>
        ///     </note>
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this._installUpdatesOnBoot.GetValueOrDefault(); }
            set { this._installUpdatesOnBoot = value; }
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this._installUpdatesOnBoot.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        /// The ARN of the instance's IAM profile. For more information about IAM ARNs, see  <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using
        /// Identifiers</a>.
        /// </para>
        /// </summary>
        public string InstanceProfileArn
        {
            get { return this._instanceProfileArn; }
            set { this._instanceProfileArn = value; }
        }

        // Check to see if InstanceProfileArn property is set
        internal bool IsSetInstanceProfileArn()
        {
            return this._instanceProfileArn != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. AWS OpsWorks supports all instance types except Cluster Compute,
        /// Cluster GPU, and High Memory Cluster.         For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Families and Types</a>.         The parameter values that specify the various types
        /// are in the API Name column of the Available Instance Types table.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }


        /// <summary>
        /// Gets and sets the property LastServiceErrorId. 
        /// <para>
        /// The ID of the last service error. For more information, call <a>DescribeServiceErrors</a>.
        /// </para>
        /// </summary>
        public string LastServiceErrorId
        {
            get { return this._lastServiceErrorId; }
            set { this._lastServiceErrorId = value; }
        }

        // Check to see if LastServiceErrorId property is set
        internal bool IsSetLastServiceErrorId()
        {
            return this._lastServiceErrorId != null;
        }


        /// <summary>
        /// Gets and sets the property LayerIds. 
        /// <para>
        /// An array containing the instance layer IDs.
        /// </para>
        /// </summary>
        public List<string> LayerIds
        {
            get { return this._layerIds; }
            set { this._layerIds = value; }
        }

        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this._layerIds != null && this._layerIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Os. 
        /// <para>
        /// The instance operating system.
        /// </para>
        /// </summary>
        public string Os
        {
            get { return this._os; }
            set { this._os = value; }
        }

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this._os != null;
        }


        /// <summary>
        /// Gets and sets the property PrivateDns. 
        /// <para>
        /// The instance private DNS name.
        /// </para>
        /// </summary>
        public string PrivateDns
        {
            get { return this._privateDns; }
            set { this._privateDns = value; }
        }

        // Check to see if PrivateDns property is set
        internal bool IsSetPrivateDns()
        {
            return this._privateDns != null;
        }


        /// <summary>
        /// Gets and sets the property PrivateIp. 
        /// <para>
        /// The instance private IP address.
        /// </para>
        /// </summary>
        public string PrivateIp
        {
            get { return this._privateIp; }
            set { this._privateIp = value; }
        }

        // Check to see if PrivateIp property is set
        internal bool IsSetPrivateIp()
        {
            return this._privateIp != null;
        }


        /// <summary>
        /// Gets and sets the property PublicDns. 
        /// <para>
        /// The instance public DNS name.
        /// </para>
        /// </summary>
        public string PublicDns
        {
            get { return this._publicDns; }
            set { this._publicDns = value; }
        }

        // Check to see if PublicDns property is set
        internal bool IsSetPublicDns()
        {
            return this._publicDns != null;
        }


        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The instance public IP address.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }


        /// <summary>
        /// Gets and sets the property RootDeviceType. 
        /// <para>
        /// The instance root device type. For more information, see  <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage
        /// for the Root Device</a>.
        /// </para>
        /// </summary>
        public RootDeviceType RootDeviceType
        {
            get { return this._rootDeviceType; }
            set { this._rootDeviceType = value; }
        }

        // Check to see if RootDeviceType property is set
        internal bool IsSetRootDeviceType()
        {
            return this._rootDeviceType != null;
        }


        /// <summary>
        /// Gets and sets the property RootDeviceVolumeId. 
        /// <para>
        /// The root device volume ID.
        /// </para>
        /// </summary>
        public string RootDeviceVolumeId
        {
            get { return this._rootDeviceVolumeId; }
            set { this._rootDeviceVolumeId = value; }
        }

        // Check to see if RootDeviceVolumeId property is set
        internal bool IsSetRootDeviceVolumeId()
        {
            return this._rootDeviceVolumeId != null;
        }


        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// An array containing the instance security group IDs.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property SshHostDsaKeyFingerprint. 
        /// <para>
        /// The SSH key's DSA fingerprint.
        /// </para>
        /// </summary>
        public string SshHostDsaKeyFingerprint
        {
            get { return this._sshHostDsaKeyFingerprint; }
            set { this._sshHostDsaKeyFingerprint = value; }
        }

        // Check to see if SshHostDsaKeyFingerprint property is set
        internal bool IsSetSshHostDsaKeyFingerprint()
        {
            return this._sshHostDsaKeyFingerprint != null;
        }


        /// <summary>
        /// Gets and sets the property SshHostRsaKeyFingerprint. 
        /// <para>
        /// The SSH key's RSA fingerprint.
        /// </para>
        /// </summary>
        public string SshHostRsaKeyFingerprint
        {
            get { return this._sshHostRsaKeyFingerprint; }
            set { this._sshHostRsaKeyFingerprint = value; }
        }

        // Check to see if SshHostRsaKeyFingerprint property is set
        internal bool IsSetSshHostRsaKeyFingerprint()
        {
            return this._sshHostRsaKeyFingerprint != null;
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

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The instance status:
        /// </para>
        ///   <ul>  <li><code>requested</code></li>  <li><code>booting</code></li>  <li><code>running_setup</code></li>
        ///  <li><code>online</code></li>  <li><code>setup_failed</code></li>  <li><code>start_failed</code></li>
        ///  <li><code>terminating</code></li>  <li><code>terminated</code></li>  <li><code>stopped</code></li>
        ///  <li><code>connection_lost</code></li>  </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }


        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The instance's subnet ID, if the stack is running in a VPC.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
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

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this._virtualizationType != null;
        }

    }
}