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
    /// Configuration setting for a response sent to the user before Amazon Lex starts eliciting
    /// slots.
    /// </summary>
    public partial class InitialResponseSetting
    {
        private DialogCodeHookInvocationSetting _codeHook;
        private ConditionalSpecification _conditional;
        private ResponseSpecification _initialResponse;
        private DialogState _nextStep;

        /// <summary>
        /// Gets and sets the property CodeHook.
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
        /// Gets and sets the property Conditional.
        /// </summary>
        public ConditionalSpecification Conditional
        {
            get { return this._conditional; }
            set { this._conditional = value; }
        }

        // Check to see if Conditional property is set
        internal bool IsSetConditional()
        {
            return this._conditional != null;
        }

        /// <summary>
        /// Gets and sets the property InitialResponse.
        /// </summary>
        public ResponseSpecification InitialResponse
        {
            get { return this._initialResponse; }
            set { this._initialResponse = value; }
        }

        // Check to see if InitialResponse property is set
        internal bool IsSetInitialResponse()
        {
            return this._initialResponse != null;
        }

        /// <summary>
        /// Gets and sets the property NextStep. 
        /// <para>
        /// The next step in the conversation.
        /// </para>
        /// </summary>
        public DialogState NextStep
        {
            get { return this._nextStep; }
            set { this._nextStep = value; }
        }

        // Check to see if NextStep property is set
        internal bool IsSetNextStep()
        {
            return this._nextStep != null;
        }

    }
}