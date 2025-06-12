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
    /// Container for the parameters to the UpdateIntent operation.
    /// Updates the settings for an intent.
    /// </summary>
    public partial class UpdateIntentRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botVersion;
        private string _description;
        private DialogCodeHookSettings _dialogCodeHook;
        private FulfillmentCodeHookSettings _fulfillmentCodeHook;
        private InitialResponseSetting _initialResponseSetting;
        private List<InputContext> _inputContexts = AWSConfigs.InitializeCollections ? new List<InputContext>() : null;
        private IntentClosingSetting _intentClosingSetting;
        private IntentConfirmationSetting _intentConfirmationSetting;
        private string _intentId;
        private string _intentName;
        private KendraConfiguration _kendraConfiguration;
        private string _localeId;
        private List<OutputContext> _outputContexts = AWSConfigs.InitializeCollections ? new List<OutputContext>() : null;
        private string _parentIntentSignature;
        private QInConnectIntentConfiguration _qInConnectIntentConfiguration;
        private QnAIntentConfiguration _qnaIntentConfiguration;
        private List<SampleUtterance> _sampleUtterances = AWSConfigs.InitializeCollections ? new List<SampleUtterance>() : null;
        private List<SlotPriority> _slotPriorities = AWSConfigs.InitializeCollections ? new List<SlotPriority>() : null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the intent.
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
        /// The version of the bot that contains the intent. Must be <c>DRAFT</c>.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description of the intent.
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
        /// Gets and sets the property DialogCodeHook. 
        /// <para>
        /// The new Lambda function to use between each turn of the conversation with the bot.
        /// </para>
        /// </summary>
        public DialogCodeHookSettings DialogCodeHook
        {
            get { return this._dialogCodeHook; }
            set { this._dialogCodeHook = value; }
        }

        // Check to see if DialogCodeHook property is set
        internal bool IsSetDialogCodeHook()
        {
            return this._dialogCodeHook != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentCodeHook. 
        /// <para>
        /// The new Lambda function to call when all of the intents required slots are provided
        /// and the intent is ready for fulfillment.
        /// </para>
        /// </summary>
        public FulfillmentCodeHookSettings FulfillmentCodeHook
        {
            get { return this._fulfillmentCodeHook; }
            set { this._fulfillmentCodeHook = value; }
        }

        // Check to see if FulfillmentCodeHook property is set
        internal bool IsSetFulfillmentCodeHook()
        {
            return this._fulfillmentCodeHook != null;
        }

        /// <summary>
        /// Gets and sets the property InitialResponseSetting. 
        /// <para>
        /// Configuration settings for a response sent to the user before Amazon Lex starts eliciting
        /// slots.
        /// </para>
        /// </summary>
        public InitialResponseSetting InitialResponseSetting
        {
            get { return this._initialResponseSetting; }
            set { this._initialResponseSetting = value; }
        }

        // Check to see if InitialResponseSetting property is set
        internal bool IsSetInitialResponseSetting()
        {
            return this._initialResponseSetting != null;
        }

        /// <summary>
        /// Gets and sets the property InputContexts. 
        /// <para>
        /// A new list of contexts that must be active in order for Amazon Lex to consider the
        /// intent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<InputContext> InputContexts
        {
            get { return this._inputContexts; }
            set { this._inputContexts = value; }
        }

        // Check to see if InputContexts property is set
        internal bool IsSetInputContexts()
        {
            return this._inputContexts != null && (this._inputContexts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntentClosingSetting. 
        /// <para>
        /// The new response that Amazon Lex sends the user when the intent is closed.
        /// </para>
        /// </summary>
        public IntentClosingSetting IntentClosingSetting
        {
            get { return this._intentClosingSetting; }
            set { this._intentClosingSetting = value; }
        }

        // Check to see if IntentClosingSetting property is set
        internal bool IsSetIntentClosingSetting()
        {
            return this._intentClosingSetting != null;
        }

        /// <summary>
        /// Gets and sets the property IntentConfirmationSetting. 
        /// <para>
        /// New prompts that Amazon Lex sends to the user to confirm the completion of an intent.
        /// </para>
        /// </summary>
        public IntentConfirmationSetting IntentConfirmationSetting
        {
            get { return this._intentConfirmationSetting; }
            set { this._intentConfirmationSetting = value; }
        }

        // Check to see if IntentConfirmationSetting property is set
        internal bool IsSetIntentConfirmationSetting()
        {
            return this._intentConfirmationSetting != null;
        }

        /// <summary>
        /// Gets and sets the property IntentId. 
        /// <para>
        /// The unique identifier of the intent to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
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
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The new name for the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string IntentName
        {
            get { return this._intentName; }
            set { this._intentName = value; }
        }

        // Check to see if IntentName property is set
        internal bool IsSetIntentName()
        {
            return this._intentName != null;
        }

        /// <summary>
        /// Gets and sets the property KendraConfiguration. 
        /// <para>
        /// New configuration settings for connecting to an Amazon Kendra index.
        /// </para>
        /// </summary>
        public KendraConfiguration KendraConfiguration
        {
            get { return this._kendraConfiguration; }
            set { this._kendraConfiguration = value; }
        }

        // Check to see if KendraConfiguration property is set
        internal bool IsSetKendraConfiguration()
        {
            return this._kendraConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale where this intent is used. The string must
        /// match one of the supported locales. For more information, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
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
        /// Gets and sets the property OutputContexts. 
        /// <para>
        /// A new list of contexts that Amazon Lex activates when the intent is fulfilled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<OutputContext> OutputContexts
        {
            get { return this._outputContexts; }
            set { this._outputContexts = value; }
        }

        // Check to see if OutputContexts property is set
        internal bool IsSetOutputContexts()
        {
            return this._outputContexts != null && (this._outputContexts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentIntentSignature. 
        /// <para>
        /// The signature of the new built-in intent to use as the parent of this intent.
        /// </para>
        /// </summary>
        public string ParentIntentSignature
        {
            get { return this._parentIntentSignature; }
            set { this._parentIntentSignature = value; }
        }

        // Check to see if ParentIntentSignature property is set
        internal bool IsSetParentIntentSignature()
        {
            return this._parentIntentSignature != null;
        }

        /// <summary>
        /// Gets and sets the property QInConnectIntentConfiguration. 
        /// <para>
        /// Qinconnect intent configuration details for the update intent request.
        /// </para>
        /// </summary>
        public QInConnectIntentConfiguration QInConnectIntentConfiguration
        {
            get { return this._qInConnectIntentConfiguration; }
            set { this._qInConnectIntentConfiguration = value; }
        }

        // Check to see if QInConnectIntentConfiguration property is set
        internal bool IsSetQInConnectIntentConfiguration()
        {
            return this._qInConnectIntentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property QnAIntentConfiguration. 
        /// <para>
        /// Specifies the configuration of the built-in <c>Amazon.QnAIntent</c>. The <c>AMAZON.QnAIntent</c>
        /// intent is called when Amazon Lex can't determine another intent to invoke. If you
        /// specify this field, you can't specify the <c>kendraConfiguration</c> field.
        /// </para>
        /// </summary>
        public QnAIntentConfiguration QnAIntentConfiguration
        {
            get { return this._qnaIntentConfiguration; }
            set { this._qnaIntentConfiguration = value; }
        }

        // Check to see if QnAIntentConfiguration property is set
        internal bool IsSetQnAIntentConfiguration()
        {
            return this._qnaIntentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SampleUtterances. 
        /// <para>
        /// New utterances used to invoke the intent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SampleUtterance> SampleUtterances
        {
            get { return this._sampleUtterances; }
            set { this._sampleUtterances = value; }
        }

        // Check to see if SampleUtterances property is set
        internal bool IsSetSampleUtterances()
        {
            return this._sampleUtterances != null && (this._sampleUtterances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SlotPriorities. 
        /// <para>
        /// A new list of slots and their priorities that are contained by the intent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SlotPriority> SlotPriorities
        {
            get { return this._slotPriorities; }
            set { this._slotPriorities = value; }
        }

        // Check to see if SlotPriorities property is set
        internal bool IsSetSlotPriorities()
        {
            return this._slotPriorities != null && (this._slotPriorities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}