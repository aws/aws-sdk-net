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
    /// A bulk job in the results of <c>ListCustomerAccountBulkJobs</c>. It includes the job
    /// status, the file name, and the record counts.
    /// </summary>
    public partial class CustomerAccountBulkJobSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bulk job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The date and time when the job finished. Absent while the job is running.
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
        /// The date and time when the bulk job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeletedCount. 
        /// <para>
        /// The number of accounts imported by this job that have since been deleted. This counter
        /// only increases, so the accounts still present equal <c>SuccessCount</c> minus <c>DeletedCount</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// Checks to see if the DeletedCount property is set.
        /// </summary>
        internal bool IsSetDeletedCount() => this.DeletedCount.HasValue;

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
        /// The reason that the job failed. Present only when the job status is <c>FAILED</c>.
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
        /// The name of the file that the job processes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the bulk job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ProcessedRecords. 
        /// <para>
        /// The number of records that the job has finished processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProcessedRecords { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedRecords property is set.
        /// </summary>
        internal bool IsSetProcessedRecords() => this.ProcessedRecords.HasValue;

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
        /// The number of records that the job processed successfully.
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
        /// The total number of records in the file. The value is 0 until the job reads the file.
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
