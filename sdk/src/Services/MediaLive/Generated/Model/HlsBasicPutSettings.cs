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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Hls Basic Put Settings
    /// </summary>
    public partial class HlsBasicPutSettings
    {
        private int? _connectionRetryInterval;
        private int? _filecacheDuration;
        private int? _numRetries;
        private int? _restartDelay;

        /// <summary>
        /// Gets and sets the property ConnectionRetryInterval. Number of seconds to wait before
        /// retrying connection to the CDN if the connection is lost.
        /// </summary>
        [AWSProperty(Min=0)]
        public int ConnectionRetryInterval
        {
            get { return this._connectionRetryInterval.GetValueOrDefault(); }
            set { this._connectionRetryInterval = value; }
        }

        // Check to see if ConnectionRetryInterval property is set
        internal bool IsSetConnectionRetryInterval()
        {
            return this._connectionRetryInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FilecacheDuration. Size in seconds of file cache for streaming
        /// outputs.
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
        public int FilecacheDuration
        {
            get { return this._filecacheDuration.GetValueOrDefault(); }
            set { this._filecacheDuration = value; }
        }

        // Check to see if FilecacheDuration property is set
        internal bool IsSetFilecacheDuration()
        {
            return this._filecacheDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumRetries. Number of retry attempts that will be made
        /// before the Live Event is put into an error state. Applies only if the CDN destination
        /// URI begins with "s3" or "mediastore". For other URIs, the value is always 3.
        /// </summary>
        [AWSProperty(Min=0)]
        public int NumRetries
        {
            get { return this._numRetries.GetValueOrDefault(); }
            set { this._numRetries = value; }
        }

        // Check to see if NumRetries property is set
        internal bool IsSetNumRetries()
        {
            return this._numRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestartDelay. If a streaming output fails, number of seconds
        /// to wait until a restart is initiated. A value of 0 means never restart.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public int RestartDelay
        {
            get { return this._restartDelay.GetValueOrDefault(); }
            set { this._restartDelay = value; }
        }

        // Check to see if RestartDelay property is set
        internal bool IsSetRestartDelay()
        {
            return this._restartDelay.HasValue; 
        }

    }
}