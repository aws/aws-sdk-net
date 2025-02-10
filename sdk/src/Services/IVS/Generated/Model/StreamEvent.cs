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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Object specifying a stream’s events. For a list of events, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/eventbridge.html">Using
    /// Amazon EventBridge with Amazon IVS</a>.
    /// </summary>
    public partial class StreamEvent
    {
        private string _code;
        private DateTime? _eventTime;
        private string _name;
        private string _type;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Provides additional details about the stream event. There are several values; the
        /// long descriptions are provided in the IVS console but not delivered through the IVS
        /// API or EventBridge. Multitrack-related codes are used only for certain Session Ended
        /// events.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MultitrackInputNotAllowed</c> — The broadcast client attempted to connect with
        /// multitrack input, but multitrack input was not enabled on the channel. Check your
        /// broadcast software settings or set <c>MultitrackInputConfiguration.Policy</c> to <c>ALLOW</c>
        /// or <c>REQUIRE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MultitrackInputRequired</c> — The broadcast client attempted to connect with single-track
        /// video, but multitrack input is required on this channel. Enable multitrack video in
        /// your broadcast software or configure the channel’s <c>MultitrackInputConfiguration.Policy</c>
        /// to <c>ALLOW</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidGetClientConfigurationStreamKey</c> — The broadcast client attempted to
        /// connect with an invalid, expired, or corrupt stream key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GetClientConfigurationStreamKeyRequired</c> — The broadcast client attempted to
        /// stream multitrack video without providing an authenticated stream key from GetClientConfiguration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidMultitrackInputTrackCount</c> — The multitrack input stream contained an
        /// invalid number of tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidMultitrackInputVideoTrackMediaProperties</c> — The multitrack input stream
        /// contained one or more tracks with an invalid codec, resolution, bitrate, or framerate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StreamTakeoverMediaMismatch</c> — The broadcast client attempted to take over
        /// with different media properties (e.g., codec, resolution, or video track type) from
        /// the original stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StreamTakeoverInvalidPriority</c> — The broadcast client attempted a takeover
        /// with either a priority integer value equal to or lower than the original stream's
        /// value or a value outside the allowed range of 1 to 2,147,483,647.
        /// </para>
        ///  
        /// <para>
        ///  <c>StreamTakeoverLimitBreached</c> — The broadcast client reached the maximum allowed
        /// takeover attempts for this stream.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// Time when the event occurred. This is an ISO 8601 timestamp; <i>note that this is
        /// returned as a string</i>.
        /// </para>
        /// </summary>
        public DateTime? EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name that identifies the stream event within a <c>type</c>.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Logical group for certain events.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}