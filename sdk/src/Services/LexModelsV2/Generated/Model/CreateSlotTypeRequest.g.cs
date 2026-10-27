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
    /// Container for the parameters to the CreateSlotType operation. Creates a custom slot
    /// type <para> To create a custom slot type, specify a name for the slot type and a set
    /// of enumeration values, the values that a slot of this type can assume. </para>
    /// </summary>
    public partial class CreateSlotTypeRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with this slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string BotId { get; set; }

        /// <summary>
        /// Checks to see if the BotId property is set.
        /// </summary>
        internal bool IsSetBotId() => this.BotId != null;

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The identifier of the bot version associated with this slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property CompositeSlotTypeSetting. 
        /// <para>
        /// Specifications for a composite slot type.
        /// </para>
        /// </summary>
        public CompositeSlotTypeSetting CompositeSlotTypeSetting { get; set; }

        /// <summary>
        /// Checks to see if the CompositeSlotTypeSetting property is set.
        /// </summary>
        internal bool IsSetCompositeSlotTypeSetting() => this.CompositeSlotTypeSetting != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the slot type. Use the description to help identify the slot type
        /// in lists.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExternalSourceSetting. 
        /// <para>
        /// Sets the type of external information used to create the slot type.
        /// </para>
        /// </summary>
        public ExternalSourceSetting ExternalSourceSetting { get; set; }

        /// <summary>
        /// Checks to see if the ExternalSourceSetting property is set.
        /// </summary>
        internal bool IsSetExternalSourceSetting() => this.ExternalSourceSetting != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale that the slot type will be used in. The
        /// string must match one of the supported locales. All of the bots, intents, and slots
        /// used by the slot type must have the same locale. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property ParentSlotTypeSignature. 
        /// <para>
        /// The built-in slot type used as a parent of this slot type. When you define a parent
        /// slot type, the new slot type has the configuration of the parent slot type.
        /// </para>
        ///  
        /// <para>
        /// Only <c>AMAZON.AlphaNumeric</c> is supported.
        /// </para>
        /// </summary>
        public string ParentSlotTypeSignature { get; set; }

        /// <summary>
        /// Checks to see if the ParentSlotTypeSignature property is set.
        /// </summary>
        internal bool IsSetParentSlotTypeSignature() => this.ParentSlotTypeSignature != null;

        /// <summary>
        /// Gets and sets the property SlotTypeName. 
        /// <para>
        /// The name for the slot. A slot type name must be unique within the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SlotTypeName { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeName property is set.
        /// </summary>
        internal bool IsSetSlotTypeName() => this.SlotTypeName != null;

        /// <summary>
        /// Gets and sets the property SlotTypeValues. 
        /// <para>
        /// A list of <c>SlotTypeValue</c> objects that defines the values that the slot type
        /// can take. Each value can have a list of synonyms, additional values that help train
        /// the machine learning model about the values that it resolves for a slot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public List<SlotTypeValue> SlotTypeValues { get; set; } = AWSConfigs.InitializeCollections ? new List<SlotTypeValue>() : null;

        /// <summary>
        /// Checks to see if the SlotTypeValues property is set.
        /// </summary>
        internal bool IsSetSlotTypeValues() => this.SlotTypeValues != null && (this.SlotTypeValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValueSelectionSetting. 
        /// <para>
        /// Determines the strategy that Amazon Lex uses to select a value from the list of possible
        /// values. The field can be set to one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ORIGINAL_VALUE</c> - Returns the value entered by the user, if the user value
        /// is similar to the slot value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOP_RESOLUTION</c> - If there is a resolution list for the slot, return the first
        /// value in the resolution list. If there is no resolution list, return null.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify the <c>valueSelectionSetting</c> parameter, the default is <c>ORIGINAL_VALUE</c>.
        /// </para>
        /// </summary>
        public SlotValueSelectionSetting ValueSelectionSetting { get; set; }

        /// <summary>
        /// Checks to see if the ValueSelectionSetting property is set.
        /// </summary>
        internal bool IsSetValueSelectionSetting() => this.ValueSelectionSetting != null;
    }
}
