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
    /// The next action that Amazon Lex V2 should take.
    /// </summary>
    public partial class DialogAction
    {
        private StyleType _slotElicitationStyle;
        private string _slotToElicit;
        private ElicitSubSlot _subSlotToElicit;
        private DialogActionType _type;

        /// <summary>
        /// Gets and sets the property SlotElicitationStyle. 
        /// <para>
        /// Configures the slot to use spell-by-letter or spell-by-word style. When you use a
        /// style on a slot, users can spell out their input to make it clear to your bot.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Spell by letter - "b" "o" "b"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spell by word - "b as in boy" "o as in oscar" "b as in boy"
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/spelling-styles.html">
        /// Using spelling to enter slot values </a>.
        /// </para>
        /// </summary>
        public StyleType SlotElicitationStyle
        {
            get { return this._slotElicitationStyle; }
            set { this._slotElicitationStyle = value; }
        }

        // Check to see if SlotElicitationStyle property is set
        internal bool IsSetSlotElicitationStyle()
        {
            return this._slotElicitationStyle != null;
        }

        /// <summary>
        /// Gets and sets the property SlotToElicit. 
        /// <para>
        /// The name of the slot that should be elicited from the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property SubSlotToElicit. 
        /// <para>
        /// The name of the constituent sub slot of the composite slot specified in slotToElicit
        /// that should be elicited from the user.
        /// </para>
        /// </summary>
        public ElicitSubSlot SubSlotToElicit
        {
            get { return this._subSlotToElicit; }
            set { this._subSlotToElicit = value; }
        }

        // Check to see if SubSlotToElicit property is set
        internal bool IsSetSubSlotToElicit()
        {
            return this._subSlotToElicit != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The next action that the bot should take in its interaction with the user. The following
        /// values are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Close</c> – Indicates that there will not be a response from the user. For example,
        /// the statement "Your order has been placed" does not require a response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConfirmIntent</c> – The next action is asking the user if the intent is complete
        /// and ready to be fulfilled. This is a yes/no question such as "Place the order?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Delegate</c> – The next action is determined by Amazon Lex V2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ElicitIntent</c> – The next action is to elicit an intent from the user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ElicitSlot</c> – The next action is to elicit a slot value from the user.
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