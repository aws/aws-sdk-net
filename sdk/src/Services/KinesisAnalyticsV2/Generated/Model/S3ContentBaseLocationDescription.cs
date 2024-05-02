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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// The description of the S3 base location that holds the application.
    /// </summary>
    public partial class S3ContentBaseLocationDescription
    {
        private string _basePath;
        private string _bucketARN;

        /// <summary>
        /// Gets and sets the property BasePath. 
        /// <para>
        /// The base path for the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string BasePath
        {
            get { return this._basePath; }
            set { this._basePath = value; }
        }

        // Check to see if BasePath property is set
        internal bool IsSetBasePath()
        {
            return this._basePath != null;
        }

        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BucketARN
        {
            get { return this._bucketARN; }
            set { this._bucketARN = value; }
        }

        // Check to see if BucketARN property is set
        internal bool IsSetBucketARN()
        {
            return this._bucketARN != null;
        }

    }
}