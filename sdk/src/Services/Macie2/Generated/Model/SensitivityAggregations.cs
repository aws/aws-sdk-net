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
    /// Provides aggregated statistical data for sensitive data discovery metrics that apply
    /// to S3 buckets. Each field contains aggregated data for all the buckets that have a
    /// sensitivity score (sensitivityScore) of a specified value or within a specified range
    /// (BucketStatisticsBySensitivity). If automated sensitive data discovery is currently
    /// disabled for your account, the value for each field is 0.
    /// </summary>
    public partial class SensitivityAggregations
    {
        private long? _classifiableSizeInBytes;
        private long? _publiclyAccessibleCount;
        private long? _totalCount;
        private long? _totalSizeInBytes;

        /// <summary>
        /// Gets and sets the property ClassifiableSizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of all the objects that Amazon Macie can analyze
        /// in the buckets. These objects use a supported storage class and have a file name extension
        /// for a supported file or storage format.
        /// </para>
        ///  
        /// <para>
        /// If versioning is enabled for any of the buckets, this value is based on the size of
        /// the latest version of each applicable object in the buckets. This value doesn't reflect
        /// the storage size of all versions of all applicable objects in the buckets.
        /// </para>
        /// </summary>
        public long ClassifiableSizeInBytes
        {
            get { return this._classifiableSizeInBytes.GetValueOrDefault(); }
            set { this._classifiableSizeInBytes = value; }
        }

        // Check to see if ClassifiableSizeInBytes property is set
        internal bool IsSetClassifiableSizeInBytes()
        {
            return this._classifiableSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessibleCount. 
        /// <para>
        /// The total number of buckets that are publicly accessible based on a combination of
        /// permissions settings for each bucket.
        /// </para>
        /// </summary>
        public long PubliclyAccessibleCount
        {
            get { return this._publiclyAccessibleCount.GetValueOrDefault(); }
            set { this._publiclyAccessibleCount = value; }
        }

        // Check to see if PubliclyAccessibleCount property is set
        internal bool IsSetPubliclyAccessibleCount()
        {
            return this._publiclyAccessibleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of buckets.
        /// </para>
        /// </summary>
        public long TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of the buckets.
        /// </para>
        ///  
        /// <para>
        /// If versioning is enabled for any of the buckets, this value is based on the size of
        /// the latest version of each object in the buckets. This value doesn't reflect the storage
        /// size of all versions of the objects in the buckets.
        /// </para>
        /// </summary>
        public long TotalSizeInBytes
        {
            get { return this._totalSizeInBytes.GetValueOrDefault(); }
            set { this._totalSizeInBytes = value; }
        }

        // Check to see if TotalSizeInBytes property is set
        internal bool IsSetTotalSizeInBytes()
        {
            return this._totalSizeInBytes.HasValue; 
        }

    }
}