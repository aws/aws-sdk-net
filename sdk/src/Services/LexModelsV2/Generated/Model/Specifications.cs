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
    /// Subslot specifications.
    /// </summary>
    public partial class Specifications
    {
        private string _slotTypeId;
        private SubSlotValueElicitationSetting _valueElicitationSetting;

        /// <summary>
        /// Gets and sets the property SlotTypeId. 
        /// <para>
        /// The unique identifier assigned to the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public string SlotTypeId
        {
            get { return this._slotTypeId; }
            set { this._slotTypeId = value; }
        }

        // Check to see if SlotTypeId property is set
        internal bool IsSetSlotTypeId()
        {
            return this._slotTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ValueElicitationSetting. 
        /// <para>
        /// Specifies the elicitation setting details for constituent sub slots of a composite
        /// slot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubSlotValueElicitationSetting ValueElicitationSetting
        {
            get { return this._valueElicitationSetting; }
            set { this._valueElicitationSetting = value; }
        }

        // Check to see if ValueElicitationSetting property is set
        internal bool IsSetValueElicitationSetting()
        {
            return this._valueElicitationSetting != null;
        }

    }
}