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
    /// The specific constituent sub slot of the composite slot to elicit in dialog action.
    /// </summary>
    public partial class ElicitSubSlot
    {
        private string _name;
        private ElicitSubSlot _subSlotToElicit;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot that should be elicited from the user.
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
        /// Gets and sets the property SubSlotToElicit. 
        /// <para>
        /// The field is not supported.
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

    }
}