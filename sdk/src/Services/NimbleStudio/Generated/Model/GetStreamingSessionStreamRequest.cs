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
    /// Container for the parameters to the GetStreamingSessionStream operation.
    /// Gets a StreamingSessionStream for a streaming session.
    /// 
    ///  
    /// <para>
    /// Invoke this operation to poll the resource after invoking <code>CreateStreamingSessionStream</code>.
    /// </para>
    ///  
    /// <para>
    /// After the <code>StreamingSessionStream</code> changes to the <code>READY</code> state,
    /// the url property will contain a stream to be used with the DCV streaming client.
    /// </para>
    /// </summary>
    public partial class GetStreamingSessionStreamRequest : AmazonNimbleStudioRequest
    {
        private string _sessionId;
        private string _streamId;
        private string _studioId;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The streaming session ID.
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
        /// Gets and sets the property StreamId. 
        /// <para>
        /// The streaming session stream ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The studio ID. 
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

    }
}