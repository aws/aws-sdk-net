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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Describes the next action that the bot should take in its interaction with the user
    /// and provides information about the context in which the action takes place. Use the
    /// <code>DialogAction</code> data type to set the interaction to a specific state, or
    /// to return the interaction to a previous state.
    /// </summary>
    public partial class DialogAction
    {
        private FulfillmentState _fulfillmentState;
        private string _intentName;
        private string _message;
        private MessageFormatType _messageFormat;
        private Dictionary<string, string> _slots = new Dictionary<string, string>();
        private string _slotToElicit;
        private DialogActionType _type;

        /// <summary>
        /// Gets and sets the property FulfillmentState. 
        /// <para>
        /// The fulfillment state of the intent. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Failed</code> - The Lambda function associated with the intent failed to fulfill
        /// the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Fulfilled</code> - The intent has fulfilled by the Lambda function associated
        /// with the intent. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReadyForFulfillment</code> - All of the information necessary for the intent
        /// is present and the intent ready to be fulfilled by the client application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FulfillmentState FulfillmentState
        {
            get { return this._fulfillmentState; }
            set { this._fulfillmentState = value; }
        }

        // Check to see if FulfillmentState property is set
        internal bool IsSetFulfillmentState()
        {
            return this._fulfillmentState != null;
        }

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent.
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
        /// The message that should be shown to the user. If you don't specify a message, Amazon
        /// Lex will use the message configured for the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
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
        /// Gets and sets the property MessageFormat. <ul> <li> 
        /// <para>
        ///  <code>PlainText</code> - The message contains plain UTF-8 text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CustomPayload</code> - The message is a custom format for the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SSML</code> - The message contains text formatted for voice output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Composite</code> - The message contains an escaped JSON object containing one
        /// or more messages. For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/howitworks-manage-prompts.html">Message
        /// Groups</a>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MessageFormatType MessageFormat
        {
            get { return this._messageFormat; }
            set { this._messageFormat = value; }
        }

        // Check to see if MessageFormat property is set
        internal bool IsSetMessageFormat()
        {
            return this._messageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// Map of the slots that have been gathered and their values. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// The name of the slot that should be elicited from the user.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The next action that the bot should take in its interaction with the user. The possible
        /// values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ConfirmIntent</code> - The next action is asking the user if the intent is
        /// complete and ready to be fulfilled. This is a yes/no question such as "Place the order?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Close</code> - Indicates that the there will not be a response from the user.
        /// For example, the statement "Your order has been placed" does not require a response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Delegate</code> - The next action is determined by Amazon Lex.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ElicitIntent</code> - The next action is to determine the intent that the user
        /// wants to fulfill.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ElicitSlot</code> - The next action is to elicit a slot value from the user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DialogActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}