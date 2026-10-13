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
    /// Configures a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTuningJobConfig
    {
        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobObjective. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobObjective.html">HyperParameterTuningJobObjective</a>
        /// specifies the objective metric used to evaluate the performance of training jobs launched
        /// by this tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobObjective HyperParameterTuningJobObjective { get; set; }

        /// <summary>
        /// Checks to see if the HyperParameterTuningJobObjective property is set.
        /// </summary>
        internal bool IsSetHyperParameterTuningJobObjective() => this.HyperParameterTuningJobObjective != null;

        /// <summary>
        /// Gets and sets the property ParameterRanges. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ParameterRanges.html">ParameterRanges</a>
        /// object that specifies the ranges of hyperparameters that this tuning job searches
        /// over to find the optimal configuration for the highest model performance against your
        /// chosen objective metric. 
        /// </para>
        /// </summary>
        public ParameterRanges ParameterRanges { get; set; }

        /// <summary>
        /// Checks to see if the ParameterRanges property is set.
        /// </summary>
        internal bool IsSetParameterRanges() => this.ParameterRanges != null;

        /// <summary>
        /// Gets and sets the property RandomSeed. 
        /// <para>
        /// A value used to initialize a pseudo-random number generator. Setting a random seed
        /// and using the same seed later for the same tuning job will allow hyperparameter optimization
        /// to find more a consistent hyperparameter configuration between the two runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// Checks to see if the RandomSeed property is set.
        /// </summary>
        internal bool IsSetRandomSeed() => this.RandomSeed.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceLimits. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ResourceLimits.html">ResourceLimits</a>
        /// object that specifies the maximum number of training and parallel training jobs that
        /// can be used for this hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceLimits ResourceLimits { get; set; }

        /// <summary>
        /// Checks to see if the ResourceLimits property is set.
        /// </summary>
        internal bool IsSetResourceLimits() => this.ResourceLimits != null;

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// Specifies how hyperparameter tuning chooses the combinations of hyperparameter values
        /// to use for the training job it launches. For information about search strategies,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-how-it-works.html">How
        /// Hyperparameter Tuning Works</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HyperParameterTuningJobStrategyType Strategy { get; set; }

        /// <summary>
        /// Checks to see if the Strategy property is set.
        /// </summary>
        internal bool IsSetStrategy() => this.Strategy != null;

        /// <summary>
        /// Gets and sets the property StrategyConfig. 
        /// <para>
        /// The configuration for the <c>Hyperband</c> optimization strategy. This parameter should
        /// be provided only if <c>Hyperband</c> is selected as the strategy for <c>HyperParameterTuningJobConfig</c>.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobStrategyConfig StrategyConfig { get; set; }

        /// <summary>
        /// Checks to see if the StrategyConfig property is set.
        /// </summary>
        internal bool IsSetStrategyConfig() => this.StrategyConfig != null;

        /// <summary>
        /// Gets and sets the property TrainingJobEarlyStoppingType. 
        /// <para>
        /// Specifies whether to use early stopping for training jobs launched by the hyperparameter
        /// tuning job. Because the <c>Hyperband</c> strategy has its own advanced internal early
        /// stopping mechanism, <c>TrainingJobEarlyStoppingType</c> must be <c>OFF</c> to use
        /// <c>Hyperband</c>. This parameter can take on one of the following values (the default
        /// value is <c>OFF</c>):
        /// </para>
        ///  <dl> <dt>OFF</dt> <dd> 
        /// <para>
        /// Training jobs launched by the hyperparameter tuning job do not use early stopping.
        /// </para>
        ///  </dd> <dt>AUTO</dt> <dd> 
        /// <para>
        /// SageMaker stops training jobs launched by the hyperparameter tuning job when they
        /// are unlikely to perform better than previously completed training jobs. For more information,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-early-stopping.html">Stop
        /// Training Jobs Early</a>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public TrainingJobEarlyStoppingType TrainingJobEarlyStoppingType { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJobEarlyStoppingType property is set.
        /// </summary>
        internal bool IsSetTrainingJobEarlyStoppingType() => this.TrainingJobEarlyStoppingType != null;

        /// <summary>
        /// Gets and sets the property TuningJobCompletionCriteria. 
        /// <para>
        /// The tuning job's completion criteria.
        /// </para>
        /// </summary>
        public TuningJobCompletionCriteria TuningJobCompletionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the TuningJobCompletionCriteria property is set.
        /// </summary>
        internal bool IsSetTuningJobCompletionCriteria() => this.TuningJobCompletionCriteria != null;
    }
}
