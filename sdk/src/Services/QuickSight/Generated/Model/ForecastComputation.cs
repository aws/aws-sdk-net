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
    /// The forecast computation configuration.
    /// </summary>
    public partial class ForecastComputation
    {
        private string _computationId;
        private int? _customSeasonalityValue;
        private double? _lowerBoundary;
        private string _name;
        private int? _periodsBackward;
        private int? _periodsForward;
        private int? _predictionInterval;
        private ForecastComputationSeasonality _seasonality;
        private DimensionField _time;
        private double? _upperBoundary;
        private MeasureField _value;

        /// <summary>
        /// Gets and sets the property ComputationId. 
        /// <para>
        /// The ID for a computation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ComputationId
        {
            get { return this._computationId; }
            set { this._computationId = value; }
        }

        // Check to see if ComputationId property is set
        internal bool IsSetComputationId()
        {
            return this._computationId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSeasonalityValue. 
        /// <para>
        /// The custom seasonality value setup of a forecast computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public int CustomSeasonalityValue
        {
            get { return this._customSeasonalityValue.GetValueOrDefault(); }
            set { this._customSeasonalityValue = value; }
        }

        // Check to see if CustomSeasonalityValue property is set
        internal bool IsSetCustomSeasonalityValue()
        {
            return this._customSeasonalityValue.HasValue; 
        }

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a computation.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        ///  <code>AUTOMATIC</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CUSTOM</code>: Checks the custom seasonality value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ForecastComputationSeasonality Seasonality
        {
            get { return this._seasonality; }
            set { this._seasonality = value; }
        }

        // Check to see if Seasonality property is set
        internal bool IsSetSeasonality()
        {
            return this._seasonality != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The time field that is used in a computation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DimensionField Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
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

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value field that is used in a computation.
        /// </para>
        /// </summary>
        public MeasureField Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}