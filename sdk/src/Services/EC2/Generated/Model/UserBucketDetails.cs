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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Describes the Amazon S3 bucket for the disk image.
    /// </summary>
    public partial class UserBucketDetails
    {
        private string _s3Bucket;
        private string _s3Key;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket from which the disk image was created.
        /// </para>
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
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The file name of the disk image.
        /// </para>
        /// </summary>
        public string S3Key
        {
            get { return this._s3Key; }
            set { this._s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this._s3Key != null;
        }

    }
}