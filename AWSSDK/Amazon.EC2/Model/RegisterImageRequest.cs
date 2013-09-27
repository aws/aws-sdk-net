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
    /// Registers an AMI with Amazon EC2.
    /// </summary>
    /// <remarks>
    /// Images must be registered before they can be launched.
    /// To launch instances, use the RunInstances operation.
    ///
    /// Each AMI is associated with an unique ID which is provided by
    /// the Amazon EC2 service through the RegisterImage operation.
    /// During registration, Amazon EC2 retrieves the specified image
    /// manifest from Amazon S3 and verifies that the image is owned
    /// by the user registering the image.
    ///
    /// The image manifest is retrieved once and stored within the Amazon
    /// EC2. Any modifications to an image in Amazon S3 invalidates this
    /// registration. If you make changes to an image, deregister the
    /// previous image and register the new image. To deregister an image,
    /// use the DeregisterImage operation.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class RegisterImageRequest : EC2Request
    {    
        private string imageLocationField;
        private string nameField;
        private string descriptionField;
        private string architectureField;
        private string kernelIdField;
        private string ramdiskIdField;
        private string rootDeviceNameField;
        private List<BlockDeviceMapping> blockDeviceMappingField;

        /// <summary>
        /// Full path to your AMI manifest in Amazon S3 storage.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageLocation")]
        public string ImageLocation
        {
            get { return this.imageLocationField; }
            set { this.imageLocationField = value; }
        }

        /// <summary>
        /// Sets the full path to your AMI manifest in Amazon S3 storage.
        /// </summary>
        /// <param name="imageLocation">Full path to your AMI manifest in Amazon S3
        /// storage.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterImageRequest WithImageLocation(string imageLocation)
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
        /// The name of the AMI that was provided during image creation.
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
        /// <param name="name">The name of the AMI that was provided during
        /// image creation.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterImageRequest WithName(string name)
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
        /// <remarks>
        /// Must be 3-128 alphanumeric characters, parenthesis (()),
        /// commas (,), slashes (/), dashes (-), or underscores(_).
        /// </remarks>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the AMI.
        /// </summary>
        /// <param name="description">The description of the AMI. Must be 3-128
        /// alphanumeric characters, parenthesis (()), commas (,), slashes
        /// (/), dashes (-), or underscores(_).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterImageRequest WithDescription(string description)
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
        /// The architecture of the image.
        /// Valid values: i386 | x86_64
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
        /// <param name="architecture">Architecture property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterImageRequest WithArchitecture(string architecture)
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
        /// The ID of the kernel to select.
        /// </summary>
        [XmlElementAttribute(ElementName = "KernelId")]
        public string KernelId
        {
            get { return this.kernelIdField; }
            set { this.kernelIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the kernel to select.
        /// </summary>
        /// <param name="kernelId">The ID of the kernel to select.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterImageRequest WithKernelId(string kernelId)
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
        /// The ID of the RAM disk to select.
        /// </summary>
        /// <remarks>
        /// Some kernels require additional drivers at launch.
        /// Check the kernel requirements for information on
        /// whether you need to specify a RAM disk.
        /// </remarks>
        [XmlElementAttribute(ElementName = "RamdiskId")]
        public string RamdiskId
        {
            get { return this.ramdiskIdField; }
            set { this.ramdiskIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the RAM disk to select.
        /// </summary>
        /// <param name="ramdiskId">The ID of the RAM disk to select. Some kernels
        /// require additional drivers at launch. Check the kernel
        /// requirements for information on whether you need to
        /// specify a RAM disk.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterImageRequest WithRamdiskId(string ramdiskId)
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
        public RegisterImageRequest WithRootDeviceName(string rootDeviceName)
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
        /// The device names exposed to the instance (for example, /dev/sdh or xvdh).
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
        /// Sets the device names exposed to the instance (for example, /dev/sdh or xvdh).
        /// </summary>
        /// <param name="list">BlockDeviceMapping property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterImageRequest WithBlockDeviceMapping(params BlockDeviceMapping[] list)
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

    }
}
