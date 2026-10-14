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

namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// Describes the destination Amazon Simple Storage Service (Amazon S3) bucket name and
    /// object keys of a data exports file.
    /// </summary>
    public partial class S3Destination
    {
        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket used as the destination of a data export file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3BucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID that owns the S3 bucket used as the destination
        /// for the data export.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string S3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketOwner property is set.
        /// </summary>
        internal bool IsSetS3BucketOwner() => this.S3BucketOwner != null;

        /// <summary>
        /// Gets and sets the property S3OutputConfigurations. 
        /// <para>
        /// The output configuration for the data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3OutputConfigurations S3OutputConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputConfigurations property is set.
        /// </summary>
        internal bool IsSetS3OutputConfigurations() => this.S3OutputConfigurations != null;

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The S3 path prefix you want prepended to the name of your data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;

        /// <summary>
        /// Gets and sets the property S3Region. 
        /// <para>
        /// The S3 bucket Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string S3Region { get; set; }

        /// <summary>
        /// Checks to see if the S3Region property is set.
        /// </summary>
        internal bool IsSetS3Region() => this.S3Region != null;
    }
}
