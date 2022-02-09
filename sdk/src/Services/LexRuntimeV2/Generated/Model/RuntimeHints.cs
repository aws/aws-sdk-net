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
    /// You can provide Amazon Lex V2 with hints to the phrases that a customer is likely
    /// to use for a slot. When a slot with hints is resolved, the phrases in the runtime
    /// hints are preferred in the resolution. You can provide hints for a maximum of 100
    /// intents. You can provide a maximum of 100 slots.
    /// 
    ///  
    /// <para>
    /// Before you can use runtime hints with an existing bot, you must first rebuild the
    /// bot.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/using-hints.xml">Using
    /// hints to improve accuracy</a>.
    /// </para>
    /// </summary>
    public partial class RuntimeHints
    {
        private Dictionary<string, Dictionary<string, RuntimeHintDetails>> _slotHints = new Dictionary<string, Dictionary<string, RuntimeHintDetails>>();

        /// <summary>
        /// Gets and sets the property SlotHints. 
        /// <para>
        /// A list of the slots in the intent that should have runtime hints added, and the phrases
        /// that should be added for each slot.
        /// </para>
        ///  
        /// <para>
        /// The first level of the <code>slotHints</code> map is the name of the intent. The second
        /// level is the name of the slot within the intent. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/using-hints.xml">Using
        /// hints to improve accuracy</a>.
        /// </para>
        ///  
        /// <para>
        /// The intent name and slot name must exist.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, RuntimeHintDetails>> SlotHints
        {
            get { return this._slotHints; }
            set { this._slotHints = value; }
        }

        // Check to see if SlotHints property is set
        internal bool IsSetSlotHints()
        {
            return this._slotHints != null && this._slotHints.Count > 0; 
        }

    }
}