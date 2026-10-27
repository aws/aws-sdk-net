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
    /// This is the response object from the CreateSlotType operation.
    /// </summary>
    public partial class CreateSlotTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier for the bot associated with the slot type.
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
        /// The version of the bot associated with the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 5)]
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the slot type was created.
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
        /// The description specified for the slot type.
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
        /// The type of external information used to create the slot type.
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
        /// The specified language and local specified for the slot type.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property ParentSlotTypeSignature. 
        /// <para>
        /// The signature of the base slot type specified for the slot type.
        /// </para>
        /// </summary>
        public string ParentSlotTypeSignature { get; set; }

        /// <summary>
        /// Checks to see if the ParentSlotTypeSignature property is set.
        /// </summary>
        internal bool IsSetParentSlotTypeSignature() => this.ParentSlotTypeSignature != null;

        /// <summary>
        /// Gets and sets the property SlotTypeId. 
        /// <para>
        /// The unique identifier assigned to the slot type. Use this to identify the slot type
        /// in the <c>UpdateSlotType</c> and <c>DeleteSlotType</c> operations.
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
        /// The name specified for the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SlotTypeName { get; set; }

        /// <summary>
        /// Checks to see if the SlotTypeName property is set.
        /// </summary>
        internal bool IsSetSlotTypeName() => this.SlotTypeName != null;

        /// <summary>
        /// Gets and sets the property SlotTypeValues. 
        /// <para>
        /// The list of values that the slot type can assume.
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
        /// The strategy that Amazon Lex uses to select a value from the list of possible values.
        /// </para>
        /// </summary>
        public SlotValueSelectionSetting ValueSelectionSetting { get; set; }

        /// <summary>
        /// Checks to see if the ValueSelectionSetting property is set.
        /// </summary>
        internal bool IsSetValueSelectionSetting() => this.ValueSelectionSetting != null;
    }
}
