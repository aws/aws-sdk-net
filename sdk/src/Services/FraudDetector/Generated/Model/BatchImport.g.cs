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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The batch import job details.
    /// </summary>
    public partial class BatchImport
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the batch import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// Timestamp of when batch import job completed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime != null;

        /// <summary>
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The name of the event type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EventTypeName { get; set; }

        /// <summary>
        /// Checks to see if the EventTypeName property is set.
        /// </summary>
        internal bool IsSetEventTypeName() => this.EventTypeName != null;

        /// <summary>
        /// Gets and sets the property FailedRecordsCount. 
        /// <para>
        /// The number of records that failed to import. 
        /// </para>
        /// </summary>
        public int? FailedRecordsCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedRecordsCount property is set.
        /// </summary>
        internal bool IsSetFailedRecordsCount() => this.FailedRecordsCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason batch import job failed.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role to use for this job request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property InputPath. 
        /// <para>
        /// The Amazon S3 location of your data file for batch import.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string InputPath { get; set; }

        /// <summary>
        /// Checks to see if the InputPath property is set.
        /// </summary>
        internal bool IsSetInputPath() => this.InputPath != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the batch import job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property OutputPath. 
        /// <para>
        /// The Amazon S3 location of your output file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string OutputPath { get; set; }

        /// <summary>
        /// Checks to see if the OutputPath property is set.
        /// </summary>
        internal bool IsSetOutputPath() => this.OutputPath != null;

        /// <summary>
        /// Gets and sets the property ProcessedRecordsCount. 
        /// <para>
        /// The number of records processed by batch import job.
        /// </para>
        /// </summary>
        public int? ProcessedRecordsCount { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedRecordsCount property is set.
        /// </summary>
        internal bool IsSetProcessedRecordsCount() => this.ProcessedRecordsCount.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Timestamp of when the batch import job started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch import job.
        /// </para>
        /// </summary>
        public AsyncJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalRecordsCount. 
        /// <para>
        /// The total number of records in the batch import job.
        /// </para>
        /// </summary>
        public int? TotalRecordsCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecordsCount property is set.
        /// </summary>
        internal bool IsSetTotalRecordsCount() => this.TotalRecordsCount.HasValue;
    }
}
