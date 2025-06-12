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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The slot values that Amazon Lex uses when it sets slot values in a dialog step.
    /// </summary>
    public partial class SlotValueOverride
    {
        private SlotShape _shape;
        private SlotValue _value;
        private List<SlotValueOverride> _values = AWSConfigs.InitializeCollections ? new List<SlotValueOverride>() : null;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// When the shape value is <c>List</c>, it indicates that the <c>values</c> field contains
        /// a list of slot values. When the value is <c>Scalar</c>, it indicates that the <c>value</c>
        /// field contains a single value.
        /// </para>
        /// </summary>
        public SlotShape Shape
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The current value of the slot.
        /// </para>
        /// </summary>
        public SlotValue Value
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
        /// A list of one or more values that the user provided for the slot. For example, for
        /// a slot that elicits pizza toppings, the values might be "pepperoni" and "pineapple."
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SlotValueOverride> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}