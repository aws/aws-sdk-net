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
    /// Container for the parameters to the CreateIntent operation. Creates an intent. <para>
    /// To define the interaction between the user and your bot, you define one or more intents.
    /// For example, for a pizza ordering bot you would create an <c>OrderPizza</c> intent.
    /// </para> <para> When you create an intent, you must provide a name. You can optionally
    /// provide the following: </para> <ul> <li> <para> Sample utterances. For example, "I
    /// want to order a pizza" and "Can I order a pizza." You can't provide utterances for
    /// built-in intents. </para> </li> <li> <para> Information to be gathered. You specify
    /// slots for the information that you bot requests from the user. You can specify standard
    /// slot types, such as date and time, or custom slot types for your application. </para>
    /// </li> <li> <para> How the intent is fulfilled. You can provide a Lambda function or
    /// configure the intent to return the intent information to your client application.
    /// If you use a Lambda function, Amazon Lex invokes the function when all of the intent
    /// information is available. </para> </li> <li> <para> A confirmation prompt to send
    /// to the user to confirm an intent. For example, "Shall I order your pizza?" </para>
    /// </li> <li> <para> A conclusion statement to send to the user after the intent is fulfilled.
    /// For example, "I ordered your pizza." </para> </li> <li> <para> A follow-up prompt
    /// that asks the user for additional activity. For example, "Do you want a drink with
    /// your pizza?" </para> </li> </ul>
    /// </summary>
    public partial class CreateIntentRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with this intent.
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
        /// The version of the bot associated with this intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the intent. Use the description to help identify the intent in lists.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        public DialogCodeHookSettings DialogCodeHook { get; set; }

        /// <summary>
        /// Checks to see if the DialogCodeHook property is set.
        /// </summary>
        internal bool IsSetDialogCodeHook() => this.DialogCodeHook != null;

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
        public FulfillmentCodeHookSettings FulfillmentCodeHook { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentCodeHook property is set.
        /// </summary>
        internal bool IsSetFulfillmentCodeHook() => this.FulfillmentCodeHook != null;

        /// <summary>
        /// Gets and sets the property InitialResponseSetting. 
        /// <para>
        /// Configuration settings for the response that is sent to the user at the beginning
        /// of a conversation, before eliciting slot values.
        /// </para>
        /// </summary>
        public InitialResponseSetting InitialResponseSetting { get; set; }

        /// <summary>
        /// Checks to see if the InitialResponseSetting property is set.
        /// </summary>
        internal bool IsSetInitialResponseSetting() => this.InitialResponseSetting != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<InputContext> InputContexts { get; set; } = AWSConfigs.InitializeCollections ? new List<InputContext>() : null;

        /// <summary>
        /// Checks to see if the InputContexts property is set.
        /// </summary>
        internal bool IsSetInputContexts() => this.InputContexts != null && (this.InputContexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntentClosingSetting. 
        /// <para>
        /// Sets the response that Amazon Lex sends to the user when the intent is closed.
        /// </para>
        /// </summary>
        public IntentClosingSetting IntentClosingSetting { get; set; }

        /// <summary>
        /// Checks to see if the IntentClosingSetting property is set.
        /// </summary>
        internal bool IsSetIntentClosingSetting() => this.IntentClosingSetting != null;

        /// <summary>
        /// Gets and sets the property IntentConfirmationSetting. 
        /// <para>
        /// Provides prompts that Amazon Lex sends to the user to confirm the completion of an
        /// intent. If the user answers "no," the settings contain a statement that is sent to
        /// the user to end the intent.
        /// </para>
        /// </summary>
        public IntentConfirmationSetting IntentConfirmationSetting { get; set; }

        /// <summary>
        /// Checks to see if the IntentConfirmationSetting property is set.
        /// </summary>
        internal bool IsSetIntentConfirmationSetting() => this.IntentConfirmationSetting != null;

        /// <summary>
        /// Gets and sets the property IntentDisplayName. 
        /// <para>
        /// A display name for the intent. If configured, This name will be shown to users during
        /// Intent Disambiguation instead of the intent name. Display names should be user-friendly,
        /// descriptive and match the intent's purpose to improve user experience during disambiguation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IntentDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the IntentDisplayName property is set.
        /// </summary>
        internal bool IsSetIntentDisplayName() => this.IntentDisplayName != null;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name of the intent. Intent names must be unique in the locale that contains the
        /// intent and cannot match the name of any built-in intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property KendraConfiguration. 
        /// <para>
        /// Configuration information required to use the <c>AMAZON.KendraSearchIntent</c> intent
        /// to connect to an Amazon Kendra index. The <c>AMAZON.KendraSearchIntent</c> intent
        /// is called when Amazon Lex can't determine another intent to invoke.
        /// </para>
        /// </summary>
        public KendraConfiguration KendraConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KendraConfiguration property is set.
        /// </summary>
        internal bool IsSetKendraConfiguration() => this.KendraConfiguration != null;

        /// <summary>
        /// Gets and sets the property LocaleId. 
        /// <para>
        /// The identifier of the language and locale where this intent is used. All of the bots,
        /// slot types, and slots used by the intent must have the same locale. For more information,
        /// see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/how-languages.html">Supported
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<OutputContext> OutputContexts { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputContext>() : null;

        /// <summary>
        /// Checks to see if the OutputContexts property is set.
        /// </summary>
        internal bool IsSetOutputContexts() => this.OutputContexts != null && (this.OutputContexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentIntentSignature. 
        /// <para>
        /// A unique identifier for the built-in intent to base this intent on.
        /// </para>
        /// </summary>
        public string ParentIntentSignature { get; set; }

        /// <summary>
        /// Checks to see if the ParentIntentSignature property is set.
        /// </summary>
        internal bool IsSetParentIntentSignature() => this.ParentIntentSignature != null;

        /// <summary>
        /// Gets and sets the property QInConnectIntentConfiguration. 
        /// <para>
        /// Qinconnect intent configuration details for the create intent request.
        /// </para>
        /// </summary>
        public QInConnectIntentConfiguration QInConnectIntentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QInConnectIntentConfiguration property is set.
        /// </summary>
        internal bool IsSetQInConnectIntentConfiguration() => this.QInConnectIntentConfiguration != null;

        /// <summary>
        /// Gets and sets the property QnAIntentConfiguration. 
        /// <para>
        /// Specifies the configuration of the built-in <c>Amazon.QnAIntent</c>. The <c>AMAZON.QnAIntent</c>
        /// intent is called when Amazon Lex can't determine another intent to invoke. If you
        /// specify this field, you can't specify the <c>kendraConfiguration</c> field.
        /// </para>
        /// </summary>
        public QnAIntentConfiguration QnAIntentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QnAIntentConfiguration property is set.
        /// </summary>
        internal bool IsSetQnAIntentConfiguration() => this.QnAIntentConfiguration != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SampleUtterance> SampleUtterances { get; set; } = AWSConfigs.InitializeCollections ? new List<SampleUtterance>() : null;

        /// <summary>
        /// Checks to see if the SampleUtterances property is set.
        /// </summary>
        internal bool IsSetSampleUtterances() => this.SampleUtterances != null && (this.SampleUtterances.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
