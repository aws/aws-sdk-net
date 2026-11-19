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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// How many scenarios a dataset generation produces.
    /// </summary>
    public partial class GenerationSamplingConfig
    {
        /// <summary>
        /// Gets and sets the property MaxScenarios. 
        /// <para>
        /// The maximum number of scenarios to generate, from 1 to 1,000. The default is 100.
        /// The generation produces at most one scenario for each selected session. The dataset's
        /// draft examples plus this value can't be more than 1,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxScenarios { get; set; }

        /// <summary>
        /// Checks to see if the MaxScenarios property is set.
        /// </summary>
        internal bool IsSetMaxScenarios() => this.MaxScenarios.HasValue;
    }
}
