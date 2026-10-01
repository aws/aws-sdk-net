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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when Upsolver is used as a destination.
    /// </summary>
    public partial class UpsolverDestinationProperties
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The Upsolver Amazon S3 bucket name in which Amazon AppFlow places the transferred
        /// data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 63)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  The object key for the destination Upsolver Amazon S3 bucket in which Amazon AppFlow
        /// places the files. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string BucketPrefix { get; set; }

        /// <summary>
        /// Checks to see if the BucketPrefix property is set.
        /// </summary>
        internal bool IsSetBucketPrefix() => this.BucketPrefix != null;

        /// <summary>
        /// Gets and sets the property S3OutputFormatConfig. 
        /// <para>
        ///  The configuration that determines how data is formatted when Upsolver is used as
        /// the flow destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UpsolverS3OutputFormatConfig S3OutputFormatConfig { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputFormatConfig property is set.
        /// </summary>
        internal bool IsSetS3OutputFormatConfig() => this.S3OutputFormatConfig != null;
    }
}
