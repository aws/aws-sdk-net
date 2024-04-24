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
    /// This is the response object from the ChannelFlowCallback operation.
    /// </summary>
    public partial class ChannelFlowCallbackResponse : AmazonWebServiceResponse
    {
        private string _callbackId;
        private string _channelArn;

        /// <summary>
        /// Gets and sets the property CallbackId. 
        /// <para>
        /// The call back ID passed in the request.
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
        [AWSProperty(Min=5, Max=1600)]
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

    }
}