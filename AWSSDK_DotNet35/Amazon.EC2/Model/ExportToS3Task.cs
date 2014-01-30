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
    /// 
    /// </summary>
    public class ExportToS3Task
    {
        
        private DiskImageFormat diskImageFormat;
        private ContainerFormat containerFormat;
        private string s3Bucket;
        private string s3Key;


        /// <summary>
        /// The format for the exported image.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>VMDK, RAW, VHD</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DiskImageFormat DiskImageFormat
        {
            get { return this.diskImageFormat; }
            set { this.diskImageFormat = value; }
        }

        // Check to see if DiskImageFormat property is set
        internal bool IsSetDiskImageFormat()
        {
            return this.diskImageFormat != null;
        }

        /// <summary>
        /// The container format used to combine disk images with metadata (such as OVF). If absent, only the disk image is exported.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ova</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ContainerFormat ContainerFormat
        {
            get { return this.containerFormat; }
            set { this.containerFormat = value; }
        }

        // Check to see if ContainerFormat property is set
        internal bool IsSetContainerFormat()
        {
            return this.containerFormat != null;
        }

        /// <summary>
        /// The Amazon S3 bucket for the destination image. The destination bucket must exist and grant WRITE and READ_ACL permissions to the AWS
        /// account <c>vm-import-export@amazon.com</c>.
        ///  
        /// </summary>
        public string S3Bucket
        {
            get { return this.s3Bucket; }
            set { this.s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this.s3Bucket != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string S3Key
        {
            get { return this.s3Key; }
            set { this.s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this.s3Key != null;
        }
    }
}
