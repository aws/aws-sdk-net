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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProcessingJob operation. Creates a processing
    /// job.
    /// </summary>
    public partial class CreateProcessingJobRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AppSpecification. 
        /// <para>
        /// Configures the processing job to run a specified Docker container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AppSpecification AppSpecification { get; set; }

        /// <summary>
        /// Checks to see if the AppSpecification property is set.
        /// </summary>
        internal bool IsSetAppSpecification() => this.AppSpecification != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container. Up to 100 key and values
        /// entries in the map are supported.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any environment fields. As part of the shared responsibility model, you
        /// are responsible for any potential exposure, unauthorized access, or compromise of
        /// your sensitive data if caused by security-sensitive information included in the request
        /// environment variable or plain text fields.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExperimentConfig.
        /// </summary>
        public ExperimentConfig ExperimentConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentConfig property is set.
        /// </summary>
        internal bool IsSetExperimentConfig() => this.ExperimentConfig != null;

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Networking options for a processing job, such as whether to allow inbound and outbound
        /// network calls to and from processing containers, and the VPC subnets and security
        /// groups to use for VPC-enabled processing jobs.
        /// </para>
        /// </summary>
        public NetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfig property is set.
        /// </summary>
        internal bool IsSetNetworkConfig() => this.NetworkConfig != null;

        /// <summary>
        /// Gets and sets the property ProcessingInputs. 
        /// <para>
        /// An array of inputs configuring the data to download into the processing container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ProcessingInput> ProcessingInputs { get; set; } = AWSConfigs.InitializeCollections ? new List<ProcessingInput>() : null;

        /// <summary>
        /// Checks to see if the ProcessingInputs property is set.
        /// </summary>
        internal bool IsSetProcessingInputs() => this.ProcessingInputs != null && (this.ProcessingInputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProcessingJobName. 
        /// <para>
        ///  The name of the processing job. The name must be unique within an Amazon Web Services
        /// Region in the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ProcessingJobName { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJobName property is set.
        /// </summary>
        internal bool IsSetProcessingJobName() => this.ProcessingJobName != null;

        /// <summary>
        /// Gets and sets the property ProcessingOutputConfig. 
        /// <para>
        /// Output configuration for the processing job.
        /// </para>
        /// </summary>
        public ProcessingOutputConfig ProcessingOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingOutputConfig property is set.
        /// </summary>
        internal bool IsSetProcessingOutputConfig() => this.ProcessingOutputConfig != null;

        /// <summary>
        /// Gets and sets the property ProcessingResources. 
        /// <para>
        /// Identifies the resources, ML compute instances, and ML storage volumes to deploy for
        /// a processing job. In distributed training, you specify more than one instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingResources ProcessingResources { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingResources property is set.
        /// </summary>
        internal bool IsSetProcessingResources() => this.ProcessingResources != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume to
        /// perform tasks on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The time limit for how long the processing job is allowed to run.
        /// </para>
        /// </summary>
        public ProcessingStoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-whatURL">Using
        /// Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any tags. As part of the shared responsibility model, you are responsible
        /// for any potential exposure, unauthorized access, or compromise of your sensitive data
        /// if caused by security-sensitive information included in the request tag variable or
        /// plain text fields.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
