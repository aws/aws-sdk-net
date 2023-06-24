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
    /// Container for the parameters to the CreateAutoPredictor operation.
    /// Creates an Amazon Forecast predictor.
    /// 
    ///  
    /// <para>
    /// Amazon Forecast creates predictors with AutoPredictor, which involves applying the
    /// optimal combination of algorithms to each time series in your datasets. You can use
    /// <a>CreateAutoPredictor</a> to create new predictors or upgrade/retrain existing predictors.
    /// </para>
    ///  
    /// <para>
    ///  <b>Creating new predictors</b> 
    /// </para>
    ///  
    /// <para>
    /// The following parameters are required when creating a new predictor:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>PredictorName</code> - A unique name for the predictor.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DatasetGroupArn</code> - The ARN of the dataset group used to train the predictor.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ForecastFrequency</code> - The granularity of your forecasts (hourly, daily,
    /// weekly, etc).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ForecastHorizon</code> - The number of time-steps that the model predicts.
    /// The forecast horizon is also called the prediction length.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When creating a new predictor, do not specify a value for <code>ReferencePredictorArn</code>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Upgrading and retraining predictors</b> 
    /// </para>
    ///  
    /// <para>
    /// The following parameters are required when retraining or upgrading a predictor:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>PredictorName</code> - A unique name for the predictor.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ReferencePredictorArn</code> - The ARN of the predictor to retrain or upgrade.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When upgrading or retraining a predictor, only specify values for the <code>ReferencePredictorArn</code>
    /// and <code>PredictorName</code>. 
    /// </para>
    /// </summary>
    public partial class CreateAutoPredictorRequest : AmazonForecastServiceRequest
    {
        private DataConfig _dataConfig;
        private EncryptionConfig _encryptionConfig;
        private bool? _explainPredictor;
        private List<string> _forecastDimensions = new List<string>();
        private string _forecastFrequency;
        private int? _forecastHorizon;
        private List<string> _forecastTypes = new List<string>();
        private MonitorConfig _monitorConfig;
        private OptimizationMetric _optimizationMetric;
        private string _predictorName;
        private string _referencePredictorArn;
        private List<Tag> _tags = new List<Tag>();
        private TimeAlignmentBoundary _timeAlignmentBoundary;

        /// <summary>
        /// Gets and sets the property DataConfig. 
        /// <para>
        /// The data configuration for your dataset group and any additional datasets.
        /// </para>
        /// </summary>
        public DataConfig DataConfig
        {
            get { return this._dataConfig; }
            set { this._dataConfig = value; }
        }

        // Check to see if DataConfig property is set
        internal bool IsSetDataConfig()
        {
            return this._dataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfig.
        /// </summary>
        public EncryptionConfig EncryptionConfig
        {
            get { return this._encryptionConfig; }
            set { this._encryptionConfig = value; }
        }

        // Check to see if EncryptionConfig property is set
        internal bool IsSetEncryptionConfig()
        {
            return this._encryptionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ExplainPredictor. 
        /// <para>
        /// Create an Explainability resource for the predictor.
        /// </para>
        /// </summary>
        public bool ExplainPredictor
        {
            get { return this._explainPredictor.GetValueOrDefault(); }
            set { this._explainPredictor = value; }
        }

        // Check to see if ExplainPredictor property is set
        internal bool IsSetExplainPredictor()
        {
            return this._explainPredictor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastDimensions. 
        /// <para>
        /// An array of dimension (field) names that specify how to group the generated forecast.
        /// </para>
        ///  
        /// <para>
        /// For example, if you are generating forecasts for item sales across all your stores,
        /// and your dataset contains a <code>store_id</code> field, you would specify <code>store_id</code>
        /// as a dimension to group sales forecasts for each store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ForecastDimensions
        {
            get { return this._forecastDimensions; }
            set { this._forecastDimensions = value; }
        }

        // Check to see if ForecastDimensions property is set
        internal bool IsSetForecastDimensions()
        {
            return this._forecastDimensions != null && this._forecastDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ForecastFrequency. 
        /// <para>
        /// The frequency of predictions in a forecast.
        /// </para>
        ///  
        /// <para>
        /// Valid intervals are an integer followed by Y (Year), M (Month), W (Week), D (Day),
        /// H (Hour), and min (Minute). For example, "1D" indicates every day and "15min" indicates
        /// every 15 minutes. You cannot specify a value that would overlap with the next larger
        /// frequency. That means, for example, you cannot specify a frequency of 60 minutes,
        /// because that is equivalent to 1 hour. The valid values for each frequency are the
        /// following:
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
        /// <para>
        /// Thus, if you want every other week forecasts, specify "2W". Or, if you want quarterly
        /// forecasts, you specify "3M".
        /// </para>
        ///  
        /// <para>
        /// The frequency must be greater than or equal to the TARGET_TIME_SERIES dataset frequency.
        /// </para>
        ///  
        /// <para>
        /// When a RELATED_TIME_SERIES dataset is provided, the frequency must be equal to the
        /// RELATED_TIME_SERIES dataset frequency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// the prediction length.
        /// </para>
        ///  
        /// <para>
        /// The maximum forecast horizon is the lesser of 500 time-steps or 1/4 of the TARGET_TIME_SERIES
        /// dataset length. If you are retraining an existing AutoPredictor, then the maximum
        /// forecast horizon is the lesser of 500 time-steps or 1/3 of the TARGET_TIME_SERIES
        /// dataset length.
        /// </para>
        ///  
        /// <para>
        /// If you are upgrading to an AutoPredictor or retraining an existing AutoPredictor,
        /// you cannot update the forecast horizon parameter. You can meet this requirement by
        /// providing longer time-series in the dataset.
        /// </para>
        /// </summary>
        public int ForecastHorizon
        {
            get { return this._forecastHorizon.GetValueOrDefault(); }
            set { this._forecastHorizon = value; }
        }

        // Check to see if ForecastHorizon property is set
        internal bool IsSetForecastHorizon()
        {
            return this._forecastHorizon.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastTypes. 
        /// <para>
        /// The forecast types used to train a predictor. You can specify up to five forecast
        /// types. Forecast types can be quantiles from 0.01 to 0.99, by increments of 0.01 or
        /// higher. You can also specify the mean forecast with <code>mean</code>.
        /// </para>
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
            return this._forecastTypes != null && this._forecastTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MonitorConfig. 
        /// <para>
        /// The configuration details for predictor monitoring. Provide a name for the monitor
        /// resource to enable predictor monitoring.
        /// </para>
        ///  
        /// <para>
        /// Predictor monitoring allows you to see how your predictor's performance changes over
        /// time. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/predictor-monitoring.html">Predictor
        /// Monitoring</a>.
        /// </para>
        /// </summary>
        public MonitorConfig MonitorConfig
        {
            get { return this._monitorConfig; }
            set { this._monitorConfig = value; }
        }

        // Check to see if MonitorConfig property is set
        internal bool IsSetMonitorConfig()
        {
            return this._monitorConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationMetric. 
        /// <para>
        /// The accuracy metric used to optimize the predictor.
        /// </para>
        /// </summary>
        public OptimizationMetric OptimizationMetric
        {
            get { return this._optimizationMetric; }
            set { this._optimizationMetric = value; }
        }

        // Check to see if OptimizationMetric property is set
        internal bool IsSetOptimizationMetric()
        {
            return this._optimizationMetric != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// A unique name for the predictor
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string PredictorName
        {
            get { return this._predictorName; }
            set { this._predictorName = value; }
        }

        // Check to see if PredictorName property is set
        internal bool IsSetPredictorName()
        {
            return this._predictorName != null;
        }

        /// <summary>
        /// Gets and sets the property ReferencePredictorArn. 
        /// <para>
        /// The ARN of the predictor to retrain or upgrade. This parameter is only used when retraining
        /// or upgrading a predictor. When creating a new predictor, do not specify a value for
        /// this parameter.
        /// </para>
        ///  
        /// <para>
        /// When upgrading or retraining a predictor, only specify values for the <code>ReferencePredictorArn</code>
        /// and <code>PredictorName</code>. The value for <code>PredictorName</code> must be a
        /// unique predictor name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ReferencePredictorArn
        {
            get { return this._referencePredictorArn; }
            set { this._referencePredictorArn = value; }
        }

        // Check to see if ReferencePredictorArn property is set
        internal bool IsSetReferencePredictorArn()
        {
            return this._referencePredictorArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata to help you categorize and organize your predictors. Each tag consists
        /// of a key and an optional value, both of which you define. Tag keys and values are
        /// case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The following restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For each resource, each tag key must be unique and each tag key must have one value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum number of tags per resource: 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length: 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length: 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Accepted characters: all letters and numbers, spaces representable in UTF-8, and +
        /// - = . _ : / @. If your tagging schema is used across other services and resources,
        /// the character restrictions of those services also apply. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key prefixes cannot include any upper or lowercase combination of <code>aws:</code>
        /// or <code>AWS:</code>. Values can have this prefix. If a tag value has <code>aws</code>
        /// as its prefix but the key does not, Forecast considers it to be a user tag and will
        /// count against the limit of 50 tags. Tags with only the key prefix of <code>aws</code>
        /// do not count against your tags per resource limit. You cannot edit or delete tag keys
        /// with this prefix.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property TimeAlignmentBoundary. 
        /// <para>
        /// The time boundary Forecast uses to align and aggregate any data that doesn't align
        /// with your forecast frequency. Provide the unit of time and the time boundary as a
        /// key value pair. For more information on specifying a time boundary, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/data-aggregation.html#specifying-time-boundary">Specifying
        /// a Time Boundary</a>. If you don't provide a time boundary, Forecast uses a set of
        /// <a href="https://docs.aws.amazon.com/forecast/latest/dg/data-aggregation.html#default-time-boundaries">Default
        /// Time Boundaries</a>.
        /// </para>
        /// </summary>
        public TimeAlignmentBoundary TimeAlignmentBoundary
        {
            get { return this._timeAlignmentBoundary; }
            set { this._timeAlignmentBoundary = value; }
        }

        // Check to see if TimeAlignmentBoundary property is set
        internal bool IsSetTimeAlignmentBoundary()
        {
            return this._timeAlignmentBoundary != null;
        }

    }
}