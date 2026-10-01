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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChannelFlow operation. Creates a channel
    /// flow, a container for processors. Processors are AWS Lambda functions that perform
    /// actions on chat messages, such as stripping out profanity. You can associate channel
    /// flows with channels, and the processors in the channel flow then take action on all
    /// messages sent to that channel. This is a developer API. <para> Channel flows process
    /// the following items: </para> <ol> <li> <para> New and updated messages </para> </li>
    /// <li> <para> Persistent and non-persistent messages </para> </li> <li> <para> The Standard
    /// message type </para> </li> </ol> <note> <para> Channel flows don't process Control
    /// or System messages. For more information about the message types provided by Chime
    /// SDK messaging, refer to <a href="https://docs.aws.amazon.com/chime-sdk/latest/dg/using-the-messaging-sdk.html#msg-types">Message
    /// types</a> in the <i>Amazon Chime developer guide</i>. </para> </note>
    /// </summary>
    public partial class CreateChannelFlowRequest : AmazonChimeSDKMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the channel flow request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string AppInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the AppInstanceArn property is set.
        /// </summary>
        internal bool IsSetAppInstanceArn() => this.AppInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The client token for the request. An Idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Processors. 
        /// <para>
        /// Information about the processor Lambda functions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 3)]
        public List<Processor> Processors { get; set; } = AWSConfigs.InitializeCollections ? new List<Processor>() : null;

        /// <summary>
        /// Checks to see if the Processors property is set.
        /// </summary>
        internal bool IsSetProcessors() => this.Processors != null && (this.Processors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the creation request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
