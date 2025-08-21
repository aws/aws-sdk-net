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
    /// Describes an Amazon GameLift Streams stream session. To retrieve additional details
    /// for the stream session, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>.
    /// </summary>
    public partial class StreamSessionSummary
    {
        private string _applicationArn;
        private string _arn;
        private DateTime? _createdAt;
        private ExportFilesMetadata _exportFilesMetadata;
        private DateTime? _lastUpdatedAt;
        private string _location;
        private Protocol _protocol;
        private StreamSessionStatus _status;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that uniquely identifies the application resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:application/a-9ZY8X7Wv6</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that uniquely identifies the stream session resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamsession/sg-1AB2C3De4/ABC123def4567</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was created. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportFilesMetadata. 
        /// <para>
        /// Provides details about the stream session's exported files. 
        /// </para>
        /// </summary>
        public ExportFilesMetadata ExportFilesMetadata
        {
            get { return this._exportFilesMetadata; }
            set { this._exportFilesMetadata = value; }
        }

        // Check to see if ExportFilesMetadata property is set
        internal bool IsSetExportFilesMetadata()
        {
            return this._exportFilesMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was last updated. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location where Amazon GameLift Streams hosts and streams your application. For
        /// example, <c>us-east-1</c>. For a complete list of locations that Amazon GameLift Streams
        /// supports, refer to <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The data transfer protocol in use with the stream session.
        /// </para>
        /// </summary>
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the stream session resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVATING</c>: The stream session is starting and preparing to stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The stream session is ready and waiting for a client connection. A
        /// client has <c>ConnectionTimeoutSeconds</c> (specified in <c>StartStreamSession</c>)
        /// from when the session reaches <c>ACTIVE</c> state to establish a connection. If no
        /// client connects within this timeframe, the session automatically terminates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTED</c>: The stream session has a connected client. A session will automatically
        /// terminate if there is no user input for 60 minutes, or if the maximum length of a
        /// session specified by <c>SessionLengthSeconds</c> in <c>StartStreamSession</c> is exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: The stream session failed to activate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_CLIENT_RECONNECTION</c>: A client has recently disconnected and the stream
        /// session is waiting for the client to reconnect. A client has <c>ConnectionTimeoutSeconds</c>
        /// (specified in <c>StartStreamSession</c>) from when the session reaches <c>PENDING_CLIENT_RECONNECTION</c>
        /// state to re-establish a connection. If no client connects within this timeframe, the
        /// session automatically terminates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RECONNECTING</c>: A client has initiated a reconnect to a session that was in
        /// <c>PENDING_CLIENT_RECONNECTION</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATING</c>: The stream session is ending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATED</c>: The stream session has ended.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  An opaque, unique identifier for an end-user, defined by the developer. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}