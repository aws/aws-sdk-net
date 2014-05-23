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
        private string _architecture;
        private string _autoScalingType;
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
        private string _rootDeviceType;
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


        /// <summary>
        /// Sets the AmiId property
        /// </summary>
        /// <param name="amiId">The value to set for the AmiId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithAmiId(string amiId)
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
        /// The instance architecture, "i386" or "x86_64".
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
        public Instance WithArchitecture(string architecture)
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
        /// The instance's auto scaling type, which has three possible values:
        /// </para>
        ///   <ul>  <li><b>AlwaysRunning</b>: A 24/7 instance, which is not affected by auto scaling.</li>
        ///  <li><b>TimeBasedAutoScaling</b>: A time-based auto scaling instance, which is started
        /// and stopped based on a specified schedule.</li>  <li><b>LoadBasedAutoScaling</b>:
        /// A load-based auto scaling instance, which is started and stopped based on load metrics.</li>
        ///  </ul>
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
        public Instance WithAutoScalingType(string autoScalingType)
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
        public Instance WithAvailabilityZone(string availabilityZone)
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


        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithCreatedAt(string createdAt)
        {
            this._createdAt = createdAt;
            return this;
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


        /// <summary>
        /// Sets the EbsOptimized property
        /// </summary>
        /// <param name="ebsOptimized">The value to set for the EbsOptimized property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithEbsOptimized(bool ebsOptimized)
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


        /// <summary>
        /// Sets the Ec2InstanceId property
        /// </summary>
        /// <param name="ec2InstanceId">The value to set for the Ec2InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithEc2InstanceId(string ec2InstanceId)
        {
            this._ec2InstanceId = ec2InstanceId;
            return this;
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


        /// <summary>
        /// Sets the ElasticIp property
        /// </summary>
        /// <param name="elasticIp">The value to set for the ElasticIp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithElasticIp(string elasticIp)
        {
            this._elasticIp = elasticIp;
            return this;
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


        /// <summary>
        /// Sets the Hostname property
        /// </summary>
        /// <param name="hostname">The value to set for the Hostname property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithHostname(string hostname)
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


        /// <summary>
        /// Sets the InstallUpdatesOnBoot property
        /// </summary>
        /// <param name="installUpdatesOnBoot">The value to set for the InstallUpdatesOnBoot property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithInstallUpdatesOnBoot(bool installUpdatesOnBoot)
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


        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithInstanceId(string instanceId)
        {
            this._instanceId = instanceId;
            return this;
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


        /// <summary>
        /// Sets the InstanceProfileArn property
        /// </summary>
        /// <param name="instanceProfileArn">The value to set for the InstanceProfileArn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithInstanceProfileArn(string instanceProfileArn)
        {
            this._instanceProfileArn = instanceProfileArn;
            return this;
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


        /// <summary>
        /// Sets the InstanceType property
        /// </summary>
        /// <param name="instanceType">The value to set for the InstanceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithInstanceType(string instanceType)
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


        /// <summary>
        /// Sets the LastServiceErrorId property
        /// </summary>
        /// <param name="lastServiceErrorId">The value to set for the LastServiceErrorId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithLastServiceErrorId(string lastServiceErrorId)
        {
            this._lastServiceErrorId = lastServiceErrorId;
            return this;
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

        /// <summary>
        /// Sets the LayerIds property
        /// </summary>
        /// <param name="layerIds">The values to add to the LayerIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithLayerIds(params string[] layerIds)
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
        public Instance WithLayerIds(IEnumerable<string> layerIds)
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
        /// The instance operating system.
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
        public Instance WithOs(string os)
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


        /// <summary>
        /// Sets the PrivateDns property
        /// </summary>
        /// <param name="privateDns">The value to set for the PrivateDns property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithPrivateDns(string privateDns)
        {
            this._privateDns = privateDns;
            return this;
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


        /// <summary>
        /// Sets the PrivateIp property
        /// </summary>
        /// <param name="privateIp">The value to set for the PrivateIp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithPrivateIp(string privateIp)
        {
            this._privateIp = privateIp;
            return this;
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


        /// <summary>
        /// Sets the PublicDns property
        /// </summary>
        /// <param name="publicDns">The value to set for the PublicDns property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithPublicDns(string publicDns)
        {
            this._publicDns = publicDns;
            return this;
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


        /// <summary>
        /// Sets the PublicIp property
        /// </summary>
        /// <param name="publicIp">The value to set for the PublicIp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithPublicIp(string publicIp)
        {
            this._publicIp = publicIp;
            return this;
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
        public Instance WithRootDeviceType(string rootDeviceType)
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


        /// <summary>
        /// Sets the RootDeviceVolumeId property
        /// </summary>
        /// <param name="rootDeviceVolumeId">The value to set for the RootDeviceVolumeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithRootDeviceVolumeId(string rootDeviceVolumeId)
        {
            this._rootDeviceVolumeId = rootDeviceVolumeId;
            return this;
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

        /// <summary>
        /// Sets the SecurityGroupIds property
        /// </summary>
        /// <param name="securityGroupIds">The values to add to the SecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithSecurityGroupIds(params string[] securityGroupIds)
        {
            foreach (var element in securityGroupIds)
            {
                this._securityGroupIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SecurityGroupIds property
        /// </summary>
        /// <param name="securityGroupIds">The values to add to the SecurityGroupIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithSecurityGroupIds(IEnumerable<string> securityGroupIds)
        {
            foreach (var element in securityGroupIds)
            {
                this._securityGroupIds.Add(element);
            }
            return this;
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


        /// <summary>
        /// Sets the SshHostDsaKeyFingerprint property
        /// </summary>
        /// <param name="sshHostDsaKeyFingerprint">The value to set for the SshHostDsaKeyFingerprint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithSshHostDsaKeyFingerprint(string sshHostDsaKeyFingerprint)
        {
            this._sshHostDsaKeyFingerprint = sshHostDsaKeyFingerprint;
            return this;
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


        /// <summary>
        /// Sets the SshHostRsaKeyFingerprint property
        /// </summary>
        /// <param name="sshHostRsaKeyFingerprint">The value to set for the SshHostRsaKeyFingerprint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithSshHostRsaKeyFingerprint(string sshHostRsaKeyFingerprint)
        {
            this._sshHostRsaKeyFingerprint = sshHostRsaKeyFingerprint;
            return this;
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


        /// <summary>
        /// Sets the SshKeyName property
        /// </summary>
        /// <param name="sshKeyName">The value to set for the SshKeyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithSshKeyName(string sshKeyName)
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
        public Instance WithStackId(string stackId)
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


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithStatus(string status)
        {
            this._status = status;
            return this;
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


        /// <summary>
        /// Sets the SubnetId property
        /// </summary>
        /// <param name="subnetId">The value to set for the SubnetId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Instance WithSubnetId(string subnetId)
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
        public Instance WithVirtualizationType(string virtualizationType)
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