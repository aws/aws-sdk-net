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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetEvaluationJob operation.
    /// </summary>
    public partial class GetEvaluationJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// Specifies whether the evaluation job is for evaluating a model or evaluating a knowledge
        /// base (retrieval and response generation).
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the evaluation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed encryption key specified when
        /// the evaluation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerEncryptionKeyId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEncryptionKeyId property is set.
        /// </summary>
        internal bool IsSetCustomerEncryptionKeyId() => this.CustomerEncryptionKeyId != null;

        /// <summary>
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// Contains the configuration details of either an automated or human-based evaluation
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationConfig EvaluationConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationConfig property is set.
        /// </summary>
        internal bool IsSetEvaluationConfig() => this.EvaluationConfig != null;

        /// <summary>
        /// Gets and sets the property FailureMessages. 
        /// <para>
        /// A list of strings that specify why the evaluation job failed to create.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> FailureMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureMessages property is set.
        /// </summary>
        internal bool IsSetFailureMessages() => this.FailureMessages != null && (this.FailureMessages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        /// Contains the configuration details of the inference model used for the evaluation
        /// job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationInferenceConfig InferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfig property is set.
        /// </summary>
        internal bool IsSetInferenceConfig() => this.InferenceConfig != null;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// The description of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string JobDescription { get; set; }

        /// <summary>
        /// Checks to see if the JobDescription property is set.
        /// </summary>
        internal bool IsSetJobDescription() => this.JobDescription != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name for the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// Specifies whether the evaluation job is automated or human-based.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationJobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time the evaluation job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Contains the configuration details of the Amazon S3 bucket for storing the results
        /// of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationOutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role used in the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
