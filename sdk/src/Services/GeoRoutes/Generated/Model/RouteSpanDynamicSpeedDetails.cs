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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Details about the dynamic speed.
    /// 
    ///  
    /// <para>
    ///  <b>Unit</b>: <c>KilometersPerHour</c> 
    /// </para>
    /// </summary>
    public partial class RouteSpanDynamicSpeedDetails
    {
        private double? _bestCaseSpeed;
        private long? _turnDuration;
        private double? _typicalSpeed;

        /// <summary>
        /// Gets and sets the property BestCaseSpeed. 
        /// <para>
        /// Estimated speed while traversing the span without traffic congestion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>KilometersPerHour</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public double? BestCaseSpeed
        {
            get { return this._bestCaseSpeed; }
            set { this._bestCaseSpeed = value; }
        }

        // Check to see if BestCaseSpeed property is set
        internal bool IsSetBestCaseSpeed()
        {
            return this._bestCaseSpeed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TurnDuration. 
        /// <para>
        /// Estimated time to turn from this span into the next. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? TurnDuration
        {
            get { return this._turnDuration; }
            set { this._turnDuration = value; }
        }

        // Check to see if TurnDuration property is set
        internal bool IsSetTurnDuration()
        {
            return this._turnDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TypicalSpeed. 
        /// <para>
        /// Estimated speed while traversing the span under typical traffic congestion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>KilometersPerHour</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public double? TypicalSpeed
        {
            get { return this._typicalSpeed; }
            set { this._typicalSpeed = value; }
        }

        // Check to see if TypicalSpeed property is set
        internal bool IsSetTypicalSpeed()
        {
            return this._typicalSpeed.HasValue; 
        }

    }
}