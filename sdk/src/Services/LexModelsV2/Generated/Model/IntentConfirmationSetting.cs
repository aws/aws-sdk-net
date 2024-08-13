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
    /// Provides a prompt for making sure that the user is ready for the intent to be fulfilled.
    /// </summary>
    public partial class IntentConfirmationSetting
    {
        private bool? _active;
        private DialogCodeHookInvocationSetting _codeHook;
        private ConditionalSpecification _confirmationConditional;
        private DialogState _confirmationNextStep;
        private ResponseSpecification _confirmationResponse;
        private ConditionalSpecification _declinationConditional;
        private DialogState _declinationNextStep;
        private ResponseSpecification _declinationResponse;
        private ElicitationCodeHookInvocationSetting _elicitationCodeHook;
        private ConditionalSpecification _failureConditional;
        private DialogState _failureNextStep;
        private ResponseSpecification _failureResponse;
        private PromptSpecification _promptSpecification;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Specifies whether the intent's confirmation is sent to the user. When this field is
        /// false, confirmation and declination responses aren't sent. If the <c>active</c> field
        /// isn't specified, the default is true.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodeHook. 
        /// <para>
        /// The <c>DialogCodeHookInvocationSetting</c> object associated with intent's confirmation
        /// step. The dialog code hook is triggered based on these invocation settings when the
        /// confirmation next step or declination next step or failure next step is <c>InvokeDialogCodeHook</c>.
        /// 
        /// </para>
        /// </summary>
        public DialogCodeHookInvocationSetting CodeHook
        {
            get { return this._codeHook; }
            set { this._codeHook = value; }
        }

        // Check to see if CodeHook property is set
        internal bool IsSetCodeHook()
        {
            return this._codeHook != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the intent is closed.
        /// </para>
        /// </summary>
        public ConditionalSpecification ConfirmationConditional
        {
            get { return this._confirmationConditional; }
            set { this._confirmationConditional = value; }
        }

        // Check to see if ConfirmationConditional property is set
        internal bool IsSetConfirmationConditional()
        {
            return this._confirmationConditional != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationNextStep. 
        /// <para>
        /// Specifies the next step that the bot executes when the customer confirms the intent.
        /// </para>
        /// </summary>
        public DialogState ConfirmationNextStep
        {
            get { return this._confirmationNextStep; }
            set { this._confirmationNextStep = value; }
        }

        // Check to see if ConfirmationNextStep property is set
        internal bool IsSetConfirmationNextStep()
        {
            return this._confirmationNextStep != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationResponse.
        /// </summary>
        public ResponseSpecification ConfirmationResponse
        {
            get { return this._confirmationResponse; }
            set { this._confirmationResponse = value; }
        }

        // Check to see if ConfirmationResponse property is set
        internal bool IsSetConfirmationResponse()
        {
            return this._confirmationResponse != null;
        }

        /// <summary>
        /// Gets and sets the property DeclinationConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the intent is declined.
        /// </para>
        /// </summary>
        public ConditionalSpecification DeclinationConditional
        {
            get { return this._declinationConditional; }
            set { this._declinationConditional = value; }
        }

        // Check to see if DeclinationConditional property is set
        internal bool IsSetDeclinationConditional()
        {
            return this._declinationConditional != null;
        }

        /// <summary>
        /// Gets and sets the property DeclinationNextStep. 
        /// <para>
        /// Specifies the next step that the bot executes when the customer declines the intent.
        /// </para>
        /// </summary>
        public DialogState DeclinationNextStep
        {
            get { return this._declinationNextStep; }
            set { this._declinationNextStep = value; }
        }

        // Check to see if DeclinationNextStep property is set
        internal bool IsSetDeclinationNextStep()
        {
            return this._declinationNextStep != null;
        }

        /// <summary>
        /// Gets and sets the property DeclinationResponse. 
        /// <para>
        /// When the user answers "no" to the question defined in <c>promptSpecification</c>,
        /// Amazon Lex responds with this response to acknowledge that the intent was canceled.
        /// 
        /// </para>
        /// </summary>
        public ResponseSpecification DeclinationResponse
        {
            get { return this._declinationResponse; }
            set { this._declinationResponse = value; }
        }

        // Check to see if DeclinationResponse property is set
        internal bool IsSetDeclinationResponse()
        {
            return this._declinationResponse != null;
        }

        /// <summary>
        /// Gets and sets the property ElicitationCodeHook. 
        /// <para>
        /// The <c>DialogCodeHookInvocationSetting</c> used when the code hook is invoked during
        /// confirmation prompt retries.
        /// </para>
        /// </summary>
        public ElicitationCodeHookInvocationSetting ElicitationCodeHook
        {
            get { return this._elicitationCodeHook; }
            set { this._elicitationCodeHook = value; }
        }

        // Check to see if ElicitationCodeHook property is set
        internal bool IsSetElicitationCodeHook()
        {
            return this._elicitationCodeHook != null;
        }

        /// <summary>
        /// Gets and sets the property FailureConditional.
        /// </summary>
        public ConditionalSpecification FailureConditional
        {
            get { return this._failureConditional; }
            set { this._failureConditional = value; }
        }

        // Check to see if FailureConditional property is set
        internal bool IsSetFailureConditional()
        {
            return this._failureConditional != null;
        }

        /// <summary>
        /// Gets and sets the property FailureNextStep. 
        /// <para>
        /// The next step to take in the conversation if the confirmation step fails.
        /// </para>
        /// </summary>
        public DialogState FailureNextStep
        {
            get { return this._failureNextStep; }
            set { this._failureNextStep = value; }
        }

        // Check to see if FailureNextStep property is set
        internal bool IsSetFailureNextStep()
        {
            return this._failureNextStep != null;
        }

        /// <summary>
        /// Gets and sets the property FailureResponse.
        /// </summary>
        public ResponseSpecification FailureResponse
        {
            get { return this._failureResponse; }
            set { this._failureResponse = value; }
        }

        // Check to see if FailureResponse property is set
        internal bool IsSetFailureResponse()
        {
            return this._failureResponse != null;
        }

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
        [AWSProperty(Required=true)]
        public PromptSpecification PromptSpecification
        {
            get { return this._promptSpecification; }
            set { this._promptSpecification = value; }
        }

        // Check to see if PromptSpecification property is set
        internal bool IsSetPromptSpecification()
        {
            return this._promptSpecification != null;
        }

    }
}