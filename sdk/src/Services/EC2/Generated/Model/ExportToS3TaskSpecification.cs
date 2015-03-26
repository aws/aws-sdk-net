/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// 
    /// </summary>
    public partial class ExportToS3TaskSpecification
    {
        private ContainerFormat _containerFormat;
        private DiskImageFormat _diskImageFormat;
        private string _s3Bucket;
        private string _s3Prefix;

        /// <summary>
        /// Gets and sets the property ContainerFormat.
        /// </summary>
        public ContainerFormat ContainerFormat
        {
            get { return this._containerFormat; }
            set { this._containerFormat = value; }
        }

        // Check to see if ContainerFormat property is set
        internal bool IsSetContainerFormat()
        {
            return this._containerFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DiskImageFormat.
        /// </summary>
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
        /// Gets and sets the property S3Bucket.
        /// </summary>
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
        /// The image is written to a single object in the Amazon S3 bucket at the S3 key s3prefix
        /// + exportTaskId + '.' + diskImageFormat.
        /// </para>
        /// </summary>
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