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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Components of the opening hours object.
    /// </summary>
    public partial class OpeningHoursComponents
    {
        private string _openDuration;
        private string _openTime;
        private string _recurrence;

        /// <summary>
        /// Gets and sets the property OpenDuration. 
        /// <para>
        /// String which represents the duration of the opening period, such as <c>"PT12H00M"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string OpenDuration
        {
            get { return this._openDuration; }
            set { this._openDuration = value; }
        }

        // Check to see if OpenDuration property is set
        internal bool IsSetOpenDuration()
        {
            return this._openDuration != null;
        }

        /// <summary>
        /// Gets and sets the property OpenTime. 
        /// <para>
        /// String which represents the opening hours, such as <c>"T070000"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=21)]
        public string OpenTime
        {
            get { return this._openTime; }
            set { this._openTime = value; }
        }

        // Check to see if OpenTime property is set
        internal bool IsSetOpenTime()
        {
            return this._openTime != null;
        }

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// Days or periods when the provided opening hours are in affect. 
        /// </para>
        ///  
        /// <para>
        /// Example: <c>FREQ:DAILY;BYDAY:MO,TU,WE,TH,SU</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public string Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this._recurrence != null;
        }

    }
}