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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The custom prompt input for an agent. This is a union type that can be either an existing
    /// prompt profile or new prompt parameters.
    /// </summary>
    public partial class CustomPromptInput
    {
        private CustomPromptProfile _existingPrompt;
        private CustomPromptInputParameters _newPrompt;

        /// <summary>
        /// Gets and sets the property ExistingPrompt. 
        /// <para>
        /// An existing custom prompt profile to use for the agent.
        /// </para>
        /// </summary>
        public CustomPromptProfile ExistingPrompt
        {
            get { return this._existingPrompt; }
            set { this._existingPrompt = value; }
        }

        // Check to see if ExistingPrompt property is set
        internal bool IsSetExistingPrompt()
        {
            return this._existingPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property NewPrompt. 
        /// <para>
        /// New custom prompt parameters to configure for the agent.
        /// </para>
        /// </summary>
        public CustomPromptInputParameters NewPrompt
        {
            get { return this._newPrompt; }
            set { this._newPrompt = value; }
        }

        // Check to see if NewPrompt property is set
        internal bool IsSetNewPrompt()
        {
            return this._newPrompt != null;
        }

    }
}