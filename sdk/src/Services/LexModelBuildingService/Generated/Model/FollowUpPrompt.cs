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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
        private Prompt _prompt;
        private Statement _rejectionStatement;

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// Prompts for information from the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Prompt Prompt
        {
            get { return this._prompt; }
            set { this._prompt = value; }
        }

        // Check to see if Prompt property is set
        internal bool IsSetPrompt()
        {
            return this._prompt != null;
        }

        /// <summary>
        /// Gets and sets the property RejectionStatement. 
        /// <para>
        /// If the user answers "no" to the question defined in the <c>prompt</c> field, Amazon
        /// Lex responds with this statement to acknowledge that the intent was canceled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Statement RejectionStatement
        {
            get { return this._rejectionStatement; }
            set { this._rejectionStatement = value; }
        }

        // Check to see if RejectionStatement property is set
        internal bool IsSetRejectionStatement()
        {
            return this._rejectionStatement != null;
        }

    }
}