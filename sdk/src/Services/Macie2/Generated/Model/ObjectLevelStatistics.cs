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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private long? _fileType;
        private long? _storageClass;
        private long? _total;

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// The total storage size (in bytes) or number of objects that Amazon Macie can't analyze
        /// because the objects don't have a file name extension for a supported file or storage
        /// format.
        /// </para>
        /// </summary>
        public long FileType
        {
            get { return this._fileType.GetValueOrDefault(); }
            set { this._fileType = value; }
        }

        // Check to see if FileType property is set
        internal bool IsSetFileType()
        {
            return this._fileType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The total storage size (in bytes) or number of objects that Amazon Macie can't analyze
        /// because the objects use an unsupported storage class.
        /// </para>
        /// </summary>
        public long StorageClass
        {
            get { return this._storageClass.GetValueOrDefault(); }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total storage size (in bytes) or number of objects that Amazon Macie can't analyze
        /// because the objects use an unsupported storage class or don't have a file name extension
        /// for a supported file or storage format.
        /// </para>
        /// </summary>
        public long Total
        {
            get { return this._total.GetValueOrDefault(); }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}