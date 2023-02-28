/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the launch specification for one or more Spot Instances. If you include
    /// On-Demand capacity in your fleet request or want to specify an EFA network device,
    /// you can't use <code>SpotFleetLaunchSpecification</code>; you must use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_LaunchTemplateConfig.html">LaunchTemplateConfig</a>.
    /// </summary>
    public partial class SpotFleetLaunchSpecification
    {
        private string _addressingType;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private bool? _ebsOptimized;
        private IamInstanceProfileSpecification _iamInstanceProfile;
        private string _imageId;
        private InstanceRequirements _instanceRequirements;
        private InstanceType _instanceType;
        private string _kernelId;
        private string _keyName;
        private SpotFleetMonitoring _monitoring;
        private List<InstanceNetworkInterfaceSpecification> _networkInterfaces = new List<InstanceNetworkInterfaceSpecification>();
        private SpotPlacement _placement;
        private string _ramdiskId;
        private List<GroupIdentifier> _securityGroups = new List<GroupIdentifier>();
        private string _spotPrice;
        private string _subnetId;
        private List<SpotFleetTagSpecification> _tagSpecifications = new List<SpotFleetTagSpecification>();
        private string _userData;
        private double? _weightedCapacity;

        /// <summary>
        /// Gets and sets the property AddressingType. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public string AddressingType
        {
            get { return this._addressingType; }
            set { this._addressingType = value; }
        }

        // Check to see if AddressingType property is set
        internal bool IsSetAddressingType()
        {
            return this._addressingType != null;
        }

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// One or more block devices that are mapped to the Spot Instances. You can't specify
        /// both a snapshot ID and an encryption value. This is because only blank volumes can
        /// be encrypted on creation. If a snapshot is the basis for a volume, it is not blank
        /// and its encryption status is used for the volume encryption status.
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
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the instances are optimized for EBS I/O. This optimization provides
        /// dedicated throughput to Amazon EBS and an optimized configuration stack to provide
        /// optimal EBS I/O performance. This optimization isn't available with all instance types.
        /// Additional usage charges apply when using an EBS Optimized instance.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
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
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM instance profile.
        /// </para>
        /// </summary>
        public IamInstanceProfileSpecification IamInstanceProfile
        {
            get { return this._iamInstanceProfile; }
            set { this._iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this._iamInstanceProfile != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with those attributes.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <code>InstanceRequirements</code>, you can't specify <code>InstanceType</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public InstanceRequirements InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
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
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel.
        /// </para>
        /// </summary>
        public string KernelId
        {
            get { return this._kernelId; }
            set { this._kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this._kernelId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair.
        /// </para>
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// Enable or disable monitoring for the instances.
        /// </para>
        /// </summary>
        public SpotFleetMonitoring Monitoring
        {
            get { return this._monitoring; }
            set { this._monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this._monitoring != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// One or more network interfaces. If you specify a network interface, you must specify
        /// subnet IDs and security group IDs using the network interface.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>SpotFleetLaunchSpecification</code> currently does not support Elastic Fabric
        /// Adapter (EFA). To specify an EFA, you must use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_LaunchTemplateConfig.html">LaunchTemplateConfig</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && this._networkInterfaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The placement information.
        /// </para>
        /// </summary>
        public SpotPlacement Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The ID of the RAM disk. Some kernels require additional drivers at launch. Check the
        /// kernel requirements for information about whether you need to specify a RAM disk.
        /// To find kernel requirements, refer to the Amazon Web Services Resource Center and
        /// search for the kernel ID.
        /// </para>
        /// </summary>
        public string RamdiskId
        {
            get { return this._ramdiskId; }
            set { this._ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this._ramdiskId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// One or more security groups. When requesting instances in a VPC, you must specify
        /// the IDs of the security groups. When requesting instances in EC2-Classic, you can
        /// specify the names or the IDs of the security groups.
        /// </para>
        /// </summary>
        public List<GroupIdentifier> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. We
        /// do not recommend using this parameter because it can lead to increased interruptions.
        /// If you do not specify this parameter, you will pay the current Spot price.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a maximum price, your instances will be interrupted more frequently
        /// than if you do not specify this parameter.
        /// </para>
        ///  </important>
        /// </summary>
        public string SpotPrice
        {
            get { return this._spotPrice; }
            set { this._spotPrice = value; }
        }

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this._spotPrice != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The IDs of the subnets in which to launch the instances. To specify multiple subnets,
        /// separate them using commas; for example, "subnet-1234abcdeexample1, subnet-0987cdef6example2".
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply during creation.
        /// </para>
        /// </summary>
        public List<SpotFleetTagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The base64-encoded user data that instances use when starting up. User data is limited
        /// to 16 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string UserData
        {
            get { return this._userData; }
            set { this._userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this._userData != null;
        }

        /// <summary>
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// The number of units provided by the specified instance type. These are the same units
        /// that you chose to set the target capacity in terms of instances, or a performance
        /// characteristic such as vCPUs, memory, or I/O.
        /// </para>
        ///  
        /// <para>
        /// If the target capacity divided by this value is not a whole number, Amazon EC2 rounds
        /// the number of instances to the next whole number. If this value is not specified,
        /// the default is 1.
        /// </para>
        /// </summary>
        public double WeightedCapacity
        {
            get { return this._weightedCapacity.GetValueOrDefault(); }
            set { this._weightedCapacity = value; }
        }

        // Check to see if WeightedCapacity property is set
        internal bool IsSetWeightedCapacity()
        {
            return this._weightedCapacity.HasValue; 
        }

    }
}