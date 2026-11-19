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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container to specify the properties of your S3 Storage Lens metrics export, including
    /// the destination, schema, and format.
    /// </summary>
    public partial class StorageLensDataExport
    {
        /// <summary>
        /// Gets and sets the property CloudWatchMetrics. 
        /// <para>
        /// A container for enabling Amazon CloudWatch publishing for S3 Storage Lens metrics.
        /// </para>
        /// </summary>
        public CloudWatchMetrics CloudWatchMetrics { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchMetrics property is set.
        /// </summary>
        internal bool IsSetCloudWatchMetrics() => this.CloudWatchMetrics != null;

        /// <summary>
        /// Gets and sets the property S3BucketDestination. 
        /// <para>
        /// A container for the bucket where the S3 Storage Lens metrics export will be located.
        /// </para>
        ///  <note> 
        /// <para>
        /// This bucket must be located in the same Region as the storage lens configuration.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public S3BucketDestination S3BucketDestination { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketDestination property is set.
        /// </summary>
        internal bool IsSetS3BucketDestination() => this.S3BucketDestination != null;

        /// <summary>
        /// Gets and sets the property StorageLensTableDestination. 
        /// <para>
        /// A container for configuring S3 Storage Lens data exports to read-only S3 table buckets.
        /// </para>
        /// </summary>
        public StorageLensTableDestination StorageLensTableDestination { get; set; }

        /// <summary>
        /// Checks to see if the StorageLensTableDestination property is set.
        /// </summary>
        internal bool IsSetStorageLensTableDestination() => this.StorageLensTableDestination != null;
    }
}
