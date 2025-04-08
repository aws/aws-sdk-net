<<<<<<< HEAD
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
    /// Allows clients to reconnect to a recently disconnected stream session without losing
    /// any data from the last session.
    /// 
    ///  
    /// <para>
    /// A client can reconnect to a stream session that's in <c>PENDING_CLIENT_RECONNECTION</c>
    /// or <c>ACTIVE</c> status. In the stream session life cycle, when the client disconnects
    /// from the stream session, the stream session transitions from <c>CONNECTED</c> to <c>PENDING_CLIENT_RECONNECTION</c>
    /// status. When a client requests to reconnect by calling <c>CreateStreamSessionConnection</c>,
    /// the stream session transitions to <c>RECONNECTING</c> status. When the reconnection
    /// is successful, the stream session transitions to <c>ACTIVE</c> status. After a stream
    /// session is disconnected for longer than <c>ConnectionTimeoutSeconds</c>, the stream
    /// session transitions to the <c>TERMINATED</c> status.
    /// </para>
    ///  
    /// <para>
    /// To connect to an existing stream session, specify the stream group ID and stream session
    /// ID that you want to reconnect to, as well as the signal request settings to use with
    /// the stream.
    /// </para>
    ///  
    /// <para>
    ///  <c>ConnectionTimeoutSeconds</c> defines the amount of time after the stream session
    /// disconnects that a reconnection is allowed. If a client is disconnected from the stream
    /// for longer than <c>ConnectionTimeoutSeconds</c>, the stream session ends.
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
        /// Format example: ARN-<c>arn:aws:gameliftstreams:us-west-2:123456789012:streamgroup/1AB2C3De4</c>
        /// or ID-<c>1AB2C3De4</c>. 
        /// </para>
        ///  
        /// <para>
        ///  The stream group that you want to run this stream session with. The stream group
        /// must be in <c>ACTIVE</c> status and have idle stream capacity. 
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
        /// Resource Name (ARN)</a> that uniquely identifies the stream session resource. Format
        /// example: <c>1AB2C3De4</c>. The stream session must be in <c>PENDING_CLIENT_RECONNECTION</c>
        /// or <c>ACTIVE</c> status. 
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
|||||||
=======
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
    /// Allows clients to reconnect to a recently disconnected stream session without losing
    /// any data from the last session.
    /// 
    ///  
    /// <para>
    /// A client can reconnect to a stream session that's in <c>PENDING_CLIENT_RECONNECTION</c>
    /// or <c>ACTIVE</c> status. In the stream session life cycle, when the client disconnects
    /// from the stream session, the stream session transitions from <c>CONNECTED</c> to <c>PENDING_CLIENT_RECONNECTION</c>
    /// status. When a client requests to reconnect by calling <c>CreateStreamSessionConnection</c>,
    /// the stream session transitions to <c>RECONNECTING</c> status. When the reconnection
    /// is successful, the stream session transitions to <c>ACTIVE</c> status. After a stream
    /// session is disconnected for longer than <c>ConnectionTimeoutSeconds</c>, the stream
    /// session transitions to the <c>TERMINATED</c> status.
    /// </para>
    ///  
    /// <para>
    /// To connect to an existing stream session, specify the stream group ID and stream session
    /// ID that you want to reconnect to, as well as the signal request settings to use with
    /// the stream.
    /// </para>
    ///  
    /// <para>
    ///  <c>ConnectionTimeoutSeconds</c> defines the amount of time after the stream session
    /// disconnects that a reconnection is allowed. If a client is disconnected from the stream
    /// for longer than <c>ConnectionTimeoutSeconds</c>, the stream session ends.
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
        /// Format example: ARN-<c>arn:aws:gameliftstreams:us-west-2:123456789012:streamgroup/sg-1AB2C3De4</c>
        /// or ID-<c>sg-1AB2C3De4</c>. 
        /// </para>
        ///  
        /// <para>
        ///  The stream group that you want to run this stream session with. The stream group
        /// must be in <c>ACTIVE</c> status and have idle stream capacity. 
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
        /// Resource Name (ARN)</a> that uniquely identifies the stream session resource. Format
        /// example: <c>1AB2C3De4</c>. The stream session must be in <c>PENDING_CLIENT_RECONNECTION</c>
        /// or <c>ACTIVE</c> status. 
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
>>>>>>> b6da6ace600c307cc9bd6dbf99b06a9d2b81da7e
