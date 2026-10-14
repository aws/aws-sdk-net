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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property MeanValue. 
        /// <para>
        /// The mean value of the forecast.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MeanValue { get; set; }

        /// <summary>
        /// Checks to see if the MeanValue property is set.
        /// </summary>
        internal bool IsSetMeanValue() => this.MeanValue != null;

        /// <summary>
        /// Gets and sets the property PredictionIntervalLowerBound. 
        /// <para>
        /// The lower limit for the prediction interval. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PredictionIntervalLowerBound { get; set; }

        /// <summary>
        /// Checks to see if the PredictionIntervalLowerBound property is set.
        /// </summary>
        internal bool IsSetPredictionIntervalLowerBound() => this.PredictionIntervalLowerBound != null;

        /// <summary>
        /// Gets and sets the property PredictionIntervalUpperBound. 
        /// <para>
        /// The upper limit for the prediction interval. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PredictionIntervalUpperBound { get; set; }

        /// <summary>
        /// Checks to see if the PredictionIntervalUpperBound property is set.
        /// </summary>
        internal bool IsSetPredictionIntervalUpperBound() => this.PredictionIntervalUpperBound != null;

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The period of time that the forecast covers.
        /// </para>
        /// </summary>
        public DateInterval TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;
    }
}
