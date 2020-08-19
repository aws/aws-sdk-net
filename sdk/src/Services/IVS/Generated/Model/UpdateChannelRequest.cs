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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChannel operation.
    /// Updates a channel's configuration. This does not affect an ongoing stream of this
    /// channel. You must stop and restart the stream for the changes to take effect.
    /// </summary>
    public partial class UpdateChannelRequest : AmazonIVSRequest
    {
        private string _arn;
        private bool? _authorized;
        private ChannelLatencyMode _latencyMode;
        private string _name;
        private ChannelType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the channel to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Authorized. 
        /// <para>
        /// Whether the channel is authorized. Default: <code>false</code>.
        /// </para>
        /// </summary>
        public bool Authorized
        {
            get { return this._authorized.GetValueOrDefault(); }
            set { this._authorized = value; }
        }

        // Check to see if Authorized property is set
        internal bool IsSetAuthorized()
        {
            return this._authorized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatencyMode. 
        /// <para>
        /// Channel latency mode. Default: <code>LOW</code>.
        /// </para>
        /// </summary>
        public ChannelLatencyMode LatencyMode
        {
            get { return this._latencyMode; }
            set { this._latencyMode = value; }
        }

        // Check to see if LatencyMode property is set
        internal bool IsSetLatencyMode()
        {
            return this._latencyMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Channel name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Channel type, which determines the allowable resolution and bitrate. <i>If you exceed
        /// the allowable resolution or bitrate, the stream probably will disconnect immediately.</i>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>STANDARD</code>: Multiple qualities are generated from the original input,
        /// to automatically give viewers the best experience for their devices and network conditions.
        /// Vertical resolution can be up to 1080 and bitrate can be up to 8.5 Mbps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BASIC</code>: Amazon IVS delivers the original input to viewers. The viewer’s
        /// video-quality choice is limited to the original input. Vertical resolution can be
        /// up to 480 and bitrate can be up to 1.5 Mbps.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>STANDARD</code>.
        /// </para>
        /// </summary>
        public ChannelType Type
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