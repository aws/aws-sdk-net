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
    /// Provides information about the state of an intent. You can use this information to
    /// get the current state of an intent so that you can process the intent, or so that
    /// you can return the intent to its previous state.
    /// </summary>
    public partial class IntentSummary
    {
        private string _checkpointLabel;
        private ConfirmationStatus _confirmationStatus;
        private DialogActionType _dialogActionType;
        private FulfillmentState _fulfillmentState;
        private string _intentName;
        private Dictionary<string, string> _slots = new Dictionary<string, string>();
        private string _slotToElicit;

        /// <summary>
        /// Gets and sets the property CheckpointLabel. 
        /// <para>
        /// A user-defined label that identifies a particular intent. You can use this label to
        /// return to a previous intent. 
        /// </para>
        ///  
        /// <para>
        /// Use the <code>checkpointLabelFilter</code> parameter of the <code>GetSessionRequest</code>
        /// operation to filter the intents returned by the operation to those with only the specified
        /// label.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CheckpointLabel
        {
            get { return this._checkpointLabel; }
            set { this._checkpointLabel = value; }
        }

        // Check to see if CheckpointLabel property is set
        internal bool IsSetCheckpointLabel()
        {
            return this._checkpointLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationStatus. 
        /// <para>
        /// The status of the intent after the user responds to the confirmation prompt. If the
        /// user confirms the intent, Amazon Lex sets this field to <code>Confirmed</code>. If
        /// the user denies the intent, Amazon Lex sets this value to <code>Denied</code>. The
        /// possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Confirmed</code> - The user has responded "Yes" to the confirmation prompt,
        /// confirming that the intent is complete and that it is ready to be fulfilled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Denied</code> - The user has responded "No" to the confirmation prompt.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>None</code> - The user has never been prompted for confirmation; or, the user
        /// was prompted but did not confirm or deny the prompt.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConfirmationStatus ConfirmationStatus
        {
            get { return this._confirmationStatus; }
            set { this._confirmationStatus = value; }
        }

        // Check to see if ConfirmationStatus property is set
        internal bool IsSetConfirmationStatus()
        {
            return this._confirmationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DialogActionType. 
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
        public DialogActionType DialogActionType
        {
            get { return this._dialogActionType; }
            set { this._dialogActionType = value; }
        }

        // Check to see if DialogActionType property is set
        internal bool IsSetDialogActionType()
        {
            return this._dialogActionType != null;
        }

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
        /// The next slot to elicit from the user. If there is not slot to elicit, the field is
        /// blank.
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