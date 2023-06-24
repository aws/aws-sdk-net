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
    /// A value that Amazon Lex V2 uses to fulfill an intent.
    /// </summary>
    public partial class Slot
    {
        private Shape _shape;
        private Dictionary<string, Slot> _subSlots = new Dictionary<string, Slot>();
        private Value _value;
        private List<Slot> _values = new List<Slot>();

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// When the <code>shape</code> value is <code>List</code>, it indicates that the <code>values</code>
        /// field contains a list of slot values. When the value is <code>Scalar</code>, it indicates
        /// that the <code>value</code> field contains a single value.
        /// </para>
        /// </summary>
        public Shape Shape
        {
            get { return this._shape; }
            set { this._shape = value; }
        }

        // Check to see if Shape property is set
        internal bool IsSetShape()
        {
            return this._shape != null;
        }

        /// <summary>
        /// Gets and sets the property SubSlots. 
        /// <para>
        /// The constituent sub slots of a composite slot.
        /// </para>
        /// </summary>
        public Dictionary<string, Slot> SubSlots
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
        /// The current value of the slot.
        /// </para>
        /// </summary>
        public Value Value
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
        /// A list of one or more values that the user provided for the slot. For example, if
        /// a for a slot that elicits pizza toppings, the values might be "pepperoni" and "pineapple."
        /// 
        /// </para>
        /// </summary>
        public List<Slot> Values
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