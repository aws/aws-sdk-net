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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetCostForecast operation.
    /// </summary>
    public partial class GetCostForecastResponse : AmazonWebServiceResponse
    {
        private List<ForecastResult> _forecastResultsByTime = AWSConfigs.InitializeCollections ? new List<ForecastResult>() : null;
        private MetricValue _total;

        /// <summary>
        /// Gets and sets the property ForecastResultsByTime. 
        /// <para>
        /// The forecasts for your query, in order. For <c>DAILY</c> forecasts, this is a list
        /// of days. For <c>MONTHLY</c> forecasts, this is a list of months.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ForecastResult> ForecastResultsByTime
        {
            get { return this._forecastResultsByTime; }
            set { this._forecastResultsByTime = value; }
        }

        // Check to see if ForecastResultsByTime property is set
        internal bool IsSetForecastResultsByTime()
        {
            return this._forecastResultsByTime != null && (this._forecastResultsByTime.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// How much you are forecasted to spend over the forecast period, in <c>USD</c>.
        /// </para>
        /// </summary>
        public MetricValue Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total != null;
        }

    }
}