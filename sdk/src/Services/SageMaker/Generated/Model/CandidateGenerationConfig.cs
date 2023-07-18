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
    /// Stores the configuration information for how model candidates are generated using
    /// an AutoML job V2.
    /// </summary>
    public partial class CandidateGenerationConfig
    {
        private List<AutoMLAlgorithmConfig> _algorithmsConfig = new List<AutoMLAlgorithmConfig>();

        /// <summary>
        /// Gets and sets the property AlgorithmsConfig. 
        /// <para>
        /// Stores the configuration information for the selection of algorithms used to train
        /// model candidates on tabular data.
        /// </para>
        ///  
        /// <para>
        /// The list of available algorithms to choose from depends on the training mode set in
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TabularJobConfig.html">
        /// <code>TabularJobConfig.Mode</code> </a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmsConfig</code> should not be set in <code>AUTO</code> training mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <code>AlgorithmsConfig</code> is provided, one <code>AutoMLAlgorithms</code>
        /// attribute must be set and one only.
        /// </para>
        ///  
        /// <para>
        /// If the list of algorithms provided as values for <code>AutoMLAlgorithms</code> is
        /// empty, <code>CandidateGenerationConfig</code> uses the full set of algorithms for
        /// the given training mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <code>AlgorithmsConfig</code> is not provided, <code>CandidateGenerationConfig</code>
        /// uses the full set of algorithms for the given training mode.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the list of all algorithms per problem type and training mode, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLAlgorithmConfig.html">
        /// AutoMLAlgorithmConfig</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information on each algorithm, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-algorithm-support">Algorithm
        /// support</a> section in Autopilot developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<AutoMLAlgorithmConfig> AlgorithmsConfig
        {
            get { return this._algorithmsConfig; }
            set { this._algorithmsConfig = value; }
        }

        // Check to see if AlgorithmsConfig property is set
        internal bool IsSetAlgorithmsConfig()
        {
            return this._algorithmsConfig != null && this._algorithmsConfig.Count > 0; 
        }

    }
}