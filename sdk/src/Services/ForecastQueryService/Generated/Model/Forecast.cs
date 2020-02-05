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
 * Do not modify this file. This file is generated from the forecastquery-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastQueryService.Model
{
    /// <summary>
    /// Provides information about a forecast. Returned as part of the <a>QueryForecast</a>
    /// response.
    /// </summary>
    public partial class Forecast
    {
        private Dictionary<string, List<DataPoint>> _predictions = new Dictionary<string, List<DataPoint>>();

        /// <summary>
        /// Gets and sets the property Predictions. 
        /// <para>
        /// The forecast.
        /// </para>
        ///  
        /// <para>
        /// The <i>string</i> of the string-to-array map is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// p10
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// p50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// p90
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, List<DataPoint>> Predictions
        {
            get { return this._predictions; }
            set { this._predictions = value; }
        }

        // Check to see if Predictions property is set
        internal bool IsSetPredictions()
        {
            return this._predictions != null && this._predictions.Count > 0; 
        }

    }
}