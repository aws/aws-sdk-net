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
    /// Provides a prompt for making sure that the user is ready for the intent to be fulfilled.
    /// </summary>
    public partial class IntentConfirmationSetting
    {
        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Specifies whether the intent's confirmation is sent to the user. When this field is
        /// false, confirmation and declination responses aren't sent. If the <c>active</c> field
        /// isn't specified, the default is true.
        /// </para>
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property CodeHook. 
        /// <para>
        /// The <c>DialogCodeHookInvocationSetting</c> object associated with intent's confirmation
        /// step. The dialog code hook is triggered based on these invocation settings when the
        /// confirmation next step or declination next step or failure next step is <c>InvokeDialogCodeHook</c>.
        /// 
        /// </para>
        /// </summary>
        public DialogCodeHookInvocationSetting CodeHook { get; set; }

        /// <summary>
        /// Checks to see if the CodeHook property is set.
        /// </summary>
        internal bool IsSetCodeHook() => this.CodeHook != null;

        /// <summary>
        /// Gets and sets the property ConfirmationConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the intent is closed.
        /// </para>
        /// </summary>
        public ConditionalSpecification ConfirmationConditional { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationConditional property is set.
        /// </summary>
        internal bool IsSetConfirmationConditional() => this.ConfirmationConditional != null;

        /// <summary>
        /// Gets and sets the property ConfirmationNextStep. 
        /// <para>
        /// Specifies the next step that the bot executes when the customer confirms the intent.
        /// </para>
        /// </summary>
        public DialogState ConfirmationNextStep { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationNextStep property is set.
        /// </summary>
        internal bool IsSetConfirmationNextStep() => this.ConfirmationNextStep != null;

        /// <summary>
        /// Gets and sets the property ConfirmationResponse.
        /// </summary>
        public ResponseSpecification ConfirmationResponse { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationResponse property is set.
        /// </summary>
        internal bool IsSetConfirmationResponse() => this.ConfirmationResponse != null;

        /// <summary>
        /// Gets and sets the property DeclinationConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the intent is declined.
        /// </para>
        /// </summary>
        public ConditionalSpecification DeclinationConditional { get; set; }

        /// <summary>
        /// Checks to see if the DeclinationConditional property is set.
        /// </summary>
        internal bool IsSetDeclinationConditional() => this.DeclinationConditional != null;

        /// <summary>
        /// Gets and sets the property DeclinationNextStep. 
        /// <para>
        /// Specifies the next step that the bot executes when the customer declines the intent.
        /// </para>
        /// </summary>
        public DialogState DeclinationNextStep { get; set; }

        /// <summary>
        /// Checks to see if the DeclinationNextStep property is set.
        /// </summary>
        internal bool IsSetDeclinationNextStep() => this.DeclinationNextStep != null;

        /// <summary>
        /// Gets and sets the property DeclinationResponse. 
        /// <para>
        /// When the user answers "no" to the question defined in <c>promptSpecification</c>,
        /// Amazon Lex responds with this response to acknowledge that the intent was canceled.
        /// 
        /// </para>
        /// </summary>
        public ResponseSpecification DeclinationResponse { get; set; }

        /// <summary>
        /// Checks to see if the DeclinationResponse property is set.
        /// </summary>
        internal bool IsSetDeclinationResponse() => this.DeclinationResponse != null;

        /// <summary>
        /// Gets and sets the property ElicitationCodeHook. 
        /// <para>
        /// The <c>DialogCodeHookInvocationSetting</c> used when the code hook is invoked during
        /// confirmation prompt retries.
        /// </para>
        /// </summary>
        public ElicitationCodeHookInvocationSetting ElicitationCodeHook { get; set; }

        /// <summary>
        /// Checks to see if the ElicitationCodeHook property is set.
        /// </summary>
        internal bool IsSetElicitationCodeHook() => this.ElicitationCodeHook != null;

        /// <summary>
        /// Gets and sets the property FailureConditional.
        /// </summary>
        public ConditionalSpecification FailureConditional { get; set; }

        /// <summary>
        /// Checks to see if the FailureConditional property is set.
        /// </summary>
        internal bool IsSetFailureConditional() => this.FailureConditional != null;

        /// <summary>
        /// Gets and sets the property FailureNextStep. 
        /// <para>
        /// The next step to take in the conversation if the confirmation step fails.
        /// </para>
        /// </summary>
        public DialogState FailureNextStep { get; set; }

        /// <summary>
        /// Checks to see if the FailureNextStep property is set.
        /// </summary>
        internal bool IsSetFailureNextStep() => this.FailureNextStep != null;

        /// <summary>
        /// Gets and sets the property FailureResponse.
        /// </summary>
        public ResponseSpecification FailureResponse { get; set; }

        /// <summary>
        /// Checks to see if the FailureResponse property is set.
        /// </summary>
        internal bool IsSetFailureResponse() => this.FailureResponse != null;

        /// <summary>
        /// Gets and sets the property PromptSpecification. 
        /// <para>
        /// Prompts the user to confirm the intent. This question should have a yes or no answer.
        /// </para>
        ///  
        /// <para>
        /// Amazon Lex uses this prompt to ensure that the user acknowledges that the intent is
        /// ready for fulfillment. For example, with the <c>OrderPizza</c> intent, you might want
        /// to confirm that the order is correct before placing it. For other intents, such as
        /// intents that simply respond to user questions, you might not need to ask the user
        /// for confirmation before providing the information. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PromptSpecification PromptSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PromptSpecification property is set.
        /// </summary>
        internal bool IsSetPromptSpecification() => this.PromptSpecification != null;
    }
}
