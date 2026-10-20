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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Provides summary information about a slot type.
    /// </summary>
    public partial class SlotTypeSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the slot type was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property ParentSlotTypeSignature. 
        /// <para>
        /// If the slot type is derived from a built-on slot type, the name of the parent slot
        /// type.
        /// </para>
        /// </summary>
        public string ParentSlotTypeSignature { get; set; }

        /// <summary>
        /// Checks to see if the ParentSlotTypeSignature property is set.
        /// </summary>
        internal bool IsSetParentSlotTypeSignature() => this.ParentSlotTypeSignature != null;

        /// <summary>
        /// Gets and sets the property SlotTypeCategory. 
        /// <para>
        /// Indicates the type of the slot type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Custom</c> - A slot type that you created using custom values. For more information,
        /// see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/custom-slot-types.html">Creating
        /// custom slot types</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Extended</c> - A slot type created by extending the <c>AMAZON.AlphaNumeric</c>
        /// built-in slot type. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/built-in-slot-alphanumerice.html">
        /// <c>AMAZON.AlphaNumeric</c> </a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExternalGrammar</c> - A slot type using a custom GRXML grammar to define values.
        /// For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/building-grxml.html">Using
        /// a custom grammar slot type</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SlotTypeCategory SlotTypeCategory { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeCategory property is set.
        /// </summary>
        internal bool IsSetSlotTypeCategory() => this.SlotTypeCategory != null;

        /// <summary>
        /// Gets and sets the property SlotTypeId. 
        /// <para>
        /// The unique identifier assigned to the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string SlotTypeId { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeId property is set.
        /// </summary>
        internal bool IsSetSlotTypeId() => this.SlotTypeId != null;

        /// <summary>
        /// Gets and sets the property SlotTypeName. 
        /// <para>
        /// The name of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SlotTypeName { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeName property is set.
        /// </summary>
        internal bool IsSetSlotTypeName() => this.SlotTypeName != null;
    }
}
