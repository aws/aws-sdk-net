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
    /// Stores the configuration information for how model candidates are generated using
    /// an AutoML job V2.
    /// </summary>
    public partial class CandidateGenerationConfig
    {
        private List<AutoMLAlgorithmConfig> _algorithmsConfig = AWSConfigs.InitializeCollections ? new List<AutoMLAlgorithmConfig>() : null;

        /// <summary>
        /// Gets and sets the property AlgorithmsConfig. 
        /// <para>
        /// Your Autopilot job trains a default set of algorithms on your dataset. For tabular
        /// and time-series data, you can customize the algorithm list by selecting a subset of
        /// algorithms for your problem type.
        /// </para>
        ///  
        /// <para>
        ///  <c>AlgorithmsConfig</c> stores the customized selection of algorithms to train on
        /// your data.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>For the tabular problem type <c>TabularJobConfig</c>,</b> the list of available
        /// algorithms to choose from depends on the training mode set in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLJobConfig.html">
        /// <c>AutoMLJobConfig.Mode</c> </a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AlgorithmsConfig</c> should not be set when the training mode <c>AutoMLJobConfig.Mode</c>
        /// is set to <c>AUTO</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>AlgorithmsConfig</c> is provided, one <c>AutoMLAlgorithms</c> attribute must
        /// be set and one only.
        /// </para>
        ///  
        /// <para>
        /// If the list of algorithms provided as values for <c>AutoMLAlgorithms</c> is empty,
        /// <c>CandidateGenerationConfig</c> uses the full set of algorithms for the given training
        /// mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>AlgorithmsConfig</c> is not provided, <c>CandidateGenerationConfig</c> uses
        /// the full set of algorithms for the given training mode.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the list of all algorithms per training mode, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLAlgorithmConfig.html">
        /// AlgorithmConfig</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information on each algorithm, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-algorithm-support">Algorithm
        /// support</a> section in the Autopilot developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>For the time-series forecasting problem type <c>TimeSeriesForecastingJobConfig</c>,</b>
        /// choose your algorithms from the list provided in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLAlgorithmConfig.html">
        /// AlgorithmConfig</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information on each algorithm, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/timeseries-forecasting-algorithms.html">Algorithms
        /// support for time-series forecasting</a> section in the Autopilot developer guide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When <c>AlgorithmsConfig</c> is provided, one <c>AutoMLAlgorithms</c> attribute must
        /// be set and one only.
        /// </para>
        ///  
        /// <para>
        /// If the list of algorithms provided as values for <c>AutoMLAlgorithms</c> is empty,
        /// <c>CandidateGenerationConfig</c> uses the full set of algorithms for time-series forecasting.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>AlgorithmsConfig</c> is not provided, <c>CandidateGenerationConfig</c> uses
        /// the full set of algorithms for time-series forecasting.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<AutoMLAlgorithmConfig> AlgorithmsConfig
        {
            get { return this._algorithmsConfig; }
            set { this._algorithmsConfig = value; }
        }

        // Check to see if AlgorithmsConfig property is set
        internal bool IsSetAlgorithmsConfig()
        {
            return this._algorithmsConfig != null && (this._algorithmsConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}