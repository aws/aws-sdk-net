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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when Amazon S3 is used as a destination.
    /// </summary>
    public partial class S3DestinationProperties
    {
        private string _bucketName;
        private string _bucketPrefix;
        private S3OutputFormatConfig _s3OutputFormatConfig;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The Amazon S3 bucket name in which Amazon AppFlow places the transferred data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  The object key for the destination bucket in which Amazon AppFlow places the files.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string BucketPrefix
        {
            get { return this._bucketPrefix; }
            set { this._bucketPrefix = value; }
        }

        // Check to see if BucketPrefix property is set
        internal bool IsSetBucketPrefix()
        {
            return this._bucketPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputFormatConfig.
        /// </summary>
        public S3OutputFormatConfig S3OutputFormatConfig
        {
            get { return this._s3OutputFormatConfig; }
            set { this._s3OutputFormatConfig = value; }
        }

        // Check to see if S3OutputFormatConfig property is set
        internal bool IsSetS3OutputFormatConfig()
        {
            return this._s3OutputFormatConfig != null;
        }

    }
}