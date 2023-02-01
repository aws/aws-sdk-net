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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the PostContent operation.
    /// Sends user input (text or speech) to Amazon Lex. Clients use this API to send text
    /// and audio requests to Amazon Lex at runtime. Amazon Lex interprets the user input
    /// using the machine learning model that it built for the bot. 
    /// 
    ///  
    /// <para>
    /// The <code>PostContent</code> operation supports audio input at 8kHz and 16kHz. You
    /// can use 8kHz audio to achieve higher speech recognition accuracy in telephone audio
    /// applications. 
    /// </para>
    ///  
    /// <para>
    ///  In response, Amazon Lex returns the next message to convey to the user. Consider
    /// the following example messages: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  For a user input "I would like a pizza," Amazon Lex might return a response with
    /// a message eliciting slot data (for example, <code>PizzaSize</code>): "What size pizza
    /// would you like?". 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  After the user provides all of the pizza order information, Amazon Lex might return
    /// a response with a message to get user confirmation: "Order the pizza?". 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  After the user replies "Yes" to the confirmation prompt, Amazon Lex might return
    /// a conclusion statement: "Thank you, your cheese pizza has been ordered.". 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  Not all Amazon Lex messages require a response from the user. For example, conclusion
    /// statements do not require a response. Some messages require only a yes or no response.
    /// In addition to the <code>message</code>, Amazon Lex provides additional context about
    /// the message in the response that you can use to enhance client behavior, such as displaying
    /// the appropriate client user interface. Consider the following examples: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  If the message is to elicit slot data, Amazon Lex returns the following context information:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>x-amz-lex-dialog-state</code> header set to <code>ElicitSlot</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>x-amz-lex-intent-name</code> header set to the intent name in the current context
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>x-amz-lex-slot-to-elicit</code> header set to the slot name for which the <code>message</code>
    /// is eliciting information 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>x-amz-lex-slots</code> header set to a map of slots configured for the intent
    /// with their current values 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  If the message is a confirmation prompt, the <code>x-amz-lex-dialog-state</code>
    /// header is set to <code>Confirmation</code> and the <code>x-amz-lex-slot-to-elicit</code>
    /// header is omitted. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If the message is a clarification prompt configured for the intent, indicating that
    /// the user intent is not understood, the <code>x-amz-dialog-state</code> header is set
    /// to <code>ElicitIntent</code> and the <code>x-amz-slot-to-elicit</code> header is omitted.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  In addition, Amazon Lex also returns your application-specific <code>sessionAttributes</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
    /// Conversation Context</a>. 
    /// </para>
    /// </summary>
    public partial class PostContentRequest : AmazonLexRequest
    {
        private string _accept;
        private string _activeContexts;
        private string _botAlias;
        private string _botName;
        private string _contentType;
        private Stream _inputStream;
        private string _requestAttributes;
        private string _sessionAttributes;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        ///  You pass this value as the <code>Accept</code> HTTP header. 
        /// </para>
        ///  
        /// <para>
        ///  The message Amazon Lex returns in the response can be either text or speech based
        /// on the <code>Accept</code> HTTP header value in the request. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If the value is <code>text/plain; charset=utf-8</code>, Amazon Lex returns text in
        /// the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the value begins with <code>audio/</code>, Amazon Lex returns speech in the response.
        /// Amazon Lex uses Amazon Polly to generate the speech (using the configuration you specified
        /// in the <code>Accept</code> header). For example, if you specify <code>audio/mpeg</code>
        /// as the value, Amazon Lex returns speech in the MPEG format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <code>audio/pcm</code>, the speech returned is <code>audio/pcm</code>
        /// in 16-bit, little endian format. 
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
        /// audio/pcm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// text/plain; charset=utf-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/* (defaults to mpeg)
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept != null;
        }

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// A list of contexts active for the request. A context can be activated when a previous
        /// intent is fulfilled, or by including the context in the request,
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a list of contexts, Amazon Lex will use the current list of contexts
        /// for the session. If you specify an empty list, all contexts for the session are cleared.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ActiveContexts
        {
            get { return this._activeContexts; }
            set { this._activeContexts = value; }
        }

        // Check to see if ActiveContexts property is set
        internal bool IsSetActiveContexts()
        {
            return this._activeContexts != null;
        }

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// Alias of the Amazon Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotAlias
        {
            get { return this._botAlias; }
            set { this._botAlias = value; }
        }

        // Check to see if BotAlias property is set
        internal bool IsSetBotAlias()
        {
            return this._botAlias != null;
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// Name of the Amazon Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        ///  You pass this value as the <code>Content-Type</code> HTTP header. 
        /// </para>
        ///  
        /// <para>
        ///  Indicates the audio format or text. The header value must start with one of the following
        /// prefixes: 
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
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Opus format
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// audio/x-cbr-opus-with-preamble; preamble-size=0; bit-rate=256000; frame-size-milliseconds=4
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
        [AWSProperty(Required=true)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property InputStream. 
        /// <para>
        ///  User input in PCM or Opus audio format or text format as described in the <code>Content-Type</code>
        /// HTTP header. 
        /// </para>
        ///  
        /// <para>
        /// You can stream audio data to Amazon Lex or you can create a local buffer that captures
        /// all of the audio data before sending. In general, you get better performance if you
        /// stream audio data rather than buffering the data locally.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// You pass this value as the <code>x-amz-lex-request-attributes</code> HTTP header.
        /// </para>
        ///  
        /// <para>
        /// Request-specific information passed between Amazon Lex and a client application. The
        /// value must be a JSON serialized and base64 encoded map with string keys and values.
        /// The total size of the <code>requestAttributes</code> and <code>sessionAttributes</code>
        /// headers is limited to 12 KB.
        /// </para>
        ///  
        /// <para>
        /// The namespace <code>x-amz-lex:</code> is reserved for special attributes. Don't create
        /// any request attributes with the prefix <code>x-amz-lex:</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-request-attribs">Setting
        /// Request Attributes</a>.
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
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// You pass this value as the <code>x-amz-lex-session-attributes</code> HTTP header.
        /// </para>
        ///  
        /// <para>
        /// Application-specific information passed between Amazon Lex and a client application.
        /// The value must be a JSON serialized and base64 encoded map with string keys and values.
        /// The total size of the <code>sessionAttributes</code> and <code>requestAttributes</code>
        /// headers is limited to 12 KB.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-session-attribs">Setting
        /// Session Attributes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the client application user. Amazon Lex uses this to identify a user's conversation
        /// with your bot. At runtime, each request must contain the <code>userID</code> field.
        /// </para>
        ///  
        /// <para>
        /// To decide the user ID to use for your application, consider the following factors.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>userID</code> field must not contain any personally identifiable information
        /// of the user, for example, name, personal identification numbers, or other end user
        /// personal information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you want a user to start a conversation on one device and continue on another device,
        /// use a user-specific identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you want the same user to be able to have two independent conversations on two
        /// different devices, choose a device-specific identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A user can't have two independent conversations with two different versions of the
        /// same bot. For example, a user can't have a conversation with the PROD and BETA versions
        /// of the same bot. If you anticipate that a user will need to have conversation with
        /// two different versions, for example, while testing, include the bot alias in the user
        /// ID to separate the two conversations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
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