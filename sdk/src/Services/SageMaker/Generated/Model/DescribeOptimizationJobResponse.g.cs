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
    /// This is the response object from the DescribeOptimizationJob operation.
    /// </summary>
    public partial class DescribeOptimizationJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when you created the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the optimization job status is <c>FAILED</c>, the reason for the failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the optimization job was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

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
        /// Gets and sets the property OptimizationEndTime. 
        /// <para>
        /// The time when the optimization job finished processing.
        /// </para>
        /// </summary>
        public DateTime? OptimizationEndTime { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationEndTime property is set.
        /// </summary>
        internal bool IsSetOptimizationEndTime() => this.OptimizationEndTime.HasValue;

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
        /// Gets and sets the property OptimizationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string OptimizationJobArn { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationJobArn property is set.
        /// </summary>
        internal bool IsSetOptimizationJobArn() => this.OptimizationJobArn != null;

        /// <summary>
        /// Gets and sets the property OptimizationJobName. 
        /// <para>
        /// The name that you assigned to the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string OptimizationJobName { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationJobName property is set.
        /// </summary>
        internal bool IsSetOptimizationJobName() => this.OptimizationJobName != null;

        /// <summary>
        /// Gets and sets the property OptimizationJobStatus. 
        /// <para>
        /// The current status of the optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OptimizationJobStatus OptimizationJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationJobStatus property is set.
        /// </summary>
        internal bool IsSetOptimizationJobStatus() => this.OptimizationJobStatus != null;

        /// <summary>
        /// Gets and sets the property OptimizationOutput. 
        /// <para>
        /// Output values produced by an optimization job.
        /// </para>
        /// </summary>
        public OptimizationOutput OptimizationOutput { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationOutput property is set.
        /// </summary>
        internal bool IsSetOptimizationOutput() => this.OptimizationOutput != null;

        /// <summary>
        /// Gets and sets the property OptimizationStartTime. 
        /// <para>
        /// The time when the optimization job started.
        /// </para>
        /// </summary>
        public DateTime? OptimizationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationStartTime property is set.
        /// </summary>
        internal bool IsSetOptimizationStartTime() => this.OptimizationStartTime.HasValue;

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
        /// The ARN of the IAM role that you assigned to the optimization job.
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
        /// Gets and sets the property TrainingPlanArns. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training plan associated with this optimization
        /// job. This field appears only when you specified a training plan when you created the
        /// job. Optimization jobs that use on-demand capacity don't return this field.
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
