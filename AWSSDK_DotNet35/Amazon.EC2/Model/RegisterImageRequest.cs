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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterImage operation.
    /// <para> The RegisterImage operation registers an AMI with Amazon EC2. Images must be registered before they can be launched. For more
    /// information, see RunInstances. </para> <para> Each AMI is associated with an unique ID which is provided by the Amazon EC2 service through
    /// the RegisterImage operation. During registration, Amazon EC2 retrieves the specified image manifest from Amazon S3 and verifies that the
    /// image is owned by the user registering the image. </para> <para> The image manifest is retrieved once and stored within the Amazon EC2. Any
    /// modifications to an image in Amazon S3 invalidates this registration. If you make changes to an image, deregister the previous image and
    /// register the new image. For more information, see DeregisterImage. </para>
    /// </summary>
    public partial class RegisterImageRequest : AmazonEC2Request
    {
        private string imageLocation;
        private string name;
        private string description;
        private ArchitectureValues architecture;
        private string kernelId;
        private string ramdiskId;
        private string rootDeviceName;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();


        /// <summary>
        /// The full path to your AMI manifest in Amazon S3 storage.
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
        /// The name to give the new Amazon Machine Image. Constraints: 3-128 alphanumeric characters, parenthesis (<c>()</c>), commas (<c>,</c>),
        /// slashes (<c>/</c>), dashes (<c>-</c>), or underscores(<c>_</c>)
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
        /// The description describing the new AMI.
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
        /// The architecture of the image. Valid Values: <c>i386</c>, <c>x86_64</c>
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
        /// The optional ID of a specific kernel to register with the new AMI.
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
        /// The optional ID of a specific ramdisk to register with the new AMI. Some kernels require additional drivers at launch. Check the kernel
        /// requirements for information on whether you need to specify a RAM disk.
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
        /// The root device name (e.g., <c>/dev/sda1</c>).
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
        /// The block device mappings for the new AMI, which specify how different block devices (ex: EBS volumes and ephemeral drives) will be exposed
        /// on instances launched from the new image.
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
    
