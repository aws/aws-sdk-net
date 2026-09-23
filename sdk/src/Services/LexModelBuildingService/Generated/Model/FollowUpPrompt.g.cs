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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// A prompt for additional activity after an intent is fulfilled. For example, after
    /// the <c>OrderPizza</c> intent is fulfilled, you might prompt the user to find out whether
    /// the user wants to order drinks.
    /// </summary>
    public partial class FollowUpPrompt
    {
        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// Prompts for information from the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Prompt Prompt { get; set; }

        /// <summary>
        /// Checks to see if the Prompt property is set.
        /// </summary>
        internal bool IsSetPrompt() => this.Prompt != null;

        /// <summary>
        /// Gets and sets the property RejectionStatement. 
        /// <para>
        /// If the user answers "no" to the question defined in the <c>prompt</c> field, Amazon
        /// Lex responds with this statement to acknowledge that the intent was canceled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Statement RejectionStatement { get; set; }

        /// <summary>
        /// Checks to see if the RejectionStatement property is set.
        /// </summary>
        internal bool IsSetRejectionStatement() => this.RejectionStatement != null;
    }
}
