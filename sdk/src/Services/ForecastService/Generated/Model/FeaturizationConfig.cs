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
    /// <note> 
    /// <para>
    /// This object belongs to the <a>CreatePredictor</a> operation. If you created your predictor
    /// with <a>CreateAutoPredictor</a>, see <a>AttributeConfig</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// In a <a>CreatePredictor</a> operation, the specified algorithm trains a model using
    /// the specified dataset group. You can optionally tell the operation to modify data
    /// fields prior to training a model. These modifications are referred to as <i>featurization</i>.
    /// </para>
    ///  
    /// <para>
    /// You define featurization using the <code>FeaturizationConfig</code> object. You specify
    /// an array of transformations, one for each field that you want to featurize. You then
    /// include the <code>FeaturizationConfig</code> object in your <code>CreatePredictor</code>
    /// request. Amazon Forecast applies the featurization to the <code>TARGET_TIME_SERIES</code>
    /// and <code>RELATED_TIME_SERIES</code> datasets before model training.
    /// </para>
    ///  
    /// <para>
    /// You can create multiple featurization configurations. For example, you might call
    /// the <code>CreatePredictor</code> operation twice by specifying different featurization
    /// configurations.
    /// </para>
    /// </summary>
    public partial class FeaturizationConfig
    {
        private List<Featurization> _featurizations = new List<Featurization>();
        private List<string> _forecastDimensions = new List<string>();
        private string _forecastFrequency;

        /// <summary>
        /// Gets and sets the property Featurizations. 
        /// <para>
        /// An array of featurization (transformation) information for the fields of a dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Featurization> Featurizations
        {
            get { return this._featurizations; }
            set { this._featurizations = value; }
        }

        // Check to see if Featurizations property is set
        internal bool IsSetFeaturizations()
        {
            return this._featurizations != null && this._featurizations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ForecastDimensions. 
        /// <para>
        /// An array of dimension (field) names that specify how to group the generated forecast.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose that you are generating a forecast for item sales across all
        /// of your stores, and your dataset contains a <code>store_id</code> field. If you want
        /// the sales forecast for each item by store, you would specify <code>store_id</code>
        /// as the dimension.
        /// </para>
        ///  
        /// <para>
        /// All forecast dimensions specified in the <code>TARGET_TIME_SERIES</code> dataset don't
        /// need to be specified in the <code>CreatePredictor</code> request. All forecast dimensions
        /// specified in the <code>RELATED_TIME_SERIES</code> dataset must be specified in the
        /// <code>CreatePredictor</code> request.
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
        /// TARGET_TIME_SERIES dataset frequency.
        /// </para>
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

    }
}