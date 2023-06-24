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
    /// Container for the parameters to the CreateExplainability operation.
    /// <note> 
    /// <para>
    /// Explainability is only available for Forecasts and Predictors generated from an AutoPredictor
    /// (<a>CreateAutoPredictor</a>)
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates an Amazon Forecast Explainability.
    /// </para>
    ///  
    /// <para>
    /// Explainability helps you better understand how the attributes in your datasets impact
    /// forecast. Amazon Forecast uses a metric called Impact scores to quantify the relative
    /// impact of each attribute and determine whether they increase or decrease forecast
    /// values.
    /// </para>
    ///  
    /// <para>
    /// To enable Forecast Explainability, your predictor must include at least one of the
    /// following: related time series, item metadata, or additional datasets like Holidays
    /// and the Weather Index.
    /// </para>
    ///  
    /// <para>
    /// CreateExplainability accepts either a Predictor ARN or Forecast ARN. To receive aggregated
    /// Impact scores for all time series and time points in your datasets, provide a Predictor
    /// ARN. To receive Impact scores for specific time series and time points, provide a
    /// Forecast ARN.
    /// </para>
    ///  
    /// <para>
    ///  <b>CreateExplainability with a Predictor ARN</b> 
    /// </para>
    ///  <note> 
    /// <para>
    /// You can only have one Explainability resource per predictor. If you already enabled
    /// <code>ExplainPredictor</code> in <a>CreateAutoPredictor</a>, that predictor already
    /// has an Explainability resource.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following parameters are required when providing a Predictor ARN:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>ExplainabilityName</code> - A unique name for the Explainability.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ResourceArn</code> - The Arn of the predictor.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TimePointGranularity</code> - Must be set to “ALL”.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TimeSeriesGranularity</code> - Must be set to “ALL”.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Do not specify a value for the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>DataSource</code> - Only valid when TimeSeriesGranularity is “SPECIFIC”.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Schema</code> - Only valid when TimeSeriesGranularity is “SPECIFIC”.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>StartDateTime</code> - Only valid when TimePointGranularity is “SPECIFIC”.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>EndDateTime</code> - Only valid when TimePointGranularity is “SPECIFIC”.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>CreateExplainability with a Forecast ARN</b> 
    /// </para>
    ///  <note> 
    /// <para>
    /// You can specify a maximum of 50 time series and 500 time points.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following parameters are required when providing a Predictor ARN:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>ExplainabilityName</code> - A unique name for the Explainability.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ResourceArn</code> - The Arn of the forecast.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TimePointGranularity</code> - Either “ALL” or “SPECIFIC”.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TimeSeriesGranularity</code> - Either “ALL” or “SPECIFIC”.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you set TimeSeriesGranularity to “SPECIFIC”, you must also provide the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>DataSource</code> - The S3 location of the CSV file specifying your time series.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Schema</code> - The Schema defines the attributes and attribute types listed
    /// in the Data Source.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you set TimePointGranularity to “SPECIFIC”, you must also provide the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>StartDateTime</code> - The first timestamp in the range of time points.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>EndDateTime</code> - The last timestamp in the range of time points.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateExplainabilityRequest : AmazonForecastServiceRequest
    {
        private DataSource _dataSource;
        private bool? _enableVisualization;
        private string _endDateTime;
        private ExplainabilityConfig _explainabilityConfig;
        private string _explainabilityName;
        private string _resourceArn;
        private Schema _schema;
        private string _startDateTime;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DataSource.
        /// </summary>
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property EnableVisualization. 
        /// <para>
        /// Create an Explainability visualization that is viewable within the Amazon Web Services
        /// console.
        /// </para>
        /// </summary>
        public bool EnableVisualization
        {
            get { return this._enableVisualization.GetValueOrDefault(); }
            set { this._enableVisualization = value; }
        }

        // Check to see if EnableVisualization property is set
        internal bool IsSetEnableVisualization()
        {
            return this._enableVisualization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// If <code>TimePointGranularity</code> is set to <code>SPECIFIC</code>, define the last
        /// time point for the Explainability.
        /// </para>
        ///  
        /// <para>
        /// Use the following timestamp format: yyyy-MM-ddTHH:mm:ss (example: 2015-01-01T20:00:00)
        /// </para>
        /// </summary>
        [AWSProperty(Max=19)]
        public string EndDateTime
        {
            get { return this._endDateTime; }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ExplainabilityConfig. 
        /// <para>
        /// The configuration settings that define the granularity of time series and time points
        /// for the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExplainabilityConfig ExplainabilityConfig
        {
            get { return this._explainabilityConfig; }
            set { this._explainabilityConfig = value; }
        }

        // Check to see if ExplainabilityConfig property is set
        internal bool IsSetExplainabilityConfig()
        {
            return this._explainabilityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ExplainabilityName. 
        /// <para>
        /// A unique name for the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ExplainabilityName
        {
            get { return this._explainabilityName; }
            set { this._explainabilityName = value; }
        }

        // Check to see if ExplainabilityName property is set
        internal bool IsSetExplainabilityName()
        {
            return this._explainabilityName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Predictor or Forecast used to create the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Schema.
        /// </summary>
        public Schema Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// If <code>TimePointGranularity</code> is set to <code>SPECIFIC</code>, define the first
        /// point for the Explainability.
        /// </para>
        ///  
        /// <para>
        /// Use the following timestamp format: yyyy-MM-ddTHH:mm:ss (example: 2015-01-01T20:00:00)
        /// </para>
        /// </summary>
        [AWSProperty(Max=19)]
        public string StartDateTime
        {
            get { return this._startDateTime; }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata to help you categorize and organize your resources. Each tag consists
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

    }
}