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
        ///  Identifies the current state of the user interaction. Amazon Lex returns one of the
        /// following values as <code>dialogState</code>. The client can optionally use this information
        /// to customize the user interface. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ElicitIntent</code> - Amazon Lex wants to elicit user intent. 
        /// </para>
        ///  
        /// <para>
        /// For example, a user might utter an intent ("I want to order a pizza"). If Amazon Lex
        /// cannot infer the user intent from this utterance, it will return this dialogState.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConfirmIntent</code> - Amazon Lex is expecting a "yes" or "no" response. 
        /// </para>
        ///  
        /// <para>
        ///  For example, Amazon Lex wants user confirmation before fulfilling an intent. 
        /// </para>
        ///  
        /// <para>
        /// Instead of a simple "yes" or "no," a user might respond with additional information.
        /// For example, "yes, but make it thick crust pizza" or "no, I want to order a drink".
        /// Amazon Lex can process such additional information (in these examples, update the
        /// crust type slot value, or change intent from OrderPizza to OrderDrink).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ElicitSlot</code> - Amazon Lex is expecting a slot value for the current intent.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, suppose that in the response Amazon Lex sends this message: "What size
        /// pizza would you like?". A user might reply with the slot value (e.g., "medium"). The
        /// user might also provide additional information in the response (e.g., "medium thick
        /// crust pizza"). Amazon Lex can process such additional information appropriately. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Fulfilled</code> - Conveys that the Lambda function configured for the intent
        /// has successfully fulfilled the intent. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReadyForFulfillment</code> - Conveys that the client has to fulfill the intent.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code> - Conveys that the conversation with the user failed. 
        /// </para>
        ///  
        /// <para>
        ///  This can happen for various reasons including that the user did not provide an appropriate
        /// response to prompts from the service (you can configure how many times Amazon Lex
        /// can prompt a user for specific information), or the Lambda function failed to fulfill
        /// the intent. 
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
        /// The current user intent that Amazon Lex is aware of.
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
        ///  A message to convey to the user. It can come from the bot's configuration or a code
        /// hook (Lambda function). If the current intent is not configured with a code hook or
        /// the code hook returned <code>Delegate</code> as the <code>dialogAction.type</code>
        /// in its response, then Amazon Lex decides the next course of action and selects an
        /// appropriate message from the bot configuration based on the current user interaction
        /// context. For example, if Amazon Lex is not able to understand the user input, it uses
        /// a clarification prompt message (for more information, see the Error Handling section
        /// in the Amazon Lex console). Another example: if the intent requires confirmation before
        /// fulfillment, then Amazon Lex uses the confirmation prompt message in the intent configuration.
        /// If the code hook returns a message, Amazon Lex passes it as-is in its response to
        /// the client. 
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
        /// Represents the options that the user has to respond to the current prompt. Response
        /// Card can come from the bot configuration (in the Amazon Lex console, choose the settings
        /// button next to a slot) or from a code hook (Lambda function). 
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
        /// A map of key-value pairs representing the session-specific context information.
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
        ///  The intent slots that Amazon Lex detected from the user input in the conversation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Amazon Lex creates a resolution list containing likely values for a slot. The value
        /// that it returns is determined by the <code>valueSelectionStrategy</code> selected
        /// when the slot type was created or updated. If <code>valueSelectionStrategy</code>
        /// is set to <code>ORIGINAL_VALUE</code>, the value provided by the user is returned,
        /// if the user value is similar to the slot values. If <code>valueSelectionStrategy</code>
        /// is set to <code>TOP_RESOLUTION</code> Amazon Lex returns the first value in the resolution
        /// list or, if there is no resolution list, null. If you don't specify a <code>valueSelectionStrategy</code>,
        /// the default is <code>ORIGINAL_VALUE</code>.
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
        /// If the <code>dialogState</code> value is <code>ElicitSlot</code>, returns the name
        /// of the slot for which Amazon Lex is eliciting a value. 
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