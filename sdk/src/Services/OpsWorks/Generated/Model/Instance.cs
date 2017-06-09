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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
        private string _agentVersion;
        private string _amiId;
        private Architecture _architecture;
        private string _arn;
        private AutoScalingType _autoScalingType;
        private string _availabilityZone;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private string _createdAt;
        private bool? _ebsOptimized;
        private string _ec2InstanceId;
        private string _ecsClusterArn;
        private string _ecsContainerInstanceArn;
        private string _elasticIp;
        private string _hostname;
        private string _infrastructureClass;
        private bool? _installUpdatesOnBoot;
        private string _instanceId;
        private string _instanceProfileArn;
        private string _instanceType;
        private string _lastServiceErrorId;
        private List<string> _layerIds = new List<string>();
        private string _os;
        private string _platform;
        private string _privateDns;
        private string _privateIp;
        private string _publicDns;
        private string _publicIp;
        private string _registeredBy;
        private string _reportedAgentVersion;
        private ReportedOs _reportedOs;
        private RootDeviceType _rootDeviceType;
        private string _rootDeviceVolumeId;
        private List<string> _securityGroupIds = new List<string>();
        private string _sshHostDsaKeyFingerprint;
        private string _sshHostRsaKeyFingerprint;
        private string _sshKeyName;
        private string _stackId;
        private string _status;
        private string _subnetId;
        private string _tenancy;
        private VirtualizationType _virtualizationType;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The agent version. This parameter is set to <code>INHERIT</code> if the instance inherits
        /// the default stack setting or to a a version number for a fixed agent version.
        /// </para>
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// A custom AMI ID to be used to create the instance. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-custom-ami.html">Instances</a>
        /// 
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
        /// The instance architecture: "i386" or "x86_64".
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
        /// Gets and sets the property Arn.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingType. 
        /// <para>
        /// For load-based or time-based instances, the type.
        /// </para>
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
        /// The instance Availability Zone. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
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
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// An array of <code>BlockDeviceMapping</code> objects that specify the instance's block
        /// device mappings.
        /// </para>
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && this._blockDeviceMappings.Count > 0; 
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
        /// Gets and sets the property EcsClusterArn. 
        /// <para>
        /// For container instances, the Amazon ECS cluster's ARN.
        /// </para>
        /// </summary>
        public string EcsClusterArn
        {
            get { return this._ecsClusterArn; }
            set { this._ecsClusterArn = value; }
        }

        // Check to see if EcsClusterArn property is set
        internal bool IsSetEcsClusterArn()
        {
            return this._ecsClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property EcsContainerInstanceArn. 
        /// <para>
        /// For container instances, the instance's ARN.
        /// </para>
        /// </summary>
        public string EcsContainerInstanceArn
        {
            get { return this._ecsContainerInstanceArn; }
            set { this._ecsContainerInstanceArn = value; }
        }

        // Check to see if EcsContainerInstanceArn property is set
        internal bool IsSetEcsContainerInstanceArn()
        {
            return this._ecsContainerInstanceArn != null;
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
        /// Gets and sets the property InfrastructureClass. 
        /// <para>
        /// For registered instances, the infrastructure class: <code>ec2</code> or <code>on-premises</code>.
        /// </para>
        /// </summary>
        public string InfrastructureClass
        {
            get { return this._infrastructureClass; }
            set { this._infrastructureClass = value; }
        }

        // Check to see if InfrastructureClass property is set
        internal bool IsSetInfrastructureClass()
        {
            return this._infrastructureClass != null;
        }

        /// <summary>
        /// Gets and sets the property InstallUpdatesOnBoot. 
        /// <para>
        /// Whether to install operating system and package updates when the instance boots. The
        /// default value is <code>true</code>. If this value is set to <code>false</code>, you
        /// must then update your instances manually by using <a>CreateDeployment</a> to run the
        /// <code>update_dependencies</code> stack command or by manually running <code>yum</code>
        /// (Amazon Linux) or <code>apt-get</code> (Ubuntu) on the instances. 
        /// </para>
        ///  <note> 
        /// <para>
        /// We strongly recommend using the default value of <code>true</code>, to ensure that
        /// your instances have the latest security updates.
        /// </para>
        ///  </note>
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
        /// The ARN of the instance's IAM profile. For more information about IAM ARNs, see <a
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
        /// The instance type, such as <code>t2.micro</code>.
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
        /// The instance's operating system.
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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The instance's platform.
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDns. 
        /// <para>
        /// The instance's private DNS name.
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
        /// The instance's private IP address.
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
        /// Gets and sets the property RegisteredBy. 
        /// <para>
        /// For registered instances, who performed the registration.
        /// </para>
        /// </summary>
        public string RegisteredBy
        {
            get { return this._registeredBy; }
            set { this._registeredBy = value; }
        }

        // Check to see if RegisteredBy property is set
        internal bool IsSetRegisteredBy()
        {
            return this._registeredBy != null;
        }

        /// <summary>
        /// Gets and sets the property ReportedAgentVersion. 
        /// <para>
        /// The instance's reported AWS OpsWorks Stacks agent version.
        /// </para>
        /// </summary>
        public string ReportedAgentVersion
        {
            get { return this._reportedAgentVersion; }
            set { this._reportedAgentVersion = value; }
        }

        // Check to see if ReportedAgentVersion property is set
        internal bool IsSetReportedAgentVersion()
        {
            return this._reportedAgentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ReportedOs. 
        /// <para>
        /// For registered instances, the reported operating system.
        /// </para>
        /// </summary>
        public ReportedOs ReportedOs
        {
            get { return this._reportedOs; }
            set { this._reportedOs = value; }
        }

        // Check to see if ReportedOs property is set
        internal bool IsSetReportedOs()
        {
            return this._reportedOs != null;
        }

        /// <summary>
        /// Gets and sets the property RootDeviceType. 
        /// <para>
        /// The instance's root device type. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ComponentsAMIs.html#storage-for-the-root-device">Storage
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
        /// The SSH key's Deep Security Agent (DSA) fingerprint.
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
        /// The instance's Amazon EC2 key-pair name.
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
        ///  <ul> <li> 
        /// <para>
        ///  <code>booting</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>connection_lost</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>online</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rebooting</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>requested</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>running_setup</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>setup_failed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>shutting_down</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>start_failed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stop_failed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stopped</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stopping</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>terminated</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>terminating</code> 
        /// </para>
        ///  </li> </ul>
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
        /// The instance's subnet ID; applicable only if the stack is running in a VPC.
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
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// The instance's tenancy option, such as <code>dedicated</code> or <code>host</code>.
        /// </para>
        /// </summary>
        public string Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The instance's virtualization type: <code>paravirtual</code> or <code>hvm</code>.
        /// </para>
        /// </summary>
        public VirtualizationType VirtualizationType
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