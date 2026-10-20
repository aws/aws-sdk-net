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
    /// Settings used when Amazon Lex successfully captures a slot value from a user.
    /// </summary>
    public partial class SlotCaptureSetting
    {
        /// <summary>
        /// Gets and sets the property CaptureConditional. 
        /// <para>
        /// A list of conditional branches to evaluate after the slot value is captured.
        /// </para>
        /// </summary>
        public ConditionalSpecification CaptureConditional { get; set; }

        /// <summary>
        /// Checks to see if the CaptureConditional property is set.
        /// </summary>
        internal bool IsSetCaptureConditional() => this.CaptureConditional != null;

        /// <summary>
        /// Gets and sets the property CaptureNextStep. 
        /// <para>
        /// Specifies the next step that the bot runs when the slot value is captured before the
        /// code hook times out.
        /// </para>
        /// </summary>
        public DialogState CaptureNextStep { get; set; }

        /// <summary>
        /// Checks to see if the CaptureNextStep property is set.
        /// </summary>
        internal bool IsSetCaptureNextStep() => this.CaptureNextStep != null;

        /// <summary>
        /// Gets and sets the property CaptureResponse.
        /// </summary>
        public ResponseSpecification CaptureResponse { get; set; }

        /// <summary>
        /// Checks to see if the CaptureResponse property is set.
        /// </summary>
        internal bool IsSetCaptureResponse() => this.CaptureResponse != null;

        /// <summary>
        /// Gets and sets the property CodeHook. 
        /// <para>
        /// Code hook called after Amazon Lex successfully captures a slot value.
        /// </para>
        /// </summary>
        public DialogCodeHookInvocationSetting CodeHook { get; set; }

        /// <summary>
        /// Checks to see if the CodeHook property is set.
        /// </summary>
        internal bool IsSetCodeHook() => this.CodeHook != null;

        /// <summary>
        /// Gets and sets the property ElicitationCodeHook. 
        /// <para>
        /// Code hook called when Amazon Lex doesn't capture a slot value.
        /// </para>
        /// </summary>
        public ElicitationCodeHookInvocationSetting ElicitationCodeHook { get; set; }

        /// <summary>
        /// Checks to see if the ElicitationCodeHook property is set.
        /// </summary>
        internal bool IsSetElicitationCodeHook() => this.ElicitationCodeHook != null;

        /// <summary>
        /// Gets and sets the property FailureConditional. 
        /// <para>
        /// A list of conditional branches to evaluate when the slot value isn't captured.
        /// </para>
        /// </summary>
        public ConditionalSpecification FailureConditional { get; set; }

        /// <summary>
        /// Checks to see if the FailureConditional property is set.
        /// </summary>
        internal bool IsSetFailureConditional() => this.FailureConditional != null;

        /// <summary>
        /// Gets and sets the property FailureNextStep. 
        /// <para>
        /// Specifies the next step that the bot runs when the slot value code is not recognized.
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
    }
}
