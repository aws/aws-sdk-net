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
    /// Summarized details of the route.
    /// </summary>
    public partial class RouteVehicleTravelOnlySummary
    {
        private long? _bestCaseDuration;
        private long? _duration;
        private long? _typicalDuration;

        /// <summary>
        /// Gets and sets the property BestCaseDuration. 
        /// <para>
        /// Total duration in free flowing traffic, which is the best case or shortest duration
        /// possible to cover the leg.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? BestCaseDuration
        {
            get { return this._bestCaseDuration; }
            set { this._bestCaseDuration = value; }
        }

        // Check to see if BestCaseDuration property is set
        internal bool IsSetBestCaseDuration()
        {
            return this._bestCaseDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration of the step.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4294967295)]
        public long? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TypicalDuration. 
        /// <para>
        /// Duration of the computed span under typical traffic congestion.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? TypicalDuration
        {
            get { return this._typicalDuration; }
            set { this._typicalDuration = value; }
        }

        // Check to see if TypicalDuration property is set
        internal bool IsSetTypicalDuration()
        {
            return this._typicalDuration.HasValue; 
        }

    }
}