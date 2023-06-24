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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains information about a slot output by the test set execution.
    /// </summary>
    public partial class UserTurnSlotOutput
    {
        private Dictionary<string, UserTurnSlotOutput> _subSlots = new Dictionary<string, UserTurnSlotOutput>();
        private string _value;
        private List<UserTurnSlotOutput> _values = new List<UserTurnSlotOutput>();

        /// <summary>
        /// Gets and sets the property SubSlots. 
        /// <para>
        /// A list of items mapping the name of the subslots to information about those subslots.
        /// </para>
        /// </summary>
        public Dictionary<string, UserTurnSlotOutput> SubSlots
        {
            get { return this._subSlots; }
            set { this._subSlots = value; }
        }

        // Check to see if SubSlots property is set
        internal bool IsSetSubSlots()
        {
            return this._subSlots != null && this._subSlots.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value output by the slot recognition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// Values that are output by the slot recognition.
        /// </para>
        /// </summary>
        public List<UserTurnSlotOutput> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}