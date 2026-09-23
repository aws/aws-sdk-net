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
    /// Amazon S3 logging configuration.
    /// </summary>
    public partial class S3Logs
    {
        private string _s3BucketName;
        private string _s3KeyPrefix;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of an existing Amazon S3 bucket where Image Builder saves build logs. The
        /// bucket isn't validated when you create or update the configuration, and Image Builder
        /// doesn't create it. The instance profile associated with this infrastructure configuration
        /// must have permission to write to the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The Amazon S3 key prefix under which Image Builder writes build and test logs in the
        /// bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

    }
}