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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the total storage size (in bytes) or number of objects
    /// that Amazon Macie can't analyze in one or more S3 buckets. In a BucketMetadata or
    /// MatchingBucket object, this data is for a specific bucket. In a GetBucketStatisticsResponse
    /// object, this data is aggregated for all the buckets in the query results. If versioning
    /// is enabled for a bucket, storage size values are based on the size of the latest version
    /// of each applicable object in the bucket.
    /// </summary>
    public partial class ObjectLevelStatistics
    {
        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// The total storage size (in bytes) or number of objects that Amazon Macie can't analyze
        /// because the objects don't have a file name extension for a supported file or storage
        /// format.
        /// </para>
        /// </summary>
        public long? FileType { get; set; }

        /// <summary>
        /// Checks to see if the FileType property is set.
        /// </summary>
        internal bool IsSetFileType() => this.FileType.HasValue;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The total storage size (in bytes) or number of objects that Amazon Macie can't analyze
        /// because the objects use an unsupported storage class.
        /// </para>
        /// </summary>
        public long? StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass.HasValue;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total storage size (in bytes) or number of objects that Amazon Macie can't analyze
        /// because the objects use an unsupported storage class or don't have a file name extension
        /// for a supported file or storage format.
        /// </para>
        /// </summary>
        public long? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;
    }
}
