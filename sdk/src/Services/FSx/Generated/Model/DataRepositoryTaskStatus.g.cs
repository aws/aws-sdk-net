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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Provides the task status showing a running total of the total number of files to be
    /// processed, the number successfully processed, and the number of files the task failed
    /// to process.
    /// </summary>
    public partial class DataRepositoryTaskStatus
    {
        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// A running total of the number of files that the task failed to process.
        /// </para>
        /// </summary>
        public long? FailedCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedCount property is set.
        /// </summary>
        internal bool IsSetFailedCount() => this.FailedCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time at which the task status was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReleasedCapacity. 
        /// <para>
        /// The total amount of data, in GiB, released by an Amazon File Cache AUTO_RELEASE_DATA
        /// task that automatically releases files from the cache.
        /// </para>
        /// </summary>
        public long? ReleasedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ReleasedCapacity property is set.
        /// </summary>
        internal bool IsSetReleasedCapacity() => this.ReleasedCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property SucceededCount. 
        /// <para>
        /// A running total of the number of files that the task has successfully processed.
        /// </para>
        /// </summary>
        public long? SucceededCount { get; set; }

        /// <summary>
        /// Checks to see if the SucceededCount property is set.
        /// </summary>
        internal bool IsSetSucceededCount() => this.SucceededCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of files that the task will process. While a task is executing, the
        /// sum of <c>SucceededCount</c> plus <c>FailedCount</c> may not equal <c>TotalCount</c>.
        /// When the task is complete, <c>TotalCount</c> equals the sum of <c>SucceededCount</c>
        /// plus <c>FailedCount</c>.
        /// </para>
        /// </summary>
        public long? TotalCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalCount property is set.
        /// </summary>
        internal bool IsSetTotalCount() => this.TotalCount.HasValue;
    }
}
