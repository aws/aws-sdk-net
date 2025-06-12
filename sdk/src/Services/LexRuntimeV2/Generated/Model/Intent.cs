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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// The current intent that Amazon Lex V2 is attempting to fulfill.
    /// </summary>
    public partial class Intent
    {
        private ConfirmationState _confirmationState;
        private string _name;
        private Dictionary<string, Slot> _slots = AWSConfigs.InitializeCollections ? new Dictionary<string, Slot>() : null;
        private IntentState _state;

        /// <summary>
        /// Gets and sets the property ConfirmationState. 
        /// <para>
        /// Indicates whether the intent has been <c>Confirmed</c>, <c>Denied</c>, or <c>None</c>
        /// if the confirmation stage has not yet been reached.
        /// </para>
        /// </summary>
        public ConfirmationState ConfirmationState
        {
            get { return this._confirmationState; }
            set { this._confirmationState = value; }
        }

        // Check to see if ConfirmationState property is set
        internal bool IsSetConfirmationState()
        {
            return this._confirmationState != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// A map of all of the slots for the intent. The name of the slot maps to the value of
        /// the slot. If a slot has not been filled, the value is null.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Slot> Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null && (this._slots.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates the fulfillment state for the intent. The meanings of each value are as
        /// follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Failed</c> – The bot failed to fulfill the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fulfilled</c> – The bot has completed fulfillment of the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FulfillmentInProgress</c> – The bot is in the middle of fulfilling the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c> – The bot is in the middle of eliciting the slot values that are
        /// necessary to fulfill the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReadyForFulfillment</c> – The bot has elicited all the slot values for the intent
        /// and is ready to fulfill the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Waiting</c> – The bot is waiting for a response from the user (limited to streaming
        /// conversations).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IntentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}