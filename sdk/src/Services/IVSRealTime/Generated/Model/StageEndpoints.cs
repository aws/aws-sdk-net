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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Summary information about various endpoints for a stage. We recommend that you cache
    /// these values at stage creation; the values can be cached for up to 14 days.
    /// </summary>
    public partial class StageEndpoints
    {
        private string _events;
        private string _rtmp;
        private string _rtmps;
        private string _whip;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Events endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null;
        }

        /// <summary>
        /// Gets and sets the property Rtmp. 
        /// <para>
        /// The endpoint to be used for IVS real-time streaming using the RTMP protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Rtmp
        {
            get { return this._rtmp; }
            set { this._rtmp = value; }
        }

        // Check to see if Rtmp property is set
        internal bool IsSetRtmp()
        {
            return this._rtmp != null;
        }

        /// <summary>
        /// Gets and sets the property Rtmps. 
        /// <para>
        /// The endpoint to be used for IVS real-time streaming using the RTMPS protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Rtmps
        {
            get { return this._rtmps; }
            set { this._rtmps = value; }
        }

        // Check to see if Rtmps property is set
        internal bool IsSetRtmps()
        {
            return this._rtmps != null;
        }

        /// <summary>
        /// Gets and sets the property Whip. 
        /// <para>
        /// The endpoint to be used for IVS real-time streaming using the WHIP protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Whip
        {
            get { return this._whip; }
            set { this._whip = value; }
        }

        // Check to see if Whip property is set
        internal bool IsSetWhip()
        {
            return this._whip != null;
        }

    }
}