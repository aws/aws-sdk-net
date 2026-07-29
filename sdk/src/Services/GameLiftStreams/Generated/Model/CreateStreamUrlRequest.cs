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
    /// Container for the parameters to the CreateStreamUrl operation.
    /// Creates a stream URL that grants temporary access to a stream session in a web browser
    /// without requiring an Amazon Web Services account or client integration.
    /// 
    ///  
    /// <para>
    /// You can use the stream URL to start a stream session up to the number of times set
    /// by <c>UsageLimit</c>, until it expires after <c>UrlExpiresAfterMinutes</c>. Each successful
    /// use starts a new stream session.
    /// </para>
    ///  
    /// <para>
    /// To make the request idempotent, provide a <c>ClientToken</c>.
    /// </para>
    /// </summary>
    public partial class CreateStreamUrlRequest : AmazonGameLiftStreamsRequest
    {
        private Dictionary<string, string> _additionalEnvironmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _additionalLaunchArgs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _applicationIdentifier;
        private string _clientToken;
        private string _description;
        private DisplayConfiguration _displayConfiguration;
        private string _identifier;
        private List<string> _locations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Protocol _protocol;
        private string _roleArn;
        private int? _sessionLengthSeconds;
        private int? _urlExpiresAfterMinutes;
        private int? _usageLimit;

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
        ///  
        /// <para>
        /// This application must be associated with the stream group.
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
        /// A unique, case-sensitive identifier that you provide to ensure this request is idempotent.
        /// If you retry a request with the same <c>ClientToken</c>, Amazon GameLift Streams returns
        /// the original response without performing the operation again.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A descriptive label for the stream URL.
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
        /// Gets and sets the property DisplayConfiguration. 
        /// <para>
        /// The display settings, such as resolution, for stream sessions started from this stream
        /// URL.
        /// </para>
        /// </summary>
        public DisplayConfiguration DisplayConfiguration
        {
            get { return this._displayConfiguration; }
            set { this._displayConfiguration = value; }
        }

        // Check to see if DisplayConfiguration property is set
        internal bool IsSetDisplayConfiguration()
        {
            return this._displayConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// Example ID: <c>sg-1AB2C3De4</c>. 
        /// </para>
        ///  
        /// <para>
        /// The stream session runs in this stream group.
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
        /// A list of locations, in order of preference, where Amazon GameLift Streams can place
        /// the stream session. Specify each location by its Amazon Web Services Region code,
        /// for example <c>us-east-1</c>. For a complete list of locations that Amazon GameLift
        /// Streams supports, refer to <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// The data transport protocol for the stream session. Amazon GameLift Streams supports
        /// <c>WebRTC</c>.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon GameLift Streams assumes
        /// during stream sessions started from this stream URL. For more information, see <a
        /// href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/session-credentials.html">Provide
        /// AWS credentials to your streaming application</a> in the <i>Amazon GameLift Streams
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionLengthSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that a stream session started from this stream
        /// URL can run. Valid values are 1-86400 seconds (1 second to 24 hours). The default
        /// is 43200 seconds (12 hours).
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
        /// Gets and sets the property UrlExpiresAfterMinutes. 
        /// <para>
        /// The number of minutes after creation that the stream URL remains valid. After this
        /// period, the status of the stream URL changes to <c>EXPIRED</c> and it can no longer
        /// start stream sessions. The minimum is 1 minute. For the maximum, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? UrlExpiresAfterMinutes
        {
            get { return this._urlExpiresAfterMinutes; }
            set { this._urlExpiresAfterMinutes = value; }
        }

        // Check to see if UrlExpiresAfterMinutes property is set
        internal bool IsSetUrlExpiresAfterMinutes()
        {
            return this._urlExpiresAfterMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsageLimit. 
        /// <para>
        /// The maximum number of times the stream URL can start a stream session. Each successful
        /// use reduces the remaining uses by one. The minimum is 1, and the default is 1. For
        /// the maximum, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? UsageLimit
        {
            get { return this._usageLimit; }
            set { this._usageLimit = value; }
        }

        // Check to see if UsageLimit property is set
        internal bool IsSetUsageLimit()
        {
            return this._usageLimit.HasValue; 
        }

    }
}