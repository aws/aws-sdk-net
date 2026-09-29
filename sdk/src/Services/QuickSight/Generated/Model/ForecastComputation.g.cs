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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The forecast computation configuration.
    /// </summary>
    public partial class ForecastComputation
    {
        /// <summary>
        /// Gets and sets the property ComputationId. 
        /// <para>
        /// The ID for a computation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ComputationId { get; set; }

        /// <summary>
        /// Checks to see if the ComputationId property is set.
        /// </summary>
        internal bool IsSetComputationId() => this.ComputationId != null;

        /// <summary>
        /// Gets and sets the property CustomSeasonalityValue. 
        /// <para>
        /// The custom seasonality value setup of a forecast computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 180)]
        public int? CustomSeasonalityValue { get; set; }

        /// <summary>
        /// Checks to see if the CustomSeasonalityValue property is set.
        /// </summary>
        internal bool IsSetCustomSeasonalityValue() => this.CustomSeasonalityValue.HasValue;

        /// <summary>
        /// Gets and sets the property LowerBoundary. 
        /// <para>
        /// The lower boundary setup of a forecast computation.
        /// </para>
        /// </summary>
        public double? LowerBoundary { get; set; }

        /// <summary>
        /// Checks to see if the LowerBoundary property is set.
        /// </summary>
        internal bool IsSetLowerBoundary() => this.LowerBoundary.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a computation.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PeriodsBackward. 
        /// <para>
        /// The periods backward setup of a forecast computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? PeriodsBackward { get; set; }

        /// <summary>
        /// Checks to see if the PeriodsBackward property is set.
        /// </summary>
        internal bool IsSetPeriodsBackward() => this.PeriodsBackward.HasValue;

        /// <summary>
        /// Gets and sets the property PeriodsForward. 
        /// <para>
        /// The periods forward setup of a forecast computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? PeriodsForward { get; set; }

        /// <summary>
        /// Checks to see if the PeriodsForward property is set.
        /// </summary>
        internal bool IsSetPeriodsForward() => this.PeriodsForward.HasValue;

        /// <summary>
        /// Gets and sets the property PredictionInterval. 
        /// <para>
        /// The prediction interval setup of a forecast computation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 95)]
        public int? PredictionInterval { get; set; }

        /// <summary>
        /// Checks to see if the PredictionInterval property is set.
        /// </summary>
        internal bool IsSetPredictionInterval() => this.PredictionInterval.HasValue;

        /// <summary>
        /// Gets and sets the property Seasonality. 
        /// <para>
        /// The seasonality setup of a forecast computation. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTOMATIC</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM</c>: Checks the custom seasonality value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ForecastComputationSeasonality Seasonality { get; set; }

        /// <summary>
        /// Checks to see if the Seasonality property is set.
        /// </summary>
        internal bool IsSetSeasonality() => this.Seasonality != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The time field that is used in a computation.
        /// </para>
        /// </summary>
        public DimensionField Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time != null;

        /// <summary>
        /// Gets and sets the property UpperBoundary. 
        /// <para>
        /// The upper boundary setup of a forecast computation.
        /// </para>
        /// </summary>
        public double? UpperBoundary { get; set; }

        /// <summary>
        /// Checks to see if the UpperBoundary property is set.
        /// </summary>
        internal bool IsSetUpperBoundary() => this.UpperBoundary.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value field that is used in a computation.
        /// </para>
        /// </summary>
        public MeasureField Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
