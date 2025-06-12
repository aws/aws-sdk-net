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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the CreateOptimizationJob operation.
    /// Creates a job that optimizes a model for inference performance. To create the job,
    /// you provide the location of a source model, and you provide the settings for the optimization
    /// techniques that you want the job to apply. When the job completes successfully, SageMaker
    /// uploads the new optimized model to the output destination that you specify.
    /// 
    ///  
    /// <para>
    /// For more information about how to use this action, and about the supported optimization
    /// techniques, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-optimize.html">Optimize
    /// model inference with Amazon SageMaker</a>.
    /// </para>
    /// </summary>
    public partial class CreateOptimizationJobRequest : AmazonSageMakerRequest
    {
        private OptimizationJobDeploymentInstanceType _deploymentInstanceType;
        private OptimizationJobModelSource _modelSource;
        private List<OptimizationConfig> _optimizationConfigs = AWSConfigs.InitializeCollections ? new List<OptimizationConfig>() : null;
        private Dictionary<string, string> _optimizationEnvironment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _optimizationJobName;
        private OptimizationJobOutputConfig _outputConfig;
        private string _roleArn;
        private StoppingCondition _stoppingCondition;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private OptimizationVpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property DeploymentInstanceType. 
        /// <para>
        /// The type of instance that hosts the optimized model that you create with the optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobDeploymentInstanceType DeploymentInstanceType
        {
            get { return this._deploymentInstanceType; }
            set { this._deploymentInstanceType = value; }
        }

        // Check to see if DeploymentInstanceType property is set
        internal bool IsSetDeploymentInstanceType()
        {
            return this._deploymentInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ModelSource. 
        /// <para>
        /// The location of the source model to optimize with an optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobModelSource ModelSource
        {
            get { return this._modelSource; }
            set { this._modelSource = value; }
        }

        // Check to see if ModelSource property is set
        internal bool IsSetModelSource()
        {
            return this._modelSource != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationConfigs. 
        /// <para>
        /// Settings for each of the optimization techniques that the job applies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<OptimizationConfig> OptimizationConfigs
        {
            get { return this._optimizationConfigs; }
            set { this._optimizationConfigs = value; }
        }

        // Check to see if OptimizationConfigs property is set
        internal bool IsSetOptimizationConfigs()
        {
            return this._optimizationConfigs != null && (this._optimizationConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptimizationEnvironment. 
        /// <para>
        /// The environment variables to set in the model container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public Dictionary<string, string> OptimizationEnvironment
        {
            get { return this._optimizationEnvironment; }
            set { this._optimizationEnvironment = value; }
        }

        // Check to see if OptimizationEnvironment property is set
        internal bool IsSetOptimizationEnvironment()
        {
            return this._optimizationEnvironment != null && (this._optimizationEnvironment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptimizationJobName. 
        /// <para>
        /// A custom name for the new optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string OptimizationJobName
        {
            get { return this._optimizationJobName; }
            set { this._optimizationJobName = value; }
        }

        // Check to see if OptimizationJobName property is set
        internal bool IsSetOptimizationJobName()
        {
            return this._optimizationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Details for where to store the optimized model that you create with the optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptimizationJobOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

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
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property StoppingCondition.
        /// </summary>
        [AWSProperty(Required=true)]
        public StoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs associated with the optimization job. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A VPC in Amazon VPC that your optimized model has access to.
        /// </para>
        /// </summary>
        public OptimizationVpcConfig VpcConfig
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