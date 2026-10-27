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
    /// Summary information about a slot, a value that the bot elicits from the user.
    /// </summary>
    public partial class SlotSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the slot.
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
        /// The timestamp of the last date and time that the slot was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SlotConstraint. 
        /// <para>
        /// Whether the slot is required or optional. An intent is complete when all required
        /// slots are filled.
        /// </para>
        /// </summary>
        public SlotConstraint SlotConstraint { get; set; }

        /// <summary>
        /// Checks to see if the SlotConstraint property is set.
        /// </summary>
        internal bool IsSetSlotConstraint() => this.SlotConstraint != null;

        /// <summary>
        /// Gets and sets the property SlotId. 
        /// <para>
        /// The unique identifier of the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string SlotId { get; set; }

        /// <summary>
        /// Checks to see if the SlotId property is set.
        /// </summary>
        internal bool IsSetSlotId() => this.SlotId != null;

        /// <summary>
        /// Gets and sets the property SlotName. 
        /// <para>
        /// The name given to the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SlotName { get; set; }

        /// <summary>
        /// Checks to see if the SlotName property is set.
        /// </summary>
        internal bool IsSetSlotName() => this.SlotName != null;

        /// <summary>
        /// Gets and sets the property SlotTypeId. 
        /// <para>
        /// The unique identifier for the slot type that defines the values for the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string SlotTypeId { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeId property is set.
        /// </summary>
        internal bool IsSetSlotTypeId() => this.SlotTypeId != null;

        /// <summary>
        /// Gets and sets the property ValueElicitationPromptSpecification. 
        /// <para>
        /// Prompts that are sent to the user to elicit a value for the slot.
        /// </para>
        /// </summary>
        public PromptSpecification ValueElicitationPromptSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ValueElicitationPromptSpecification property is set.
        /// </summary>
        internal bool IsSetValueElicitationPromptSpecification() => this.ValueElicitationPromptSpecification != null;
    }
}
