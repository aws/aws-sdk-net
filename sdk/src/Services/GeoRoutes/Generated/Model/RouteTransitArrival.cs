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
    /// Details corresponding to the arrival for the leg.
    /// </summary>
    public partial class RouteTransitArrival
    {
        private long? _delay;
        private RouteTransitPlace _place;
        private RouteTransitTripStatus _status;
        private string _time;

        /// <summary>
        /// Gets and sets the property Delay. 
        /// <para>
        /// The delay from the scheduled arrival time.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Delay
        {
            get { return this._delay; }
            set { this._delay = value; }
        }

        // Check to see if Delay property is set
        internal bool IsSetDelay()
        {
            return this._delay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Place. 
        /// <para>
        /// Place details corresponding to the arrival.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteTransitPlace Place
        {
            get { return this._place; }
            set { this._place = value; }
        }

        // Check to see if Place property is set
        internal bool IsSetPlace()
        {
            return this._place != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the arrival.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteTransitTripStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The arrival time.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

    }
}