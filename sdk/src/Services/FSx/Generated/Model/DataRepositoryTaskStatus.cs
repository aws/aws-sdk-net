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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Provides the task status showing a running total of the total number of files to be
    /// processed, the number successfully processed, and the number of files the task failed
    /// to process.
    /// </summary>
    public partial class DataRepositoryTaskStatus
    {
        private long? _failedCount;
        private DateTime? _lastUpdatedTime;
        private long? _succeededCount;
        private long? _totalCount;

        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// A running total of the number of files that the task failed to process.
        /// </para>
        /// </summary>
        public long FailedCount
        {
            get { return this._failedCount.GetValueOrDefault(); }
            set { this._failedCount = value; }
        }

        // Check to see if FailedCount property is set
        internal bool IsSetFailedCount()
        {
            return this._failedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time at which the task status was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SucceededCount. 
        /// <para>
        /// A running total of the number of files that the task has successfully processed.
        /// </para>
        /// </summary>
        public long SucceededCount
        {
            get { return this._succeededCount.GetValueOrDefault(); }
            set { this._succeededCount = value; }
        }

        // Check to see if SucceededCount property is set
        internal bool IsSetSucceededCount()
        {
            return this._succeededCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of files that the task will process. While a task is executing, the
        /// sum of <code>SucceededCount</code> plus <code>FailedCount</code> may not equal <code>TotalCount</code>.
        /// When the task is complete, <code>TotalCount</code> equals the sum of <code>SucceededCount</code>
        /// plus <code>FailedCount</code>.
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

    }
}