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
    /// The forecast that's created for your query.
    /// </summary>
    public partial class ForecastResult
    {
        private string _meanValue;
        private string _predictionIntervalLowerBound;
        private string _predictionIntervalUpperBound;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property MeanValue. 
        /// <para>
        /// The mean value of the forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MeanValue
        {
            get { return this._meanValue; }
            set { this._meanValue = value; }
        }

        // Check to see if MeanValue property is set
        internal bool IsSetMeanValue()
        {
            return this._meanValue != null;
        }

        /// <summary>
        /// Gets and sets the property PredictionIntervalLowerBound. 
        /// <para>
        /// The lower limit for the prediction interval. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PredictionIntervalLowerBound
        {
            get { return this._predictionIntervalLowerBound; }
            set { this._predictionIntervalLowerBound = value; }
        }

        // Check to see if PredictionIntervalLowerBound property is set
        internal bool IsSetPredictionIntervalLowerBound()
        {
            return this._predictionIntervalLowerBound != null;
        }

        /// <summary>
        /// Gets and sets the property PredictionIntervalUpperBound. 
        /// <para>
        /// The upper limit for the prediction interval. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PredictionIntervalUpperBound
        {
            get { return this._predictionIntervalUpperBound; }
            set { this._predictionIntervalUpperBound = value; }
        }

        // Check to see if PredictionIntervalUpperBound property is set
        internal bool IsSetPredictionIntervalUpperBound()
        {
            return this._predictionIntervalUpperBound != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The period of time that the forecast covers.
        /// </para>
        /// </summary>
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}