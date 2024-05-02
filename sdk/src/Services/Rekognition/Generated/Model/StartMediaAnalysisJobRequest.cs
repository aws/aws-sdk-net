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
    /// Container for the parameters to the StartMediaAnalysisJob operation.
    /// Initiates a new media analysis job. Accepts a manifest file in an Amazon S3 bucket.
    /// The output is a manifest file and a summary of the manifest stored in the Amazon S3
    /// bucket.
    /// </summary>
    public partial class StartMediaAnalysisJobRequest : AmazonRekognitionRequest
    {
        private string _clientRequestToken;
        private MediaAnalysisInput _input;
        private string _jobName;
        private string _kmsKeyId;
        private MediaAnalysisOperationsConfig _operationsConfig;
        private MediaAnalysisOutputConfig _outputConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotency token used to prevent the accidental creation of duplicate versions. If
        /// you use the same token with multiple <c>StartMediaAnalysisJobRequest</c> requests,
        /// the same response is returned. Use <c>ClientRequestToken</c> to prevent the same request
        /// from being processed more than once.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Input data to be analyzed by the job.
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job. Does not have to be unique.
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
        /// The identifier of customer managed AWS KMS key (name or ARN). The key is used to encrypt
        /// images copied into the service. The key is also used to encrypt results and manifest
        /// files written to the output Amazon S3 bucket.
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
        /// Gets and sets the property OperationsConfig. 
        /// <para>
        /// Configuration options for the media analysis job to be created.
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
        /// The Amazon S3 bucket location to store the results.
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

    }
}