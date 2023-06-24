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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// This is the response object from the GetVectorEnrichmentJob operation.
    /// </summary>
    public partial class GetVectorEnrichmentJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private int? _durationInSeconds;
        private VectorEnrichmentJobErrorDetails _errorDetails;
        private string _executionRoleArn;
        private VectorEnrichmentJobExportErrorDetails _exportErrorDetails;
        private VectorEnrichmentJobExportStatus _exportStatus;
        private VectorEnrichmentJobInputConfig _inputConfig;
        private VectorEnrichmentJobConfig _jobConfig;
        private string _kmsKeyId;
        private string _name;
        private VectorEnrichmentJobStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private VectorEnrichmentJobType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Vector Enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The creation time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration of the Vector Enrichment job, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Details about the errors generated during the Vector Enrichment job.
        /// </para>
        /// </summary>
        public VectorEnrichmentJobErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that you specified for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExportErrorDetails. 
        /// <para>
        /// Details about the errors generated during the ExportVectorEnrichmentJob.
        /// </para>
        /// </summary>
        public VectorEnrichmentJobExportErrorDetails ExportErrorDetails
        {
            get { return this._exportErrorDetails; }
            set { this._exportErrorDetails = value; }
        }

        // Check to see if ExportErrorDetails property is set
        internal bool IsSetExportErrorDetails()
        {
            return this._exportErrorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// The export status of the Vector Enrichment job being initiated.
        /// </para>
        /// </summary>
        public VectorEnrichmentJobExportStatus ExportStatus
        {
            get { return this._exportStatus; }
            set { this._exportStatus = value; }
        }

        // Check to see if ExportStatus property is set
        internal bool IsSetExportStatus()
        {
            return this._exportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Input configuration information for the Vector Enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorEnrichmentJobInputConfig InputConfig
        {
            get { return this._inputConfig; }
            set { this._inputConfig = value; }
        }

        // Check to see if InputConfig property is set
        internal bool IsSetInputConfig()
        {
            return this._inputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobConfig. 
        /// <para>
        /// An object containing information about the job configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorEnrichmentJobConfig JobConfig
        {
            get { return this._jobConfig; }
            set { this._jobConfig = value; }
        }

        // Check to see if JobConfig property is set
        internal bool IsSetJobConfig()
        {
            return this._jobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Key Management Service key ID for server-side encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Vector Enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the initiated Vector Enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorEnrichmentJobStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and a value.
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Vector Enrichment job being initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VectorEnrichmentJobType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}