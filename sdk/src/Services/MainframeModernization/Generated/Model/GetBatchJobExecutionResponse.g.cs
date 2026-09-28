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

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// This is the response object from the GetBatchJobExecution operation.
    /// </summary>
    public partial class GetBatchJobExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property BatchJobIdentifier. 
        /// <para>
        /// The unique identifier of this batch job.
        /// </para>
        /// </summary>
        public BatchJobIdentifier BatchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BatchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetBatchJobIdentifier() => this.BatchJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the batch job execution ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier for this batch job execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier for this batch job.
        /// </para>
        /// </summary>
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of this batch job.
        /// </para>
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobStepRestartMarker. 
        /// <para>
        /// The step/procedure step information for the restart batch job operation.
        /// </para>
        /// </summary>
        public JobStepRestartMarker JobStepRestartMarker { get; set; }

        /// <summary>
        /// Checks to see if the JobStepRestartMarker property is set.
        /// </summary>
        internal bool IsSetJobStepRestartMarker() => this.JobStepRestartMarker != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of job.
        /// </para>
        /// </summary>
        public BatchJobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property JobUser. 
        /// <para>
        /// The user for the job.
        /// </para>
        /// </summary>
        public string JobUser { get; set; }

        /// <summary>
        /// Checks to see if the JobUser property is set.
        /// </summary>
        internal bool IsSetJobUser() => this.JobUser != null;

        /// <summary>
        /// Gets and sets the property ReturnCode. 
        /// <para>
        /// The batch job return code from either the Blu Age or Micro Focus runtime engines.
        /// For more information, see <a href="https://www.ibm.com/docs/en/was/8.5.5?topic=model-batch-return-codes">Batch
        /// return codes</a> in the <i>IBM WebSphere Application Server</i> documentation.
        /// </para>
        /// </summary>
        public string ReturnCode { get; set; }

        /// <summary>
        /// Checks to see if the ReturnCode property is set.
        /// </summary>
        internal bool IsSetReturnCode() => this.ReturnCode != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the batch job execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch job execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchJobExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the reported status.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
