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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// A mutation operation that modifies an existing variable in the policy definition during
    /// the build process.
    /// </summary>
    public partial class AutomatedReasoningPolicyUpdateVariableMutation
    {
        private AutomatedReasoningPolicyDefinitionVariable _variable;

        /// <summary>
        /// Gets and sets the property Variable. 
        /// <para>
        /// The updated variable definition containing the modified name, type, or description
        /// for the existing variable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningPolicyDefinitionVariable Variable
        {
            get { return this._variable; }
            set { this._variable = value; }
        }

        // Check to see if Variable property is set
        internal bool IsSetVariable()
        {
            return this._variable != null;
        }

    }
}