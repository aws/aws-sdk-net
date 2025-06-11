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
    /// Summary information about a slot, a value that the bot elicits from the user.
    /// </summary>
    public partial class SlotSummary
    {
        private string _description;
        private DateTime? _lastUpdatedDateTime;
        private SlotConstraint _slotConstraint;
        private string _slotId;
        private string _slotName;
        private string _slotTypeId;
        private PromptSpecification _valueElicitationPromptSpecification;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The timestamp of the last date and time that the slot was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SlotConstraint. 
        /// <para>
        /// Whether the slot is required or optional. An intent is complete when all required
        /// slots are filled.
        /// </para>
        /// </summary>
        public SlotConstraint SlotConstraint
        {
            get { return this._slotConstraint; }
            set { this._slotConstraint = value; }
        }

        // Check to see if SlotConstraint property is set
        internal bool IsSetSlotConstraint()
        {
            return this._slotConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property SlotId. 
        /// <para>
        /// The unique identifier of the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string SlotId
        {
            get { return this._slotId; }
            set { this._slotId = value; }
        }

        // Check to see if SlotId property is set
        internal bool IsSetSlotId()
        {
            return this._slotId != null;
        }

        /// <summary>
        /// Gets and sets the property SlotName. 
        /// <para>
        /// The name given to the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SlotName
        {
            get { return this._slotName; }
            set { this._slotName = value; }
        }

        // Check to see if SlotName property is set
        internal bool IsSetSlotName()
        {
            return this._slotName != null;
        }

        /// <summary>
        /// Gets and sets the property SlotTypeId. 
        /// <para>
        /// The unique identifier for the slot type that defines the values for the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        /// Gets and sets the property ValueElicitationPromptSpecification. 
        /// <para>
        /// Prompts that are sent to the user to elicit a value for the slot.
        /// </para>
        /// </summary>
        public PromptSpecification ValueElicitationPromptSpecification
        {
            get { return this._valueElicitationPromptSpecification; }
            set { this._valueElicitationPromptSpecification = value; }
        }

        // Check to see if ValueElicitationPromptSpecification property is set
        internal bool IsSetValueElicitationPromptSpecification()
        {
            return this._valueElicitationPromptSpecification != null;
        }

    }
}