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
    /// This is the response object from the DescribeIntent operation.
    /// </summary>
    public partial class DescribeIntentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot associated with the intent.
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
        /// The version of the bot associated with the intent.
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
        /// A timestamp of the date and time that the intent was created.
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
        /// The description of the intent.
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
        /// The Lambda function called during each turn of a conversation with the intent.
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
        /// The Lambda function called when the intent is complete and ready for fulfillment.
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
        /// Configuration setting for a response sent to the user before Amazon Lex starts eliciting
        /// slots.
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
        /// A list of contexts that must be active for the intent to be considered for sending
        /// to the user.
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
        /// The response that Amazon Lex sends to when the intent is closed.
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
        /// Prompts that Amazon Lex sends to the user to confirm completion of an intent.
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
        /// The display name specified for the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IntentDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the IntentDisplayName property is set.
        /// </summary>
        internal bool IsSetIntentDisplayName() => this.IntentDisplayName != null;

        /// <summary>
        /// Gets and sets the property IntentId. 
        /// <para>
        /// The unique identifier assigned to the intent when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string IntentId { get; set; }

        /// <summary>
        /// Checks to see if the IntentId property is set.
        /// </summary>
        internal bool IsSetIntentId() => this.IntentId != null;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The name specified for the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property KendraConfiguration. 
        /// <para>
        /// Configuration information required to use the <c>AMAZON.KendraSearchIntent</c> intent.
        /// </para>
        /// </summary>
        public KendraConfiguration KendraConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KendraConfiguration property is set.
        /// </summary>
        internal bool IsSetKendraConfiguration() => this.KendraConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// A timestamp of the date and time that the intent was last updated.
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
        /// The language and locale specified for the intent.
        /// </para>
        /// </summary>
        public string LocaleId { get; set; }

        /// <summary>
        /// Checks to see if the LocaleId property is set.
        /// </summary>
        internal bool IsSetLocaleId() => this.LocaleId != null;

        /// <summary>
        /// Gets and sets the property OutputContexts. 
        /// <para>
        /// A list of contexts that are activated when the intent is fulfilled.
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
        /// The identifier of the built-in intent that this intent is derived from, if any.
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
        /// Qinconnect intent configuration details for the describe intent response.
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
        /// Details about the configuration of the built-in <c>Amazon.QnAIntent</c>.
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
        /// User utterances that trigger this intent.
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

        /// <summary>
        /// Gets and sets the property SlotPriorities. 
        /// <para>
        /// The list that determines the priority that slots should be elicited from the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SlotPriority> SlotPriorities { get; set; } = AWSConfigs.InitializeCollections ? new List<SlotPriority>() : null;

        /// <summary>
        /// Checks to see if the SlotPriorities property is set.
        /// </summary>
        internal bool IsSetSlotPriorities() => this.SlotPriorities != null && (this.SlotPriorities.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
