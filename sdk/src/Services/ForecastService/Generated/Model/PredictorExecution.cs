/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The algorithm used to perform a backtest and the status of those tests.
    /// </summary>
    public partial class PredictorExecution
    {
        private string _algorithmArn;
        private List<TestWindowSummary> _testWindows = new List<TestWindowSummary>();

        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The ARN of the algorithm used to test the predictor.
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
        /// An array of test windows used to evaluate the algorithm. The <code>NumberOfBacktestWindows</code>
        /// from the object determines the number of windows in the array.
        /// </para>
        /// </summary>
        public List<TestWindowSummary> TestWindows
        {
            get { return this._testWindows; }
            set { this._testWindows = value; }
        }

        // Check to see if TestWindows property is set
        internal bool IsSetTestWindows()
        {
            return this._testWindows != null && this._testWindows.Count > 0; 
        }

    }
}