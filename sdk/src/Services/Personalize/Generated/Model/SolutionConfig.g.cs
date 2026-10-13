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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes the configuration properties for the solution.
    /// </summary>
    public partial class SolutionConfig
    {
        /// <summary>
        /// Gets and sets the property AlgorithmHyperParameters. 
        /// <para>
        /// Lists the algorithm hyperparameters and their values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> AlgorithmHyperParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AlgorithmHyperParameters property is set.
        /// </summary>
        internal bool IsSetAlgorithmHyperParameters() => this.AlgorithmHyperParameters != null && (this.AlgorithmHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoMLConfig. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_AutoMLConfig.html">AutoMLConfig</a>
        /// object containing a list of recipes to search when AutoML is performed.
        /// </para>
        /// </summary>
        public AutoMLConfig AutoMLConfig { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLConfig property is set.
        /// </summary>
        internal bool IsSetAutoMLConfig() => this.AutoMLConfig != null;

        /// <summary>
        /// Gets and sets the property AutoTrainingConfig. 
        /// <para>
        /// Specifies the automatic training configuration to use.
        /// </para>
        /// </summary>
        public AutoTrainingConfig AutoTrainingConfig { get; set; }

        /// <summary>
        /// Checks to see if the AutoTrainingConfig property is set.
        /// </summary>
        internal bool IsSetAutoTrainingConfig() => this.AutoTrainingConfig != null;

        /// <summary>
        /// Gets and sets the property EventValueThreshold. 
        /// <para>
        /// Only events with a value greater than or equal to this threshold are used for training
        /// a model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EventValueThreshold { get; set; }

        /// <summary>
        /// Checks to see if the EventValueThreshold property is set.
        /// </summary>
        internal bool IsSetEventValueThreshold() => this.EventValueThreshold != null;

        /// <summary>
        /// Gets and sets the property EventsConfig. 
        /// <para>
        /// Describes the configuration of an event, which includes a list of event parameters.
        /// You can specify up to 10 event parameters. Events are used in solution creation.
        /// </para>
        /// </summary>
        public EventsConfig EventsConfig { get; set; }

        /// <summary>
        /// Checks to see if the EventsConfig property is set.
        /// </summary>
        internal bool IsSetEventsConfig() => this.EventsConfig != null;

        /// <summary>
        /// Gets and sets the property FeatureTransformationParameters. 
        /// <para>
        /// Lists the feature transformation parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> FeatureTransformationParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the FeatureTransformationParameters property is set.
        /// </summary>
        internal bool IsSetFeatureTransformationParameters() => this.FeatureTransformationParameters != null && (this.FeatureTransformationParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HpoConfig. 
        /// <para>
        /// Describes the properties for hyperparameter optimization (HPO).
        /// </para>
        /// </summary>
        public HPOConfig HpoConfig { get; set; }

        /// <summary>
        /// Checks to see if the HpoConfig property is set.
        /// </summary>
        internal bool IsSetHpoConfig() => this.HpoConfig != null;

        /// <summary>
        /// Gets and sets the property OptimizationObjective. 
        /// <para>
        /// Describes the additional objective for the solution, such as maximizing streaming
        /// minutes or increasing revenue. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/optimizing-solution-for-objective.html">Optimizing
        /// a solution</a>.
        /// </para>
        /// </summary>
        public OptimizationObjective OptimizationObjective { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationObjective property is set.
        /// </summary>
        internal bool IsSetOptimizationObjective() => this.OptimizationObjective != null;

        /// <summary>
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        ///  Specifies the training data configuration to use when creating a custom solution
        /// version (trained model). 
        /// </para>
        /// </summary>
        public TrainingDataConfig TrainingDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataConfig property is set.
        /// </summary>
        internal bool IsSetTrainingDataConfig() => this.TrainingDataConfig != null;
    }
}
