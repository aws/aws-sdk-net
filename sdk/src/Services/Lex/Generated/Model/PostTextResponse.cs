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
    /// This is the response object from the PostText operation.
    /// </summary>
    public partial class PostTextResponse : AmazonWebServiceResponse
    {
        private DialogState _dialogState;
        private string _intentName;
        private string _message;
        private ResponseCard _responseCard;
        private Dictionary<string, string> _sessionAttributes = new Dictionary<string, string>();
        private Dictionary<string, string> _slots = new Dictionary<string, string>();
        private string _slotToElicit;

        /// <summary>
        /// Gets and sets the property DialogState. 
        /// <para>
        /// Represents the message type to be conveyed to the user. For example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ElicitIntent</code> – Amazon Lex wants to elicit user intent. For example,
        /// Amazon Lex did not understand the first utterances such as "I want to order pizza",
        /// which indicates the OrderPizza intent. If Amazon Lex doesn't understand the intent,
        /// it returns this <code>dialogState</code>. Another example is when your intent is configured
        /// with a follow up prompt. For example, after OrderPizza intent is fulfilled, the intent
        /// might have a follow up prompt such as " Do you want to order a drink or desert?" In
        /// this case, Amazon Lex returns this <code>dialogState</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConfirmIntent</code> – Amazon Lex is expecting a yes/no response from the user
        /// indicating whether to go ahead and fulfill the intent (for example, OK to go ahead
        /// and order the pizza). In addition to a yes/no reply, the user might provide a response
        /// with additional slot information (either new slot information or changes to the existing
        /// slot values). For example, "Yes, but change to thick crust." Amazon Lex understands
        /// the additional information and updates the intent slots accordingly. 
        /// </para>
        ///  
        /// <para>
        ///  Consider another example. Before fulfilling an order, your application might prompt
        /// for confirmation such as "Do you want to place this pizza order?" A user might reply
        /// with "No, I want to order a drink." Amazon Lex recognizes the new OrderDrink intent.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ElicitSlot</code> – Amazon Lex is expecting a value of a slot for the current
        /// intent. For example, suppose Amazon Lex asks, "What size pizza would you like?" A
        /// user might reply with "Medium pepperoni pizza." Amazon Lex recognizes the size and
        /// the topping as the two separate slot values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Fulfilled</code> – Conveys that the Lambda function has successfully fulfilled
        /// the intent. If Lambda function returns a statement/message to convey the fulfillment
        /// result, Amazon Lex passes this string to the client. If not, Amazon Lex looks for
        /// <code>conclusionStatement</code> that you configured for the intent. 
        /// </para>
        ///  
        /// <para>
        ///  If both the Lambda function statement and the <code>conclusionStatement</code> are
        /// missing, Amazon Lex throws a bad request exception. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReadyForFulfillment</code> – conveys that the client has to do the fulfillment
        /// work for the intent. This is the case when the current intent is configured with <code>ReturnIntent</code>
        /// as the <code>fulfillmentActivity </code>, where Amazon Lex returns this state to client.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> – Conversation with the user failed. Some of the reasons for
        /// this <code>dialogState</code> are: after the configured number of attempts the user
        /// didn't provide an appropriate response, or the Lambda function failed to fulfill an
        /// intent. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DialogState DialogState
        {
            get { return this._dialogState; }
            set { this._dialogState = value; }
        }

        // Check to see if DialogState property is set
        internal bool IsSetDialogState()
        {
            return this._dialogState != null;
        }

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// Intent Amazon Lex inferred from the user input text. This is one of the intents configured
        /// for the bot. 
        /// </para>
        /// </summary>
        public string IntentName
        {
            get { return this._intentName; }
            set { this._intentName = value; }
        }

        // Check to see if IntentName property is set
        internal bool IsSetIntentName()
        {
            return this._intentName != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        ///  Prompt (or statement) to convey to the user. This is based on the application configuration
        /// and context. For example, if Amazon Lex did not understand the user intent, it sends
        /// the <code>clarificationPrompt</code> configured for the application. In another example,
        /// if the intent requires confirmation before taking the fulfillment action, it sends
        /// the <code>confirmationPrompt</code>. Suppose the Lambda function successfully fulfilled
        /// the intent, and sent a message to convey to the user. In that situation, Amazon Lex
        /// sends that message in the response. 
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseCard. 
        /// <para>
        /// Represents the options that the user has to respond to the current prompt. Amazon
        /// Lex sends this in the response only if the <code>dialogState</code> value indicates
        /// that a user response is expected. 
        /// </para>
        /// </summary>
        public ResponseCard ResponseCard
        {
            get { return this._responseCard; }
            set { this._responseCard = value; }
        }

        // Check to see if ResponseCard property is set
        internal bool IsSetResponseCard()
        {
            return this._responseCard != null;
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Map of key value pairs representing the session specific context information.
        /// </para>
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
        /// Gets and sets the property Slots. 
        /// <para>
        ///  Intent slots (name/value pairs) Amazon Lex detected so far from the user input in
        /// the conversation. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null && this._slots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SlotToElicit. 
        /// <para>
        /// If <code>dialogState</code> value is <code>ElicitSlot</code>, returns the name of
        /// the slot for which Amazon Lex is eliciting a value. 
        /// </para>
        /// </summary>
        public string SlotToElicit
        {
            get { return this._slotToElicit; }
            set { this._slotToElicit = value; }
        }

        // Check to see if SlotToElicit property is set
        internal bool IsSetSlotToElicit()
        {
            return this._slotToElicit != null;
        }

    }
}