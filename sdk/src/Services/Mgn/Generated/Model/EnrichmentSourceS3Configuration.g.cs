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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// S3 configuration for the source import file to be enriched.
    /// </summary>
    public partial class EnrichmentSourceS3Configuration
    {
        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the S3 bucket containing the source import file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The AWS account ID of the S3 bucket owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string S3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwner property is set.
        /// </summary>
        internal bool IsSetS3BucketOwner() => this.S3BucketOwner != null;

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The S3 key (path) for the source import file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3Key { get; set; }

        /// <summary>
        /// Checks to see if the S3Key property is set.
        /// </summary>
        internal bool IsSetS3Key() => this.S3Key != null;
    }
}
