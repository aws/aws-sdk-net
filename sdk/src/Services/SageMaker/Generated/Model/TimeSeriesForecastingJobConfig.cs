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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The collection of settings used by an AutoML job V2 for the time-series forecasting
    /// problem type.
    /// </summary>
    public partial class TimeSeriesForecastingJobConfig
    {
        private CandidateGenerationConfig _candidateGenerationConfig;
        private AutoMLJobCompletionCriteria _completionCriteria;
        private string _featureSpecificationS3Uri;
        private string _forecastFrequency;
        private int? _forecastHorizon;
        private List<string> _forecastQuantiles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<HolidayConfigAttributes> _holidayConfig = AWSConfigs.InitializeCollections ? new List<HolidayConfigAttributes>() : null;
        private TimeSeriesConfig _timeSeriesConfig;
        private TimeSeriesTransformations _transformations;

        /// <summary>
        /// Gets and sets the property CandidateGenerationConfig.
        /// </summary>
        public CandidateGenerationConfig CandidateGenerationConfig
        {
            get { return this._candidateGenerationConfig; }
            set { this._candidateGenerationConfig = value; }
        }

        // Check to see if CandidateGenerationConfig property is set
        internal bool IsSetCandidateGenerationConfig()
        {
            return this._candidateGenerationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionCriteria.
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria
        {
            get { return this._completionCriteria; }
            set { this._completionCriteria = value; }
        }

        // Check to see if CompletionCriteria property is set
        internal bool IsSetCompletionCriteria()
        {
            return this._completionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureSpecificationS3Uri. 
        /// <para>
        /// A URL to the Amazon S3 data source containing additional selected features that complement
        /// the target, itemID, timestamp, and grouped columns set in <c>TimeSeriesConfig</c>.
        /// When not provided, the AutoML job V2 includes all the columns from the original dataset
        /// that are not already declared in <c>TimeSeriesConfig</c>. If provided, the AutoML
        /// job V2 only considers these additional columns as a complement to the ones declared
        /// in <c>TimeSeriesConfig</c>.
        /// </para>
        ///  
        /// <para>
        /// You can input <c>FeatureAttributeNames</c> (optional) in JSON format as shown below:
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "FeatureAttributeNames":["col1", "col2", ...] }</c>.
        /// </para>
        ///  
        /// <para>
        /// You can also specify the data type of the feature (optional) in the format shown below:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "FeatureDataTypes":{"col1":"numeric", "col2":"categorical" ... } }</c> 
        /// </para>
        ///  
        /// <para>
        /// Autopilot supports the following data types: <c>numeric</c>, <c>categorical</c>, <c>text</c>,
        /// and <c>datetime</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// These column keys must not include any column set in <c>TimeSeriesConfig</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FeatureSpecificationS3Uri
        {
            get { return this._featureSpecificationS3Uri; }
            set { this._featureSpecificationS3Uri = value; }
        }

        // Check to see if FeatureSpecificationS3Uri property is set
        internal bool IsSetFeatureSpecificationS3Uri()
        {
            return this._featureSpecificationS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastFrequency. 
        /// <para>
        /// The frequency of predictions in a forecast.
        /// </para>
        ///  
        /// <para>
        /// Valid intervals are an integer followed by Y (Year), M (Month), W (Week), D (Day),
        /// H (Hour), and min (Minute). For example, <c>1D</c> indicates every day and <c>15min</c>
        /// indicates every 15 minutes. The value of a frequency must not overlap with the next
        /// larger frequency. For example, you must use a frequency of <c>1H</c> instead of <c>60min</c>.
        /// </para>
        ///  
        /// <para>
        /// The valid values for each frequency are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Minute - 1-59
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hour - 1-23
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Day - 1-6
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Week - 1-4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Month - 1-11
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Year - 1
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string ForecastFrequency
        {
            get { return this._forecastFrequency; }
            set { this._forecastFrequency = value; }
        }

        // Check to see if ForecastFrequency property is set
        internal bool IsSetForecastFrequency()
        {
            return this._forecastFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastHorizon. 
        /// <para>
        /// The number of time-steps that the model predicts. The forecast horizon is also called
        /// the prediction length. The maximum forecast horizon is the lesser of 500 time-steps
        /// or 1/4 of the time-steps in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? ForecastHorizon
        {
            get { return this._forecastHorizon; }
            set { this._forecastHorizon = value; }
        }

        // Check to see if ForecastHorizon property is set
        internal bool IsSetForecastHorizon()
        {
            return this._forecastHorizon.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastQuantiles. 
        /// <para>
        /// The quantiles used to train the model for forecasts at a specified quantile. You can
        /// specify quantiles from <c>0.01</c> (p1) to <c>0.99</c> (p99), by increments of 0.01
        /// or higher. Up to five forecast quantiles can be specified. When <c>ForecastQuantiles</c>
        /// is not provided, the AutoML job uses the quantiles p10, p50, and p90 as default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> ForecastQuantiles
        {
            get { return this._forecastQuantiles; }
            set { this._forecastQuantiles = value; }
        }

        // Check to see if ForecastQuantiles property is set
        internal bool IsSetForecastQuantiles()
        {
            return this._forecastQuantiles != null && (this._forecastQuantiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HolidayConfig. 
        /// <para>
        /// The collection of holiday featurization attributes used to incorporate national holiday
        /// information into your forecasting model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<HolidayConfigAttributes> HolidayConfig
        {
            get { return this._holidayConfig; }
            set { this._holidayConfig = value; }
        }

        // Check to see if HolidayConfig property is set
        internal bool IsSetHolidayConfig()
        {
            return this._holidayConfig != null && (this._holidayConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesConfig. 
        /// <para>
        /// The collection of components that defines the time-series.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeSeriesConfig TimeSeriesConfig
        {
            get { return this._timeSeriesConfig; }
            set { this._timeSeriesConfig = value; }
        }

        // Check to see if TimeSeriesConfig property is set
        internal bool IsSetTimeSeriesConfig()
        {
            return this._timeSeriesConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Transformations. 
        /// <para>
        /// The transformations modifying specific attributes of the time-series, such as filling
        /// strategies for missing values.
        /// </para>
        /// </summary>
        public TimeSeriesTransformations Transformations
        {
            get { return this._transformations; }
            set { this._transformations = value; }
        }

        // Check to see if Transformations property is set
        internal bool IsSetTransformations()
        {
            return this._transformations != null;
        }

    }
}