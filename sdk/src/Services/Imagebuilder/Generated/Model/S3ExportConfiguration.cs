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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
    /// Properties that configure export from your build instance to a compatible file format
    /// for your VM.
    /// </summary>
    public partial class S3ExportConfiguration
    {
        private DiskImageFormat _diskImageFormat;
        private string _roleName;
        private string _s3Bucket;
        private string _s3Prefix;

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
        [AWSProperty(Required=true)]
        public DiskImageFormat DiskImageFormat
        {
            get { return this._diskImageFormat; }
            set { this._diskImageFormat = value; }
        }

        // Check to see if DiskImageFormat property is set
        internal bool IsSetDiskImageFormat()
        {
            return this._diskImageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role that grants VM Import/Export permission to export images to your
        /// S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The S3 bucket in which to store the output disk images for your VM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The Amazon S3 path for the bucket where the output disk images for your VM are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

    }
}