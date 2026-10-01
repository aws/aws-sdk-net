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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the PostContent operation. Sends user input (text
    /// or speech) to Amazon Lex. Clients use this API to send text and audio requests to
    /// Amazon Lex at runtime. Amazon Lex interprets the user input using the machine learning
    /// model that it built for the bot. <para> The <c>PostContent</c> operation supports
    /// audio input at 8kHz and 16kHz. You can use 8kHz audio to achieve higher speech recognition
    /// accuracy in telephone audio applications. </para> <para> In response, Amazon Lex returns
    /// the next message to convey to the user. Consider the following example messages: </para>
    /// <ul> <li> <para> For a user input "I would like a pizza," Amazon Lex might return
    /// a response with a message eliciting slot data (for example, <c>PizzaSize</c>): "What
    /// size pizza would you like?". </para> </li> <li> <para> After the user provides all
    /// of the pizza order information, Amazon Lex might return a response with a message
    /// to get user confirmation: "Order the pizza?". </para> </li> <li> <para> After the
    /// user replies "Yes" to the confirmation prompt, Amazon Lex might return a conclusion
    /// statement: "Thank you, your cheese pizza has been ordered.". </para> </li> </ul> <para>
    /// Not all Amazon Lex messages require a response from the user. For example, conclusion
    /// statements do not require a response. Some messages require only a yes or no response.
    /// In addition to the <c>message</c>, Amazon Lex provides additional context about the
    /// message in the response that you can use to enhance client behavior, such as displaying
    /// the appropriate client user interface. Consider the following examples: </para> <ul>
    /// <li> <para> If the message is to elicit slot data, Amazon Lex returns the following
    /// context information: </para> <ul> <li> <para> <c>x-amz-lex-dialog-state</c> header
    /// set to <c>ElicitSlot</c> </para> </li> <li> <para> <c>x-amz-lex-intent-name</c> header
    /// set to the intent name in the current context </para> </li> <li> <para> <c>x-amz-lex-slot-to-elicit</c>
    /// header set to the slot name for which the <c>message</c> is eliciting information
    /// </para> </li> <li> <para> <c>x-amz-lex-slots</c> header set to a map of slots configured
    /// for the intent with their current values </para> </li> </ul> </li> <li> <para> If
    /// the message is a confirmation prompt, the <c>x-amz-lex-dialog-state</c> header is
    /// set to <c>Confirmation</c> and the <c>x-amz-lex-slot-to-elicit</c> header is omitted.
    /// </para> </li> <li> <para> If the message is a clarification prompt configured for
    /// the intent, indicating that the user intent is not understood, the <c>x-amz-dialog-state</c>
    /// header is set to <c>ElicitIntent</c> and the <c>x-amz-slot-to-elicit</c> header is
    /// omitted. </para> </li> </ul> <para> In addition, Amazon Lex also returns your application-specific
    /// <c>sessionAttributes</c>. For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
    /// Conversation Context</a>. </para>
    /// </summary>
    public partial class PostContentRequest : AmazonLexRequest
    {
        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        ///  You pass this value as the <c>Accept</c> HTTP header. 
        /// </para>
        ///  
        /// <para>
        ///  The message Amazon Lex returns in the response can be either text or speech based
        /// on the <c>Accept</c> HTTP header value in the request. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If the value is <c>text/plain; charset=utf-8</c>, Amazon Lex returns text in the
        /// response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the value begins with <c>audio/</c>, Amazon Lex returns speech in the response.
        /// Amazon Lex uses Amazon Polly to generate the speech (using the configuration you specified
        /// in the <c>Accept</c> header). For example, if you specify <c>audio/mpeg</c> as the
        /// value, Amazon Lex returns speech in the MPEG format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <c>audio/pcm</c>, the speech returned is <c>audio/pcm</c> in 16-bit,
        /// little endian format. 
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
        public string Accept { get; set; }

        /// <summary>
        /// Checks to see if the Accept property is set.
        /// </summary>
        internal bool IsSetAccept() => this.Accept != null;

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
        [AWSProperty(Sensitive = true)]
        public string ActiveContexts { get; set; }

        /// <summary>
        /// Checks to see if the ActiveContexts property is set.
        /// </summary>
        internal bool IsSetActiveContexts() => this.ActiveContexts != null;

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// Alias of the Amazon Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BotAlias { get; set; }

        /// <summary>
        /// Checks to see if the BotAlias property is set.
        /// </summary>
        internal bool IsSetBotAlias() => this.BotAlias != null;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// Name of the Amazon Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        ///  You pass this value as the <c>Content-Type</c> HTTP header. 
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
        [AWSProperty(Required = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property InputStream. 
        /// <para>
        ///  User input in PCM or Opus audio format or text format as described in the <c>Content-Type</c>
        /// HTTP header. 
        /// </para>
        ///  
        /// <para>
        /// You can stream audio data to Amazon Lex or you can create a local buffer that captures
        /// all of the audio data before sending. In general, you get better performance if you
        /// stream audio data rather than buffering the data locally.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Stream InputStream { get; set; }

        /// <summary>
        /// Checks to see if the InputStream property is set.
        /// </summary>
        internal bool IsSetInputStream() => this.InputStream != null;

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// You pass this value as the <c>x-amz-lex-request-attributes</c> HTTP header.
        /// </para>
        ///  
        /// <para>
        /// Request-specific information passed between Amazon Lex and a client application. The
        /// value must be a JSON serialized and base64 encoded map with string keys and values.
        /// The total size of the <c>requestAttributes</c> and <c>sessionAttributes</c> headers
        /// is limited to 12 KB.
        /// </para>
        ///  
        /// <para>
        /// The namespace <c>x-amz-lex:</c> is reserved for special attributes. Don't create any
        /// request attributes with the prefix <c>x-amz-lex:</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-request-attribs">Setting
        /// Request Attributes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string RequestAttributes { get; set; }

        /// <summary>
        /// Checks to see if the RequestAttributes property is set.
        /// </summary>
        internal bool IsSetRequestAttributes() => this.RequestAttributes != null;

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// You pass this value as the <c>x-amz-lex-session-attributes</c> HTTP header.
        /// </para>
        ///  
        /// <para>
        /// Application-specific information passed between Amazon Lex and a client application.
        /// The value must be a JSON serialized and base64 encoded map with string keys and values.
        /// The total size of the <c>sessionAttributes</c> and <c>requestAttributes</c> headers
        /// is limited to 12 KB.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-session-attribs">Setting
        /// Session Attributes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SessionAttributes { get; set; }

        /// <summary>
        /// Checks to see if the SessionAttributes property is set.
        /// </summary>
        internal bool IsSetSessionAttributes() => this.SessionAttributes != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the client application user. Amazon Lex uses this to identify a user's conversation
        /// with your bot. At runtime, each request must contain the <c>userID</c> field.
        /// </para>
        ///  
        /// <para>
        /// To decide the user ID to use for your application, consider the following factors.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>userID</c> field must not contain any personally identifiable information of
        /// the user, for example, name, personal identification numbers, or other end user personal
        /// information.
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
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
