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
    /// Container for the parameters to the CreateModelInvocationJob operation.
    /// Creates a batch inference job to invoke a model on multiple prompts. Format your data
    /// according to <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-data">Format
    /// your inference data</a> and upload it to an Amazon S3 bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference.html">Process
    /// multiple prompts with batch inference</a>.
    /// 
    ///  
    /// <para>
    /// The response returns a <c>jobArn</c> that you can use to stop or get details about
    /// the job.
    /// </para>
    /// </summary>
    public partial class CreateModelInvocationJobRequest : AmazonBedrockRequest
    {
        private string _clientRequestToken;
        private ModelInvocationJobInputDataConfig _inputDataConfig;
        private string _jobName;
        private string _modelId;
        private ModelInvocationJobOutputDataConfig _outputDataConfig;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _timeoutDurationInHours;
        private VpcConfig _vpcConfig;

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
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Details about the location of the input to the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelInvocationJobInputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// A name to give the batch inference job.
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
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique identifier of the foundation model to use for the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Details about the location of the output of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelInvocationJobOutputDataConfig OutputDataConfig
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
        /// The Amazon Resource Name (ARN) of the service role with permissions to carry out and
        /// manage batch inference. You can use the console to create a default service role or
        /// follow the steps at <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-iam-sr.html">Create
        /// a service role for batch inference</a>.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags to associate with the batch inference job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tagging.html">Tagging
        /// Amazon Bedrock resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeoutDurationInHours. 
        /// <para>
        /// The number of hours after which to force the batch inference job to time out.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=168)]
        public int? TimeoutDurationInHours
        {
            get { return this._timeoutDurationInHours; }
            set { this._timeoutDurationInHours = value; }
        }

        // Check to see if TimeoutDurationInHours property is set
        internal bool IsSetTimeoutDurationInHours()
        {
            return this._timeoutDurationInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The configuration of the Virtual Private Cloud (VPC) for the data in the batch inference
        /// job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-vpc">Protect
        /// batch inference jobs using a VPC</a>.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}