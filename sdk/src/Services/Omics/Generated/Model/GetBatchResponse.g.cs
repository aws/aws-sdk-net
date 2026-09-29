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
    /// This is the response object from the GetBatch operation.
    /// </summary>
    public partial class GetBatchResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique ARN of the run batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the batch was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultRunSetting. 
        /// <para>
        /// The shared configuration applied to all runs in the batch. See <c>DefaultRunSetting</c>.
        /// </para>
        /// </summary>
        public DefaultRunSetting DefaultRunSetting { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRunSetting property is set.
        /// </summary>
        internal bool IsSetDefaultRunSetting() => this.DefaultRunSetting != null;

        /// <summary>
        /// Gets and sets the property FailedTime. 
        /// <para>
        /// The timestamp when the batch transitioned to a <c>FAILED</c> status.
        /// </para>
        /// </summary>
        public DateTime? FailedTime { get; set; }

        /// <summary>
        /// Checks to see if the FailedTime property is set.
        /// </summary>
        internal bool IsSetFailedTime() => this.FailedTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A description of the batch failure. Present only when status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier portion of the run batch ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional user-friendly name of the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProcessedTime. 
        /// <para>
        /// The timestamp when all run executions completed.
        /// </para>
        /// </summary>
        public DateTime? ProcessedTime { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedTime property is set.
        /// </summary>
        internal bool IsSetProcessedTime() => this.ProcessedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RunSummary. 
        /// <para>
        /// A summary of run execution states. Run execution counts are eventually consistent
        /// and may lag behind actual run states. Final counts are accurate once the batch reaches
        /// <c>PROCESSED</c> status. See <c>RunSummary</c>.
        /// </para>
        /// </summary>
        public RunSummary RunSummary { get; set; }

        /// <summary>
        /// Checks to see if the RunSummary property is set.
        /// </summary>
        internal bool IsSetRunSummary() => this.RunSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the run batch. Possible values: <c>CREATING</c> (initial setup),
        /// <c>PENDING</c> (ready to submit runs), <c>SUBMITTING</c> (submitting runs), <c>INPROGRESS</c>
        /// (runs executing), <c>STOPPING</c> (cancellation in progress), <c>PROCESSED</c> (all
        /// runs completed), <c>CANCELLED</c> (batch cancelled), <c>FAILED</c> (batch failed),
        /// <c>RUNS_DELETING</c> (deleting runs), <c>RUNS_DELETE_FAILED</c> (run deletion failed
        /// for some or all runs), <c>RUNS_DELETED</c> (runs deleted).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public BatchStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubmissionSummary. 
        /// <para>
        /// A summary of run submission outcomes. See <c>SubmissionSummary</c>.
        /// </para>
        /// </summary>
        public SubmissionSummary SubmissionSummary { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionSummary property is set.
        /// </summary>
        internal bool IsSetSubmissionSummary() => this.SubmissionSummary != null;

        /// <summary>
        /// Gets and sets the property SubmittedTime. 
        /// <para>
        /// The timestamp when all run submissions completed.
        /// </para>
        /// </summary>
        public DateTime? SubmittedTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedTime property is set.
        /// </summary>
        internal bool IsSetSubmittedTime() => this.SubmittedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Amazon Web Services tags associated with the run batch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalRuns. 
        /// <para>
        /// The total number of runs in the batch.
        /// </para>
        /// </summary>
        public int? TotalRuns { get; set; }

        /// <summary>
        /// Checks to see if the TotalRuns property is set.
        /// </summary>
        internal bool IsSetTotalRuns() => this.TotalRuns.HasValue;

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The universally unique identifier (UUID) for the run batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Uuid { get; set; }

        /// <summary>
        /// Checks to see if the Uuid property is set.
        /// </summary>
        internal bool IsSetUuid() => this.Uuid != null;
    }
}
