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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateStreamUrl operation. Creates a stream URL
    /// that grants temporary access to a stream session in a web browser without requiring
    /// an Amazon Web Services account or client integration. <para> You can use the stream
    /// URL to start a stream session up to the number of times set by <c>UsageLimit</c>,
    /// until it expires after <c>UrlExpiresAfterMinutes</c>. Each successful use starts a
    /// new stream session. </para> <para> To make the request idempotent, provide a <c>ClientToken</c>.
    /// </para>
    /// </summary>
    public partial class CreateStreamUrlRequest : AmazonGameLiftStreamsRequest
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> AdditionalEnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalEnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetAdditionalEnvironmentVariables() => this.AdditionalEnvironmentVariables != null && (this.AdditionalEnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> AdditionalLaunchArgs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalLaunchArgs property is set.
        /// </summary>
        internal bool IsSetAdditionalLaunchArgs() => this.AdditionalLaunchArgs != null && (this.AdditionalLaunchArgs.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationIdentifier property is set.
        /// </summary>
        internal bool IsSetApplicationIdentifier() => this.ApplicationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure this request is idempotent.
        /// If you retry a request with the same <c>ClientToken</c>, Amazon GameLift Streams returns
        /// the original response without performing the operation again.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A descriptive label for the stream URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayConfiguration. 
        /// <para>
        /// The display settings, such as resolution, for stream sessions started from this stream
        /// URL.
        /// </para>
        /// </summary>
        public DisplayConfiguration DisplayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DisplayConfiguration property is set.
        /// </summary>
        internal bool IsSetDisplayConfiguration() => this.DisplayConfiguration != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> Locations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Locations property is set.
        /// </summary>
        internal bool IsSetLocations() => this.Locations != null && (this.Locations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The data transport protocol for the stream session. Amazon GameLift Streams supports
        /// <c>WebRTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

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
        [AWSProperty(Sensitive = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SessionLengthSeconds. 
        /// <para>
        /// The maximum length of time, in seconds, that a stream session started from this stream
        /// URL can run. Valid values are 1-86400 seconds (1 second to 24 hours). The default
        /// is 43200 seconds (12 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 86400)]
        public int? SessionLengthSeconds { get; set; }

        /// <summary>
        /// Checks to see if the SessionLengthSeconds property is set.
        /// </summary>
        internal bool IsSetSessionLengthSeconds() => this.SessionLengthSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property UrlExpiresAfterMinutes. 
        /// <para>
        /// The number of minutes after creation that the stream URL remains valid. After this
        /// period, the status of the stream URL changes to <c>EXPIRED</c> and it can no longer
        /// start stream sessions. The minimum is 1 minute. For the maximum, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? UrlExpiresAfterMinutes { get; set; }

        /// <summary>
        /// Checks to see if the UrlExpiresAfterMinutes property is set.
        /// </summary>
        internal bool IsSetUrlExpiresAfterMinutes() => this.UrlExpiresAfterMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property UsageLimit. 
        /// <para>
        /// The maximum number of times the stream URL can start a stream session. Each successful
        /// use reduces the remaining uses by one. The minimum is 1, and the default is 1. For
        /// the maximum, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions,
        /// quotas, and limitations</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// Checks to see if the UsageLimit property is set.
        /// </summary>
        internal bool IsSetUsageLimit() => this.UsageLimit.HasValue;
    }
}
