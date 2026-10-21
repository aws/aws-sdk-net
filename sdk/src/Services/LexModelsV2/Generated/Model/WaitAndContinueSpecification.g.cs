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
    /// Specifies the prompts that Amazon Lex uses while a bot is waiting for customer input.
    /// </summary>
    public partial class WaitAndContinueSpecification
    {
        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Specifies whether the bot will wait for a user to respond. When this field is false,
        /// wait and continue responses for a slot aren't used. If the <c>active</c> field isn't
        /// specified, the default is true.
        /// </para>
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property ContinueResponse. 
        /// <para>
        /// The response that Amazon Lex sends to indicate that the bot is ready to continue the
        /// conversation. Required unless the bot locale's <c>assistedNluMode</c> is <c>DialogManager</c>.
        /// </para>
        /// </summary>
        public ResponseSpecification ContinueResponse { get; set; }

        /// <summary>
        /// Checks to see if the ContinueResponse property is set.
        /// </summary>
        internal bool IsSetContinueResponse() => this.ContinueResponse != null;

        /// <summary>
        /// Gets and sets the property StillWaitingResponse. 
        /// <para>
        /// A response that Amazon Lex sends periodically to the user to indicate that the bot
        /// is still waiting for input from the user.
        /// </para>
        /// </summary>
        public StillWaitingResponseSpecification StillWaitingResponse { get; set; }

        /// <summary>
        /// Checks to see if the StillWaitingResponse property is set.
        /// </summary>
        internal bool IsSetStillWaitingResponse() => this.StillWaitingResponse != null;

        /// <summary>
        /// Gets and sets the property WaitingResponse. 
        /// <para>
        /// The response that Amazon Lex sends to indicate that the bot is waiting for the conversation
        /// to continue. Required unless the bot locale's <c>assistedNluMode</c> is <c>DialogManager</c>.
        /// </para>
        /// </summary>
        public ResponseSpecification WaitingResponse { get; set; }

        /// <summary>
        /// Checks to see if the WaitingResponse property is set.
        /// </summary>
        internal bool IsSetWaitingResponse() => this.WaitingResponse != null;
    }
}
