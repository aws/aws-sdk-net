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
    /// The configuration for a training job launched by a hyperparameter tuning job. Choose
    /// <c>Bayesian</c> for Bayesian optimization, and <c>Random</c> for random search optimization.
    /// For more advanced use cases, use <c>Hyperband</c>, which evaluates objective metrics
    /// for training jobs after every epoch. For more information about strategies, see <a
    /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-how-it-works.html">How
    /// Hyperparameter Tuning Works</a>.
    /// </summary>
    public partial class HyperParameterTuningJobStrategyConfig
    {
        private HyperbandStrategyConfig _hyperbandStrategyConfig;

        /// <summary>
        /// Gets and sets the property HyperbandStrategyConfig. 
        /// <para>
        /// The configuration for the object that specifies the <c>Hyperband</c> strategy. This
        /// parameter is only supported for the <c>Hyperband</c> selection for <c>Strategy</c>
        /// within the <c>HyperParameterTuningJobConfig</c> API.
        /// </para>
        /// </summary>
        public HyperbandStrategyConfig HyperbandStrategyConfig
        {
            get { return this._hyperbandStrategyConfig; }
            set { this._hyperbandStrategyConfig = value; }
        }

        // Check to see if HyperbandStrategyConfig property is set
        internal bool IsSetHyperbandStrategyConfig()
        {
            return this._hyperbandStrategyConfig != null;
        }

    }
}