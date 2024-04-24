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
    /// Settings used when Amazon Lex successfully captures a slot value from a user.
    /// </summary>
    public partial class SlotCaptureSetting
    {
        private ConditionalSpecification _captureConditional;
        private DialogState _captureNextStep;
        private ResponseSpecification _captureResponse;
        private DialogCodeHookInvocationSetting _codeHook;
        private ElicitationCodeHookInvocationSetting _elicitationCodeHook;
        private ConditionalSpecification _failureConditional;
        private DialogState _failureNextStep;
        private ResponseSpecification _failureResponse;

        /// <summary>
        /// Gets and sets the property CaptureConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the slot value is captured.
        /// </para>
        /// </summary>
        public ConditionalSpecification CaptureConditional
        {
            get { return this._captureConditional; }
            set { this._captureConditional = value; }
        }

        // Check to see if CaptureConditional property is set
        internal bool IsSetCaptureConditional()
        {
            return this._captureConditional != null;
        }

        /// <summary>
        /// Gets and sets the property CaptureNextStep. 
        /// <para>
        /// Specifies the next step that the bot runs when the slot value is captured before the
        /// code hook times out.
        /// </para>
        /// </summary>
        public DialogState CaptureNextStep
        {
            get { return this._captureNextStep; }
            set { this._captureNextStep = value; }
        }

        // Check to see if CaptureNextStep property is set
        internal bool IsSetCaptureNextStep()
        {
            return this._captureNextStep != null;
        }

        /// <summary>
        /// Gets and sets the property CaptureResponse.
        /// </summary>
        public ResponseSpecification CaptureResponse
        {
            get { return this._captureResponse; }
            set { this._captureResponse = value; }
        }

        // Check to see if CaptureResponse property is set
        internal bool IsSetCaptureResponse()
        {
            return this._captureResponse != null;
        }

        /// <summary>
        /// Gets and sets the property CodeHook. 
        /// <para>
        /// Code hook called after Amazon Lex successfully captures a slot value.
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
        /// Gets and sets the property ElicitationCodeHook. 
        /// <para>
        /// Code hook called when Amazon Lex doesn't capture a slot value.
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
        /// <para>
        /// A list of conditional branches to evaluate when the slot value isn't captured.
        /// </para>
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
        /// Specifies the next step that the bot runs when the slot value code is not recognized.
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

    }
}