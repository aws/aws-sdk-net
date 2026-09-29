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
    /// Describes the next action that the bot should take in its interaction with the user
    /// and provides information about the context in which the action takes place. Use the
    /// <c>DialogAction</c> data type to set the interaction to a specific state, or to return
    /// the interaction to a previous state.
    /// </summary>
    public partial class DialogAction
    {
        /// <summary>
        /// Gets and sets the property FulfillmentState. 
        /// <para>
        /// The fulfillment state of the intent. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Failed</c> - The Lambda function associated with the intent failed to fulfill
        /// the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fulfilled</c> - The intent has fulfilled by the Lambda function associated with
        /// the intent. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReadyForFulfillment</c> - All of the information necessary for the intent is present
        /// and the intent ready to be fulfilled by the client application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FulfillmentState FulfillmentState { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentState property is set.
        /// </summary>
        internal bool IsSetFulfillmentState() => this.FulfillmentState != null;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent.
        /// </para>
        /// </summary>
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message that should be shown to the user. If you don't specify a message, Amazon
        /// Lex will use the message configured for the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property MessageFormat. <ul> <li> 
        /// <para>
        ///  <c>PlainText</c> - The message contains plain UTF-8 text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CustomPayload</c> - The message is a custom format for the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SSML</c> - The message contains text formatted for voice output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Composite</c> - The message contains an escaped JSON object containing one or
        /// more messages. For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/howitworks-manage-prompts.html">Message
        /// Groups</a>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MessageFormatType MessageFormat { get; set; }

        /// <summary>
        /// Checks to see if the MessageFormat property is set.
        /// </summary>
        internal bool IsSetMessageFormat() => this.MessageFormat != null;

        /// <summary>
        /// Gets and sets the property SlotToElicit. 
        /// <para>
        /// The name of the slot that should be elicited from the user.
        /// </para>
        /// </summary>
        public string SlotToElicit { get; set; }

        /// <summary>
        /// Checks to see if the SlotToElicit property is set.
        /// </summary>
        internal bool IsSetSlotToElicit() => this.SlotToElicit != null;

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// Map of the slots that have been gathered and their values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Slots { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null && (this.Slots.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The next action that the bot should take in its interaction with the user. The possible
        /// values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ConfirmIntent</c> - The next action is asking the user if the intent is complete
        /// and ready to be fulfilled. This is a yes/no question such as "Place the order?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Close</c> - Indicates that the there will not be a response from the user. For
        /// example, the statement "Your order has been placed" does not require a response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Delegate</c> - The next action is determined by Amazon Lex.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ElicitIntent</c> - The next action is to determine the intent that the user wants
        /// to fulfill.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ElicitSlot</c> - The next action is to elicit a slot value from the user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DialogActionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
