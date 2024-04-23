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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the UpdateSlotType operation.
    /// </summary>
    public partial class UpdateSlotTypeResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _botVersion;
        private CompositeSlotTypeSetting _compositeSlotTypeSetting;
        private DateTime? _creationDateTime;
        private string _description;
        private ExternalSourceSetting _externalSourceSetting;
        private DateTime? _lastUpdatedDateTime;
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
        [AWSProperty(Min=10, Max=10)]
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
        /// The version of the bot that contains the slot type. This is always <c>DRAFT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The timestamp of the date and time that the slot type was created.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the slot type was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime.GetValueOrDefault(); }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The language and locale of the updated slot type.
        /// </para>
        /// </summary>
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
        /// The updated signature of the built-in slot type that is the parent of this slot type.
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
        /// The unique identifier of the updated slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
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
        /// The updated name of the slot type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The updated values that the slot type provides.
        /// </para>
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
        /// The updated strategy that Amazon Lex uses to determine which value to select from
        /// the slot type.
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