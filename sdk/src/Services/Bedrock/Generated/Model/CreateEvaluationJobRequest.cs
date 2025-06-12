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
    /// Container for the parameters to the CreateEvaluationJob operation.
    /// Creates an evaluation job.
    /// </summary>
    public partial class CreateEvaluationJobRequest : AmazonBedrockRequest
    {
        private ApplicationType _applicationType;
        private string _clientRequestToken;
        private string _customerEncryptionKeyId;
        private EvaluationConfig _evaluationConfig;
        private EvaluationInferenceConfig _inferenceConfig;
        private string _jobDescription;
        private string _jobName;
        private List<Tag> _jobTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private EvaluationOutputDataConfig _outputDataConfig;
        private string _roleArn;

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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property CustomerEncryptionKeyId. 
        /// <para>
        /// Specify your customer managed encryption key Amazon Resource Name (ARN) that will
        /// be used to encrypt your evaluation job.
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
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        /// Contains the configuration details of the inference model for the evaluation job.
        /// </para>
        ///  
        /// <para>
        /// For model evaluation jobs, automated jobs support a single model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
        /// profile</a>, and jobs that use human workers support two models or inference profiles.
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
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// A description of the evaluation job.
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
        /// A name for the evaluation job. Names must unique with your Amazon Web Services account,
        /// and your account's Amazon Web Services region.
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
        /// Gets and sets the property JobTags. 
        /// <para>
        /// Tags to attach to the model evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> JobTags
        {
            get { return this._jobTags; }
            set { this._jobTags = value; }
        }

        // Check to see if JobTags property is set
        internal bool IsSetJobTags()
        {
            return this._jobTags != null && (this._jobTags.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The Amazon Resource Name (ARN) of an IAM service role that Amazon Bedrock can assume
        /// to perform tasks on your behalf. To learn more about the required permissions, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-evaluation-security.html">Required
        /// permissions for model evaluations</a>.
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

    }
}