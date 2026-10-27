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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Properties that configure exporting the output image to a disk image file in an Amazon
    /// S3 bucket, in a format that's compatible with your VMs.
    /// </summary>
    public partial class S3ExportConfiguration
    {
        /// <summary>
        /// Gets and sets the property DiskImageFormat. 
        /// <para>
        /// Export the updated image to one of the following supported disk image formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Virtual Hard Disk (VHD)</b> – Compatible with Citrix Xen and Microsoft Hyper-V
        /// virtualization products.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Stream-optimized ESX Virtual Machine Disk (VMDK)</b> – Compatible with VMware
        /// ESX and VMware vSphere versions 4, 5, and 6.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Raw</b> – Raw format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DiskImageFormat DiskImageFormat { get; set; }

        /// <summary>
        /// Checks to see if the DiskImageFormat property is set.
        /// </summary>
        internal bool IsSetDiskImageFormat() => this.DiskImageFormat != null;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role that grants VM Import/Export permission to export images to your
        /// S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The S3 bucket in which to store the output disk images for your VM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The Amazon S3 path for the bucket where the output disk images for your VM are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;
    }
}
