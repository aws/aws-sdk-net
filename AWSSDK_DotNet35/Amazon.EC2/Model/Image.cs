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
    /// <para>Describes an image.</para>
    /// </summary>
    public class Image
    {
        
        private string imageId;
        private string imageLocation;
        private ImageState state;
        private string ownerId;
        private bool? publicValue;
        private List<ProductCode> productCodes = new List<ProductCode>();
        private ArchitectureValues architecture;
        private ImageTypeValues imageType;
        private string kernelId;
        private string ramdiskId;
        private PlatformValues platform;
        private string sriovNetSupport;
        private StateReason stateReason;
        private string imageOwnerAlias;
        private string name;
        private string description;
        private DeviceType rootDeviceType;
        private string rootDeviceName;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();
        private VirtualizationType virtualizationType;
        private List<Tag> tags = new List<Tag>();
        private HypervisorType hypervisor;


        /// <summary>
        /// The ID of the AMI.
        ///  
        /// </summary>
        public string ImageId
        {
            get { return this.imageId; }
            set { this.imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this.imageId != null;
        }

        /// <summary>
        /// The location of the AMI.
        ///  
        /// </summary>
        public string ImageLocation
        {
            get { return this.imageLocation; }
            set { this.imageLocation = value; }
        }

        // Check to see if ImageLocation property is set
        internal bool IsSetImageLocation()
        {
            return this.imageLocation != null;
        }

        /// <summary>
        /// The current state of the AMI. If the state is <c>available</c>, the image is successfully registered and can be used to launch an instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>available, deregistered</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ImageState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The AWS account ID of the image owner.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }

        /// <summary>
        /// Indicates whether the image has public launch permissions. The value is <c>true</c> if this image has public launch permissions or
        /// <c>false</c> if it has only implicit and explicit launch permissions.
        ///  
        /// </summary>
        public bool Public
        {
            get { return this.publicValue ?? default(bool); }
            set { this.publicValue = value; }
        }

        // Check to see if Public property is set
        internal bool IsSetPublic()
        {
            return this.publicValue.HasValue;
        }

        /// <summary>
        /// Any product codes associated with the AMI.
        ///  
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this.productCodes; }
            set { this.productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this.productCodes.Count > 0;
        }

        /// <summary>
        /// The architecture of the image.
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
        /// The type of image.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>machine, kernel, ramdisk</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ImageTypeValues ImageType
        {
            get { return this.imageType; }
            set { this.imageType = value; }
        }

        // Check to see if ImageType property is set
        internal bool IsSetImageType()
        {
            return this.imageType != null;
        }

        /// <summary>
        /// The kernel associated with the image, if any. Only applicable for machine images.
        ///  
        /// </summary>
        public string KernelId
        {
            get { return this.kernelId; }
            set { this.kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this.kernelId != null;
        }

        /// <summary>
        /// The RAM disk associated with the image, if any. Only applicable for machine images.
        ///  
        /// </summary>
        public string RamdiskId
        {
            get { return this.ramdiskId; }
            set { this.ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this.ramdiskId != null;
        }

        /// <summary>
        /// The value is <c>Windows</c> for Windows AMIs; otherwise blank.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Windows</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public PlatformValues Platform
        {
            get { return this.platform; }
            set { this.platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this.platform != null;
        }

        /// <summary>
        /// Specifies whether enhanced networking is enabled.
        ///  
        /// </summary>
        public string SriovNetSupport
        {
            get { return this.sriovNetSupport; }
            set { this.sriovNetSupport = value; }
        }

        // Check to see if SriovNetSupport property is set
        internal bool IsSetSriovNetSupport()
        {
            return this.sriovNetSupport != null;
        }

        /// <summary>
        /// The reason for the state change.
        ///  
        /// </summary>
        public StateReason StateReason
        {
            get { return this.stateReason; }
            set { this.stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this.stateReason != null;
        }

        /// <summary>
        /// The AWS account alias (for example, <c>amazon</c>, <c>self</c>) or the AWS account ID of the AMI owner.
        ///  
        /// </summary>
        public string ImageOwnerAlias
        {
            get { return this.imageOwnerAlias; }
            set { this.imageOwnerAlias = value; }
        }

        // Check to see if ImageOwnerAlias property is set
        internal bool IsSetImageOwnerAlias()
        {
            return this.imageOwnerAlias != null;
        }

        /// <summary>
        /// The name of the AMI that was provided during image creation.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The description of the AMI that was provided during image creation.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The type of root device used by the AMI. The AMI can use an Amazon EBS volume or an instance store volume.
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
        public DeviceType RootDeviceType
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
        /// The device name of the root device (for example, <filename>/dev/sda1</filename> or <filename>xvda</filename>).
        ///  
        /// </summary>
        public string RootDeviceName
        {
            get { return this.rootDeviceName; }
            set { this.rootDeviceName = value; }
        }

        // Check to see if RootDeviceName property is set
        internal bool IsSetRootDeviceName()
        {
            return this.rootDeviceName != null;
        }

        /// <summary>
        /// Any block device mapping entries.
        ///  
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this.blockDeviceMappings; }
            set { this.blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this.blockDeviceMappings.Count > 0;
        }

        /// <summary>
        /// The type of virtualization of the AMI.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>hvm, paravirtual</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VirtualizationType VirtualizationType
        {
            get { return this.virtualizationType; }
            set { this.virtualizationType = value; }
        }

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this.virtualizationType != null;
        }

        /// <summary>
        /// Any tags assigned to the image.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

        /// <summary>
        /// The hypervisor type of the image.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ovm, xen</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public HypervisorType Hypervisor
        {
            get { return this.hypervisor; }
            set { this.hypervisor = value; }
        }

        // Check to see if Hypervisor property is set
        internal bool IsSetHypervisor()
        {
            return this.hypervisor != null;
        }
    }
}
