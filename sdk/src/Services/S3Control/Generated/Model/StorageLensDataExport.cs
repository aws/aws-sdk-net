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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
        private CloudWatchMetrics _cloudWatchMetrics;
        private S3BucketDestination _s3BucketDestination;

        /// <summary>
        /// Gets and sets the property CloudWatchMetrics. 
        /// <para>
        /// A container for enabling Amazon CloudWatch publishing for S3 Storage Lens metrics.
        /// </para>
        /// </summary>
        public CloudWatchMetrics CloudWatchMetrics
        {
            get { return this._cloudWatchMetrics; }
            set { this._cloudWatchMetrics = value; }
        }

        // Check to see if CloudWatchMetrics property is set
        internal bool IsSetCloudWatchMetrics()
        {
            return this._cloudWatchMetrics != null;
        }

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
        public S3BucketDestination S3BucketDestination
        {
            get { return this._s3BucketDestination; }
            set { this._s3BucketDestination = value; }
        }

        // Check to see if S3BucketDestination property is set
        internal bool IsSetS3BucketDestination()
        {
            return this._s3BucketDestination != null;
        }

    }
}