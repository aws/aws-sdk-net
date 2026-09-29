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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Details about the response from the Lambda parsing of the output from the pre-processing
    /// step.
    /// </summary>
    public partial class PreProcessingParsedResponse
    {
        /// <summary>
        /// Gets and sets the property IsValid. 
        /// <para>
        /// Whether the user input is valid or not. If <c>false</c>, the agent doesn't proceed
        /// to orchestration.
        /// </para>
        /// </summary>
        public bool? IsValid { get; set; }

        /// <summary>
        /// Checks to see if the IsValid property is set.
        /// </summary>
        internal bool IsSetIsValid() => this.IsValid.HasValue;

        /// <summary>
        /// Gets and sets the property Rationale. 
        /// <para>
        /// The text returned by the parsing of the pre-processing step, explaining the steps
        /// that the agent plans to take in orchestration, if the user input is valid.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Rationale { get; set; }

        /// <summary>
        /// Checks to see if the Rationale property is set.
        /// </summary>
        internal bool IsSetRationale() => this.Rationale != null;
    }
}
