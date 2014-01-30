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
    /// <para>Describes an image attribute.</para>
    /// </summary>
    public class ImageAttribute
    {
        
        private string imageId;
        private List<LaunchPermission> launchPermissions = new List<LaunchPermission>();
        private List<ProductCode> productCodes = new List<ProductCode>();
        private string kernelId;
        private string ramdiskId;
        private string description;
        private string sriovNetSupport;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();


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
        /// One or more launch permissions.
        ///  
        /// </summary>
        public List<LaunchPermission> LaunchPermissions
        {
            get { return this.launchPermissions; }
            set { this.launchPermissions = value; }
        }

        // Check to see if LaunchPermissions property is set
        internal bool IsSetLaunchPermissions()
        {
            return this.launchPermissions.Count > 0;
        }

        /// <summary>
        /// One or more product codes.
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
        /// The kernel ID.
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
        /// The RAM disk ID.
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
        /// A description for the AMI.
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
        /// 
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
        /// One or more block device mapping entries.
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
    }
}
