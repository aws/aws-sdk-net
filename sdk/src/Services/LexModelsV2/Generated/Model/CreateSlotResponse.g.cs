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
    /// This is the response object from the CreateSlot operation.
    /// </summary>
    public partial class CreateSlotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The unique identifier of the bot associated with the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot associated with the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The timestamp of the date and time that the slot was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description associated with the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IntentId. 
        /// <para>
        /// The unique identifier of the intent associated with the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string IntentId { get; set; }

        /// <summary>
        /// Checks to see if the IntentId property is set.
        /// </summary>
        internal bool IsSetIntentId() => this.IntentId != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The language and local specified for the slot.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property MultipleValuesSetting. 
        /// <para>
        /// Indicates whether the slot returns multiple values in one response.
        /// </para>
        /// </summary>
        public MultipleValuesSetting MultipleValuesSetting { get; set; }

        /// <summary>
        /// Checks to see if the MultipleValuesSetting property is set.
        /// </summary>
        internal bool IsSetMultipleValuesSetting() => this.MultipleValuesSetting != null;

        /// <summary>
        /// Gets and sets the property ObfuscationSetting. 
        /// <para>
        /// Indicates whether the slot is configured to obfuscate values in Amazon CloudWatch
        /// logs.
        /// </para>
        /// </summary>
        public ObfuscationSetting ObfuscationSetting { get; set; }

        /// <summary>
        /// Checks to see if the ObfuscationSetting property is set.
        /// </summary>
        internal bool IsSetObfuscationSetting() => this.ObfuscationSetting != null;

        /// <summary>
        /// Gets and sets the property SlotId. 
        /// <para>
        /// The unique identifier associated with the slot. Use this to identify the slot when
        /// you update or delete it.
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
        /// The name specified for the slot.
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
        /// The unique identifier of the slot type associated with this slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string SlotTypeId { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeId property is set.
        /// </summary>
        internal bool IsSetSlotTypeId() => this.SlotTypeId != null;

        /// <summary>
        /// Gets and sets the property SubSlotSetting. 
        /// <para>
        /// Specifications for the constituent sub slots and the expression for the composite
        /// slot.
        /// </para>
        /// </summary>
        public SubSlotSetting SubSlotSetting { get; set; }

        /// <summary>
        /// Checks to see if the SubSlotSetting property is set.
        /// </summary>
        internal bool IsSetSubSlotSetting() => this.SubSlotSetting != null;

        /// <summary>
        /// Gets and sets the property ValueElicitationSetting. 
        /// <para>
        /// The value elicitation settings specified for the slot.
        /// </para>
        /// </summary>
        public SlotValueElicitationSetting ValueElicitationSetting { get; set; }

        /// <summary>
        /// Checks to see if the ValueElicitationSetting property is set.
        /// </summary>
        internal bool IsSetValueElicitationSetting() => this.ValueElicitationSetting != null;
    }
}
