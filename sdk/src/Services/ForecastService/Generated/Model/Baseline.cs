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
    /// Metrics you can use as a baseline for comparison purposes. Use these metrics when
    /// you interpret monitoring results for an auto predictor.
    /// </summary>
    public partial class Baseline
    {
        private PredictorBaseline _predictorBaseline;

        /// <summary>
        /// Gets and sets the property PredictorBaseline. 
        /// <para>
        /// The initial <a href="https://docs.aws.amazon.com/forecast/latest/dg/metrics.html">accuracy
        /// metrics</a> for the predictor you are monitoring. Use these metrics as a baseline
        /// for comparison purposes as you use your predictor and the metrics change.
        /// </para>
        /// </summary>
        public PredictorBaseline PredictorBaseline
        {
            get { return this._predictorBaseline; }
            set { this._predictorBaseline = value; }
        }

        // Check to see if PredictorBaseline property is set
        internal bool IsSetPredictorBaseline()
        {
            return this._predictorBaseline != null;
        }

    }
}