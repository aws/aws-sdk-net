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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// A summary of the submissions in a batch.
    /// </summary>
    public partial class SubmissionSummary
    {
        /// <summary>
        /// Gets and sets the property FailedCancelSubmissionCount. 
        /// <para>
        /// The number of failed cancel submissions.
        /// </para>
        /// </summary>
        public int? FailedCancelSubmissionCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedCancelSubmissionCount property is set.
        /// </summary>
        internal bool IsSetFailedCancelSubmissionCount() => this.FailedCancelSubmissionCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedDeleteSubmissionCount. 
        /// <para>
        /// The number of failed delete submissions.
        /// </para>
        /// </summary>
        public int? FailedDeleteSubmissionCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedDeleteSubmissionCount property is set.
        /// </summary>
        internal bool IsSetFailedDeleteSubmissionCount() => this.FailedDeleteSubmissionCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailedStartSubmissionCount. 
        /// <para>
        /// The number of failed start submissions.
        /// </para>
        /// </summary>
        public int? FailedStartSubmissionCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedStartSubmissionCount property is set.
        /// </summary>
        internal bool IsSetFailedStartSubmissionCount() => this.FailedStartSubmissionCount.HasValue;

        /// <summary>
        /// Gets and sets the property PendingStartSubmissionCount. 
        /// <para>
        /// The number of pending start submissions.
        /// </para>
        /// </summary>
        public int? PendingStartSubmissionCount { get; set; }

        /// <summary>
        /// Checks to see if the PendingStartSubmissionCount property is set.
        /// </summary>
        internal bool IsSetPendingStartSubmissionCount() => this.PendingStartSubmissionCount.HasValue;

        /// <summary>
        /// Gets and sets the property SuccessfulCancelSubmissionCount. 
        /// <para>
        /// The number of successful cancel submissions.
        /// </para>
        /// </summary>
        public int? SuccessfulCancelSubmissionCount { get; set; }

        /// <summary>
        /// Checks to see if the SuccessfulCancelSubmissionCount property is set.
        /// </summary>
        internal bool IsSetSuccessfulCancelSubmissionCount() => this.SuccessfulCancelSubmissionCount.HasValue;

        /// <summary>
        /// Gets and sets the property SuccessfulDeleteSubmissionCount. 
        /// <para>
        /// The number of successful delete submissions.
        /// </para>
        /// </summary>
        public int? SuccessfulDeleteSubmissionCount { get; set; }

        /// <summary>
        /// Checks to see if the SuccessfulDeleteSubmissionCount property is set.
        /// </summary>
        internal bool IsSetSuccessfulDeleteSubmissionCount() => this.SuccessfulDeleteSubmissionCount.HasValue;

        /// <summary>
        /// Gets and sets the property SuccessfulStartSubmissionCount. 
        /// <para>
        /// The number of successful start submissions.
        /// </para>
        /// </summary>
        public int? SuccessfulStartSubmissionCount { get; set; }

        /// <summary>
        /// Checks to see if the SuccessfulStartSubmissionCount property is set.
        /// </summary>
        internal bool IsSetSuccessfulStartSubmissionCount() => this.SuccessfulStartSubmissionCount.HasValue;
    }
}
