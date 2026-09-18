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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Details about the dynamic speed.
    /// 
    ///  
    /// <para>
    ///  <b>Unit</b>: <c>kilometers per hour</c> 
    /// </para>
    /// </summary>
    public partial class RouteSpanDynamicSpeedDetails
    {
        /// <summary>
        /// Gets and sets the property BestCaseSpeed. 
        /// <para>
        /// Estimated speed while traversing the span without traffic congestion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilometers per hour</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public double? BestCaseSpeed { get; set; }

        /// <summary>
        /// Checks to see if the BestCaseSpeed property is set.
        /// </summary>
        internal bool IsSetBestCaseSpeed() => this.BestCaseSpeed.HasValue;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? TurnDuration { get; set; }

        /// <summary>
        /// Checks to see if the TurnDuration property is set.
        /// </summary>
        internal bool IsSetTurnDuration() => this.TurnDuration.HasValue;

        /// <summary>
        /// Gets and sets the property TypicalSpeed. 
        /// <para>
        /// Estimated speed while traversing the span under typical traffic congestion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilometers per hour</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public double? TypicalSpeed { get; set; }

        /// <summary>
        /// Checks to see if the TypicalSpeed property is set.
        /// </summary>
        internal bool IsSetTypicalSpeed() => this.TypicalSpeed.HasValue;
    }
}
