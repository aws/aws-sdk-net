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
    /// Settings for SRT Listener input.
    /// </summary>
    public partial class SrtListenerSettings
    {
        private SrtListenerDecryption _decryption;
        private int? _minimumLatency;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property Decryption.
        /// </summary>
        public SrtListenerDecryption Decryption
        {
            get { return this._decryption; }
            set { this._decryption = value; }
        }

        // Check to see if Decryption property is set
        internal bool IsSetDecryption()
        {
            return this._decryption != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumLatency. The preferred latency (in milliseconds)
        /// for implementing packet loss and recovery. Range 120-15000.
        /// </summary>
        public int MinimumLatency
        {
            get { return this._minimumLatency.GetValueOrDefault(); }
            set { this._minimumLatency = value; }
        }

        // Check to see if MinimumLatency property is set
        internal bool IsSetMinimumLatency()
        {
            return this._minimumLatency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamId. The stream ID, if the upstream system uses this
        /// identifier.
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}