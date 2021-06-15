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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// The current intent that Amazon Lex V2 is attempting to fulfill.
    /// </summary>
    public partial class Intent
    {
        private ConfirmationState _confirmationState;
        private string _name;
        private Dictionary<string, Slot> _slots = new Dictionary<string, Slot>();
        private IntentState _state;

        /// <summary>
        /// Gets and sets the property ConfirmationState. 
        /// <para>
        /// Contains information about whether fulfillment of the intent has been confirmed.
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
        /// </summary>
        public Dictionary<string, Slot> Slots
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
        /// Gets and sets the property State. 
        /// <para>
        /// Contains fulfillment information for the intent. 
        /// </para>
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