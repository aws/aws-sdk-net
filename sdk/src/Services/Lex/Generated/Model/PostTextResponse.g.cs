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

namespace Amazon.Lex.Model
{
    /// <summary>
    /// This is the response object from the PostText operation.
    /// </summary>
    public partial class PostTextResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// A list of active contexts for the session. A context can be set when an intent is
        /// fulfilled or by calling the <c>PostContent</c>, <c>PostText</c>, or <c>PutSession</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// You can use a context to control the intents that can follow up an intent, or to modify
        /// the operation of your application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 20)]
        public List<ActiveContext> ActiveContexts { get; set; } = AWSConfigs.InitializeCollections ? new List<ActiveContext>() : null;

        /// <summary>
        /// Checks to see if the ActiveContexts property is set.
        /// </summary>
        internal bool IsSetActiveContexts() => this.ActiveContexts != null && (this.ActiveContexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AlternativeIntents. 
        /// <para>
        /// One to four alternative intents that may be applicable to the user's intent.
        /// </para>
        ///  
        /// <para>
        /// Each alternative includes a score that indicates how confident Amazon Lex is that
        /// the intent matches the user's intent. The intents are sorted by the confidence score.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public List<PredictedIntent> AlternativeIntents { get; set; } = AWSConfigs.InitializeCollections ? new List<PredictedIntent>() : null;

        /// <summary>
        /// Checks to see if the AlternativeIntents property is set.
        /// </summary>
        internal bool IsSetAlternativeIntents() => this.AlternativeIntents != null && (this.AlternativeIntents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot that responded to the conversation. You can use this information
        /// to help determine if one version of a bot is performing better than another version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string BotVersion { get; set; }

        /// <summary>
        /// Checks to see if the BotVersion property is set.
        /// </summary>
        internal bool IsSetBotVersion() => this.BotVersion != null;

        /// <summary>
        /// Gets and sets the property DialogState. 
        /// <para>
        ///  Identifies the current state of the user interaction. Amazon Lex returns one of the
        /// following values as <c>dialogState</c>. The client can optionally use this information
        /// to customize the user interface. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ElicitIntent</c> - Amazon Lex wants to elicit user intent. 
        /// </para>
        ///  
        /// <para>
        /// For example, a user might utter an intent ("I want to order a pizza"). If Amazon Lex
        /// cannot infer the user intent from this utterance, it will return this dialogState.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConfirmIntent</c> - Amazon Lex is expecting a "yes" or "no" response. 
        /// </para>
        ///  
        /// <para>
        ///  For example, Amazon Lex wants user confirmation before fulfilling an intent. 
        /// </para>
        ///  
        /// <para>
        /// Instead of a simple "yes" or "no," a user might respond with additional information.
        /// For example, "yes, but make it thick crust pizza" or "no, I want to order a drink".
        /// Amazon Lex can process such additional information (in these examples, update the
        /// crust type slot value, or change intent from OrderPizza to OrderDrink).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ElicitSlot</c> - Amazon Lex is expecting a slot value for the current intent.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, suppose that in the response Amazon Lex sends this message: "What size
        /// pizza would you like?". A user might reply with the slot value (e.g., "medium"). The
        /// user might also provide additional information in the response (e.g., "medium thick
        /// crust pizza"). Amazon Lex can process such additional information appropriately. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Fulfilled</c> - Conveys that the Lambda function configured for the intent has
        /// successfully fulfilled the intent. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReadyForFulfillment</c> - Conveys that the client has to fulfill the intent. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - Conveys that the conversation with the user failed. 
        /// </para>
        ///  
        /// <para>
        ///  This can happen for various reasons including that the user did not provide an appropriate
        /// response to prompts from the service (you can configure how many times Amazon Lex
        /// can prompt a user for specific information), or the Lambda function failed to fulfill
        /// the intent. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DialogState DialogState { get; set; }

        /// <summary>
        /// Checks to see if the DialogState property is set.
        /// </summary>
        internal bool IsSetDialogState() => this.DialogState != null;

        /// <summary>
        /// Gets and sets the property IntentName. 
        /// <para>
        /// The current user intent that Amazon Lex is aware of.
        /// </para>
        /// </summary>
        public string IntentName { get; set; }

        /// <summary>
        /// Checks to see if the IntentName property is set.
        /// </summary>
        internal bool IsSetIntentName() => this.IntentName != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message to convey to the user. The message can come from the bot's configuration
        /// or from a Lambda function.
        /// </para>
        ///  
        /// <para>
        /// If the intent is not configured with a Lambda function, or if the Lambda function
        /// returned <c>Delegate</c> as the <c>dialogAction.type</c> its response, Amazon Lex
        /// decides on the next course of action and selects an appropriate message from the bot's
        /// configuration based on the current interaction context. For example, if Amazon Lex
        /// isn't able to understand user input, it uses a clarification prompt message.
        /// </para>
        ///  
        /// <para>
        /// When you create an intent you can assign messages to groups. When messages are assigned
        /// to groups Amazon Lex returns one message from each group in the response. The message
        /// field is an escaped JSON string containing the messages. For more information about
        /// the structure of the JSON string returned, see <a>msg-prompts-formats</a>.
        /// </para>
        ///  
        /// <para>
        /// If the Lambda function returns a message, Amazon Lex passes it to the client in its
        /// response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property MessageFormat. 
        /// <para>
        /// The format of the response message. One of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PlainText</c> - The message contains plain UTF-8 text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CustomPayload</c> - The message is a custom format defined by the Lambda function.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SSML</c> - The message contains text formatted for voice output.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Composite</c> - The message contains an escaped JSON object containing one or
        /// more messages from the groups that messages were assigned to when the intent was created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MessageFormatType MessageFormat { get; set; }

        /// <summary>
        /// Checks to see if the MessageFormat property is set.
        /// </summary>
        internal bool IsSetMessageFormat() => this.MessageFormat != null;

        /// <summary>
        /// Gets and sets the property NluIntentConfidence. 
        /// <para>
        /// Provides a score that indicates how confident Amazon Lex is that the returned intent
        /// is the one that matches the user's intent. The score is between 0.0 and 1.0. For more
        /// information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/confidence-scores.html">Confidence
        /// Scores</a>.
        /// </para>
        ///  
        /// <para>
        /// The score is a relative score, not an absolute score. The score may change based on
        /// improvements to Amazon Lex.
        /// </para>
        /// </summary>
        public IntentConfidence NluIntentConfidence { get; set; }

        /// <summary>
        /// Checks to see if the NluIntentConfidence property is set.
        /// </summary>
        internal bool IsSetNluIntentConfidence() => this.NluIntentConfidence != null;

        /// <summary>
        /// Gets and sets the property ResponseCard. 
        /// <para>
        /// Represents the options that the user has to respond to the current prompt. Response
        /// Card can come from the bot configuration (in the Amazon Lex console, choose the settings
        /// button next to a slot) or from a code hook (Lambda function). 
        /// </para>
        /// </summary>
        public ResponseCard ResponseCard { get; set; }

        /// <summary>
        /// Checks to see if the ResponseCard property is set.
        /// </summary>
        internal bool IsSetResponseCard() => this.ResponseCard != null;

        /// <summary>
        /// Gets and sets the property SentimentResponse. 
        /// <para>
        /// The sentiment expressed in and utterance.
        /// </para>
        ///  
        /// <para>
        /// When the bot is configured to send utterances to Amazon Comprehend for sentiment analysis,
        /// this field contains the result of the analysis.
        /// </para>
        /// </summary>
        public SentimentResponse SentimentResponse { get; set; }

        /// <summary>
        /// Checks to see if the SentimentResponse property is set.
        /// </summary>
        internal bool IsSetSentimentResponse() => this.SentimentResponse != null;

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// A map of key-value pairs representing the session-specific context information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> SessionAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SessionAttributes property is set.
        /// </summary>
        internal bool IsSetSessionAttributes() => this.SessionAttributes != null && (this.SessionAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique identifier for the session.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SlotToElicit. 
        /// <para>
        /// If the <c>dialogState</c> value is <c>ElicitSlot</c>, returns the name of the slot
        /// for which Amazon Lex is eliciting a value. 
        /// </para>
        /// </summary>
        public string SlotToElicit { get; set; }

        /// <summary>
        /// Checks to see if the SlotToElicit property is set.
        /// </summary>
        internal bool IsSetSlotToElicit() => this.SlotToElicit != null;

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        ///  The intent slots that Amazon Lex detected from the user input in the conversation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Amazon Lex creates a resolution list containing likely values for a slot. The value
        /// that it returns is determined by the <c>valueSelectionStrategy</c> selected when the
        /// slot type was created or updated. If <c>valueSelectionStrategy</c> is set to <c>ORIGINAL_VALUE</c>,
        /// the value provided by the user is returned, if the user value is similar to the slot
        /// values. If <c>valueSelectionStrategy</c> is set to <c>TOP_RESOLUTION</c> Amazon Lex
        /// returns the first value in the resolution list or, if there is no resolution list,
        /// null. If you don't specify a <c>valueSelectionStrategy</c>, the default is <c>ORIGINAL_VALUE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Slots { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null && (this.Slots.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
