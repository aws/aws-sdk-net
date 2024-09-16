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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains the configuration of the S3 location of the input data.
    /// </summary>
    public partial class ModelInvocationJobS3InputDataConfig
    {
        private string _s3BucketOwner;
        private S3InputFormat _s3InputFormat;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the S3 bucket containing the input
        /// data.
        /// </para>
        /// </summary>
        public string S3BucketOwner
        {
            get { return this._s3BucketOwner; }
            set { this._s3BucketOwner = value; }
        }

        // Check to see if S3BucketOwner property is set
        internal bool IsSetS3BucketOwner()
        {
            return this._s3BucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property S3InputFormat. 
        /// <para>
        /// The format of the input data.
        /// </para>
        /// </summary>
        public S3InputFormat S3InputFormat
        {
            get { return this._s3InputFormat; }
            set { this._s3InputFormat = value; }
        }

        // Check to see if S3InputFormat property is set
        internal bool IsSetS3InputFormat()
        {
            return this._s3InputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The S3 location of the input data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}