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
    /// Container for the parameters to the StartStreamSession operation.
    /// This action initiates a new stream session and outputs connection information that
    /// clients can use to access the stream. A stream session refers to an instance of a
    /// stream that Amazon GameLift Streams transmits from the server to the end-user. A stream
    /// session runs on a compute resource that a stream group has allocated. The start stream
    /// session process works as follows: 
    /// 
    ///  <ol> <li> 
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must have a stream group in <c>ACTIVE</c> state
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must have idle or on-demand capacity in a stream group in the location you want
    /// to stream from
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must have at least one application associated to the stream group (use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_AssociateApplications.html">AssociateApplications</a>
    /// if needed)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Start stream request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Your backend server calls <b>StartStreamSession</b> to initiate connection
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon GameLift Streams creates the stream session resource, assigns an Amazon Resource
    /// Name (ARN) value, and begins searching for available stream capacity to run the stream
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Session transitions to <c>ACTIVATING</c> status
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Placement completion:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If Amazon GameLift Streams is successful in finding capacity for the stream, the stream
    /// session status changes to <c>ACTIVE</c> status and <b>StartStreamSession</b> returns
    /// stream connection information
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If Amazon GameLift Streams was not successful in finding capacity within the placement
    /// timeout period (defined according to the capacity type and platform type), the stream
    /// session status changes to <c>ERROR</c> status and <b>StartStreamSession</b> returns
    /// a <c>StatusReason</c> of <c>placementTimeout</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Connection completion:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Provide the new connection information to the requesting client
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Client must establish connection within <c>ConnectionTimeoutSeconds</c> (specified
    /// in <b>StartStreamSession</b> parameters)
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
    /// Timeouts to be aware of that affect a stream session:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Placement timeout</b>: The amount of time that Amazon GameLift Streams has to
    /// find capacity for a stream request. Placement timeout varies based on the capacity
    /// type used to fulfill your stream request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Always-on capacity</b>: 75 seconds
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>On-demand capacity</b>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Linux/Proton runtimes: 90 seconds
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Windows runtime: 10 minutes
    /// </para>
    ///  </li> </ul> </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Connection timeout</b>: The amount of time that Amazon GameLift Streams waits
    /// for a client to connect to a stream session in <c>ACTIVE</c> status, or reconnect
    /// to a stream session in <c>PENDING_CLIENT_RECONNECTION</c> status, the latter of which
    /// occurs when a client disconnects or loses connection from a stream session. If no
    /// client connects before the timeout, Amazon GameLift Streams terminates the stream
    /// session. This value is specified by <c>ConnectionTimeoutSeconds</c> in the <c>StartStreamSession</c>
    /// parameters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Idle timeout</b>: A stream session will be terminated if no user input has been
    /// received for 60 minutes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Maximum session length</b>: A stream session will be terminated after this amount
    /// of time has elapsed since it started, regardless of any existing client connections.
    /// This value is specified by <c>SessionLengthSeconds</c> in the <c>StartStreamSession</c>
    /// parameters.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To start a new stream session, specify a stream group ID and application ID, along
    /// with the transport protocol and signal request to use with the stream session.
    /// </para>
    ///  
    /// <para>
    /// For stream groups that have multiple locations, provide a set of locations ordered
    /// by priority using a <c>Locations</c> parameter. Amazon GameLift Streams will start
    /// a single stream session in the next available location. An application must be finished
    /// replicating to a remote location before the remote location can host a stream.
    /// </para>
    ///  
    /// <para>
    /// To reconnect to a stream session after a client disconnects or loses connection, use
    /// <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_CreateStreamSessionConnection.html">CreateStreamSessionConnection</a>.
    /// </para>
    /// </summary>
    public partial class StartStreamSessionRequest : AmazonGameLiftStreamsRequest
    {
        private Dictionary<string, string> _additionalEnvironmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _additionalLaunchArgs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _applicationIdentifier;
        private string _clientToken;
        private int? _connectionTimeoutSeconds;
        private string _description;
        private string _identifier;
        private List<string> _locations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Protocol _protocol;
        private int? _sessionLengthSeconds;
        private string _signalRequest;
        private string _userId;

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
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the application resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:application/a-9ZY8X7Wv6</c>.
        /// Example ID: <c>a-9ZY8X7Wv6</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationIdentifier
        {
            get { return this._applicationIdentifier; }
            set { this._applicationIdentifier = value; }
        }

        // Check to see if ApplicationIdentifier property is set
        internal bool IsSetApplicationIdentifier()
        {
            return this._applicationIdentifier != null;
        }

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
        /// Gets and sets the property ConnectionTimeoutSeconds. 
        /// <para>
        /// Length of time (in seconds) that Amazon GameLift Streams should wait for a client
        /// to connect or reconnect to the stream session. Applies to both connection and reconnection
        /// scenarios. This time span starts when the stream session reaches <c>ACTIVE</c> state.
        /// If no client connects before the timeout, Amazon GameLift Streams terminates the stream
        /// session. Default value is 120.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable label for the stream session. You can update this value later.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The stream group to run this stream session with.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// Example ID: <c>sg-1AB2C3De4</c>. 
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
        /// Gets and sets the property Locations. 
        /// <para>
        ///  A list of locations, in order of priority, where you want Amazon GameLift Streams
        /// to start a stream from. For example, <c>us-east-1</c>. Amazon GameLift Streams selects
        /// the location with the next available capacity to start a single stream session in.
        /// If this value is empty, Amazon GameLift Streams attempts to start a stream session
        /// in the primary location. 
        /// </para>
        ///  
        /// <para>
        ///  For a complete list of locations that Amazon GameLift Streams supports, refer to
        /// <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The data transport protocol to use for the stream session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// connections. Default value is 43200 (12 hours).
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
        /// A WebRTC ICE offer string to use when initializing a WebRTC connection. Typically,
        /// the offer is a very long JSON string. Provide the string as a text value in quotes.
        /// </para>
        ///  
        /// <para>
        /// Amazon GameLift Streams also supports setting the field to "NO_CLIENT_CONNECTION".
        /// This will create a session without needing any browser request or Web SDK integration.
        /// The session starts up as usual and waits for a reconnection from a browser, which
        /// is accomplished using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_CreateStreamSessionConnection.html">CreateStreamSessionConnection</a>.
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