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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an export instance task.
    /// </summary>
    public partial class ExportToS3TaskSpecification
    {
        /// <summary>
        /// Gets and sets the property ContainerFormat. 
        /// <para>
        /// The container format used to combine disk images with metadata (such as OVF). If absent,
        /// only the disk image is exported.
        /// </para>
        /// </summary>
        public ContainerFormat ContainerFormat { get; set; }

        /// <summary>
        /// Checks to see if the ContainerFormat property is set.
        /// </summary>
        internal bool IsSetContainerFormat() => this.ContainerFormat != null;

        /// <summary>
        /// Gets and sets the property DiskImageFormat. 
        /// <para>
        /// The format for the exported image.
        /// </para>
        /// </summary>
        public DiskImageFormat DiskImageFormat { get; set; }

        /// <summary>
        /// Checks to see if the DiskImageFormat property is set.
        /// </summary>
        internal bool IsSetDiskImageFormat() => this.DiskImageFormat != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket for the destination image. The destination bucket must exist
        /// and have an access control list (ACL) attached that specifies the Region-specific
        /// canonical account ID for the <c>Grantee</c>. For more information about the ACL to
        /// your S3 bucket, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmexport.html#vmexport-prerequisites">Prerequisites</a>
        /// in the VM Import/Export User Guide.
        /// </para>
        /// </summary>
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The image is written to a single object in the Amazon S3 bucket at the S3 key s3prefix
        /// + exportTaskId + '.' + diskImageFormat.
        /// </para>
        /// </summary>
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;
    }
}
