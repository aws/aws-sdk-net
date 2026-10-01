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
    /// The forecast properties setup of a forecast in the line chart.
    /// </summary>
    public partial class TimeBasedForecastProperties
    {
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
        ///  <c>NULL</c>: The input is set to <c>NULL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_NULL</c>: The input is set to a custom value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 180)]
        public int? Seasonality { get; set; }

        /// <summary>
        /// Checks to see if the Seasonality property is set.
        /// </summary>
        internal bool IsSetSeasonality() => this.Seasonality.HasValue;

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
    }
}
