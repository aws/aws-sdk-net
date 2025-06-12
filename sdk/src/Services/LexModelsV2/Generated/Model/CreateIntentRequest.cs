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
    /// Container for the parameters to the CreateIntent operation.
    /// Creates an intent.
    /// 
    ///  
    /// <para>
    /// To define the interaction between the user and your bot, you define one or more intents.
    /// For example, for a pizza ordering bot you would create an <c>OrderPizza</c> intent.
    /// </para>
    ///  
    /// <para>
    /// When you create an intent, you must provide a name. You can optionally provide the
    /// following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Sample utterances. For example, "I want to order a pizza" and "Can I order a pizza."
    /// You can't provide utterances for built-in intents.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Information to be gathered. You specify slots for the information that you bot requests
    /// from the user. You can specify standard slot types, such as date and time, or custom
    /// slot types for your application.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How the intent is fulfilled. You can provide a Lambda function or configure the intent
    /// to return the intent information to your client application. If you use a Lambda function,
    /// Amazon Lex invokes the function when all of the intent information is available.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A confirmation prompt to send to the user to confirm an intent. For example, "Shall
    /// I order your pizza?"
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A conclusion statement to send to the user after the intent is fulfilled. For example,
    /// "I ordered your pizza."
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A follow-up prompt that asks the user for additional activity. For example, "Do you
    /// want a drink with your pizza?"
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateIntentRequest : AmazonLexModelsV2Request
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
        private string _intentName;
        private KendraConfiguration _kendraConfiguration;
        private string _localeId;
        private List<OutputContext> _outputContexts = AWSConfigs.InitializeCollections ? new List<OutputContext>() : null;
        private string _parentIntentSignature;
        private QInConnectIntentConfiguration _qInConnectIntentConfiguration;
        private QnAIntentConfiguration _qnaIntentConfiguration;
        private List<SampleUtterance> _sampleUtterances = AWSConfigs.InitializeCollections ? new List<SampleUtterance>() : null;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with this intent.
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
        /// The version of the bot associated with this intent.
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
        /// A description of the intent. Use the description to help identify the intent in lists.
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
        /// Specifies that Amazon Lex invokes the alias Lambda function for each user input. You
        /// can invoke this Lambda function to personalize user interaction.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose that your bot determines that the user's name is John. You Lambda
        /// function might retrieve John's information from a backend database and prepopulate
        /// some of the values. For example, if you find that John is gluten intolerant, you might
        /// set the corresponding intent slot, <c>glutenIntolerant</c> to <c>true</c>. You might
        /// find John's phone number and set the corresponding session attribute.
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
        /// Specifies that Amazon Lex invokes the alias Lambda function when the intent is ready
        /// for fulfillment. You can invoke this function to complete the bot's transaction with
        /// the user.
        /// </para>
        ///  
        /// <para>
        /// For example, in a pizza ordering bot, the Lambda function can look up the closest
        /// pizza restaurant to the customer's location and then place an order on the customer's
        /// behalf.
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
        /// Configuration settings for the response that is sent to the user at the beginning
        /// of a conversation, before eliciting slot values.
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
        /// A list of contexts that must be active for this intent to be considered by Amazon
        /// Lex.
        /// </para>
        ///  
        /// <para>
        /// When an intent has an input context list, Amazon Lex only considers using the intent
        /// in an interaction with the user when the specified contexts are included in the active
        /// context list for the session. If the contexts are not active, then Amazon Lex will
        /// not use the intent.
        /// </para>
        ///  
        /// <para>
        /// A context can be automatically activated using the <c>outputContexts</c> property
        /// or it can be set at runtime.
        /// </para>
        ///  
        /// <para>
        ///  For example, if there are two intents with different input contexts that respond
        /// to the same utterances, only the intent with the active context will respond.
        /// </para>
        ///  
        /// <para>
        /// An intent may have up to 5 input contexts. If an intent has multiple input contexts,
        /// all of the contexts must be active to consider the intent.
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
        /// Sets the response that Amazon Lex sends to the user when the intent is closed.
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
        /// Provides prompts that Amazon Lex sends to the user to confirm the completion of an
        /// intent. If the user answers "no," the settings contain a statement that is sent to
        /// the user to end the intent.
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
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent. Intent names must be unique in the locale that contains the
        /// intent and cannot match the name of any built-in intent.
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
        /// Configuration information required to use the <c>AMAZON.KendraSearchIntent</c> intent
        /// to connect to an Amazon Kendra index. The <c>AMAZON.KendraSearchIntent</c> intent
        /// is called when Amazon Lex can't determine another intent to invoke.
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
        /// The identifier of the language and locale where this intent is used. All of the bots,
        /// slot types, and slots used by the intent must have the same locale. For more information,
        /// see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
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
        /// A lists of contexts that the intent activates when it is fulfilled.
        /// </para>
        ///  
        /// <para>
        /// You can use an output context to indicate the intents that Amazon Lex should consider
        /// for the next turn of the conversation with a customer. 
        /// </para>
        ///  
        /// <para>
        /// When you use the <c>outputContextsList</c> property, all of the contexts specified
        /// in the list are activated when the intent is fulfilled. You can set up to 10 output
        /// contexts. You can also set the number of conversation turns that the context should
        /// be active, or the length of time that the context should be active.
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
        /// A unique identifier for the built-in intent to base this intent on.
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
        /// Qinconnect intent configuration details for the create intent request.
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
        /// An array of strings that a user might say to signal the intent. For example, "I want
        /// a pizza", or "I want a {PizzaSize} pizza". 
        /// </para>
        ///  
        /// <para>
        /// In an utterance, slot names are enclosed in curly braces ("{", "}") to indicate where
        /// they should be displayed in the utterance shown to the user.. 
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

    }
}