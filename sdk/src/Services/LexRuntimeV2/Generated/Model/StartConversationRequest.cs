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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Container for the parameters to the StartConversation operation.
    /// Starts an HTTP/2 bidirectional event stream that enables you to send audio, text,
    /// or DTMF input in real time. After your application starts a conversation, users send
    /// input to Amazon Lex V2 as a stream of events. Amazon Lex V2 processes the incoming
    /// events and responds with streaming text or audio events. 
    /// 
    ///  
    /// <para>
    /// Audio input must be in the following format: <c>audio/lpcm sample-rate=8000 sample-size-bits=16
    /// channel-count=1; is-big-endian=false</c>.
    /// </para>
    ///  
    /// <para>
    /// If the optional post-fulfillment response is specified, the messages are returned
    /// as follows. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_PostFulfillmentStatusSpecification.html">PostFulfillmentStatusSpecification</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Success message</b> - Returned if the Lambda function completes successfully and
    /// the intent state is fulfilled or ready fulfillment if the message is present.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Failed message</b> - The failed message is returned if the Lambda function throws
    /// an exception or if the Lambda function returns a failed intent state without a message.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Timeout message</b> - If you don't configure a timeout message and a timeout,
    /// and the Lambda function doesn't return within 30 seconds, the timeout message is returned.
    /// If you configure a timeout, the timeout message is returned when the period times
    /// out. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-complete.html">Completion
    /// message</a>.
    /// </para>
    ///  
    /// <para>
    /// If the optional update message is configured, it is played at the specified frequency
    /// while the Lambda function is running and the update message state is active. If the
    /// fulfillment update message is not active, the Lambda function runs with a 30 second
    /// timeout. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/streaming-progress.html#progress-update.html">Update
    /// message </a> 
    /// </para>
    ///  
    /// <para>
    /// The <c>StartConversation</c> operation is supported only in the following SDKs: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/goto/SdkForCpp/runtime.lex.v2-2020-08-07/StartConversation">AWS
    /// SDK for C++</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/goto/SdkForJavaV2/runtime.lex.v2-2020-08-07/StartConversation">AWS
    /// SDK for Java V2</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/goto/SdkForRubyV3/runtime.lex.v2-2020-08-07/StartConversation">AWS
    /// SDK for Ruby V3</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartConversationRequest : AmazonLexRuntimeV2Request
    {
        private string _botAliasId;
        private string _botId;
        private ConversationMode _conversationMode;
        private string _localeId;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The alias identifier in use for the bot that processes the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotAliasId
        {
            get { return this._botAliasId; }
            set { this._botAliasId = value; }
        }

        // Check to see if BotAliasId property is set
        internal bool IsSetBotAliasId()
        {
            return this._botAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot to process the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationMode. 
        /// <para>
        /// The conversation type that you are using the Amazon Lex V2. If the conversation mode
        /// is <c>AUDIO</c> you can send both audio and DTMF information. If the mode is <c>TEXT</c>
        /// you can only send text.
        /// </para>
        /// </summary>
        public ConversationMode ConversationMode
        {
            get { return this._conversationMode; }
            set { this._conversationMode = value; }
        }

        // Check to see if ConversationMode property is set
        internal bool IsSetConversationMode()
        {
            return this._conversationMode != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale where the session is in use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestEventStreamPublisher. 
        /// <para>
        /// Represents the stream of events to Amazon Lex V2 from your application. The events
        /// are encoded as HTTP/2 data frames.
        /// </para>
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IStartConversationRequestEventStreamEvent
        /// interface. The known implementatons in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="AudioInputEvent"/></term></item>
        ///   <item><term><see cref="ConfigurationEvent"/></term></item>
        ///   <item><term><see cref="DisconnectionEvent"/></term></item>
        ///   <item><term><see cref="DTMFInputEvent"/></term></item>
        ///   <item><term><see cref="PlaybackCompletionEvent"/></term></item>
        ///   <item><term><see cref="TextInputEvent"/></term></item>
        /// </list>
        /// </para>
        /// 
        /// </summary>
        [AWSProperty(Required=true)]
        public  Func<System.Threading.Tasks.Task<IStartConversationRequestEventStreamEvent>> RequestEventStreamPublisher { get; set; }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the user session that is having the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}