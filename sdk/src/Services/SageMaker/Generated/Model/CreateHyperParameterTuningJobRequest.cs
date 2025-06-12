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
    /// Container for the parameters to the CreateHyperParameterTuningJob operation.
    /// Starts a hyperparameter tuning job. A hyperparameter tuning job finds the best version
    /// of a model by running many training jobs on your dataset using the algorithm you choose
    /// and values for hyperparameters within ranges that you specify. It then chooses the
    /// hyperparameter values that result in a model that performs the best, as measured by
    /// an objective metric that you choose.
    /// 
    ///  
    /// <para>
    /// A hyperparameter tuning job automatically creates Amazon SageMaker experiments, trials,
    /// and trial components for each training job that it runs. You can view these entities
    /// in Amazon SageMaker Studio. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/experiments-view-compare.html#experiments-view">View
    /// Experiments, Trials, and Trial Components</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Do not include any security-sensitive information including account access IDs, secrets,
    /// or tokens in any hyperparameter fields. As part of the shared responsibility model,
    /// you are responsible for any potential exposure, unauthorized access, or compromise
    /// of your sensitive data if caused by any security-sensitive information included in
    /// the request hyperparameter variable or plain text fields..
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateHyperParameterTuningJobRequest : AmazonSageMakerRequest
    {
        private Autotune _autotune;
        private HyperParameterTuningJobConfig _hyperParameterTuningJobConfig;
        private string _hyperParameterTuningJobName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private HyperParameterTrainingJobDefinition _trainingJobDefinition;
        private List<HyperParameterTrainingJobDefinition> _trainingJobDefinitions = AWSConfigs.InitializeCollections ? new List<HyperParameterTrainingJobDefinition>() : null;
        private HyperParameterTuningJobWarmStartConfig _warmStartConfig;

        /// <summary>
        /// Gets and sets the property Autotune. 
        /// <para>
        /// Configures SageMaker Automatic model tuning (AMT) to automatically find optimal parameters
        /// for the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html#sagemaker-Type-HyperParameterTuningJobConfig-ParameterRanges">ParameterRanges</a>:
        /// The names and ranges of parameters that a hyperparameter tuning job can optimize.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ResourceLimits.html">ResourceLimits</a>:
        /// The maximum resources that can be used for a training job. These resources include
        /// the maximum number of training jobs, the maximum runtime of a tuning job, and the
        /// maximum number of training jobs to run at the same time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html#sagemaker-Type-HyperParameterTuningJobConfig-TrainingJobEarlyStoppingType">TrainingJobEarlyStoppingType</a>:
        /// A flag that specifies whether or not to use early stopping for training jobs launched
        /// by a hyperparameter tuning job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html#sagemaker-Type-HyperParameterTrainingJobDefinition-RetryStrategy">RetryStrategy</a>:
        /// The number of times to retry a training job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html">Strategy</a>:
        /// Specifies how hyperparameter tuning chooses the combinations of hyperparameter values
        /// to use for the training jobs that it launches.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ConvergenceDetected.html">ConvergenceDetected</a>:
        /// A flag to indicate that Automatic model tuning (AMT) has detected model convergence.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Autotune Autotune
        {
            get { return this._autotune; }
            set { this._autotune = value; }
        }

        // Check to see if Autotune property is set
        internal bool IsSetAutotune()
        {
            return this._autotune != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobConfig. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html">HyperParameterTuningJobConfig</a>
        /// object that describes the tuning job, including the search strategy, the objective
        /// metric used to evaluate training jobs, ranges of parameters to search, and resource
        /// limits for the tuning job. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-how-it-works.html">How
        /// Hyperparameter Tuning Works</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HyperParameterTuningJobConfig HyperParameterTuningJobConfig
        {
            get { return this._hyperParameterTuningJobConfig; }
            set { this._hyperParameterTuningJobConfig = value; }
        }

        // Check to see if HyperParameterTuningJobConfig property is set
        internal bool IsSetHyperParameterTuningJobConfig()
        {
            return this._hyperParameterTuningJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobName. 
        /// <para>
        /// The name of the tuning job. This name is the prefix for the names of all training
        /// jobs that this tuning job launches. The name must be unique within the same Amazon
        /// Web Services account and Amazon Web Services Region. The name must have 1 to 32 characters.
        /// Valid characters are a-z, A-Z, 0-9, and : + = @ _ % - (hyphen). The name is not case
        /// sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string HyperParameterTuningJobName
        {
            get { return this._hyperParameterTuningJobName; }
            set { this._hyperParameterTuningJobName = value; }
        }

        // Check to see if HyperParameterTuningJobName property is set
        internal bool IsSetHyperParameterTuningJobName()
        {
            return this._hyperParameterTuningJobName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// Tags that you specify for the tuning job are also added to all training jobs that
        /// the tuning job launches.
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
        /// Gets and sets the property TrainingJobDefinition. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html">HyperParameterTrainingJobDefinition</a>
        /// object that describes the training jobs that this tuning job launches, including static
        /// hyperparameters, input data configuration, output data configuration, resource configuration,
        /// and stopping condition.
        /// </para>
        /// </summary>
        public HyperParameterTrainingJobDefinition TrainingJobDefinition
        {
            get { return this._trainingJobDefinition; }
            set { this._trainingJobDefinition = value; }
        }

        // Check to see if TrainingJobDefinition property is set
        internal bool IsSetTrainingJobDefinition()
        {
            return this._trainingJobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobDefinitions. 
        /// <para>
        /// A list of the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html">HyperParameterTrainingJobDefinition</a>
        /// objects launched for this tuning job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<HyperParameterTrainingJobDefinition> TrainingJobDefinitions
        {
            get { return this._trainingJobDefinitions; }
            set { this._trainingJobDefinitions = value; }
        }

        // Check to see if TrainingJobDefinitions property is set
        internal bool IsSetTrainingJobDefinitions()
        {
            return this._trainingJobDefinitions != null && (this._trainingJobDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WarmStartConfig. 
        /// <para>
        /// Specifies the configuration for starting the hyperparameter tuning job using one or
        /// more previous tuning jobs as a starting point. The results of previous tuning jobs
        /// are used to inform which combinations of hyperparameters to search over in the new
        /// tuning job.
        /// </para>
        ///  
        /// <para>
        /// All training jobs launched by the new hyperparameter tuning job are evaluated by using
        /// the objective metric. If you specify <c>IDENTICAL_DATA_AND_ALGORITHM</c> as the <c>WarmStartType</c>
        /// value for the warm start configuration, the training job that performs the best in
        /// the new tuning job is compared to the best training jobs from the parent tuning jobs.
        /// From these, the training job that performs the best as measured by the objective metric
        /// is returned as the overall best training job.
        /// </para>
        ///  <note> 
        /// <para>
        /// All training jobs launched by parent hyperparameter tuning jobs and the new hyperparameter
        /// tuning jobs count against the limit of training jobs for the tuning job.
        /// </para>
        ///  </note>
        /// </summary>
        public HyperParameterTuningJobWarmStartConfig WarmStartConfig
        {
            get { return this._warmStartConfig; }
            set { this._warmStartConfig = value; }
        }

        // Check to see if WarmStartConfig property is set
        internal bool IsSetWarmStartConfig()
        {
            return this._warmStartConfig != null;
        }

    }
}