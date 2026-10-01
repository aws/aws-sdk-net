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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Identifies the version of a specific slot.
    /// </summary>
    public partial class Slot
    {
        /// <summary>
        /// Gets and sets the property DefaultValueSpec. 
        /// <para>
        /// A list of default values for the slot. Default values are used when Amazon Lex hasn't
        /// determined a value for a slot. You can specify default values from context variables,
        /// session attributes, and defined values.
        /// </para>
        /// </summary>
        public SlotDefaultValueSpec DefaultValueSpec { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValueSpec property is set.
        /// </summary>
        internal bool IsSetDefaultValueSpec() => this.DefaultValueSpec != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ObfuscationSetting. 
        /// <para>
        /// Determines whether a slot is obfuscated in conversation logs and stored utterances.
        /// When you obfuscate a slot, the value is replaced by the slot name in curly braces
        /// ({}). For example, if the slot name is "full_name", obfuscated values are replaced
        /// with "{full_name}". For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/how-obfuscate.html">
        /// Slot Obfuscation </a>. 
        /// </para>
        /// </summary>
        public ObfuscationSetting ObfuscationSetting { get; set; }

        /// <summary>
        /// Checks to see if the ObfuscationSetting property is set.
        /// </summary>
        internal bool IsSetObfuscationSetting() => this.ObfuscationSetting != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        ///  Directs Amazon Lex the order in which to elicit this slot value from the user. For
        /// example, if the intent has two slots with priorities 1 and 2, AWS Amazon Lex first
        /// elicits a value for the slot with priority 1.
        /// </para>
        ///  
        /// <para>
        /// If multiple slots share the same priority, the order in which Amazon Lex elicits values
        /// is arbitrary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseCard. 
        /// <para>
        ///  A set of possible responses for the slot type used by text-based clients. A user
        /// chooses an option from the response card, instead of using text to reply. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50000)]
        public string ResponseCard { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCard property is set.
        /// </summary>
        internal bool IsSetResponseCard() => this.ResponseCard != null;

        /// <summary>
        /// Gets and sets the property SampleUtterances. 
        /// <para>
        ///  If you know a specific pattern with which users might respond to an Amazon Lex request
        /// for a slot value, you can provide those utterances to improve accuracy. This is optional.
        /// In most cases, Amazon Lex is capable of understanding user utterances. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> SampleUtterances { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SampleUtterances property is set.
        /// </summary>
        internal bool IsSetSampleUtterances() => this.SampleUtterances != null && (this.SampleUtterances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SlotConstraint. 
        /// <para>
        /// Specifies whether the slot is required or optional. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SlotConstraint SlotConstraint { get; set; }

        /// <summary>
        /// Checks to see if the SlotConstraint property is set.
        /// </summary>
        internal bool IsSetSlotConstraint() => this.SlotConstraint != null;

        /// <summary>
        /// Gets and sets the property SlotType. 
        /// <para>
        /// The type of the slot, either a custom slot type that you defined or one of the built-in
        /// slot types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SlotType { get; set; }

        /// <summary>
        /// Checks to see if the SlotType property is set.
        /// </summary>
        internal bool IsSetSlotType() => this.SlotType != null;

        /// <summary>
        /// Gets and sets the property SlotTypeVersion. 
        /// <para>
        /// The version of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SlotTypeVersion { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeVersion property is set.
        /// </summary>
        internal bool IsSetSlotTypeVersion() => this.SlotTypeVersion != null;

        /// <summary>
        /// Gets and sets the property ValueElicitationPrompt. 
        /// <para>
        /// The prompt that Amazon Lex uses to elicit the slot value from the user.
        /// </para>
        /// </summary>
        public Prompt ValueElicitationPrompt { get; set; }

        /// <summary>
        /// Checks to see if the ValueElicitationPrompt property is set.
        /// </summary>
        internal bool IsSetValueElicitationPrompt() => this.ValueElicitationPrompt != null;
    }
}
