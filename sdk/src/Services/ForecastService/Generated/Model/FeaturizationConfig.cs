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
    /// In a <a>CreatePredictor</a> operation, the specified algorithm trains a model using
    /// the specified dataset group. You can optionally tell the operation to modify data
    /// fields prior to training a model. These modifications are referred to as <i>featurization</i>.
    /// 
    ///  
    /// <para>
    /// You define featurization using the <code>FeaturizationConfig</code> object. You specify
    /// an array of transformations, one for each field that you want to featurize. You then
    /// include the <code>FeaturizationConfig</code> object in your <code>CreatePredictor</code>
    /// request. Amazon Forecast applies the featurization to the <code>TARGET_TIME_SERIES</code>
    /// dataset before model training.
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
        /// Only a single featurization is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        [AWSProperty(Min=1, Max=5)]
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
        /// Valid intervals are Y (Year), M (Month), W (Week), D (Day), H (Hour), 30min (30 minutes),
        /// 15min (15 minutes), 10min (10 minutes), 5min (5 minutes), and 1min (1 minute). For
        /// example, "Y" indicates every year and "5min" indicates every five minutes.
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
        [AWSProperty(Required=true)]
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