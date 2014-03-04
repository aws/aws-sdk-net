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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Image (AMI) description.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Image
    {    
        private string imageIdField;
        private string imageLocationField;
        private string imageStateField;
        private string ownerIdField;
        private string visibilityField;
        // obsolete, to be removed
        private List<string> productCodeField;
        // replacement for string list of product codes
        private List<ProductCode> productCodesField;
        private string architectureField;
        private string imageTypeField;
        private string kernelIdField;
        private string ramdiskIdField;
        private string platformField;
        private StateReason stateReasonField;
        private string imageOwnerAliasField;
        private string nameField;
        private string descriptionField;
        private string rootDeviceTypeField;
        private string rootDeviceNameField;
        private List<BlockDeviceMapping> blockDeviceMappingField;
        private string virtualizationTypeField;
        private List<Tag> tagField;
        private string hypervisorField;

        /// <summary>
        /// The ID of the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public string ImageId
        {
            get { return this.imageIdField; }
            set { this.imageIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the AMI.
        /// </summary>
        /// <param name="imageId">The ID of the AMI.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithImageId(string imageId)
        {
            this.imageIdField = imageId;
            return this;
        }

        /// <summary>
        /// Checks if ImageId property is set
        /// </summary>
        /// <returns>true if ImageId property is set</returns>
        public bool IsSetImageId()
        {
            return this.imageIdField != null;
        }

        /// <summary>
        /// The location of the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageLocation")]
        public string ImageLocation
        {
            get { return this.imageLocationField; }
            set { this.imageLocationField = value; }
        }

        /// <summary>
        /// Sets the location of the AMI.
        /// </summary>
        /// <param name="imageLocation">The location of the AMI.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithImageLocation(string imageLocation)
        {
            this.imageLocationField = imageLocation;
            return this;
        }

        /// <summary>
        /// Checks if ImageLocation property is set
        /// </summary>
        /// <returns>true if ImageLocation property is set</returns>
        public bool IsSetImageLocation()
        {
            return this.imageLocationField != null;
        }

        /// <summary>
        /// Current state of the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageState")]
        public string ImageState
        {
            get { return this.imageStateField; }
            set { this.imageStateField = value; }
        }

        /// <summary>
        /// Sets current state of the AMI.
        /// </summary>
        /// <param name="imageState">Current state of the AMI.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithImageState(string imageState)
        {
            this.imageStateField = imageState;
            return this;
        }

        /// <summary>
        /// Checks if ImageState property is set
        /// </summary>
        /// <returns>true if ImageState property is set</returns>
        public bool IsSetImageState()
        {
            return this.imageStateField != null;
        }

        /// <summary>
        /// AWS Access Key ID of the image owner.
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerId")]
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }

        /// <summary>
        /// Sets the AWS Access Key ID of the image owner.
        /// </summary>
        /// <param name="ownerId">AWS Access Key ID of the image owner.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithOwnerId(string ownerId)
        {
            this.ownerIdField = ownerId;
            return this;
        }

        /// <summary>
        /// Checks if OwnerId property is set
        /// </summary>
        /// <returns>true if OwnerId property is set</returns>
        public bool IsSetOwnerId()
        {
            return this.ownerIdField != null;
        }

        /// <summary>
        /// Image visibility.
        /// Valid values: public | private
        /// </summary>
        [XmlElementAttribute(ElementName = "Visibility")]
        public string Visibility
        {
            get { return this.visibilityField; }
            set { this.visibilityField = value; }
        }

        /// <summary>
        /// Sets the image visibility.
        /// </summary>
        /// <param name="visibility">Visibility - public or private</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithVisibility(string visibility)
        {
            this.visibilityField = visibility;
            return this;
        }

        /// <summary>
        /// Checks if Visibility property is set
        /// </summary>
        /// <returns>true if Visibility property is set</returns>
        public bool IsSetVisibility()
        {
            return this.visibilityField != null;
        }

        /// <summary>
        /// Product codes of the AMI
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCodeId")]
        [Obsolete("This member has been deprecated and will be removed in a future release. Please use the ProductCodes member instead.")]
        public List<string> ProductCode
        {
            get
            {
                if (this.productCodeField == null)
                {
                    this.productCodeField = new List<string>();
                }
                return this.productCodeField;
            }
            set { this.productCodeField = value; }
        }

        /// <summary>
        /// Sets the product codes of the AMI
        /// </summary>
        /// <param name="list">Product codes of the AMI</param>
        /// <returns>this instance</returns>
        [Obsolete("This member has been deprecated and will be removed in a future release. Please use the WithProductCodes member instead.")]
        public Image WithProductCode(params string[] list)
        {
            foreach (string item in list)
            {
                ProductCode.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ProductCode property is set
        /// </summary>
        /// <returns>true if ProductCode property is set</returns>
        [Obsolete("This member has been deprecated and will be removed in a future release. Please use the IsSetProductCodes member instead.")]
        public bool IsSetProductCode()
        {
            return (ProductCode.Count > 0);
        }

        /// <summary>
        /// Product codes attached to this instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCodes")]
        public List<ProductCode> ProductCodes
        {
            get
            {
                if (this.productCodesField == null)
                {
                    this.productCodesField = new List<ProductCode>();
                }
                return this.productCodesField;
            }
            set { this.productCodesField = value; }
        }

        /// <summary>
        /// Sets the product codes attached to this instance.
        /// </summary>
        /// <param name="list">Product codes attached to this instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithProductCodes(params ProductCode[] list)
        {
            foreach (ProductCode item in list)
            {
                ProductCodes.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ProductCodes property is set
        /// </summary>
        /// <returns>true if ProductCodes property is set</returns>
        public bool IsSetProductCodes()
        {
            return (ProductCodes.Count > 0);
        }

        /// <summary>
        /// The architecture of the image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Architecture")]
        public string Architecture
        {
            get { return this.architectureField; }
            set { this.architectureField = value; }
        }

        /// <summary>
        /// Sets the architecture of the image.
        /// </summary>
        /// <param name="architecture">The architecture of the image.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithArchitecture(string architecture)
        {
            this.architectureField = architecture;
            return this;
        }

        /// <summary>
        /// Checks if Architecture property is set
        /// </summary>
        /// <returns>true if Architecture property is set</returns>
        public bool IsSetArchitecture()
        {
            return this.architectureField != null;
        }

        /// <summary>
        /// The image type.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageType")]
        public string ImageType
        {
            get { return this.imageTypeField; }
            set { this.imageTypeField = value; }
        }

        /// <summary>
        /// Sets the image type.
        /// </summary>
        /// <param name="imageType">The type of image</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithImageType(string imageType)
        {
            this.imageTypeField = imageType;
            return this;
        }

        /// <summary>
        /// Checks if ImageType property is set
        /// </summary>
        /// <returns>true if ImageType property is set</returns>
        public bool IsSetImageType()
        {
            return this.imageTypeField != null;
        }

        /// <summary>
        /// The kernel associated with the image, if any.
        /// Only applicable for machine images.
        /// </summary>
        [XmlElementAttribute(ElementName = "KernelId")]
        public string KernelId
        {
            get { return this.kernelIdField; }
            set { this.kernelIdField = value; }
        }

        /// <summary>
        /// Sets the kernel associated with the image.
        /// </summary>
        /// <param name="kernelId">The kernel associated with the image, if any.
        /// Only applicable for machine images.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithKernelId(string kernelId)
        {
            this.kernelIdField = kernelId;
            return this;
        }

        /// <summary>
        /// Checks if KernelId property is set
        /// </summary>
        /// <returns>true if KernelId property is set</returns>
        public bool IsSetKernelId()
        {
            return this.kernelIdField != null;
        }

        /// <summary>
        /// The RAM disk associated with the image, if any.
        /// Only applicable for machine images.
        /// </summary>
        [XmlElementAttribute(ElementName = "RamdiskId")]
        public string RamdiskId
        {
            get { return this.ramdiskIdField; }
            set { this.ramdiskIdField = value; }
        }

        /// <summary>
        /// Sets the RAM disk associated with the image.
        /// </summary>
        /// <param name="ramdiskId">The RAM disk associated with the image, if any.
        /// Only applicable for machine images.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithRamdiskId(string ramdiskId)
        {
            this.ramdiskIdField = ramdiskId;
            return this;
        }

        /// <summary>
        /// Checks if RamdiskId property is set
        /// </summary>
        /// <returns>true if RamdiskId property is set</returns>
        public bool IsSetRamdiskId()
        {
            return this.ramdiskIdField != null;
        }

        /// <summary>
        /// The operating platform of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Platform")]
        public string Platform
        {
            get { return this.platformField; }
            set { this.platformField = value; }
        }

        /// <summary>
        /// Sets the operating platform of the instance.
        /// </summary>
        /// <param name="platform">The operating platform of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithPlatform(string platform)
        {
            this.platformField = platform;
            return this;
        }

        /// <summary>
        /// Checks if Platform property is set
        /// </summary>
        /// <returns>true if Platform property is set</returns>
        public bool IsSetPlatform()
        {
            return this.platformField != null;
        }

        /// <summary>
        /// The reason for the state change.
        /// </summary>
        [XmlElementAttribute(ElementName = "StateReason")]
        public StateReason StateReason
        {
            get { return this.stateReasonField; }
            set { this.stateReasonField = value; }
        }

        /// <summary>
        /// Ses the reason for the state change.
        /// </summary>
        /// <param name="stateReason">The reason for the state change.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithStateReason(StateReason stateReason)
        {
            this.stateReasonField = stateReason;
            return this;
        }

        /// <summary>
        /// Checks if StateReason property is set
        /// </summary>
        /// <returns>true if StateReason property is set</returns>
        public bool IsSetStateReason()
        {
            return this.stateReasonField != null;
        }

        /// <summary>
        /// The AWS account alias (e.g., "amazon") or AWS
        /// account ID that owns the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageOwnerAlias")]
        public string ImageOwnerAlias
        {
            get { return this.imageOwnerAliasField; }
            set { this.imageOwnerAliasField = value; }
        }

        /// <summary>
        /// Sets the AWS account alias (e.g., "amazon") or AWS
        /// account ID that owns the AMI.
        /// </summary>
        /// <param name="imageOwnerAlias">The AWS account alias (e.g., "amazon") or AWS
        /// account ID that owns the AMI.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithImageOwnerAlias(string imageOwnerAlias)
        {
            this.imageOwnerAliasField = imageOwnerAlias;
            return this;
        }

        /// <summary>
        /// Checks if ImageOwnerAlias property is set
        /// </summary>
        /// <returns>true if ImageOwnerAlias property is set</returns>
        public bool IsSetImageOwnerAlias()
        {
            return this.imageOwnerAliasField != null;
        }

        /// <summary>
        /// The name of the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the name of the AMI.
        /// </summary>
        /// <param name="name">The name of the AMI.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

        /// <summary>
        /// The description of the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the AMI.
        /// </summary>
        /// <param name="description">The description of the AMI.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }

        /// <summary>
        /// The root device type used by the AMI.
        /// The AMI can use an Amazon EBS or instance store root device.
        /// </summary>
        [XmlElementAttribute(ElementName = "RootDeviceType")]
        public string RootDeviceType
        {
            get { return this.rootDeviceTypeField; }
            set { this.rootDeviceTypeField = value; }
        }

        /// <summary>
        /// Sets the root device type used by the AMI.
        /// </summary>
        /// <param name="rootDeviceType">The root device type used by the AMI. The AMI
        /// can use an Amazon EBS or instance store root device.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithRootDeviceType(string rootDeviceType)
        {
            this.rootDeviceTypeField = rootDeviceType;
            return this;
        }

        /// <summary>
        /// Checks if RootDeviceType property is set
        /// </summary>
        /// <returns>true if RootDeviceType property is set</returns>
        public bool IsSetRootDeviceType()
        {
            return this.rootDeviceTypeField != null;
        }

        /// <summary>
        /// The root device name (e.g., /dev/sda1).
        /// </summary>
        [XmlElementAttribute(ElementName = "RootDeviceName")]
        public string RootDeviceName
        {
            get { return this.rootDeviceNameField; }
            set { this.rootDeviceNameField = value; }
        }

        /// <summary>
        /// Sets the root device name (e.g., /dev/sda1).
        /// </summary>
        /// <param name="rootDeviceName">The root device name (e.g., /dev/sda1).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithRootDeviceName(string rootDeviceName)
        {
            this.rootDeviceNameField = rootDeviceName;
            return this;
        }

        /// <summary>
        /// Checks if RootDeviceName property is set
        /// </summary>
        /// <returns>true if RootDeviceName property is set</returns>
        public bool IsSetRootDeviceName()
        {
            return this.rootDeviceNameField != null;
        }

        /// <summary>
        /// One or more specifications of how block devices are exposed to the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "BlockDeviceMapping")]
        public List<BlockDeviceMapping> BlockDeviceMapping
        {
            get
            {
                if (this.blockDeviceMappingField == null)
                {
                    this.blockDeviceMappingField = new List<BlockDeviceMapping>();
                }
                return this.blockDeviceMappingField;
            }
            set { this.blockDeviceMappingField = value; }
        }

        /// <summary>
        /// Sets specifications of how block devices are exposed to the instance.
        /// </summary>
        /// <param name="list">Specifies how block devices are exposed to the
        /// instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithBlockDeviceMapping(params BlockDeviceMapping[] list)
        {
            foreach (BlockDeviceMapping item in list)
            {
                BlockDeviceMapping.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if BlockDeviceMapping property is set
        /// </summary>
        /// <returns>true if BlockDeviceMapping property is set</returns>
        public bool IsSetBlockDeviceMapping()
        {
            return (BlockDeviceMapping.Count > 0);
        }

        /// <summary>
        /// Specifies whether the Amazon EC2 instance is a hardware virtual
        /// machine (HVM) or a para-virtual machine (PVM).
        /// </summary>
        [XmlElementAttribute(ElementName = "VirtualizationType")]
        public string VirtualizationType
        {
            get { return this.virtualizationTypeField; }
            set { this.virtualizationTypeField = value; }
        }

        /// <summary>
        /// Sets whether the Amazon EC2 instance is a hardware virtual
        /// machine (HVM) or a para-virtual machine (PVM).
        /// </summary>
        /// <param name="virtualizationType">Specifies whether the Amazon EC2 instance is a
        /// hardware virtual machine
        /// (HVM) or a para-virtual machine (PVM).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithVirtualizationType(string virtualizationType)
        {
            this.virtualizationTypeField = virtualizationType;
            return this;
        }

        /// <summary>
        /// Checks if VirtualizationType property is set
        /// </summary>
        /// <returns>true if VirtualizationType property is set</returns>
        public bool IsSetVirtualizationType()
        {
            return this.virtualizationTypeField != null;
        }

        /// <summary>
        /// A list of tags for the Image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the list of tags for the Image.
        /// </summary>
        /// <param name="list">A list of tags for the Image.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

        /// <summary>
        /// The image hypervisor type.
        /// </summary>
        [XmlElementAttribute(ElementName = "Hypervisor")]
        public string Hypervisor
        {
            get { return this.hypervisorField; }
            set { this.hypervisorField = value; }
        }

        /// <summary>
        /// Sets the image hypervisor type.
        /// </summary>
        /// <param name="hypervisor">Hypervisor property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Image WithHypervisor(string hypervisor)
        {
            this.hypervisorField = hypervisor;
            return this;
        }

        /// <summary>
        /// Checks if Hypervisor property is set
        /// </summary>
        /// <returns>true if Hypervisor property is set</returns>
        public bool IsSetHypervisor()
        {
            return this.hypervisorField != null;
        }

    }
}
