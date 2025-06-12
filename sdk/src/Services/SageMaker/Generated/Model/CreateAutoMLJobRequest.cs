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
    /// Container for the parameters to the CreateAutoMLJob operation.
    /// Creates an Autopilot job also referred to as Autopilot experiment or AutoML job.
    /// 
    ///  
    /// <para>
    /// An AutoML job in SageMaker AI is a fully automated process that allows you to build
    /// machine learning models with minimal effort and machine learning expertise. When initiating
    /// an AutoML job, you provide your data and optionally specify parameters tailored to
    /// your use case. SageMaker AI then automates the entire model development lifecycle,
    /// including data preprocessing, model training, tuning, and evaluation. AutoML jobs
    /// are designed to simplify and accelerate the model building process by automating various
    /// tasks and exploring different combinations of machine learning algorithms, data preprocessing
    /// techniques, and hyperparameter values. The output of an AutoML job comprises one or
    /// more trained models ready for deployment and inference. Additionally, SageMaker AI
    /// AutoML jobs generate a candidate model leaderboard, allowing you to select the best-performing
    /// model for deployment.
    /// </para>
    ///  
    /// <para>
    /// For more information about AutoML jobs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html">https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development.html</a>
    /// in the SageMaker AI developer guide.
    /// </para>
    ///  <note> 
    /// <para>
    /// We recommend using the new versions <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJobV2.html">CreateAutoMLJobV2</a>
    /// and <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJobV2.html">DescribeAutoMLJobV2</a>,
    /// which offer backward compatibility.
    /// </para>
    ///  
    /// <para>
    ///  <c>CreateAutoMLJobV2</c> can manage tabular problem types identical to those of its
    /// previous version <c>CreateAutoMLJob</c>, as well as time-series forecasting, non-tabular
    /// problem types such as image or text classification, and text generation (LLMs fine-tuning).
    /// </para>
    ///  
    /// <para>
    /// Find guidelines about how to migrate a <c>CreateAutoMLJob</c> to <c>CreateAutoMLJobV2</c>
    /// in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development-create-experiment.html#autopilot-create-experiment-api-migrate-v1-v2">Migrate
    /// a CreateAutoMLJob to CreateAutoMLJobV2</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can find the best-performing model after you run an AutoML job by calling <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJobV2.html">DescribeAutoMLJobV2</a>
    /// (recommended) or <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeAutoMLJob.html">DescribeAutoMLJob</a>.
    /// </para>
    /// </summary>
    public partial class CreateAutoMLJobRequest : AmazonSageMakerRequest
    {
        private AutoMLJobConfig _autoMLJobConfig;
        private string _autoMLJobName;
        private AutoMLJobObjective _autoMLJobObjective;
        private bool? _generateCandidateDefinitionsOnly;
        private List<AutoMLChannel> _inputDataConfig = AWSConfigs.InitializeCollections ? new List<AutoMLChannel>() : null;
        private ModelDeployConfig _modelDeployConfig;
        private AutoMLOutputDataConfig _outputDataConfig;
        private ProblemType _problemType;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AutoMLJobConfig. 
        /// <para>
        /// A collection of settings used to configure an AutoML job.
        /// </para>
        /// </summary>
        public AutoMLJobConfig AutoMLJobConfig
        {
            get { return this._autoMLJobConfig; }
            set { this._autoMLJobConfig = value; }
        }

        // Check to see if AutoMLJobConfig property is set
        internal bool IsSetAutoMLJobConfig()
        {
            return this._autoMLJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// Identifies an Autopilot job. The name must be unique to your account and is case insensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AutoMLJobName
        {
            get { return this._autoMLJobName; }
            set { this._autoMLJobName = value; }
        }

        // Check to see if AutoMLJobName property is set
        internal bool IsSetAutoMLJobName()
        {
            return this._autoMLJobName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobObjective. 
        /// <para>
        /// Specifies a metric to minimize or maximize as the objective of a job. If not specified,
        /// the default objective metric depends on the problem type. See <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLJobObjective.html">AutoMLJobObjective</a>
        /// for the default values.
        /// </para>
        /// </summary>
        public AutoMLJobObjective AutoMLJobObjective
        {
            get { return this._autoMLJobObjective; }
            set { this._autoMLJobObjective = value; }
        }

        // Check to see if AutoMLJobObjective property is set
        internal bool IsSetAutoMLJobObjective()
        {
            return this._autoMLJobObjective != null;
        }

        /// <summary>
        /// Gets and sets the property GenerateCandidateDefinitionsOnly. 
        /// <para>
        /// Generates possible candidates without training the models. A candidate is a combination
        /// of data preprocessors, algorithms, and algorithm parameter settings.
        /// </para>
        /// </summary>
        public bool? GenerateCandidateDefinitionsOnly
        {
            get { return this._generateCandidateDefinitionsOnly; }
            set { this._generateCandidateDefinitionsOnly = value; }
        }

        // Check to see if GenerateCandidateDefinitionsOnly property is set
        internal bool IsSetGenerateCandidateDefinitionsOnly()
        {
            return this._generateCandidateDefinitionsOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// An array of channel objects that describes the input data and its location. Each channel
        /// is a named input source. Similar to <c>InputDataConfig</c> supported by <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html">HyperParameterTrainingJobDefinition</a>.
        /// Format(s) supported: CSV, Parquet. A minimum of 500 rows is required for the training
        /// dataset. There is not a minimum number of rows required for the validation dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<AutoMLChannel> InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null && (this._inputDataConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelDeployConfig. 
        /// <para>
        /// Specifies how to generate the endpoint name for an automatic one-click Autopilot model
        /// deployment.
        /// </para>
        /// </summary>
        public ModelDeployConfig ModelDeployConfig
        {
            get { return this._modelDeployConfig; }
            set { this._modelDeployConfig = value; }
        }

        // Check to see if ModelDeployConfig property is set
        internal bool IsSetModelDeployConfig()
        {
            return this._modelDeployConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Provides information about encryption and the Amazon S3 output path needed to store
        /// artifacts from an AutoML job. Format(s) supported: CSV.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLOutputDataConfig OutputDataConfig
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
        /// Gets and sets the property ProblemType. 
        /// <para>
        /// Defines the type of supervised learning problem available for the candidates. For
        /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-datasets-problem-types.html#autopilot-problem-types">
        /// SageMaker Autopilot problem types</a>.
        /// </para>
        /// </summary>
        public ProblemType ProblemType
        {
            get { return this._problemType; }
            set { this._problemType = value; }
        }

        // Check to see if ProblemType property is set
        internal bool IsSetProblemType()
        {
            return this._problemType != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that is used to access the data.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web ServicesResources</a>. Tag keys must be unique per resource.
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

    }
}