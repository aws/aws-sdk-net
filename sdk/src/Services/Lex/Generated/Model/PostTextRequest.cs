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
    /// Sends user input text to Amazon Lex at runtime. Amazon Lex uses the machine learning
    /// model that the service built for the application to interpret user input. 
    /// 
    ///  
    /// <para>
    ///  In response, Amazon Lex returns the next message to convey to the user (based on
    /// the context of the user interaction) and whether to expect a user response to the
    /// message (<code>dialogState</code>). For example, consider the following response messages:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// "What pizza toppings would you like?" – In this case, the <code>dialogState</code>
    /// would be <code>ElicitSlot</code> (that is, a user response is expected). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// "Your order has been placed." – In this case, Amazon Lex returns one of the following
    /// <code>dialogState</code> values depending on how the intent fulfillment is configured
    /// (see <code>fulfillmentActivity</code> in <code>CreateIntent</code>): 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>FulFilled</code> – The intent fulfillment is configured through a Lambda function.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ReadyForFulfilment</code> – The intent's <code>fulfillmentActivity</code> is
    /// to simply return the intent data back to the client application. 
    /// </para>
    ///  </li> </ul> </li> </ul>
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
        /// Gets and sets the property InputText. 
        /// <para>
        /// Text user entered (Amazon Lex interprets this text).
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
        ///  A session represents the dialog between a user and Amazon Lex. At runtime, a client
        /// application can pass contextual information (session attributes) in the request. For
        /// example, <code>"FirstName" : "Joe"</code>. Amazon Lex passes these session attributes
        /// to the AWS Lambda functions configured for the intent (see <code>dialogCodeHook</code>
        /// and <code>fulfillmentActivity.codeHook</code> in <code>CreateIntent</code>). 
        /// </para>
        ///  
        /// <para>
        /// In your Lambda function, you can use the session attributes for customization. Some
        /// examples are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  In a pizza ordering application, if you can pass user location as a session attribute
        /// (for example, <code>"Location" : "111 Maple street"</code>), your Lambda function
        /// might use this information to determine the closest pizzeria to place the order. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Use session attributes to personalize prompts. For example, you pass in user name
        /// as a session attribute (<code>"FirstName" : "Joe"</code>), you might configure subsequent
        /// prompts to refer to this attribute, as <code>$session.FirstName"</code>. At runtime,
        /// Amazon Lex substitutes a real value when it generates a prompt, such as "Hello Joe,
        /// what would you like to order?" 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  Amazon Lex does not persist session attributes. 
        /// </para>
        ///  
        /// <para>
        ///  If the intent is configured without a Lambda function to process the intent (that
        /// is, the client application to process the intent), Amazon Lex simply returns the session
        /// attributes back to the client application. 
        /// </para>
        ///  
        /// <para>
        ///  If the intent is configured with a Lambda function to process the intent, Amazon
        /// Lex passes the incoming session attributes to the Lambda function. The Lambda function
        /// must return these session attributes if you want Amazon Lex to return them back to
        /// the client. 
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
        /// User ID of your client application. Typically, each of your application users should
        /// have a unique ID. Note the following considerations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you want a user to start a conversation on one mobile device and continue the
        /// conversation on another device, you might choose a user-specific identifier, such
        /// as a login or Amazon Cognito user ID (assuming your application is using Amazon Cognito).
        /// 
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