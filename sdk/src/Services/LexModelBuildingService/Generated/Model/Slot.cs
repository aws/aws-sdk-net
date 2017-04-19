/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Identifies the version of a specific slot.
    /// </summary>
    public partial class Slot
    {
        private string _description;
        private string _name;
        private int? _priority;
        private string _responseCard;
        private List<string> _sampleUtterances = new List<string>();
        private SlotConstraint _slotConstraint;
        private string _slotType;
        private string _slotTypeVersion;
        private Prompt _valueElicitationPrompt;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the slot.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Priority. 
        /// <para>
        ///  Specifies the order in which to elicit slot values from the user. For example, if
        /// the intent has two slots with priorities 1 and 2, AWS Amazon Lex first elicits a value
        /// for the slot with priority 1.
        /// </para>
        ///  
        /// <para>
        /// If multiple slots share the same priority, the order in which Amazon Lex elicits values
        /// is arbitrary.
        /// </para>
        /// </summary>
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseCard. 
        /// <para>
        ///  A set of possible responses for the slot type used by text-based clients. A user
        /// chooses an option from the response card, instead of using text to reply. 
        /// </para>
        /// </summary>
        public string ResponseCard
        {
            get { return this._responseCard; }
            set { this._responseCard = value; }
        }

        // Check to see if ResponseCard property is set
        internal bool IsSetResponseCard()
        {
            return this._responseCard != null;
        }

        /// <summary>
        /// Gets and sets the property SampleUtterances. 
        /// <para>
        ///  If you know a specific pattern with which users might respond to an Amazon Lex request
        /// for a slot value, you can provide those utterances to improve accuracy. This is optional.
        /// In most cases, Amazon Lex is capable of understanding user utterances. 
        /// </para>
        /// </summary>
        public List<string> SampleUtterances
        {
            get { return this._sampleUtterances; }
            set { this._sampleUtterances = value; }
        }

        // Check to see if SampleUtterances property is set
        internal bool IsSetSampleUtterances()
        {
            return this._sampleUtterances != null && this._sampleUtterances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SlotConstraint. 
        /// <para>
        /// Specifies whether the slot is required or optional. 
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
        /// Gets and sets the property SlotType. 
        /// <para>
        /// The type of the slot, either a custom slot type that you defined or one of the built-in
        /// slot types.
        /// </para>
        /// </summary>
        public string SlotType
        {
            get { return this._slotType; }
            set { this._slotType = value; }
        }

        // Check to see if SlotType property is set
        internal bool IsSetSlotType()
        {
            return this._slotType != null;
        }

        /// <summary>
        /// Gets and sets the property SlotTypeVersion. 
        /// <para>
        /// The version of the slot type.
        /// </para>
        /// </summary>
        public string SlotTypeVersion
        {
            get { return this._slotTypeVersion; }
            set { this._slotTypeVersion = value; }
        }

        // Check to see if SlotTypeVersion property is set
        internal bool IsSetSlotTypeVersion()
        {
            return this._slotTypeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ValueElicitationPrompt. 
        /// <para>
        /// The prompt that Amazon Lex uses to elicit the slot value from the user.
        /// </para>
        /// </summary>
        public Prompt ValueElicitationPrompt
        {
            get { return this._valueElicitationPrompt; }
            set { this._valueElicitationPrompt = value; }
        }

        // Check to see if ValueElicitationPrompt property is set
        internal bool IsSetValueElicitationPrompt()
        {
            return this._valueElicitationPrompt != null;
        }

    }
}