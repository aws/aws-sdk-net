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
 * Do not modify this file. This file is generated from the forecastquery-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastQueryService.Model
{
    /// <summary>
    /// Provides information about a forecast. Returned as part of the <a>QueryForecast</a>
    /// response.
    /// </summary>
    public partial class Forecast
    {
        private Dictionary<string, List<DataPoint>> _predictions = AWSConfigs.InitializeCollections ? new Dictionary<string, List<DataPoint>>() : null;

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
        /// <para>
        /// The default setting is <c>["0.1", "0.5", "0.9"]</c>. Use the optional <c>ForecastTypes</c>
        /// parameter of the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateForecast.html">CreateForecast</a>
        /// operation to change the values. The values will vary depending on how this is set,
        /// with a minimum of <c>1</c> and a maximum of <c>5.</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<DataPoint>> Predictions
        {
            get { return this._predictions; }
            set { this._predictions = value; }
        }

        // Check to see if Predictions property is set
        internal bool IsSetPredictions()
        {
            return this._predictions != null && (this._predictions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}