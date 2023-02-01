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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChannelFlow operation.
    /// Creates a channel flow, a container for processors. Processors are AWS Lambda functions
    /// that perform actions on chat messages, such as stripping out profanity. You can associate
    /// channel flows with channels, and the processors in the channel flow then take action
    /// on all messages sent to that channel. This is a developer API.
    /// 
    ///  
    /// <para>
    /// Channel flows process the following items:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// New and updated messages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Persistent and non-persistent messages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Standard message type
    /// </para>
    ///  </li> </ol> <note> 
    /// <para>
    /// Channel flows don't process Control or System messages. For more information about
    /// the message types provided by Chime SDK Messaging, refer to <a href="https://docs.aws.amazon.com/chime/latest/dg/using-the-messaging-sdk.html#msg-types">Message
    /// types</a> in the <i>Amazon Chime developer guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateChannelFlowRequest : AmazonChimeSDKMessagingRequest
    {
        private string _appInstanceArn;
        private string _clientRequestToken;
        private string _name;
        private List<Processor> _processors = new List<Processor>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the channel flow request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string AppInstanceArn
        {
            get { return this._appInstanceArn; }
            set { this._appInstanceArn = value; }
        }

        // Check to see if AppInstanceArn property is set
        internal bool IsSetAppInstanceArn()
        {
            return this._appInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The client token for the request. An Idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Processors. 
        /// <para>
        /// Information about the processor Lambda functions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<Processor> Processors
        {
            get { return this._processors; }
            set { this._processors = value; }
        }

        // Check to see if Processors property is set
        internal bool IsSetProcessors()
        {
            return this._processors != null && this._processors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the creation request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}