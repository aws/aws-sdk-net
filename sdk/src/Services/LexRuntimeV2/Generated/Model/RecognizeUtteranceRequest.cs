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
using Amazon.Runtime.Internal.Auth;

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Container for the parameters to the RecognizeUtterance operation.
    /// Sends user input to Amazon Lex V2. You can send text or speech. Clients use this API
    /// to send text and audio requests to Amazon Lex V2 at runtime. Amazon Lex V2 interprets
    /// the user input using the machine learning model built for the bot.
    /// 
    ///  
    /// <para>
    /// The following request fields must be compressed with gzip and then base64 encoded
    /// before you send them to Amazon Lex V2. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// requestAttributes
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sessionState
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following response fields are compressed using gzip and then base64 encoded by
    /// Amazon Lex V2. Before you can use these fields, you must decode and decompress them.
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// inputTranscript
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// interpretations
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// messages
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// requestAttributes
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// sessionState
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The example contains a Java application that compresses and encodes a Java object
    /// to send to Amazon Lex V2, and a second that decodes and decompresses a response from
    /// Amazon Lex V2.
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
    /// </summary>
    public partial class RecognizeUtteranceRequest : AmazonLexRuntimeV2Request
    {
        private string _botAliasId;
        private string _botId;
        private Stream _inputStream;
        private string _localeId;
        private string _requestAttributes;
        private string _requestContentType;
        private string _responseContentType;
        private string _sessionId;
        private string _sessionStateValue;

        /// <summary>
        /// Gets and sets the property BotAliasId. 
        /// <para>
        /// The alias identifier in use for the bot that should receive the request.
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
        /// The identifier of the bot that should receive the request.
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
        /// Gets and sets the property InputStream. 
        /// <para>
        /// User input in PCM or Opus audio format or text format as described in the <code>requestContentType</code>
        /// parameter.
        /// </para>
        /// </summary>
        public Stream InputStream
        {
            get { return this._inputStream; }
            set { this._inputStream = value; }
        }

        // Check to see if InputStream property is set
        internal bool IsSetInputStream()
        {
            return this._inputStream != null;
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
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// Request-specific information passed between the client application and Amazon Lex
        /// V2 
        /// </para>
        ///  
        /// <para>
        /// The namespace <code>x-amz-lex:</code> is reserved for special attributes. Don't create
        /// any request attributes for prefix <code>x-amz-lex:</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>requestAttributes</code> field must be compressed using gzip and then base64
        /// encoded before sending to Amazon Lex V2.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RequestContentType. 
        /// <para>
        /// Indicates the format for audio input or that the content is text. The header must
        /// start with one of the following prefixes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PCM format, audio data must be in little-endian byte order.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// audio/l16; rate=16000; channels=1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/x-l16; sample-rate=16000; channel-count=1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/lpcm; sample-rate=8000; sample-size-bits=16; channel-count=1; is-big-endian=false
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Opus format
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// audio/x-cbr-opus-with-preamble;preamble-size=0;bit-rate=256000;frame-size-milliseconds=4
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Text format
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// text/plain; charset=utf-8
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string RequestContentType
        {
            get { return this._requestContentType; }
            set { this._requestContentType = value; }
        }

        // Check to see if RequestContentType property is set
        internal bool IsSetRequestContentType()
        {
            return this._requestContentType != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseContentType. 
        /// <para>
        /// The message that Amazon Lex V2 returns in the response can be either text or speech
        /// based on the <code>responseContentType</code> value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <code>text/plain;charset=utf-8</code>, Amazon Lex V2 returns text
        /// in the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value begins with <code>audio/</code>, Amazon Lex V2 returns speech in the
        /// response. Amazon Lex V2 uses Amazon Polly to generate the speech using the configuration
        /// that you specified in the <code>requestContentType</code> parameter. For example,
        /// if you specify <code>audio/mpeg</code> as the value, Amazon Lex V2 returns speech
        /// in the MPEG format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <code>audio/pcm</code>, the speech returned is <code>audio/pcm</code>
        /// at 16 KHz in 16-bit, little-endian format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following are the accepted values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// audio/mpeg
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/ogg
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/pcm (16 KHz)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/* (defaults to mpeg)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// text/plain; charset=utf-8
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ResponseContentType
        {
            get { return this._responseContentType; }
            set { this._responseContentType = value; }
        }

        // Check to see if ResponseContentType property is set
        internal bool IsSetResponseContentType()
        {
            return this._responseContentType != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the session in use.
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

        /// <summary>
        /// Gets and sets the property SessionStateValue. 
        /// <para>
        /// Sets the state of the session with the user. You can use this to set the current intent,
        /// attributes, context, and dialog action. Use the dialog action to determine the next
        /// step that Amazon Lex V2 should use in the conversation with the user.
        /// </para>
        ///  
        /// <para>
        /// The <code>sessionState</code> field must be compressed using gzip and then base64
        /// encoded before sending to Amazon Lex V2.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SessionStateValue
        {
            get { return this._sessionStateValue; }
            set { this._sessionStateValue = value; }
        }

        // Check to see if SessionStateValue property is set
        internal bool IsSetSessionStateValue()
        {
            return this._sessionStateValue != null;
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer(false);
        }
    }
}