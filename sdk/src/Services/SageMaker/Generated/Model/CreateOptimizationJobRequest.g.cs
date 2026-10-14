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
    /// Container for the parameters to the CreateOptimizationJob operation. Creates a job
    /// that optimizes a model for inference performance. To create the job, you provide the
    /// location of a source model, and you provide the settings for the optimization techniques
    /// that you want the job to apply. When the job completes successfully, SageMaker uploads
    /// the new optimized model to the output destination that you specify. <para> For more
    /// information about how to use this action, and about the supported optimization techniques,
    /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-optimize.html">Optimize
    /// model inference with Amazon SageMaker</a>. </para>
    /// </summary>
    public partial class CreateOptimizationJobRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DeploymentInstanceType. 
        /// <para>
        /// The type of instance that hosts the optimized model that you create with the optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OptimizationJobDeploymentInstanceType DeploymentInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentInstanceType property is set.
        /// </summary>
        internal bool IsSetDeploymentInstanceType() => this.DeploymentInstanceType != null;

        /// <summary>
        /// Gets and sets the property MaxInstanceCount. 
        /// <para>
        /// The maximum number of instances to use for the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxInstanceCount property is set.
        /// </summary>
        internal bool IsSetMaxInstanceCount() => this.MaxInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ModelSource. 
        /// <para>
        /// The location of the source model to optimize with an optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OptimizationJobModelSource ModelSource { get; set; }

        /// <summary>
        /// Checks to see if the ModelSource property is set.
        /// </summary>
        internal bool IsSetModelSource() => this.ModelSource != null;

        /// <summary>
        /// Gets and sets the property OptimizationConfigs. 
        /// <para>
        /// Settings for each of the optimization techniques that the job applies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<OptimizationConfig> OptimizationConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<OptimizationConfig>() : null;

        /// <summary>
        /// Checks to see if the OptimizationConfigs property is set.
        /// </summary>
        internal bool IsSetOptimizationConfigs() => this.OptimizationConfigs != null && (this.OptimizationConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptimizationEnvironment. 
        /// <para>
        /// The environment variables to set in the model container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public Dictionary<string, string> OptimizationEnvironment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the OptimizationEnvironment property is set.
        /// </summary>
        internal bool IsSetOptimizationEnvironment() => this.OptimizationEnvironment != null && (this.OptimizationEnvironment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptimizationJobName. 
        /// <para>
        /// A custom name for the new optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string OptimizationJobName { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationJobName property is set.
        /// </summary>
        internal bool IsSetOptimizationJobName() => this.OptimizationJobName != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Details for where to store the optimized model that you create with the optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OptimizationJobOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that enables Amazon SageMaker AI to
        /// perform tasks on your behalf. 
        /// </para>
        ///  
        /// <para>
        /// During model optimization, Amazon SageMaker AI needs your permission to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Read input data from an S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Write model artifacts to an S3 bucket
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Write logs to Amazon CloudWatch Logs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Publish metrics to Amazon CloudWatch
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You grant permissions for all of these tasks to an IAM role. To pass this role to
        /// Amazon SageMaker AI, the caller of this API must have the <c>iam:PassRole</c> permission.
        /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html">Amazon
        /// SageMaker AI Roles.</a> 
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
        /// </summary>
        [AWSProperty(Required = true)]
        public StoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs associated with the optimization job. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference
        /// Guide</i>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property TrainingPlanArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training plan to use for this optimization job.
        /// </para>
        ///  
        /// <para>
        /// When you use reserved capacity from a training plan, the optimization job runs on
        /// that reserved capacity instead of on-demand capacity. If you omit this field, the
        /// job uses on-demand capacity. You can specify at most one training plan.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to reserve GPU capacity for your optimization jobs
        /// using Amazon SageMaker Training Plans, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/reserve-capacity-with-training-plans.html">Reserve
        /// capacity with training plans</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> TrainingPlanArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TrainingPlanArns property is set.
        /// </summary>
        internal bool IsSetTrainingPlanArns() => this.TrainingPlanArns != null && (this.TrainingPlanArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A VPC in Amazon VPC that your optimized model has access to.
        /// </para>
        /// </summary>
        public OptimizationVpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
