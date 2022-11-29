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
    /// Provides statistical data for sensitive data discovery metrics that apply to an S3
    /// bucket that Amazon Macie monitors and analyzes for your account. The statistics capture
    /// the results of automated sensitive data discovery activities that Macie has performed
    /// for the bucket. The data is available only if automated sensitive data discovery is
    /// currently enabled for your account.
    /// </summary>
    public partial class ResourceStatistics
    {
        private long? _totalBytesClassified;
        private long? _totalDetections;
        private long? _totalDetectionsSuppressed;
        private long? _totalItemsClassified;
        private long? _totalItemsSensitive;
        private long? _totalItemsSkipped;
        private long? _totalItemsSkippedInvalidEncryption;
        private long? _totalItemsSkippedInvalidKms;
        private long? _totalItemsSkippedPermissionDenied;

        /// <summary>
        /// Gets and sets the property TotalBytesClassified. 
        /// <para>
        /// The total amount of data, in bytes, that Amazon Macie has analyzed in the bucket.
        /// </para>
        /// </summary>
        public long TotalBytesClassified
        {
            get { return this._totalBytesClassified.GetValueOrDefault(); }
            set { this._totalBytesClassified = value; }
        }

        // Check to see if TotalBytesClassified property is set
        internal bool IsSetTotalBytesClassified()
        {
            return this._totalBytesClassified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalDetections. 
        /// <para>
        /// The total number of occurrences of sensitive data that Amazon Macie has found in the
        /// bucket's objects. This includes occurrences that are currently suppressed by the sensitivity
        /// scoring settings for the bucket (totalDetectionsSuppressed).
        /// </para>
        /// </summary>
        public long TotalDetections
        {
            get { return this._totalDetections.GetValueOrDefault(); }
            set { this._totalDetections = value; }
        }

        // Check to see if TotalDetections property is set
        internal bool IsSetTotalDetections()
        {
            return this._totalDetections.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalDetectionsSuppressed. 
        /// <para>
        /// The total number of occurrences of sensitive data that are currently suppressed by
        /// the sensitivity scoring settings for the bucket. These represent occurrences of sensitive
        /// data that Amazon Macie found in the bucket's objects, but the occurrences were manually
        /// suppressed. By default, suppressed occurrences are excluded from the bucket's sensitivity
        /// score.
        /// </para>
        /// </summary>
        public long TotalDetectionsSuppressed
        {
            get { return this._totalDetectionsSuppressed.GetValueOrDefault(); }
            set { this._totalDetectionsSuppressed = value; }
        }

        // Check to see if TotalDetectionsSuppressed property is set
        internal bool IsSetTotalDetectionsSuppressed()
        {
            return this._totalDetectionsSuppressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalItemsClassified. 
        /// <para>
        /// The total number of objects that Amazon Macie has analyzed in the bucket.
        /// </para>
        /// </summary>
        public long TotalItemsClassified
        {
            get { return this._totalItemsClassified.GetValueOrDefault(); }
            set { this._totalItemsClassified = value; }
        }

        // Check to see if TotalItemsClassified property is set
        internal bool IsSetTotalItemsClassified()
        {
            return this._totalItemsClassified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalItemsSensitive. 
        /// <para>
        /// The total number of the bucket's objects that Amazon Macie has found sensitive data
        /// in.
        /// </para>
        /// </summary>
        public long TotalItemsSensitive
        {
            get { return this._totalItemsSensitive.GetValueOrDefault(); }
            set { this._totalItemsSensitive = value; }
        }

        // Check to see if TotalItemsSensitive property is set
        internal bool IsSetTotalItemsSensitive()
        {
            return this._totalItemsSensitive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalItemsSkipped. 
        /// <para>
        /// The total number of objects that Amazon Macie hasn't analyzed in the bucket due to
        /// an error or issue. For example, the object is a malformed file. This value includes
        /// objects that Macie hasn't analyzed for reasons reported by other statistics in the
        /// ResourceStatistics object.
        /// </para>
        /// </summary>
        public long TotalItemsSkipped
        {
            get { return this._totalItemsSkipped.GetValueOrDefault(); }
            set { this._totalItemsSkipped = value; }
        }

        // Check to see if TotalItemsSkipped property is set
        internal bool IsSetTotalItemsSkipped()
        {
            return this._totalItemsSkipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalItemsSkippedInvalidEncryption. 
        /// <para>
        /// The total number of objects that Amazon Macie hasn't analyzed in the bucket because
        /// the objects are encrypted with a key that Macie isn't allowed to use.
        /// </para>
        /// </summary>
        public long TotalItemsSkippedInvalidEncryption
        {
            get { return this._totalItemsSkippedInvalidEncryption.GetValueOrDefault(); }
            set { this._totalItemsSkippedInvalidEncryption = value; }
        }

        // Check to see if TotalItemsSkippedInvalidEncryption property is set
        internal bool IsSetTotalItemsSkippedInvalidEncryption()
        {
            return this._totalItemsSkippedInvalidEncryption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalItemsSkippedInvalidKms. 
        /// <para>
        /// The total number of objects that Amazon Macie hasn't analyzed in the bucket because
        /// the objects are encrypted with an KMS key that was disabled or deleted.
        /// </para>
        /// </summary>
        public long TotalItemsSkippedInvalidKms
        {
            get { return this._totalItemsSkippedInvalidKms.GetValueOrDefault(); }
            set { this._totalItemsSkippedInvalidKms = value; }
        }

        // Check to see if TotalItemsSkippedInvalidKms property is set
        internal bool IsSetTotalItemsSkippedInvalidKms()
        {
            return this._totalItemsSkippedInvalidKms.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalItemsSkippedPermissionDenied. 
        /// <para>
        /// The total number of objects that Amazon Macie hasn't analyzed in the bucket because
        /// Macie isn't allowed to access the objects.
        /// </para>
        /// </summary>
        public long TotalItemsSkippedPermissionDenied
        {
            get { return this._totalItemsSkippedPermissionDenied.GetValueOrDefault(); }
            set { this._totalItemsSkippedPermissionDenied = value; }
        }

        // Check to see if TotalItemsSkippedPermissionDenied property is set
        internal bool IsSetTotalItemsSkippedPermissionDenied()
        {
            return this._totalItemsSkippedPermissionDenied.HasValue; 
        }

    }
}