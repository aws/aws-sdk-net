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
    /// The value to set in a slot.
    /// </summary>
    public partial class SlotValue
    {
        private string _interpretedValue;

        /// <summary>
        /// Gets and sets the property InterpretedValue. 
        /// <para>
        /// The value that Amazon Lex determines for the slot. The actual value depends on the
        /// setting of the value selection strategy for the bot. You can choose to use the value
        /// entered by the user, or you can have Amazon Lex choose the first value in the <c>resolvedValues</c>
        /// list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string InterpretedValue
        {
            get { return this._interpretedValue; }
            set { this._interpretedValue = value; }
        }

        // Check to see if InterpretedValue property is set
        internal bool IsSetInterpretedValue()
        {
            return this._interpretedValue != null;
        }

    }
}