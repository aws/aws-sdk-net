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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the PostText operation.
    /// Sends user input (text-only) to Amazon Lex. Client applications can use this API to
    /// send requests to Amazon Lex at runtime. Amazon Lex then interprets the user input
    /// using the machine learning model it built for the bot. 
    /// 
    ///  
    /// <para>
    ///  In response, Amazon Lex returns the next <code>message</code> to convey to the user
    /// an optional <code>responseCard</code> to display. Consider the following example messages:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  For a user input "I would like a pizza", Amazon Lex might return a response with
    /// a message eliciting slot data (for example, PizzaSize): "What size pizza would you
    /// like?" 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  After the user provides all of the pizza order information, Amazon Lex might return
    /// a response with a message to obtain user confirmation "Proceed with the pizza order?".
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  After the user replies to a confirmation prompt with a "yes", Amazon Lex might return
    /// a conclusion statement: "Thank you, your cheese pizza has been ordered.". 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  Not all Amazon Lex messages require a user response. For example, a conclusion statement
    /// does not require a response. Some messages require only a "yes" or "no" user response.
    /// In addition to the <code>message</code>, Amazon Lex provides additional context about
    /// the message in the response that you might use to enhance client behavior, for example,
    /// to display the appropriate client user interface. These are the <code>slotToElicit</code>,
    /// <code>dialogState</code>, <code>intentName</code>, and <code>slots</code> fields in
    /// the response. Consider the following examples: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the message is to elicit slot data, Amazon Lex returns the following context information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>dialogState</code> set to ElicitSlot 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>intentName</code> set to the intent name in the current context 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>slotToElicit</code> set to the slot name for which the <code>message</code>
    /// is eliciting information 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>slots</code> set to a map of slots, configured for the intent, with currently
    /// known values 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  If the message is a confirmation prompt, the <code>dialogState</code> is set to ConfirmIntent
    /// and <code>SlotToElicit</code> is set to null. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the message is a clarification prompt (configured for the intent) that indicates
    /// that user intent is not understood, the <code>dialogState</code> is set to ElicitIntent
    /// and <code>slotToElicit</code> is set to null. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  In addition, Amazon Lex also returns your application-specific <code>sessionAttributes</code>.
    /// For more information, see <a href="http://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
    /// Conversation Context</a>. 
    /// </para>
    /// </summary>
    public partial class PostTextRequest : AmazonLexRequest
    {
        private string _botAlias;
        private string _botName;
        private string _inputText;
        private Dictionary<string, string> _sessionAttributes = new Dictionary<string, string>();
        private string _userId;

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// The alias of the Amazon Lex bot.
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
        /// The name of the Amazon Lex bot.
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
        /// Gets and sets the property InputText. 
        /// <para>
        /// The text that the user entered (Amazon Lex interprets this text).
        /// </para>
        /// </summary>
        public string InputText
        {
            get { return this._inputText; }
            set { this._inputText = value; }
        }

        // Check to see if InputText property is set
        internal bool IsSetInputText()
        {
            return this._inputText != null;
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        ///  By using session attributes, a client application can pass contextual information
        /// in the request to Amazon Lex For example, 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In Getting Started Exercise 1, the example bot uses the <code>price</code> session
        /// attribute to maintain the price of the flowers ordered (for example, "Price":25).
        /// The code hook (the Lambda function) sets this attribute based on the type of flowers
        /// ordered. For more information, see <a href="http://docs.aws.amazon.com/lex/latest/dg/gs-bp-details-after-lambda.html">Review
        /// the Details of Information Flow</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the BookTrip bot exercise, the bot uses the <code>currentReservation</code> session
        /// attribute to maintain slot data during the in-progress conversation to book a hotel
        /// or book a car. For more information, see <a href="http://docs.aws.amazon.com/lex/latest/dg/book-trip-detail-flow.html">Details
        /// of Information Flow</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You might use the session attributes (key, value pairs) to track the requestID of
        /// user requests.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Amazon Lex simply passes these session attributes to the Lambda functions configured
        /// for the intent.
        /// </para>
        ///  
        /// <para>
        /// In your Lambda function, you can also use the session attributes for initialization
        /// and customization (prompts and response cards). Some examples are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Initialization - In a pizza ordering bot, if you can pass the user location as a
        /// session attribute (for example, <code>"Location" : "111 Maple street"</code>), then
        /// your Lambda function might use this information to determine the closest pizzeria
        /// to place the order (perhaps to set the storeAddress slot value). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Personalize prompts - For example, you can configure prompts to refer to the user
        /// name. (For example, "Hey [FirstName], what toppings would you like?"). You can pass
        /// the user name as a session attribute (<code>"FirstName" : "Joe"</code>) so that Amazon
        /// Lex can substitute the placeholder to provide a personalize prompt to the user ("Hey
        /// Joe, what toppings would you like?"). 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  Amazon Lex does not persist session attributes. 
        /// </para>
        ///  
        /// <para>
        ///  If you configure a code hook for the intent, Amazon Lex passes the incoming session
        /// attributes to the Lambda function. If you want Amazon Lex to return these session
        /// attributes back to the client, the Lambda function must return them. 
        /// </para>
        ///  
        /// <para>
        ///  If there is no code hook configured for the intent, Amazon Lex simply returns the
        /// session attributes back to the client application. 
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, string> SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null && this._sessionAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the client application user. The application developer decides the user
        /// IDs. At runtime, each request must include the user ID. Typically, each of your application
        /// users should have a unique ID. Note the following considerations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you want a user to start a conversation on one device and continue the conversation
        /// on another device, you might choose a user-specific identifier, such as a login or
        /// Amazon Cognito user ID (assuming your application is using Amazon Cognito). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you want the same user to be able to have two independent conversations on two
        /// different devices, you might choose a device-specific identifier, such as device ID,
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

    }
}