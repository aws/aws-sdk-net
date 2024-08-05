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
    /// API operation for creating and managing Amazon Bedrock automatic model evaluation
    /// jobs and model evaluation jobs that use human workers. To learn more about the requirements
    /// for creating a model evaluation job see, <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-evaluation.html">Model
    /// evaluation</a>.
    /// </summary>
    public partial class CreateEvaluationJobRequest : AmazonBedrockRequest
    {
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
        /// Specify your customer managed key ARN that will be used to encrypt your model evaluation
        /// job.
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
        /// Specifies whether the model evaluation job is automatic or uses human worker.
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
        /// Specify the models you want to use in your model evaluation job. Automatic model evaluation
        /// jobs support a single model, and model evaluation job that use human workers support
        /// two models.
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
        /// A description of the model evaluation job.
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
        /// The name of the model evaluation job. Model evaluation job names must unique with
        /// your AWS account, and your account's AWS region.
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
        /// An object that defines where the results of model evaluation job will be saved in
        /// Amazon S3.
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
        /// to perform tasks on your behalf. The service role must have Amazon Bedrock as the
        /// service principal, and provide access to any Amazon S3 buckets specified in the <c>EvaluationConfig</c>
        /// object. To pass this role to Amazon Bedrock, the caller of this API must have the
        /// <c>iam:PassRole</c> permission. To learn more about the required permissions, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-evaluation-security.html">Required
        /// permissions</a>.
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