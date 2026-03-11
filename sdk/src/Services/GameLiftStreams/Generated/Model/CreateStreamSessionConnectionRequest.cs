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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStreamSessionConnection operation.
    /// Enables clients to reconnect to a stream session while preserving all session state
    /// and data in the disconnected session. This reconnection process can be initiated when
    /// a stream session is in either <c>PENDING_CLIENT_RECONNECTION</c> or <c>ACTIVE</c>
    /// status. The process works as follows: 
    /// 
    ///  <ol> <li> 
    /// <para>
    /// Initial disconnect:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When a client disconnects or loses connection, the stream session transitions from
    /// <c>CONNECTED</c> to <c>PENDING_CLIENT_RECONNECTION</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Reconnection time window:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Clients have <c>ConnectionTimeoutSeconds</c> (defined in <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_StartStreamSession.html">StartStreamSession</a>)
    /// to reconnect before session termination
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your backend server must call <b>CreateStreamSessionConnection</b> to initiate reconnection
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Session transitions to <c>RECONNECTING</c> status
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Reconnection completion:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// On successful <b>CreateStreamSessionConnection</b>, session status changes to <c>ACTIVE</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the new connection information to the requesting client
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Client must establish connection within <c>ConnectionTimeoutSeconds</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Session terminates automatically if client fails to connect in time
    /// </para>
    ///  </li> </ul> </li> </ol> 
    /// <para>
    /// For more information about the stream session lifecycle, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/stream-sessions.html">Stream
    /// sessions</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To begin re-connecting to an existing stream session, specify the stream group ID
    /// and stream session ID that you want to reconnect to, and the signal request to use
    /// with the stream.
    /// </para>
    /// </summary>
    public partial class CreateStreamSessionConnectionRequest : AmazonGameLiftStreamsRequest
    {
        private string _clientToken;
        private string _identifier;
        private string _signalRequest;
        private string _streamSessionIdentifier;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier that represents a client request. The request is idempotent,
        /// which ensures that an API request completes only once. When users send a request,
        /// Amazon GameLift Streams automatically populates this field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
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
        /// Gets and sets the property Identifier. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// Example ID: <c>sg-1AB2C3De4</c>. 
        /// </para>
        ///  
        /// <para>
        ///  The stream group that you want to run this stream session with. The stream group
        /// must be in <c>ACTIVE</c> status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property SignalRequest. 
        /// <para>
        /// A WebRTC ICE offer string to use when initializing a WebRTC connection. The offer
        /// is a very long JSON string. Provide the string as a text value in quotes. The offer
        /// must be newly generated, not the same offer provided to <c>StartStreamSession</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string SignalRequest
        {
            get { return this._signalRequest; }
            set { this._signalRequest = value; }
        }

        // Check to see if SignalRequest property is set
        internal bool IsSetSignalRequest()
        {
            return this._signalRequest != null;
        }

        /// <summary>
        /// Gets and sets the property StreamSessionIdentifier. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream session resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamsession/sg-1AB2C3De4/ABC123def4567</c>.
        /// Example ID: <c>ABC123def4567</c>. 
        /// </para>
        ///  
        /// <para>
        ///  The stream session must be in <c>PENDING_CLIENT_RECONNECTION</c> or <c>ACTIVE</c>
        /// status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StreamSessionIdentifier
        {
            get { return this._streamSessionIdentifier; }
            set { this._streamSessionIdentifier = value; }
        }

        // Check to see if StreamSessionIdentifier property is set
        internal bool IsSetStreamSessionIdentifier()
        {
            return this._streamSessionIdentifier != null;
        }

    }
}