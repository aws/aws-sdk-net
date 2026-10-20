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
    /// Configuration setting for a response sent to the user before Amazon Lex starts eliciting
    /// slots.
    /// </summary>
    public partial class InitialResponseSetting
    {
        /// <summary>
        /// Gets and sets the property CodeHook.
        /// </summary>
        public DialogCodeHookInvocationSetting CodeHook { get; set; }

        /// <summary>
        /// Checks to see if the CodeHook property is set.
        /// </summary>
        internal bool IsSetCodeHook() => this.CodeHook != null;

        /// <summary>
        /// Gets and sets the property Conditional.
        /// </summary>
        public ConditionalSpecification Conditional { get; set; }

        /// <summary>
        /// Checks to see if the Conditional property is set.
        /// </summary>
        internal bool IsSetConditional() => this.Conditional != null;

        /// <summary>
        /// Gets and sets the property InitialResponse.
        /// </summary>
        public ResponseSpecification InitialResponse { get; set; }

        /// <summary>
        /// Checks to see if the InitialResponse property is set.
        /// </summary>
        internal bool IsSetInitialResponse() => this.InitialResponse != null;

        /// <summary>
        /// Gets and sets the property NextStep. 
        /// <para>
        /// The next step in the conversation.
        /// </para>
        /// </summary>
        public DialogState NextStep { get; set; }

        /// <summary>
        /// Checks to see if the NextStep property is set.
        /// </summary>
        internal bool IsSetNextStep() => this.NextStep != null;
    }
}
