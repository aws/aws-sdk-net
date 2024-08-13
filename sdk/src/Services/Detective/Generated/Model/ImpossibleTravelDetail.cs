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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Contains information on unusual and impossible travel in an account.
    /// </summary>
    public partial class ImpossibleTravelDetail
    {
        private string _endingIpAddress;
        private string _endingLocation;
        private int? _hourlyTimeDelta;
        private string _startingIpAddress;
        private string _startingLocation;

        /// <summary>
        /// Gets and sets the property EndingIpAddress. 
        /// <para>
        /// IP address where the resource was last used in the impossible travel.
        /// </para>
        /// </summary>
        public string EndingIpAddress
        {
            get { return this._endingIpAddress; }
            set { this._endingIpAddress = value; }
        }

        // Check to see if EndingIpAddress property is set
        internal bool IsSetEndingIpAddress()
        {
            return this._endingIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property EndingLocation. 
        /// <para>
        /// Location where the resource was last used in the impossible travel.
        /// </para>
        /// </summary>
        public string EndingLocation
        {
            get { return this._endingLocation; }
            set { this._endingLocation = value; }
        }

        // Check to see if EndingLocation property is set
        internal bool IsSetEndingLocation()
        {
            return this._endingLocation != null;
        }

        /// <summary>
        /// Gets and sets the property HourlyTimeDelta. 
        /// <para>
        /// Returns the time difference between the first and last timestamp the resource was
        /// used.
        /// </para>
        /// </summary>
        public int? HourlyTimeDelta
        {
            get { return this._hourlyTimeDelta; }
            set { this._hourlyTimeDelta = value; }
        }

        // Check to see if HourlyTimeDelta property is set
        internal bool IsSetHourlyTimeDelta()
        {
            return this._hourlyTimeDelta.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartingIpAddress. 
        /// <para>
        /// IP address where the resource was first used in the impossible travel.
        /// </para>
        /// </summary>
        public string StartingIpAddress
        {
            get { return this._startingIpAddress; }
            set { this._startingIpAddress = value; }
        }

        // Check to see if StartingIpAddress property is set
        internal bool IsSetStartingIpAddress()
        {
            return this._startingIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property StartingLocation. 
        /// <para>
        /// Location where the resource was first used in the impossible travel.
        /// </para>
        /// </summary>
        public string StartingLocation
        {
            get { return this._startingLocation; }
            set { this._startingLocation = value; }
        }

        // Check to see if StartingLocation property is set
        internal bool IsSetStartingLocation()
        {
            return this._startingLocation != null;
        }

    }
}