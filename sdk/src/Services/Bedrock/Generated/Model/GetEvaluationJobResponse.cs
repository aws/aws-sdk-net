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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetEvaluationJob operation.
    /// </summary>
    public partial class GetEvaluationJobResponse : AmazonWebServiceResponse
    {
        private ApplicationType _applicationType;
        private DateTime? _creationTime;
        private string _customerEncryptionKeyId;
        private EvaluationConfig _evaluationConfig;
        private List<string> _failureMessages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EvaluationInferenceConfig _inferenceConfig;
        private string _jobArn;
        private string _jobDescription;
        private string _jobName;
        private EvaluationJobType _jobType;
        private DateTime? _lastModifiedTime;
        private EvaluationOutputDataConfig _outputDataConfig;
        private string _roleArn;
        private EvaluationJobStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// Specifies whether the evaluation job is for evaluating a model or evaluating a knowledge
        /// base (retrieval and response generation).
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType
        {
            get { return this._applicationType; }
            set { this._applicationType = value; }
        }

        // Check to see if ApplicationType property is set
        internal bool IsSetApplicationType()
        {
            return this._applicationType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the evaluation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed encryption key specified when
        /// the evaluation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CustomerEncryptionKeyId
        {
            get { return this._customerEncryptionKeyId; }
            set { this._customerEncryptionKeyId = value; }
        }

        // Check to see if CustomerEncryptionKeyId property is set
        internal bool IsSetCustomerEncryptionKeyId()
        {
            return this._customerEncryptionKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// Contains the configuration details of either an automated or human-based evaluation
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationConfig EvaluationConfig
        {
            get { return this._evaluationConfig; }
            set { this._evaluationConfig = value; }
        }

        // Check to see if EvaluationConfig property is set
        internal bool IsSetEvaluationConfig()
        {
            return this._evaluationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessages. 
        /// <para>
        /// A list of strings that specify why the evaluation job failed to create.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> FailureMessages
        {
            get { return this._failureMessages; }
            set { this._failureMessages = value; }
        }

        // Check to see if FailureMessages property is set
        internal bool IsSetFailureMessages()
        {
            return this._failureMessages != null && (this._failureMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        /// Contains the configuration details of the inference model used for the evaluation
        /// job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationInferenceConfig InferenceConfig
        {
            get { return this._inferenceConfig; }
            set { this._inferenceConfig = value; }
        }

        // Check to see if InferenceConfig property is set
        internal bool IsSetInferenceConfig()
        {
            return this._inferenceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// The description of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string JobDescription
        {
            get { return this._jobDescription; }
            set { this._jobDescription = value; }
        }

        // Check to see if JobDescription property is set
        internal bool IsSetJobDescription()
        {
            return this._jobDescription != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name for the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property JobType. 
        /// <para>
        /// Specifies whether the evaluation job is automated or human-based.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationJobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time the evaluation job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Contains the configuration details of the Amazon S3 bucket for storing the results
        /// of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationOutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role used in the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationJobStatus Status
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