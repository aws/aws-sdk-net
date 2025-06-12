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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The results of evaluating an algorithm. Returned as part of the <a>GetAccuracyMetrics</a>
    /// response.
    /// </summary>
    public partial class EvaluationResult
    {
        private string _algorithmArn;
        private List<WindowSummary> _testWindows = AWSConfigs.InitializeCollections ? new List<WindowSummary>() : null;

        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AlgorithmArn
        {
            get { return this._algorithmArn; }
            set { this._algorithmArn = value; }
        }

        // Check to see if AlgorithmArn property is set
        internal bool IsSetAlgorithmArn()
        {
            return this._algorithmArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestWindows. 
        /// <para>
        /// The array of test windows used for evaluating the algorithm. The <c>NumberOfBacktestWindows</c>
        /// from the <a>EvaluationParameters</a> object determines the number of windows in the
        /// array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WindowSummary> TestWindows
        {
            get { return this._testWindows; }
            set { this._testWindows = value; }
        }

        // Check to see if TestWindows property is set
        internal bool IsSetTestWindows()
        {
            return this._testWindows != null && (this._testWindows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}