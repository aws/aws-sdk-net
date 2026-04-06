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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// A summary of the submissions in a batch.
    /// </summary>
    public partial class SubmissionSummary
    {
        private int? _failedCancelSubmissionCount;
        private int? _failedDeleteSubmissionCount;
        private int? _failedStartSubmissionCount;
        private int? _pendingStartSubmissionCount;
        private int? _successfulCancelSubmissionCount;
        private int? _successfulDeleteSubmissionCount;
        private int? _successfulStartSubmissionCount;

        /// <summary>
        /// Gets and sets the property FailedCancelSubmissionCount. 
        /// <para>
        /// The number of failed cancel submissions.
        /// </para>
        /// </summary>
        public int? FailedCancelSubmissionCount
        {
            get { return this._failedCancelSubmissionCount; }
            set { this._failedCancelSubmissionCount = value; }
        }

        // Check to see if FailedCancelSubmissionCount property is set
        internal bool IsSetFailedCancelSubmissionCount()
        {
            return this._failedCancelSubmissionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedDeleteSubmissionCount. 
        /// <para>
        /// The number of failed delete submissions.
        /// </para>
        /// </summary>
        public int? FailedDeleteSubmissionCount
        {
            get { return this._failedDeleteSubmissionCount; }
            set { this._failedDeleteSubmissionCount = value; }
        }

        // Check to see if FailedDeleteSubmissionCount property is set
        internal bool IsSetFailedDeleteSubmissionCount()
        {
            return this._failedDeleteSubmissionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedStartSubmissionCount. 
        /// <para>
        /// The number of failed start submissions.
        /// </para>
        /// </summary>
        public int? FailedStartSubmissionCount
        {
            get { return this._failedStartSubmissionCount; }
            set { this._failedStartSubmissionCount = value; }
        }

        // Check to see if FailedStartSubmissionCount property is set
        internal bool IsSetFailedStartSubmissionCount()
        {
            return this._failedStartSubmissionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingStartSubmissionCount. 
        /// <para>
        /// The number of pending start submissions.
        /// </para>
        /// </summary>
        public int? PendingStartSubmissionCount
        {
            get { return this._pendingStartSubmissionCount; }
            set { this._pendingStartSubmissionCount = value; }
        }

        // Check to see if PendingStartSubmissionCount property is set
        internal bool IsSetPendingStartSubmissionCount()
        {
            return this._pendingStartSubmissionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulCancelSubmissionCount. 
        /// <para>
        /// The number of successful cancel submissions.
        /// </para>
        /// </summary>
        public int? SuccessfulCancelSubmissionCount
        {
            get { return this._successfulCancelSubmissionCount; }
            set { this._successfulCancelSubmissionCount = value; }
        }

        // Check to see if SuccessfulCancelSubmissionCount property is set
        internal bool IsSetSuccessfulCancelSubmissionCount()
        {
            return this._successfulCancelSubmissionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulDeleteSubmissionCount. 
        /// <para>
        /// The number of successful delete submissions.
        /// </para>
        /// </summary>
        public int? SuccessfulDeleteSubmissionCount
        {
            get { return this._successfulDeleteSubmissionCount; }
            set { this._successfulDeleteSubmissionCount = value; }
        }

        // Check to see if SuccessfulDeleteSubmissionCount property is set
        internal bool IsSetSuccessfulDeleteSubmissionCount()
        {
            return this._successfulDeleteSubmissionCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulStartSubmissionCount. 
        /// <para>
        /// The number of successful start submissions.
        /// </para>
        /// </summary>
        public int? SuccessfulStartSubmissionCount
        {
            get { return this._successfulStartSubmissionCount; }
            set { this._successfulStartSubmissionCount = value; }
        }

        // Check to see if SuccessfulStartSubmissionCount property is set
        internal bool IsSetSuccessfulStartSubmissionCount()
        {
            return this._successfulStartSubmissionCount.HasValue; 
        }

    }
}