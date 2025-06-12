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
    /// Container for the parameters to the UpdateSlotType operation.
    /// Updates the configuration of an existing slot type.
    /// </summary>
    public partial class UpdateSlotTypeRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botVersion;
        private CompositeSlotTypeSetting _compositeSlotTypeSetting;
        private string _description;
        private ExternalSourceSetting _externalSourceSetting;
        private string _localeId;
        private string _parentSlotTypeSignature;
        private string _slotTypeId;
        private string _slotTypeName;
        private List<SlotTypeValue> _slotTypeValues = AWSConfigs.InitializeCollections ? new List<SlotTypeValue>() : null;
        private SlotValueSelectionSetting _valueSelectionSetting;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that contains the slot type. Must be <c>DRAFT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CompositeSlotTypeSetting. 
        /// <para>
        /// Specifications for a composite slot type.
        /// </para>
        /// </summary>
        public CompositeSlotTypeSetting CompositeSlotTypeSetting
        {
            get { return this._compositeSlotTypeSetting; }
            set { this._compositeSlotTypeSetting = value; }
        }

        // Check to see if CompositeSlotTypeSetting property is set
        internal bool IsSetCompositeSlotTypeSetting()
        {
            return this._compositeSlotTypeSetting != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description of the slot type.
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
        /// Gets and sets the property ExternalSourceSetting.
        /// </summary>
        public ExternalSourceSetting ExternalSourceSetting
        {
            get { return this._externalSourceSetting; }
            set { this._externalSourceSetting = value; }
        }

        // Check to see if ExternalSourceSetting property is set
        internal bool IsSetExternalSourceSetting()
        {
            return this._externalSourceSetting != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale that contains the slot type. The string
        /// must match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
        /// languages</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LocaleId
        {
            get { return this._localeId; }
            set { this._localeId = value; }
        }

        // Check to see if LocaleId property is set
        internal bool IsSetLocaleId()
        {
            return this._localeId != null;
        }

        /// <summary>
        /// Gets and sets the property ParentSlotTypeSignature. 
        /// <para>
        /// The new built-in slot type that should be used as the parent of this slot type.
        /// </para>
        /// </summary>
        public string ParentSlotTypeSignature
        {
            get { return this._parentSlotTypeSignature; }
            set { this._parentSlotTypeSignature = value; }
        }

        // Check to see if ParentSlotTypeSignature property is set
        internal bool IsSetParentSlotTypeSignature()
        {
            return this._parentSlotTypeSignature != null;
        }

        /// <summary>
        /// Gets and sets the property SlotTypeId. 
        /// <para>
        /// The unique identifier of the slot type to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
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
        /// Gets and sets the property SlotTypeName. 
        /// <para>
        /// The new name of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string SlotTypeName
        {
            get { return this._slotTypeName; }
            set { this._slotTypeName = value; }
        }

        // Check to see if SlotTypeName property is set
        internal bool IsSetSlotTypeName()
        {
            return this._slotTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property SlotTypeValues. 
        /// <para>
        /// A new list of values and their optional synonyms that define the values that the slot
        /// type can take.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public List<SlotTypeValue> SlotTypeValues
        {
            get { return this._slotTypeValues; }
            set { this._slotTypeValues = value; }
        }

        // Check to see if SlotTypeValues property is set
        internal bool IsSetSlotTypeValues()
        {
            return this._slotTypeValues != null && (this._slotTypeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValueSelectionSetting. 
        /// <para>
        /// The strategy that Amazon Lex should use when deciding on a value from the list of
        /// slot type values.
        /// </para>
        /// </summary>
        public SlotValueSelectionSetting ValueSelectionSetting
        {
            get { return this._valueSelectionSetting; }
            set { this._valueSelectionSetting = value; }
        }

        // Check to see if ValueSelectionSetting property is set
        internal bool IsSetValueSelectionSetting()
        {
            return this._valueSelectionSetting != null;
        }

    }
}