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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Container for the parameters to the StopStreamingSession operation.
    /// Transitions sessions from the <code>READY</code> state into the <code>STOPPED</code>
    /// state. The <code>STOP_IN_PROGRESS</code> state is the intermediate state between the
    /// <code>READY</code> and <code>STOPPED</code> states.
    /// </summary>
    public partial class StopStreamingSessionRequest : AmazonNimbleStudioRequest
    {
        private string _clientToken;
        private string _sessionId;
        private string _studioId;
        private VolumeRetentionMode _volumeRetentionMode;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. If you don’t specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The streaming session ID for the <code>StopStreamingSessionRequest</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The studioId for the StopStreamingSessionRequest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeRetentionMode. 
        /// <para>
        /// Adds additional instructions to a streaming session stop action to either retain the
        /// EBS volumes or delete the EBS volumes.
        /// </para>
        /// </summary>
        public VolumeRetentionMode VolumeRetentionMode
        {
            get { return this._volumeRetentionMode; }
            set { this._volumeRetentionMode = value; }
        }

        // Check to see if VolumeRetentionMode property is set
        internal bool IsSetVolumeRetentionMode()
        {
            return this._volumeRetentionMode != null;
        }

    }
}