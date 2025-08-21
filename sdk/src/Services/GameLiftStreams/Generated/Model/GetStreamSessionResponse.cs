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
    /// This is the response object from the GetStreamSession operation.
    /// </summary>
    public partial class GetStreamSessionResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _additionalEnvironmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _additionalLaunchArgs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _applicationArn;
        private string _arn;
        private int? _connectionTimeoutSeconds;
        private DateTime? _createdAt;
        private string _description;
        private ExportFilesMetadata _exportFilesMetadata;
        private DateTime? _lastUpdatedAt;
        private string _location;
        private string _logFileLocationUri;
        private Protocol _protocol;
        private int? _sessionLengthSeconds;
        private string _signalRequest;
        private string _signalResponse;
        private StreamSessionStatus _status;
        private StreamSessionStatusReason _statusReason;
        private string _streamGroupId;
        private string _userId;
        private string _webSdkProtocolUrl;

        /// <summary>
        /// Gets and sets the property AdditionalEnvironmentVariables. 
        /// <para>
        /// A set of options that you can use to control the stream session runtime environment,
        /// expressed as a set of key-value pairs. You can use this to configure the application
        /// or stream session details. You can also provide custom environment variables that
        /// Amazon GameLift Streams passes to your game client.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you want to debug your application with environment variables, we recommend that
        /// you do so in a local environment outside of Amazon GameLift Streams. For more information,
        /// refer to the Compatibility Guidance in the troubleshooting section of the Developer
        /// Guide.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>AdditionalEnvironmentVariables</c> and <c>AdditionalLaunchArgs</c> have similar
        /// purposes. <c>AdditionalEnvironmentVariables</c> passes data using environment variables;
        /// while <c>AdditionalLaunchArgs</c> passes data using command-line arguments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> AdditionalEnvironmentVariables
        {
            get { return this._additionalEnvironmentVariables; }
            set { this._additionalEnvironmentVariables = value; }
        }

        // Check to see if AdditionalEnvironmentVariables property is set
        internal bool IsSetAdditionalEnvironmentVariables()
        {
            return this._additionalEnvironmentVariables != null && (this._additionalEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdditionalLaunchArgs. 
        /// <para>
        /// A list of CLI arguments that are sent to the streaming server when a stream session
        /// launches. You can use this to configure the application or stream session details.
        /// You can also provide custom arguments that Amazon GameLift Streams passes to your
        /// game client.
        /// </para>
        ///  
        /// <para>
        ///  <c>AdditionalEnvironmentVariables</c> and <c>AdditionalLaunchArgs</c> have similar
        /// purposes. <c>AdditionalEnvironmentVariables</c> passes data using environment variables;
        /// while <c>AdditionalLaunchArgs</c> passes data using command-line arguments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> AdditionalLaunchArgs
        {
            get { return this._additionalLaunchArgs; }
            set { this._additionalLaunchArgs = value; }
        }

        // Check to see if AdditionalLaunchArgs property is set
        internal bool IsSetAdditionalLaunchArgs()
        {
            return this._additionalLaunchArgs != null && (this._additionalLaunchArgs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The application streaming in this session.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
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
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that's assigned to a stream session resource. When combined
        /// with the stream group resource ID, this value uniquely identifies the stream session
        /// across all Amazon Web Services Regions. Format is <c>arn:aws:gameliftstreams:[AWS
        /// Region]:[AWS account]:streamsession/[stream group resource ID]/[stream session resource
        /// ID]</c>.
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
        /// Gets and sets the property ConnectionTimeoutSeconds. 
        /// <para>
        /// The length of time that Amazon GameLift Streams should wait for a client to connect
        /// or reconnect to the stream session. This time span starts when the stream session
        /// reaches <c>ACTIVE</c> or <c>PENDING_CLIENT_RECONNECTION</c> state. If no client connects
        /// (or reconnects) before the timeout, Amazon GameLift Streams terminates the stream
        /// session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3600)]
        public int? ConnectionTimeoutSeconds
        {
            get { return this._connectionTimeoutSeconds; }
            set { this._connectionTimeoutSeconds = value; }
        }

        // Check to see if ConnectionTimeoutSeconds property is set
        internal bool IsSetConnectionTimeoutSeconds()
        {
            return this._connectionTimeoutSeconds.HasValue; 
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable label for the stream session. You can update this value at any time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
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
        /// Gets and sets the property LogFileLocationUri. 
        /// <para>
        /// Access location for log files that your content generates during a stream session.
        /// These log files are uploaded to cloud storage location at the end of a stream session.
        /// The Amazon GameLift Streams application resource defines which log files to upload.
        /// </para>
        /// </summary>
        public string LogFileLocationUri
        {
            get { return this._logFileLocationUri; }
            set { this._logFileLocationUri = value; }
        }

        // Check to see if LogFileLocationUri property is set
        internal bool IsSetLogFileLocationUri()
        {
            return this._logFileLocationUri != null;
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
        /// Gets and sets the property SessionLengthSeconds. 
        /// <para>
        /// The maximum duration of a session. Amazon GameLift Streams will automatically terminate
        /// a session after this amount of time has elapsed, regardless of any existing client
        /// connections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public int? SessionLengthSeconds
        {
            get { return this._sessionLengthSeconds; }
            set { this._sessionLengthSeconds = value; }
        }

        // Check to see if SessionLengthSeconds property is set
        internal bool IsSetSessionLengthSeconds()
        {
            return this._sessionLengthSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SignalRequest. 
        /// <para>
        /// The WebRTC ICE offer string that a client generates to initiate a connection to the
        /// stream session.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
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
        /// Gets and sets the property SignalResponse. 
        /// <para>
        /// The WebRTC answer string that the stream server generates in response to the <c>SignalRequest</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SignalResponse
        {
            get { return this._signalResponse; }
            set { this._signalResponse = value; }
        }

        // Check to see if SignalResponse property is set
        internal bool IsSetSignalResponse()
        {
            return this._signalResponse != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the stream session. A stream session is ready for a client to
        /// connect when in <c>ACTIVE</c> status.
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short description of the reason the stream session is in <c>ERROR</c> status.
        /// </para>
        /// </summary>
        public StreamSessionStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StreamGroupId. 
        /// <para>
        /// The unique identifier for the Amazon GameLift Streams stream group that is hosting
        /// the stream session. Format example: <c>sg-1AB2C3De4</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string StreamGroupId
        {
            get { return this._streamGroupId; }
            set { this._streamGroupId = value; }
        }

        // Check to see if StreamGroupId property is set
        internal bool IsSetStreamGroupId()
        {
            return this._streamGroupId != null;
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

        /// <summary>
        /// Gets and sets the property WebSdkProtocolUrl. 
        /// <para>
        /// The URL of an S3 bucket that stores Amazon GameLift Streams WebSDK files. The URL
        /// is used to establish connection with the client.
        /// </para>
        /// </summary>
        public string WebSdkProtocolUrl
        {
            get { return this._webSdkProtocolUrl; }
            set { this._webSdkProtocolUrl = value; }
        }

        // Check to see if WebSdkProtocolUrl property is set
        internal bool IsSetWebSdkProtocolUrl()
        {
            return this._webSdkProtocolUrl != null;
        }

    }
}