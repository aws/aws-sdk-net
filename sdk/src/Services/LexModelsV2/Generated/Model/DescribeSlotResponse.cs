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
    /// This is the response object from the DescribeSlot operation.
    /// </summary>
    public partial class DescribeSlotResponse : AmazonWebServiceResponse
    {
        private string _botId;
        private string _botVersion;
        private DateTime? _creationDateTime;
        private string _description;
        private string _intentId;
        private DateTime? _lastUpdatedDateTime;
        private string _localeId;
        private MultipleValuesSetting _multipleValuesSetting;
        private ObfuscationSetting _obfuscationSetting;
        private string _slotId;
        private string _slotName;
        private string _slotTypeId;
        private SubSlotSetting _subSlotSetting;
        private SlotValueElicitationSetting _valueElicitationSetting;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with the slot.
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
        /// The version of the bot associated with the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// A timestamp of the date and time that the slot was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
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
        /// The description specified for the slot.
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
        /// Gets and sets the property IntentId. 
        /// <para>
        /// The identifier of the intent associated with the slot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string IntentId
        {
            get { return this._intentId; }
            set { this._intentId = value; }
        }

        // Check to see if IntentId property is set
        internal bool IsSetIntentId()
        {
            return this._intentId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the slot was last updated.
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
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The language and locale specified for the slot.
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
        /// Gets and sets the property MultipleValuesSetting. 
        /// <para>
        /// Indicates whether the slot accepts multiple values in a single utterance.
        /// </para>
        ///  
        /// <para>
        /// If the <c>multipleValuesSetting</c> is not set, the default value is <c>false</c>.
        /// </para>
        /// </summary>
        public MultipleValuesSetting MultipleValuesSetting
        {
            get { return this._multipleValuesSetting; }
            set { this._multipleValuesSetting = value; }
        }

        // Check to see if MultipleValuesSetting property is set
        internal bool IsSetMultipleValuesSetting()
        {
            return this._multipleValuesSetting != null;
        }

        /// <summary>
        /// Gets and sets the property ObfuscationSetting. 
        /// <para>
        /// Whether slot values are shown in Amazon CloudWatch logs. If the value is <c>None</c>,
        /// the actual value of the slot is shown in logs.
        /// </para>
        /// </summary>
        public ObfuscationSetting ObfuscationSetting
        {
            get { return this._obfuscationSetting; }
            set { this._obfuscationSetting = value; }
        }

        // Check to see if ObfuscationSetting property is set
        internal bool IsSetObfuscationSetting()
        {
            return this._obfuscationSetting != null;
        }

        /// <summary>
        /// Gets and sets the property SlotId. 
        /// <para>
        /// The unique identifier generated for the slot.
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
        /// The name specified for the slot.
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
        /// The identifier of the slot type that determines the values entered into the slot.
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
        /// Gets and sets the property SubSlotSetting. 
        /// <para>
        /// Specifications for the constituent sub slots and the expression for the composite
        /// slot.
        /// </para>
        /// </summary>
        public SubSlotSetting SubSlotSetting
        {
            get { return this._subSlotSetting; }
            set { this._subSlotSetting = value; }
        }

        // Check to see if SubSlotSetting property is set
        internal bool IsSetSubSlotSetting()
        {
            return this._subSlotSetting != null;
        }

        /// <summary>
        /// Gets and sets the property ValueElicitationSetting. 
        /// <para>
        /// Prompts that Amazon Lex uses to elicit a value for the slot.
        /// </para>
        /// </summary>
        public SlotValueElicitationSetting ValueElicitationSetting
        {
            get { return this._valueElicitationSetting; }
            set { this._valueElicitationSetting = value; }
        }

        // Check to see if ValueElicitationSetting property is set
        internal bool IsSetValueElicitationSetting()
        {
            return this._valueElicitationSetting != null;
        }

    }
}