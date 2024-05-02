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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// A default value for a slot.
    /// </summary>
    public partial class SlotDefaultValue
    {
        private string _defaultValue;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for the slot. You can specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>#context-name.slot-name</c> - The slot value "slot-name" in the context "context-name."
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>{attribute}</c> - The slot value of the session attribute "attribute."
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>'value'</c> - The discrete value "value."
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=202)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

    }
}