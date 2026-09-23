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
    /// Provides statistical data for sensitive data discovery metrics that apply to an S3
    /// bucket that Amazon Macie monitors and analyzes for an account, if automated sensitive
    /// data discovery has been enabled for the account. The data captures the results of
    /// automated sensitive data discovery activities that Macie has performed for the bucket.
    /// </summary>
    public partial class ResourceStatistics
    {
        /// <summary>
        /// Gets and sets the property TotalBytesClassified. 
        /// <para>
        /// The total amount of data, in bytes, that Amazon Macie has analyzed in the bucket.
        /// </para>
        /// </summary>
        public long? TotalBytesClassified { get; set; }

        /// <summary>
        /// Checks to see if the TotalBytesClassified property is set.
        /// </summary>
        internal bool IsSetTotalBytesClassified() => this.TotalBytesClassified.HasValue;

        /// <summary>
        /// Gets and sets the property TotalDetections. 
        /// <para>
        /// The total number of occurrences of sensitive data that Amazon Macie has found in the
        /// bucket's objects. This includes occurrences that are currently suppressed by the sensitivity
        /// scoring settings for the bucket (totalDetectionsSuppressed).
        /// </para>
        /// </summary>
        public long? TotalDetections { get; set; }

        /// <summary>
        /// Checks to see if the TotalDetections property is set.
        /// </summary>
        internal bool IsSetTotalDetections() => this.TotalDetections.HasValue;

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
        public long? TotalDetectionsSuppressed { get; set; }

        /// <summary>
        /// Checks to see if the TotalDetectionsSuppressed property is set.
        /// </summary>
        internal bool IsSetTotalDetectionsSuppressed() => this.TotalDetectionsSuppressed.HasValue;

        /// <summary>
        /// Gets and sets the property TotalItemsClassified. 
        /// <para>
        /// The total number of objects that Amazon Macie has analyzed in the bucket.
        /// </para>
        /// </summary>
        public long? TotalItemsClassified { get; set; }

        /// <summary>
        /// Checks to see if the TotalItemsClassified property is set.
        /// </summary>
        internal bool IsSetTotalItemsClassified() => this.TotalItemsClassified.HasValue;

        /// <summary>
        /// Gets and sets the property TotalItemsSensitive. 
        /// <para>
        /// The total number of the bucket's objects that Amazon Macie has found sensitive data
        /// in.
        /// </para>
        /// </summary>
        public long? TotalItemsSensitive { get; set; }

        /// <summary>
        /// Checks to see if the TotalItemsSensitive property is set.
        /// </summary>
        internal bool IsSetTotalItemsSensitive() => this.TotalItemsSensitive.HasValue;

        /// <summary>
        /// Gets and sets the property TotalItemsSkipped. 
        /// <para>
        /// The total number of objects that Amazon Macie wasn't able to analyze in the bucket
        /// due to an object-level issue or error. For example, an object is a malformed file.
        /// This value includes objects that Macie wasn't able to analyze for reasons reported
        /// by other statistics in the ResourceStatistics object.
        /// </para>
        /// </summary>
        public long? TotalItemsSkipped { get; set; }

        /// <summary>
        /// Checks to see if the TotalItemsSkipped property is set.
        /// </summary>
        internal bool IsSetTotalItemsSkipped() => this.TotalItemsSkipped.HasValue;

        /// <summary>
        /// Gets and sets the property TotalItemsSkippedInvalidEncryption. 
        /// <para>
        /// The total number of objects that Amazon Macie wasn't able to analyze in the bucket
        /// because the objects are encrypted with a key that Macie can't access. The objects
        /// use server-side encryption with customer-provided keys (SSE-C).
        /// </para>
        /// </summary>
        public long? TotalItemsSkippedInvalidEncryption { get; set; }

        /// <summary>
        /// Checks to see if the TotalItemsSkippedInvalidEncryption property is set.
        /// </summary>
        internal bool IsSetTotalItemsSkippedInvalidEncryption() => this.TotalItemsSkippedInvalidEncryption.HasValue;

        /// <summary>
        /// Gets and sets the property TotalItemsSkippedInvalidKms. 
        /// <para>
        /// The total number of objects that Amazon Macie wasn't able to analyze in the bucket
        /// because the objects are encrypted with KMS keys that were disabled, are scheduled
        /// for deletion, or were deleted.
        /// </para>
        /// </summary>
        public long? TotalItemsSkippedInvalidKms { get; set; }

        /// <summary>
        /// Checks to see if the TotalItemsSkippedInvalidKms property is set.
        /// </summary>
        internal bool IsSetTotalItemsSkippedInvalidKms() => this.TotalItemsSkippedInvalidKms.HasValue;

        /// <summary>
        /// Gets and sets the property TotalItemsSkippedPermissionDenied. 
        /// <para>
        /// The total number of objects that Amazon Macie wasn't able to analyze in the bucket
        /// due to the permissions settings for the objects or the permissions settings for the
        /// keys that were used to encrypt the objects.
        /// </para>
        /// </summary>
        public long? TotalItemsSkippedPermissionDenied { get; set; }

        /// <summary>
        /// Checks to see if the TotalItemsSkippedPermissionDenied property is set.
        /// </summary>
        internal bool IsSetTotalItemsSkippedPermissionDenied() => this.TotalItemsSkippedPermissionDenied.HasValue;
    }
}
