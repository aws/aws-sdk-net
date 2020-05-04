/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Creates settings for the instant booking feature that are applied to a room profile.
    /// When users start their meeting with Alexa, Alexa automatically books the room for
    /// the configured duration if the room is available.
    /// </summary>
    public partial class CreateInstantBooking
    {
        private int? _durationInMinutes;
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property DurationInMinutes. 
        /// <para>
        /// Duration between 15 and 240 minutes at increments of 15 that determines how long to
        /// book an available room when a meeting is started with Alexa.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int DurationInMinutes
        {
            get { return this._durationInMinutes.GetValueOrDefault(); }
            set { this._durationInMinutes = value; }
        }

        // Check to see if DurationInMinutes property is set
        internal bool IsSetDurationInMinutes()
        {
            return this._durationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether instant booking is enabled or not.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}