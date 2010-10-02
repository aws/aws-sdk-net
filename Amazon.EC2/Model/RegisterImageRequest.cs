/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Registers an AMI with Amazon EC2. Images must be
    /// registered before they
    /// can be launched. To launch instances, use
    /// the RunInstances operation.
    ///
    /// Each AMI is associated with an unique
    /// ID which is provided by the Amazon
    /// EC2 service through the
    /// RegisterImage operation. During registration,
    /// Amazon EC2 retrieves
    /// the specified image manifest from Amazon S3
    /// and verifies that the
    /// image is owned by the user registering the image.
    ///
    /// The image manifest is retrieved once and stored within the Amazon
    /// EC2. Any modifications to an image in Amazon S3 invalidates this
    /// registration. If you make changes to an image, deregister the
    /// previous image and register
    /// the new image. To deregister an image,
    /// use the DeregisterImage
    /// operation.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class RegisterImageRequest
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
        /// Gets and sets the ImageLocation property.
        /// Full path to your AMI manifest in Amazon S3
        /// storage.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageLocation")]
        public string ImageLocation
        {
            get { return this.imageLocationField; }
            set { this.imageLocationField = value; }
        }

        /// <summary>
        /// Sets the ImageLocation property
        /// </summary>
        /// <param name="imageLocation">Full path to your AMI manifest in Amazon S3
        /// storage.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Name property.
        /// The name of the AMI that was provided during
        /// image creation.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The name of the AMI that was provided during
        /// image creation.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Description property.
        /// The description of the AMI. Must be 3-128
        /// alphanumeric characters,
        /// parenthesis (()), commas (,), slashes
        /// (/), dashes (-), or
        /// underscores(_).
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The description of the AMI. Must be 3-128
        /// alphanumeric characters,
        /// parenthesis (()), commas (,), slashes
        /// (/), dashes (-), or
        /// underscores(_).</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Architecture property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Architecture")]
        public string Architecture
        {
            get { return this.architectureField; }
            set { this.architectureField = value; }
        }

        /// <summary>
        /// Sets the Architecture property
        /// </summary>
        /// <param name="architecture">Architecture property</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the KernelId property.
        /// The ID of the kernel to select.
        /// </summary>
        [XmlElementAttribute(ElementName = "KernelId")]
        public string KernelId
        {
            get { return this.kernelIdField; }
            set { this.kernelIdField = value; }
        }

        /// <summary>
        /// Sets the KernelId property
        /// </summary>
        /// <param name="kernelId">The ID of the kernel to select.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the RamdiskId property.
        /// The ID of the RAM disk to select. Some kernels
        /// require additional drivers at launch. Check the kernel
        /// requirements for information on whether you need to
        /// specify a
        /// RAM disk.
        /// </summary>
        [XmlElementAttribute(ElementName = "RamdiskId")]
        public string RamdiskId
        {
            get { return this.ramdiskIdField; }
            set { this.ramdiskIdField = value; }
        }

        /// <summary>
        /// Sets the RamdiskId property
        /// </summary>
        /// <param name="ramdiskId">The ID of the RAM disk to select. Some kernels
        /// require additional drivers at launch. Check the kernel
        /// requirements for information on whether you need to
        /// specify a
        /// RAM disk.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the RootDeviceName property.
        /// The root device name (e.g., /dev/sda1).
        /// </summary>
        [XmlElementAttribute(ElementName = "RootDeviceName")]
        public string RootDeviceName
        {
            get { return this.rootDeviceNameField; }
            set { this.rootDeviceNameField = value; }
        }

        /// <summary>
        /// Sets the RootDeviceName property
        /// </summary>
        /// <param name="rootDeviceName">The root device name (e.g., /dev/sda1).</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the BlockDeviceMapping property.
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
        /// Sets the BlockDeviceMapping property
        /// </summary>
        /// <param name="list">BlockDeviceMapping property</param>
        /// <returns>this instance</returns>
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
