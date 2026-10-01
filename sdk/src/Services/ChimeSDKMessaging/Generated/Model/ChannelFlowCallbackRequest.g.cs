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
    /// Container for the parameters to the ChannelFlowCallback operation. Calls back Amazon
    /// Chime SDK messaging with a processing response message. This should be invoked from
    /// the processor Lambda. This is a developer API. <para> You can return one of the following
    /// processing responses: </para> <ul> <li> <para> Update message content or metadata
    /// </para> </li> <li> <para> Deny a message </para> </li> <li> <para> Make no changes
    /// to the message </para> </li> </ul>
    /// </summary>
    public partial class ChannelFlowCallbackRequest : AmazonChimeSDKMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property CallbackId. 
        /// <para>
        /// The identifier passed to the processor by the service when invoked. Use the identifier
        /// to call back the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 64)]
        public string CallbackId { get; set; }

        /// <summary>
        /// Checks to see if the CallbackId property is set.
        /// </summary>
        internal bool IsSetCallbackId() => this.CallbackId != null;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property ChannelMessage. 
        /// <para>
        /// Stores information about the processed message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelMessageCallback ChannelMessage { get; set; }

        /// <summary>
        /// Checks to see if the ChannelMessage property is set.
        /// </summary>
        internal bool IsSetChannelMessage() => this.ChannelMessage != null;

        /// <summary>
        /// Gets and sets the property DeleteResource. 
        /// <para>
        /// When a processor determines that a message needs to be <c>DENIED</c>, pass this parameter
        /// with a value of true.
        /// </para>
        /// </summary>
        public bool? DeleteResource { get; set; }

        /// <summary>
        /// Checks to see if the DeleteResource property is set.
        /// </summary>
        internal bool IsSetDeleteResource() => this.DeleteResource.HasValue;
    }
}
