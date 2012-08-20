/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    ///<summary>
    ///Image Attribute
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ImageAttribute
    {    
        private string imageIdField;
        private List<LaunchPermission> launchPermissionField;
        // obsolete, to be removed
        private List<string> productCodeField;
        // replacement for string list of product codes
        private List<ProductCode> productCodesField;
        private string kernelIdField;
        private string ramdiskIdField;
        private string descriptionField;
        private List<BlockDeviceMapping> blockDeviceMappingField;

        /// <summary>
        /// Gets and sets the ImageId property.
        /// The ID of the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public string ImageId
        {
            get { return this.imageIdField; }
            set { this.imageIdField = value; }
        }

        /// <summary>
        /// Sets the ImageId property
        /// </summary>
        /// <param name="imageId">The ID of the AMI.</param>
        /// <returns>this instance</returns>
        public ImageAttribute WithImageId(string imageId)
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
        /// Gets and sets the LaunchPermission property.
        /// Launch permissions.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchPermission")]
        public List<LaunchPermission> LaunchPermission
        {
            get
            {
                if (this.launchPermissionField == null)
                {
                    this.launchPermissionField = new List<LaunchPermission>();
                }
                return this.launchPermissionField;
            }
            set { this.launchPermissionField = value; }
        }

        /// <summary>
        /// Sets the LaunchPermission property
        /// </summary>
        /// <param name="list">Launch permissions.</param>
        /// <returns>this instance</returns>
        public ImageAttribute WithLaunchPermission(params LaunchPermission[] list)
        {
            foreach (LaunchPermission item in list)
            {
                LaunchPermission.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LaunchPermission property is set
        /// </summary>
        /// <returns>true if LaunchPermission property is set</returns>
        public bool IsSetLaunchPermission()
        {
            return (LaunchPermission.Count > 0);
        }

        /// <summary>
        /// Gets and sets the ProductCode property.
        /// Product codes.
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
        /// Sets the ProductCode property
        /// </summary>
        /// <param name="list">Product codes.</param>
        /// <returns>this instance</returns>
        [Obsolete("This member has been deprecated and will be removed in a future release. Please use the WithProductCodes member instead.")]
        public ImageAttribute WithProductCode(params string[] list)
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
        /// Gets and sets the ProductCodes property.
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
        /// Sets the ProductCodes property
        /// </summary>
        /// <param name="list">Product codes attached to this instance.</param>
        /// <returns>this instance</returns>
        public ImageAttribute WithProductCodes(params ProductCode[] list)
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
        /// Gets and sets the KernelId property.
        /// Kernel ID.
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
        /// <param name="kernelId">Kernel ID.</param>
        /// <returns>this instance</returns>
        public ImageAttribute WithKernelId(string kernelId)
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
        /// RAM disk ID.
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
        /// <param name="ramdiskId">RAM disk ID.</param>
        /// <returns>this instance</returns>
        public ImageAttribute WithRamdiskId(string ramdiskId)
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
        /// Gets and sets the Description property.
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
        /// <param name="description">Description property</param>
        /// <returns>this instance</returns>
        public ImageAttribute WithDescription(string description)
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
        public ImageAttribute WithBlockDeviceMapping(params BlockDeviceMapping[] list)
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
