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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes the configuration properties for the solution.
    /// </summary>
    public partial class SolutionConfig
    {
        private Dictionary<string, string> _algorithmHyperParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AutoMLConfig _automlConfig;
        private AutoTrainingConfig _autoTrainingConfig;
        private EventsConfig _eventsConfig;
        private string _eventValueThreshold;
        private Dictionary<string, string> _featureTransformationParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private HPOConfig _hpoConfig;
        private OptimizationObjective _optimizationObjective;
        private TrainingDataConfig _trainingDataConfig;

        /// <summary>
        /// Gets and sets the property AlgorithmHyperParameters. 
        /// <para>
        /// Lists the algorithm hyperparameters and their values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> AlgorithmHyperParameters
        {
            get { return this._algorithmHyperParameters; }
            set { this._algorithmHyperParameters = value; }
        }

        // Check to see if AlgorithmHyperParameters property is set
        internal bool IsSetAlgorithmHyperParameters()
        {
            return this._algorithmHyperParameters != null && (this._algorithmHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoMLConfig. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_AutoMLConfig.html">AutoMLConfig</a>
        /// object containing a list of recipes to search when AutoML is performed.
        /// </para>
        /// </summary>
        public AutoMLConfig AutoMLConfig
        {
            get { return this._automlConfig; }
            set { this._automlConfig = value; }
        }

        // Check to see if AutoMLConfig property is set
        internal bool IsSetAutoMLConfig()
        {
            return this._automlConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AutoTrainingConfig. 
        /// <para>
        /// Specifies the automatic training configuration to use.
        /// </para>
        /// </summary>
        public AutoTrainingConfig AutoTrainingConfig
        {
            get { return this._autoTrainingConfig; }
            set { this._autoTrainingConfig = value; }
        }

        // Check to see if AutoTrainingConfig property is set
        internal bool IsSetAutoTrainingConfig()
        {
            return this._autoTrainingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EventsConfig. 
        /// <para>
        /// Describes the configuration of an event, which includes a list of event parameters.
        /// You can specify up to 10 event parameters. Events are used in solution creation.
        /// </para>
        /// </summary>
        public EventsConfig EventsConfig
        {
            get { return this._eventsConfig; }
            set { this._eventsConfig = value; }
        }

        // Check to see if EventsConfig property is set
        internal bool IsSetEventsConfig()
        {
            return this._eventsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EventValueThreshold. 
        /// <para>
        /// Only events with a value greater than or equal to this threshold are used for training
        /// a model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EventValueThreshold
        {
            get { return this._eventValueThreshold; }
            set { this._eventValueThreshold = value; }
        }

        // Check to see if EventValueThreshold property is set
        internal bool IsSetEventValueThreshold()
        {
            return this._eventValueThreshold != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureTransformationParameters. 
        /// <para>
        /// Lists the feature transformation parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> FeatureTransformationParameters
        {
            get { return this._featureTransformationParameters; }
            set { this._featureTransformationParameters = value; }
        }

        // Check to see if FeatureTransformationParameters property is set
        internal bool IsSetFeatureTransformationParameters()
        {
            return this._featureTransformationParameters != null && (this._featureTransformationParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HpoConfig. 
        /// <para>
        /// Describes the properties for hyperparameter optimization (HPO).
        /// </para>
        /// </summary>
        public HPOConfig HpoConfig
        {
            get { return this._hpoConfig; }
            set { this._hpoConfig = value; }
        }

        // Check to see if HpoConfig property is set
        internal bool IsSetHpoConfig()
        {
            return this._hpoConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationObjective. 
        /// <para>
        /// Describes the additional objective for the solution, such as maximizing streaming
        /// minutes or increasing revenue. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/optimizing-solution-for-objective.html">Optimizing
        /// a solution</a>.
        /// </para>
        /// </summary>
        public OptimizationObjective OptimizationObjective
        {
            get { return this._optimizationObjective; }
            set { this._optimizationObjective = value; }
        }

        // Check to see if OptimizationObjective property is set
        internal bool IsSetOptimizationObjective()
        {
            return this._optimizationObjective != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        ///  Specifies the training data configuration to use when creating a custom solution
        /// version (trained model). 
        /// </para>
        /// </summary>
        public TrainingDataConfig TrainingDataConfig
        {
            get { return this._trainingDataConfig; }
            set { this._trainingDataConfig = value; }
        }

        // Check to see if TrainingDataConfig property is set
        internal bool IsSetTrainingDataConfig()
        {
            return this._trainingDataConfig != null;
        }

    }
}