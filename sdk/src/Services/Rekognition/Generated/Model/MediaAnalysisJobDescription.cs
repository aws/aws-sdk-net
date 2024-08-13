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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
    /// Description for a media analysis job.
    /// </summary>
    public partial class MediaAnalysisJobDescription
    {
        private DateTime? _completionTimestamp;
        private DateTime? _creationTimestamp;
        private MediaAnalysisJobFailureDetails _failureDetails;
        private MediaAnalysisInput _input;
        private string _jobId;
        private string _jobName;
        private string _kmsKeyId;
        private MediaAnalysisManifestSummary _manifestSummary;
        private MediaAnalysisOperationsConfig _operationsConfig;
        private MediaAnalysisOutputConfig _outputConfig;
        private MediaAnalysisResults _results;
        private MediaAnalysisJobStatus _status;

        /// <summary>
        /// Gets and sets the property CompletionTimestamp. 
        /// <para>
        /// The Unix date and time when the job finished.
        /// </para>
        /// </summary>
        public DateTime? CompletionTimestamp
        {
            get { return this._completionTimestamp; }
            set { this._completionTimestamp = value; }
        }

        // Check to see if CompletionTimestamp property is set
        internal bool IsSetCompletionTimestamp()
        {
            return this._completionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The Unix date and time when the job was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Details about the error that resulted in failure of the job.
        /// </para>
        /// </summary>
        public MediaAnalysisJobFailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Reference to the input manifest that was provided in the job creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaAnalysisInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier for a media analysis job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of a media analysis job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// KMS Key that was provided in the creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestSummary. 
        /// <para>
        /// Provides statistics on input manifest and errors identified in the input manifest.
        /// </para>
        /// </summary>
        public MediaAnalysisManifestSummary ManifestSummary
        {
            get { return this._manifestSummary; }
            set { this._manifestSummary = value; }
        }

        // Check to see if ManifestSummary property is set
        internal bool IsSetManifestSummary()
        {
            return this._manifestSummary != null;
        }

        /// <summary>
        /// Gets and sets the property OperationsConfig. 
        /// <para>
        /// Operation configurations that were provided during job creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaAnalysisOperationsConfig OperationsConfig
        {
            get { return this._operationsConfig; }
            set { this._operationsConfig = value; }
        }

        // Check to see if OperationsConfig property is set
        internal bool IsSetOperationsConfig()
        {
            return this._operationsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Output configuration that was provided in the creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaAnalysisOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// Output manifest that contains prediction results.
        /// </para>
        /// </summary>
        public MediaAnalysisResults Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the media analysis job being retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaAnalysisJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}