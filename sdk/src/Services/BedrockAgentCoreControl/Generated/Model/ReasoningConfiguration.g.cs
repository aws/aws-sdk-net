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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The reasoning configuration that controls how a reasoning model allocates effort
    /// during evaluation.
    /// </summary>
    public partial class ReasoningConfiguration
    {
        /// <summary>
        /// Gets and sets the property Effort. 
        /// <para>
        ///  The level of reasoning effort the model applies when generating a response. For supported
        /// values, see the model provider's documentation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Effort { get; set; }

        /// <summary>
        /// Checks to see if the Effort property is set.
        /// </summary>
        internal bool IsSetEffort() => this.Effort != null;
    }
}
