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
    /// Provides a statement the Amazon Lex conveys to the user when the intent is successfully
    /// fulfilled.
    /// </summary>
    public partial class IntentClosingSetting
    {
        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Specifies whether an intent's closing response is used. When this field is false,
        /// the closing response isn't sent to the user. If the <c>active</c> field isn't specified,
        /// the default is true.
        /// </para>
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property ClosingResponse. 
        /// <para>
        /// The response that Amazon Lex sends to the user when the intent is complete.
        /// </para>
        /// </summary>
        public ResponseSpecification ClosingResponse { get; set; }

        /// <summary>
        /// Checks to see if the ClosingResponse property is set.
        /// </summary>
        internal bool IsSetClosingResponse() => this.ClosingResponse != null;

        /// <summary>
        /// Gets and sets the property Conditional. 
        /// <para>
        /// A list of conditional branches associated with the intent's closing response. These
        /// branches are executed when the <c>nextStep</c> attribute is set to <c>EvalutateConditional</c>.
        /// </para>
        /// </summary>
        public ConditionalSpecification Conditional { get; set; }

        /// <summary>
        /// Checks to see if the Conditional property is set.
        /// </summary>
        internal bool IsSetConditional() => this.Conditional != null;

        /// <summary>
        /// Gets and sets the property NextStep. 
        /// <para>
        /// Specifies the next step that the bot executes after playing the intent's closing response.
        /// </para>
        /// </summary>
        public DialogState NextStep { get; set; }

        /// <summary>
        /// Checks to see if the NextStep property is set.
        /// </summary>
        internal bool IsSetNextStep() => this.NextStep != null;
    }
}
