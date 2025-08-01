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
    /// This is the response object from the DescribeWhatIfForecast operation.
    /// </summary>
    public partial class DescribeWhatIfForecastResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private long? _estimatedTimeRemainingInMinutes;
        private List<string> _forecastTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastModificationTime;
        private string _message;
        private string _status;
        private TimeSeriesReplacementsDataSource _timeSeriesReplacementsDataSource;
        private List<TimeSeriesTransformation> _timeSeriesTransformations = AWSConfigs.InitializeCollections ? new List<TimeSeriesTransformation>() : null;
        private string _whatIfAnalysisArn;
        private string _whatIfForecastArn;
        private string _whatIfForecastName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the what-if forecast was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The approximate time remaining to complete the what-if forecast, in minutes.
        /// </para>
        /// </summary>
        public long? EstimatedTimeRemainingInMinutes
        {
            get { return this._estimatedTimeRemainingInMinutes; }
            set { this._estimatedTimeRemainingInMinutes = value; }
        }

        // Check to see if EstimatedTimeRemainingInMinutes property is set
        internal bool IsSetEstimatedTimeRemainingInMinutes()
        {
            return this._estimatedTimeRemainingInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastTypes. 
        /// <para>
        /// The quantiles at which probabilistic forecasts are generated. You can specify up to
        /// five quantiles per what-if forecast in the <a>CreateWhatIfForecast</a> operation.
        /// If you didn't specify quantiles, the default values are <c>["0.1", "0.5", "0.9"]</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> ForecastTypes
        {
            get { return this._forecastTypes; }
            set { this._forecastTypes = value; }
        }

        // Check to see if ForecastTypes property is set
        internal bool IsSetForecastTypes()
        {
            return this._forecastTypes != null && (this._forecastTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the resource was modified. The timestamp depends on the status of the
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c> - The <c>CreationTime</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPED</c> - When the job stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> or <c>CREATE_FAILED</c> - When the job finished or failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the what-if forecast. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c>, <c>CREATE_IN_PROGRESS</c>, <c>CREATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c>, <c>CREATE_STOPPED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_PENDING</c>, <c>DELETE_IN_PROGRESS</c>, <c>DELETE_FAILED</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>Status</c> of the what-if forecast must be <c>ACTIVE</c> before you can access
        /// the forecast.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesReplacementsDataSource. 
        /// <para>
        /// An array of <c>S3Config</c>, <c>Schema</c>, and <c>Format</c> elements that describe
        /// the replacement time series.
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
        /// An array of <c>Action</c> and <c>TimeSeriesConditions</c> elements that describe what
        /// transformations were applied to which time series.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._timeSeriesTransformations != null && (this._timeSeriesTransformations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WhatIfAnalysisArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if analysis that contains this forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property WhatIfForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Max=300)]
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

        /// <summary>
        /// Gets and sets the property WhatIfForecastName. 
        /// <para>
        /// The name of the what-if forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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