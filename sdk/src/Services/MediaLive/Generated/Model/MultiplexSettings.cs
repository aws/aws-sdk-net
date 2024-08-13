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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Contains configuration for a Multiplex event
    /// </summary>
    public partial class MultiplexSettings
    {
        private int? _maximumVideoBufferDelayMilliseconds;
        private int? _transportStreamBitrate;
        private int? _transportStreamId;
        private int? _transportStreamReservedBitrate;

        /// <summary>
        /// Gets and sets the property MaximumVideoBufferDelayMilliseconds. Maximum video buffer
        /// delay in milliseconds.
        /// </summary>
        [AWSProperty(Min=800, Max=3000)]
        public int? MaximumVideoBufferDelayMilliseconds
        {
            get { return this._maximumVideoBufferDelayMilliseconds; }
            set { this._maximumVideoBufferDelayMilliseconds = value; }
        }

        // Check to see if MaximumVideoBufferDelayMilliseconds property is set
        internal bool IsSetMaximumVideoBufferDelayMilliseconds()
        {
            return this._maximumVideoBufferDelayMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransportStreamBitrate. Transport stream bit rate.
        /// </summary>
        [AWSProperty(Required=true, Min=1000000, Max=100000000)]
        public int? TransportStreamBitrate
        {
            get { return this._transportStreamBitrate; }
            set { this._transportStreamBitrate = value; }
        }

        // Check to see if TransportStreamBitrate property is set
        internal bool IsSetTransportStreamBitrate()
        {
            return this._transportStreamBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransportStreamId. Transport stream ID.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=65535)]
        public int? TransportStreamId
        {
            get { return this._transportStreamId; }
            set { this._transportStreamId = value; }
        }

        // Check to see if TransportStreamId property is set
        internal bool IsSetTransportStreamId()
        {
            return this._transportStreamId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransportStreamReservedBitrate. Transport stream reserved
        /// bit rate.
        /// </summary>
        [AWSProperty(Min=0, Max=100000000)]
        public int? TransportStreamReservedBitrate
        {
            get { return this._transportStreamReservedBitrate; }
            set { this._transportStreamReservedBitrate = value; }
        }

        // Check to see if TransportStreamReservedBitrate property is set
        internal bool IsSetTransportStreamReservedBitrate()
        {
            return this._transportStreamReservedBitrate.HasValue; 
        }

    }
}