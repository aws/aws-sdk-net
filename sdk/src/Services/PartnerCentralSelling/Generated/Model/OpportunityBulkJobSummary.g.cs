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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// The status, record counts, and input file name of an opportunity bulk job.
    /// </summary>
    public partial class OpportunityBulkJobSummary
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The date and time, in UTC, when the bulk job finished.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC, when you created the bulk job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCount. 
        /// <para>
        /// The number of records that failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FailureCount { get; set; }

        /// <summary>
        /// Checks to see if the FailureCount property is set.
        /// </summary>
        internal bool IsSetFailureCount() => this.FailureCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason that the bulk job failed. Present only when <c>Status</c> is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the input file that started the bulk job. Use it to identify the job by
        /// its file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the bulk job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// Indicates whether the bulk job creates or updates opportunities, based on the template
        /// of the input file. Partner Central doesn't set this field until it reads the file.
        /// </para>
        /// </summary>
        public BulkOperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property ProcessedRecords. 
        /// <para>
        /// The number of records that Partner Central has processed so far.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProcessedRecords { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedRecords property is set.
        /// </summary>
        internal bool IsSetProcessedRecords() => this.ProcessedRecords.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time, in UTC, when the bulk job started processing records.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the bulk job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BulkJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SuccessCount. 
        /// <para>
        /// The number of records that succeeded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// Checks to see if the SuccessCount property is set.
        /// </summary>
        internal bool IsSetSuccessCount() => this.SuccessCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalRecords. 
        /// <para>
        /// The total number of records in the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecords property is set.
        /// </summary>
        internal bool IsSetTotalRecords() => this.TotalRecords.HasValue;
    }
}
