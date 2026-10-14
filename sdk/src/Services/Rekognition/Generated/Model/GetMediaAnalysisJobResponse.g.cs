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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the GetMediaAnalysisJob operation.
    /// </summary>
    public partial class GetMediaAnalysisJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletionTimestamp. 
        /// <para>
        /// The Unix date and time when the job finished.
        /// </para>
        /// </summary>
        public DateTime? CompletionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTimestamp property is set.
        /// </summary>
        internal bool IsSetCompletionTimestamp() => this.CompletionTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The Unix date and time when the job was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Details about the error that resulted in failure of the job.
        /// </para>
        /// </summary>
        public MediaAnalysisJobFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Reference to the input manifest that was provided in the job creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaAnalysisInput Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier for the media analysis job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the media analysis job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// KMS Key that was provided in the creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ManifestSummary. 
        /// <para>
        /// The summary manifest provides statistics on input manifest and errors identified in
        /// the input manifest.
        /// </para>
        /// </summary>
        public MediaAnalysisManifestSummary ManifestSummary { get; set; }

        /// <summary>
        /// Checks to see if the ManifestSummary property is set.
        /// </summary>
        internal bool IsSetManifestSummary() => this.ManifestSummary != null;

        /// <summary>
        /// Gets and sets the property OperationsConfig. 
        /// <para>
        /// Operation configurations that were provided during job creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaAnalysisOperationsConfig OperationsConfig { get; set; }

        /// <summary>
        /// Checks to see if the OperationsConfig property is set.
        /// </summary>
        internal bool IsSetOperationsConfig() => this.OperationsConfig != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Output configuration that was provided in the creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaAnalysisOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// Output manifest that contains prediction results.
        /// </para>
        /// </summary>
        public MediaAnalysisResults Results { get; set; }

        /// <summary>
        /// Checks to see if the Results property is set.
        /// </summary>
        internal bool IsSetResults() => this.Results != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the media analysis job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MediaAnalysisJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
