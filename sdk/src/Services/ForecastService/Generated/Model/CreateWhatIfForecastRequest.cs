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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWhatIfForecast operation.
    /// A what-if forecast is a forecast that is created from a modified version of the baseline
    /// forecast. Each what-if forecast incorporates either a replacement dataset or a set
    /// of transformations to the original dataset.
    /// </summary>
    public partial class CreateWhatIfForecastRequest : AmazonForecastServiceRequest
    {
        private List<Tag> _tags = new List<Tag>();
        private TimeSeriesReplacementsDataSource _timeSeriesReplacementsDataSource;
        private List<TimeSeriesTransformation> _timeSeriesTransformations = new List<TimeSeriesTransformation>();
        private string _whatIfAnalysisArn;
        private string _whatIfForecastName;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/forecast/latest/dg/tagging-forecast-resources.html">tags</a>
        /// to apply to the what if forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesReplacementsDataSource. 
        /// <para>
        /// The replacement time series dataset, which contains the rows that you want to change
        /// in the related time series dataset. A replacement time series does not need to contain
        /// all rows that are in the baseline related time series. Include only the rows (measure-dimension
        /// combinations) that you want to include in the what-if forecast.
        /// </para>
        ///  
        /// <para>
        /// This dataset is merged with the original time series to create a transformed dataset
        /// that is used for the what-if analysis.
        /// </para>
        ///  
        /// <para>
        /// This dataset should contain the items to modify (such as item_id or workforce_type),
        /// any relevant dimensions, the timestamp column, and at least one of the related time
        /// series columns. This file should not contain duplicate timestamps for the same time
        /// series.
        /// </para>
        ///  
        /// <para>
        /// Timestamps and item_ids not included in this dataset are not included in the what-if
        /// analysis. 
        /// </para>
        /// </summary>
        public TimeSeriesReplacementsDataSource TimeSeriesReplacementsDataSource
        {
            get { return this._timeSeriesReplacementsDataSource; }
            set { this._timeSeriesReplacementsDataSource = value; }
        }

        // Check to see if TimeSeriesReplacementsDataSource property is set
        internal bool IsSetTimeSeriesReplacementsDataSource()
        {
            return this._timeSeriesReplacementsDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesTransformations. 
        /// <para>
        /// The transformations that are applied to the baseline time series. Each transformation
        /// contains an action and a set of conditions. An action is applied only when all conditions
        /// are met. If no conditions are provided, the action is applied to all items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<TimeSeriesTransformation> TimeSeriesTransformations
        {
            get { return this._timeSeriesTransformations; }
            set { this._timeSeriesTransformations = value; }
        }

        // Check to see if TimeSeriesTransformations property is set
        internal bool IsSetTimeSeriesTransformations()
        {
            return this._timeSeriesTransformations != null && this._timeSeriesTransformations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WhatIfAnalysisArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string WhatIfAnalysisArn
        {
            get { return this._whatIfAnalysisArn; }
            set { this._whatIfAnalysisArn = value; }
        }

        // Check to see if WhatIfAnalysisArn property is set
        internal bool IsSetWhatIfAnalysisArn()
        {
            return this._whatIfAnalysisArn != null;
        }

        /// <summary>
        /// Gets and sets the property WhatIfForecastName. 
        /// <para>
        /// The name of the what-if forecast. Names must be unique within each what-if analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string WhatIfForecastName
        {
            get { return this._whatIfForecastName; }
            set { this._whatIfForecastName = value; }
        }

        // Check to see if WhatIfForecastName property is set
        internal bool IsSetWhatIfForecastName()
        {
            return this._whatIfForecastName != null;
        }

    }
}