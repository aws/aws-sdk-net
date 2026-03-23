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
    /// This is the response object from the GetBatch operation.
    /// </summary>
    public partial class GetBatchResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private DefaultRunSetting _defaultRunSetting;
        private DateTime? _failedTime;
        private string _failureReason;
        private string _id;
        private string _name;
        private DateTime? _processedTime;
        private RunSummary _runSummary;
        private BatchStatus _status;
        private SubmissionSummary _submissionSummary;
        private DateTime? _submittedTime;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _totalRuns;
        private string _uuid;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique ARN of the run batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the batch was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultRunSetting. 
        /// <para>
        /// The shared configuration applied to all runs in the batch. See <c>DefaultRunSetting</c>.
        /// </para>
        /// </summary>
        public DefaultRunSetting DefaultRunSetting
        {
            get { return this._defaultRunSetting; }
            set { this._defaultRunSetting = value; }
        }

        // Check to see if DefaultRunSetting property is set
        internal bool IsSetDefaultRunSetting()
        {
            return this._defaultRunSetting != null;
        }

        /// <summary>
        /// Gets and sets the property FailedTime. 
        /// <para>
        /// The timestamp when the batch transitioned to a <c>FAILED</c> status.
        /// </para>
        /// </summary>
        public DateTime FailedTime
        {
            get { return this._failedTime.GetValueOrDefault(); }
            set { this._failedTime = value; }
        }

        // Check to see if FailedTime property is set
        internal bool IsSetFailedTime()
        {
            return this._failedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A description of the batch failure. Present only when status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier portion of the run batch ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional user-friendly name of the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessedTime. 
        /// <para>
        /// The timestamp when all run executions completed.
        /// </para>
        /// </summary>
        public DateTime ProcessedTime
        {
            get { return this._processedTime.GetValueOrDefault(); }
            set { this._processedTime = value; }
        }

        // Check to see if ProcessedTime property is set
        internal bool IsSetProcessedTime()
        {
            return this._processedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunSummary. 
        /// <para>
        /// A summary of run execution states. Run execution counts are eventually consistent
        /// and may lag behind actual run states. Final counts are accurate once the batch reaches
        /// <c>PROCESSED</c> status. See <c>RunSummary</c>.
        /// </para>
        /// </summary>
        public RunSummary RunSummary
        {
            get { return this._runSummary; }
            set { this._runSummary = value; }
        }

        // Check to see if RunSummary property is set
        internal bool IsSetRunSummary()
        {
            return this._runSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the run batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public BatchStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubmissionSummary. 
        /// <para>
        /// A summary of run submission outcomes. See <c>SubmissionSummary</c>.
        /// </para>
        /// </summary>
        public SubmissionSummary SubmissionSummary
        {
            get { return this._submissionSummary; }
            set { this._submissionSummary = value; }
        }

        // Check to see if SubmissionSummary property is set
        internal bool IsSetSubmissionSummary()
        {
            return this._submissionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SubmittedTime. 
        /// <para>
        /// The timestamp when all run submissions completed.
        /// </para>
        /// </summary>
        public DateTime SubmittedTime
        {
            get { return this._submittedTime.GetValueOrDefault(); }
            set { this._submittedTime = value; }
        }

        // Check to see if SubmittedTime property is set
        internal bool IsSetSubmittedTime()
        {
            return this._submittedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// AWS tags associated with the run batch.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalRuns. 
        /// <para>
        /// The total number of runs in the batch.
        /// </para>
        /// </summary>
        public int TotalRuns
        {
            get { return this._totalRuns.GetValueOrDefault(); }
            set { this._totalRuns = value; }
        }

        // Check to see if TotalRuns property is set
        internal bool IsSetTotalRuns()
        {
            return this._totalRuns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Uuid. 
        /// <para>
        /// The universally unique identifier (UUID) for the run batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Uuid
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if Uuid property is set
        internal bool IsSetUuid()
        {
            return this._uuid != null;
        }

    }
}