/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the PostContent operation.
    /// Sends user input (text or speech) to Amazon Lex. Clients use this API to send requests
    /// to Amazon Lex at runtime. Amazon Lex interprets the user input using the machine learning
    /// model that it built for the bot. 
    /// 
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
    /// For more information, see <a href="http://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
    /// Conversation Context</a>. 
    /// </para>
    /// </summary>
    public partial class PostContentRequest : AmazonLexRequest
    {
        private string _accept;
        private string _botAlias;
        private string _botName;
        private string _contentType;
        private Stream _inputStream;
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
        ///  
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
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// Alias of the Amazon Lex bot.
        /// </para>
        /// </summary>
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
        ///  You pass this values as the <code>Content-Type</code> HTTP header. 
        /// </para>
        ///  
        /// <para>
        ///  Indicates the audio format or text. The header value must start with one of the following
        /// prefixes: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PCM format
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// audio/l16; rate=16000; channels=1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/x-l16; sample-rate=16000; channel-count=1
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Opus format
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// audio/x-cbr-opus-with-preamble; preamble-size=0; bit-rate=1; frame-size-milliseconds=1.1
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
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// You pass this value in the <code>x-amz-lex-session-attributes</code> HTTP header.
        /// The value must be map (keys and values must be strings) that is JSON serialized and
        /// then base64 encoded.
        /// </para>
        ///  
        /// <para>
        ///  A session represents dialog between a user and Amazon Lex. At runtime, a client application
        /// can pass contextual information, in the request to Amazon Lex. For example, 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You might use session attributes to track the requestID of user requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Getting Started Exercise 1, the example bot uses the price session attribute to
        /// maintain the price of flowers ordered (for example, "price":25). The code hook (Lambda
        /// function) sets this attribute based on the type of flowers ordered. For more information,
        /// see <a href="http://docs.aws.amazon.com/lex/latest/dg/gs-bp-details-after-lambda.html">Review
        /// the Details of Information Flow</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the BookTrip bot exercise, the bot uses the <code>currentReservation</code> session
        /// attribute to maintains the slot data during the in-progress conversation to book a
        /// hotel or book a car. For more information, see <a href="http://docs.aws.amazon.com/lex/latest/dg/book-trip-detail-flow.html">Details
        /// of Information Flow</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Amazon Lex passes these session attributes to the Lambda functions configured for
        /// the intent In the your Lambda function, you can use the session attributes for initialization
        /// and customization (prompts). Some examples are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Initialization - In a pizza ordering bot, if you pass user location (for example,
        /// <code>"Location : 111 Maple Street"</code>), then your Lambda function might use this
        /// information to determine the closest pizzeria to place the order (and perhaps set
        /// the storeAddress slot value as well). 
        /// </para>
        ///  
        /// <para>
        ///  Personalized prompts - For example, you can configure prompts to refer to the user
        /// by name (for example, "Hey [firstName], what toppings would you like?"). You can pass
        /// the user's name as a session attribute ("firstName": "Joe") so that Amazon Lex can
        /// substitute the placeholder to provide a personalized prompt to the user ("Hey Joe,
        /// what toppings would you like?"). 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  Amazon Lex does not persist session attributes. 
        /// </para>
        ///  
        /// <para>
        ///  If you configured a code hook for the intent, Amazon Lex passes the incoming session
        /// attributes to the Lambda function. The Lambda function must return these session attributes
        /// if you want Amazon Lex to return them to the client. 
        /// </para>
        ///  
        /// <para>
        ///  If there is no code hook configured for the intent Amazon Lex simply returns the
        /// session attributes to the client application. 
        /// </para>
        ///  </note>
        /// </summary>
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
        /// ID of the client application user. Typically, each of your application users should
        /// have a unique ID. The application developer decides the user IDs. At runtime, each
        /// request must include the user ID. Note the following considerations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you want a user to start conversation on one device and continue the conversation
        /// on another device, you might choose a user-specific identifier, such as the user's
        /// login, or Amazon Cognito user ID (assuming your application is using Amazon Cognito).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you want the same user to be able to have two independent conversations on two
        /// different devices, you might choose device-specific identifier, such as device ID,
        /// or some globally unique identifier. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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