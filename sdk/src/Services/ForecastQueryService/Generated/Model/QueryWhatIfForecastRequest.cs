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
    /// Container for the parameters to the QueryWhatIfForecast operation.
    /// Retrieves a what-if forecast.
    /// </summary>
    public partial class QueryWhatIfForecastRequest : AmazonForecastQueryServiceRequest
    {
        private string _endDate;
        private Dictionary<string, string> _filters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _nextToken;
        private string _startDate;
        private string _whatIfForecastArn;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date for the what-if forecast. Specify the date using this format: yyyy-MM-dd'T'HH:mm:ss
        /// (ISO 8601 format). For example, 2015-01-01T20:00:00. 
        /// </para>
        /// </summary>
        public string EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filtering criteria to apply when retrieving the forecast. For example, to get
        /// the forecast for <c>client_21</c> in the electricity usage dataset, specify the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"item_id" : "client_21"}</c> 
        /// </para>
        ///  
        /// <para>
        /// To get the full what-if forecast, use the <a href="https://docs.aws.amazon.com/en_us/forecast/latest/dg/API_CreateWhatIfForecastExport.html">CreateForecastExportJob</a>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public Dictionary<string, string> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of the previous request was truncated, the response includes a <c>NextToken</c>.
        /// To retrieve the next set of results, use the token in the next request. Tokens expire
        /// after 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date for the what-if forecast. Specify the date using this format: yyyy-MM-dd'T'HH:mm:ss
        /// (ISO 8601 format). For example, 2015-01-01T08:00:00.
        /// </para>
        /// </summary>
        public string StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate != null;
        }

        /// <summary>
        /// Gets and sets the property WhatIfForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if forecast to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=300)]
        public string WhatIfForecastArn
        {
            get { return this._whatIfForecastArn; }
            set { this._whatIfForecastArn = value; }
        }

        // Check to see if WhatIfForecastArn property is set
        internal bool IsSetWhatIfForecastArn()
        {
            return this._whatIfForecastArn != null;
        }

    }
}