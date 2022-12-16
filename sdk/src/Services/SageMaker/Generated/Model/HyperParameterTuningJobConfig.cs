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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configures a hyperparameter tuning job.
    /// </summary>
    public partial class HyperParameterTuningJobConfig
    {
        private HyperParameterTuningJobObjective _hyperParameterTuningJobObjective;
        private ParameterRanges _parameterRanges;
        private int? _randomSeed;
        private ResourceLimits _resourceLimits;
        private HyperParameterTuningJobStrategyType _strategy;
        private HyperParameterTuningJobStrategyConfig _strategyConfig;
        private TrainingJobEarlyStoppingType _trainingJobEarlyStoppingType;
        private TuningJobCompletionCriteria _tuningJobCompletionCriteria;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobObjective. 
        /// <para>
        /// The <a>HyperParameterTuningJobObjective</a> specifies the objective metric used to
        /// evaluate the performance of training jobs launched by this tuning job.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobObjective HyperParameterTuningJobObjective
        {
            get { return this._hyperParameterTuningJobObjective; }
            set { this._hyperParameterTuningJobObjective = value; }
        }

        // Check to see if HyperParameterTuningJobObjective property is set
        internal bool IsSetHyperParameterTuningJobObjective()
        {
            return this._hyperParameterTuningJobObjective != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterRanges. 
        /// <para>
        /// The <a>ParameterRanges</a> object that specifies the ranges of hyperparameters that
        /// this tuning job searches over to find the optimal configuration for the highest model
        /// performance against .your chosen objective metric. 
        /// </para>
        /// </summary>
        public ParameterRanges ParameterRanges
        {
            get { return this._parameterRanges; }
            set { this._parameterRanges = value; }
        }

        // Check to see if ParameterRanges property is set
        internal bool IsSetParameterRanges()
        {
            return this._parameterRanges != null;
        }

        /// <summary>
        /// Gets and sets the property RandomSeed. 
        /// <para>
        /// A value used to initialize a pseudo-random number generator. Setting a random seed
        /// and using the same seed later for the same tuning job will allow hyperparameter optimization
        /// to find more a consistent hyperparameter configuration between the two runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int RandomSeed
        {
            get { return this._randomSeed.GetValueOrDefault(); }
            set { this._randomSeed = value; }
        }

        // Check to see if RandomSeed property is set
        internal bool IsSetRandomSeed()
        {
            return this._randomSeed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceLimits. 
        /// <para>
        /// The <a>ResourceLimits</a> object that specifies the maximum number of training and
        /// parallel training jobs that can be used for this hyperparameter tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceLimits ResourceLimits
        {
            get { return this._resourceLimits; }
            set { this._resourceLimits = value; }
        }

        // Check to see if ResourceLimits property is set
        internal bool IsSetResourceLimits()
        {
            return this._resourceLimits != null;
        }

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// Specifies how hyperparameter tuning chooses the combinations of hyperparameter values
        /// to use for the training job it launches. For information about search strategies,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-how-it-works.html">How
        /// Hyperparameter Tuning Works</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HyperParameterTuningJobStrategyType Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

        /// <summary>
        /// Gets and sets the property StrategyConfig. 
        /// <para>
        /// The configuration for the <code>Hyperband</code> optimization strategy. This parameter
        /// should be provided only if <code>Hyperband</code> is selected as the strategy for
        /// <code>HyperParameterTuningJobConfig</code>.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobStrategyConfig StrategyConfig
        {
            get { return this._strategyConfig; }
            set { this._strategyConfig = value; }
        }

        // Check to see if StrategyConfig property is set
        internal bool IsSetStrategyConfig()
        {
            return this._strategyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJobEarlyStoppingType. 
        /// <para>
        /// Specifies whether to use early stopping for training jobs launched by the hyperparameter
        /// tuning job. Because the <code>Hyperband</code> strategy has its own advanced internal
        /// early stopping mechanism, <code>TrainingJobEarlyStoppingType</code> must be <code>OFF</code>
        /// to use <code>Hyperband</code>. This parameter can take on one of the following values
        /// (the default value is <code>OFF</code>):
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
        public TrainingJobEarlyStoppingType TrainingJobEarlyStoppingType
        {
            get { return this._trainingJobEarlyStoppingType; }
            set { this._trainingJobEarlyStoppingType = value; }
        }

        // Check to see if TrainingJobEarlyStoppingType property is set
        internal bool IsSetTrainingJobEarlyStoppingType()
        {
            return this._trainingJobEarlyStoppingType != null;
        }

        /// <summary>
        /// Gets and sets the property TuningJobCompletionCriteria. 
        /// <para>
        /// The tuning job's completion criteria.
        /// </para>
        /// </summary>
        public TuningJobCompletionCriteria TuningJobCompletionCriteria
        {
            get { return this._tuningJobCompletionCriteria; }
            set { this._tuningJobCompletionCriteria = value; }
        }

        // Check to see if TuningJobCompletionCriteria property is set
        internal bool IsSetTuningJobCompletionCriteria()
        {
            return this._tuningJobCompletionCriteria != null;
        }

    }
}