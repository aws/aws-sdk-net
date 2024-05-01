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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
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
    /// Container for the parameters to the ChannelFlowCallback operation.
    /// Calls back Amazon Chime SDK messaging with a processing response message. This should
    /// be invoked from the processor Lambda. This is a developer API.
    /// 
    ///  
    /// <para>
    /// You can return one of the following processing responses:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Update message content or metadata
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deny a message
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Make no changes to the message
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ChannelFlowCallbackRequest : AmazonChimeSDKMessagingRequest
    {
        private string _callbackId;
        private string _channelArn;
        private ChannelMessageCallback _channelMessage;
        private bool? _deleteResource;

        /// <summary>
        /// Gets and sets the property CallbackId. 
        /// <para>
        /// The identifier passed to the processor by the service when invoked. Use the identifier
        /// to call back the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string CallbackId
        {
            get { return this._callbackId; }
            set { this._callbackId = value; }
        }

        // Check to see if CallbackId property is set
        internal bool IsSetCallbackId()
        {
            return this._callbackId != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelMessage. 
        /// <para>
        /// Stores information about the processed message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelMessageCallback ChannelMessage
        {
            get { return this._channelMessage; }
            set { this._channelMessage = value; }
        }

        // Check to see if ChannelMessage property is set
        internal bool IsSetChannelMessage()
        {
            return this._channelMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteResource. 
        /// <para>
        /// When a processor determines that a message needs to be <c>DENIED</c>, pass this parameter
        /// with a value of true.
        /// </para>
        /// </summary>
        public bool? DeleteResource
        {
            get { return this._deleteResource; }
            set { this._deleteResource = value; }
        }

        // Check to see if DeleteResource property is set
        internal bool IsSetDeleteResource()
        {
            return this._deleteResource.HasValue; 
        }

    }
}