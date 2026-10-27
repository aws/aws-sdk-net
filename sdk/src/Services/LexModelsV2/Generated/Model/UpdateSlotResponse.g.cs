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
    /// This is the response object from the UpdateSlot operation.
    /// </summary>
    public partial class UpdateSlotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the slot.
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
        /// The version of the bot that contains the slot. Will always be <c>DRAFT</c>.
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
        /// The updated description of the bot.
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
        /// The intent that contains the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string IntentId { get; set; }

        /// <summary>
        /// Checks to see if the IntentId property is set.
        /// </summary>
        internal bool IsSetIntentId() => this.IntentId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The timestamp of the date and time that the slot was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The locale that contains the slot.
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
        /// Indicates whether the slot accepts multiple values in one response.
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
        /// The updated setting that determines whether the slot value is obfuscated in the Amazon
        /// CloudWatch logs.
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
        /// The unique identifier of the slot that was updated.
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
        /// The updated name of the slot.
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
        /// The updated identifier of the slot type that provides values for the slot.
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
        /// The updated prompts that Amazon Lex sends to the user to elicit a response that provides
        /// a value for the slot.
        /// </para>
        /// </summary>
        public SlotValueElicitationSetting ValueElicitationSetting { get; set; }

        /// <summary>
        /// Checks to see if the ValueElicitationSetting property is set.
        /// </summary>
        internal bool IsSetValueElicitationSetting() => this.ValueElicitationSetting != null;
    }
}
