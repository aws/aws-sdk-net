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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The forecast properties setup of a forecast in the line chart.
    /// </summary>
    public partial class TimeBasedForecastProperties
    {
        private double? _lowerBoundary;
        private int? _periodsBackward;
        private int? _periodsForward;
        private int? _predictionInterval;
        private int? _seasonality;
        private double? _upperBoundary;

        /// <summary>
        /// Gets and sets the property LowerBoundary. 
        /// <para>
        /// The lower boundary setup of a forecast computation.
        /// </para>
        /// </summary>
        public double LowerBoundary
        {
            get { return this._lowerBoundary.GetValueOrDefault(); }
            set { this._lowerBoundary = value; }
        }

        // Check to see if LowerBoundary property is set
        internal bool IsSetLowerBoundary()
        {
            return this._lowerBoundary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeriodsBackward. 
        /// <para>
        /// The periods backward setup of a forecast computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int PeriodsBackward
        {
            get { return this._periodsBackward.GetValueOrDefault(); }
            set { this._periodsBackward = value; }
        }

        // Check to see if PeriodsBackward property is set
        internal bool IsSetPeriodsBackward()
        {
            return this._periodsBackward.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeriodsForward. 
        /// <para>
        /// The periods forward setup of a forecast computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int PeriodsForward
        {
            get { return this._periodsForward.GetValueOrDefault(); }
            set { this._periodsForward = value; }
        }

        // Check to see if PeriodsForward property is set
        internal bool IsSetPeriodsForward()
        {
            return this._periodsForward.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredictionInterval. 
        /// <para>
        /// The prediction interval setup of a forecast computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=95)]
        public int PredictionInterval
        {
            get { return this._predictionInterval.GetValueOrDefault(); }
            set { this._predictionInterval = value; }
        }

        // Check to see if PredictionInterval property is set
        internal bool IsSetPredictionInterval()
        {
            return this._predictionInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Seasonality. 
        /// <para>
        /// The seasonality setup of a forecast computation. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NULL</code>: The input is set to <code>NULL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NON_NULL</code>: The input is set to a custom value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public int Seasonality
        {
            get { return this._seasonality.GetValueOrDefault(); }
            set { this._seasonality = value; }
        }

        // Check to see if Seasonality property is set
        internal bool IsSetSeasonality()
        {
            return this._seasonality.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpperBoundary. 
        /// <para>
        /// The upper boundary setup of a forecast computation.
        /// </para>
        /// </summary>
        public double UpperBoundary
        {
            get { return this._upperBoundary.GetValueOrDefault(); }
            set { this._upperBoundary = value; }
        }

        // Check to see if UpperBoundary property is set
        internal bool IsSetUpperBoundary()
        {
            return this._upperBoundary.HasValue; 
        }

    }
}