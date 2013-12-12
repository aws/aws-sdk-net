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
    /// <para>Describes an instance.</para>
    /// </summary>
    public class Instance
    {
        
        private string instanceId;
        private string ec2InstanceId;
        private string hostname;
        private string stackId;
        private List<string> layerIds = new List<string>();
        private List<string> securityGroupIds = new List<string>();
        private string instanceType;
        private string instanceProfileArn;
        private string status;
        private string os;
        private string amiId;
        private string availabilityZone;
        private string subnetId;
        private string publicDns;
        private string privateDns;
        private string publicIp;
        private string privateIp;
        private string elasticIp;
        private AutoScalingType autoScalingType;
        private string sshKeyName;
        private string sshHostRsaKeyFingerprint;
        private string sshHostDsaKeyFingerprint;
        private string createdAt;
        private string lastServiceErrorId;
        private Architecture architecture;
        private RootDeviceType rootDeviceType;
        private string rootDeviceVolumeId;
        private bool? installUpdatesOnBoot;


        /// <summary>
        /// The instance ID.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The ID of the associated Amazon EC2 instance.
        ///  
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this.ec2InstanceId; }
            set { this.ec2InstanceId = value; }
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this.ec2InstanceId != null;
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

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this.hostname != null;
        }

        /// <summary>
        /// The stack ID.
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
        /// An array containing the instance layer IDs.
        ///  
        /// </summary>
        public List<string> LayerIds
        {
            get { return this.layerIds; }
            set { this.layerIds = value; }
        }

        // Check to see if LayerIds property is set
        internal bool IsSetLayerIds()
        {
            return this.layerIds.Count > 0;
        }

        /// <summary>
        /// An array containing the instance security group IDs.
        ///  
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this.securityGroupIds; }
            set { this.securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this.securityGroupIds.Count > 0;
        }

        /// <summary>
        /// The instance type. AWS OpsWorks supports all instance types except Cluster Compute, Cluster GPU, and High Memory Cluster. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance Families and Types</a>. The
        /// parameter values that specify the various types are in the API Name column of the Available Instance Types table.
        ///  
        /// </summary>
        public string InstanceType
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
        /// The ARN of the instance's IAM profile. For more information about IAM ARNs, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">Using Identifiers</a>.
        ///  
        /// </summary>
        public string InstanceProfileArn
        {
            get { return this.instanceProfileArn; }
            set { this.instanceProfileArn = value; }
        }

        // Check to see if InstanceProfileArn property is set
        internal bool IsSetInstanceProfileArn()
        {
            return this.instanceProfileArn != null;
        }

        /// <summary>
        /// The instance status: <ul> <li><c>requested</c></li> <li><c>booting</c></li> <li><c>running_setup</c></li> <li><c>online</c></li>
        /// <li><c>setup_failed</c></li> <li><c>start_failed</c></li> <li><c>terminating</c></li> <li><c>terminated</c></li> <li><c>stopped</c></li>
        /// <li><c>connection_lost</c></li> </ul>
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The instance operating system.
        ///  
        /// </summary>
        public string Os
        {
            get { return this.os; }
            set { this.os = value; }
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

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this.amiId != null;
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

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The instance's subnet ID, if the stack is running in a VPC.
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
        /// The instance public DNS name.
        ///  
        /// </summary>
        public string PublicDns
        {
            get { return this.publicDns; }
            set { this.publicDns = value; }
        }

        // Check to see if PublicDns property is set
        internal bool IsSetPublicDns()
        {
            return this.publicDns != null;
        }

        /// <summary>
        /// The instance private DNS name.
        ///  
        /// </summary>
        public string PrivateDns
        {
            get { return this.privateDns; }
            set { this.privateDns = value; }
        }

        // Check to see if PrivateDns property is set
        internal bool IsSetPrivateDns()
        {
            return this.privateDns != null;
        }

        /// <summary>
        /// The instance public IP address.
        ///  
        /// </summary>
        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }

        /// <summary>
        /// The instance private IP address.
        ///  
        /// </summary>
        public string PrivateIp
        {
            get { return this.privateIp; }
            set { this.privateIp = value; }
        }

        // Check to see if PrivateIp property is set
        internal bool IsSetPrivateIp()
        {
            return this.privateIp != null;
        }

        /// <summary>
        /// The instance <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP address </a>.
        ///  
        /// </summary>
        public string ElasticIp
        {
            get { return this.elasticIp; }
            set { this.elasticIp = value; }
        }

        // Check to see if ElasticIp property is set
        internal bool IsSetElasticIp()
        {
            return this.elasticIp != null;
        }

        /// <summary>
        /// The instance's auto scaling type, which has three possible values: <ul> <li><b>AlwaysRunning</b>: A 24/7 instance, which is not affected by
        /// auto scaling.</li> <li><b>TimeBasedAutoScaling</b>: A time-based auto scaling instance, which is started and stopped based on a specified
        /// schedule.</li> <li><b>LoadBasedAutoScaling</b>: A load-based auto scaling instance, which is started and stopped based on load metrics.</li>
        /// </ul>
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
        public AutoScalingType AutoScalingType
        {
            get { return this.autoScalingType; }
            set { this.autoScalingType = value; }
        }

        // Check to see if AutoScalingType property is set
        internal bool IsSetAutoScalingType()
        {
            return this.autoScalingType != null;
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

        // Check to see if SshKeyName property is set
        internal bool IsSetSshKeyName()
        {
            return this.sshKeyName != null;
        }

        /// <summary>
        /// The SSH key's RSA fingerprint.
        ///  
        /// </summary>
        public string SshHostRsaKeyFingerprint
        {
            get { return this.sshHostRsaKeyFingerprint; }
            set { this.sshHostRsaKeyFingerprint = value; }
        }

        // Check to see if SshHostRsaKeyFingerprint property is set
        internal bool IsSetSshHostRsaKeyFingerprint()
        {
            return this.sshHostRsaKeyFingerprint != null;
        }

        /// <summary>
        /// The SSH key's DSA fingerprint.
        ///  
        /// </summary>
        public string SshHostDsaKeyFingerprint
        {
            get { return this.sshHostDsaKeyFingerprint; }
            set { this.sshHostDsaKeyFingerprint = value; }
        }

        // Check to see if SshHostDsaKeyFingerprint property is set
        internal bool IsSetSshHostDsaKeyFingerprint()
        {
            return this.sshHostDsaKeyFingerprint != null;
        }

        /// <summary>
        /// The time that the instance was created.
        ///  
        /// </summary>
        public string CreatedAt
        {
            get { return this.createdAt; }
            set { this.createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this.createdAt != null;
        }

        /// <summary>
        /// The ID of the last service error. For more information, call <a>DescribeServiceErrors</a>.
        ///  
        /// </summary>
        public string LastServiceErrorId
        {
            get { return this.lastServiceErrorId; }
            set { this.lastServiceErrorId = value; }
        }

        // Check to see if LastServiceErrorId property is set
        internal bool IsSetLastServiceErrorId()
        {
            return this.lastServiceErrorId != null;
        }

        /// <summary>
        /// The instance architecture, "i386" or "x86_64".
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
        public Architecture Architecture
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
        public RootDeviceType RootDeviceType
        {
            get { return this.rootDeviceType; }
            set { this.rootDeviceType = value; }
        }

        // Check to see if RootDeviceType property is set
        internal bool IsSetRootDeviceType()
        {
            return this.rootDeviceType != null;
        }

        /// <summary>
        /// The root device volume ID.
        ///  
        /// </summary>
        public string RootDeviceVolumeId
        {
            get { return this.rootDeviceVolumeId; }
            set { this.rootDeviceVolumeId = value; }
        }

        // Check to see if RootDeviceVolumeId property is set
        internal bool IsSetRootDeviceVolumeId()
        {
            return this.rootDeviceVolumeId != null;
        }

        /// <summary>
        /// Whether to install operating system and package updates when the instance boots. The default value is <c>true</c>. If this value is set to
        /// <c>false</c>, you must then update your instances manually by using <a>CreateDeployment</a> to run the <c>update_dependencies</c> stack
        /// command or manually running <c>yum</c> (Amazon Linux) or <c>apt-get</c> (Ubuntu) on the instances. <note>We strongly recommend using the
        /// default value of <c>true</c>, to ensure that your instances have the latest security updates.</note>
        ///  
        /// </summary>
        public bool InstallUpdatesOnBoot
        {
            get { return this.installUpdatesOnBoot ?? default(bool); }
            set { this.installUpdatesOnBoot = value; }
        }

        // Check to see if InstallUpdatesOnBoot property is set
        internal bool IsSetInstallUpdatesOnBoot()
        {
            return this.installUpdatesOnBoot.HasValue;
        }
    }
}
