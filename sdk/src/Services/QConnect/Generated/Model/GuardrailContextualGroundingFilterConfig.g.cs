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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The filter configuration details for the AI Guardrail's contextual grounding filter.
    /// </summary>
    public partial class GuardrailContextualGroundingFilterConfig
    {
        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The threshold details for the AI Guardrail's contextual grounding filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0)]
        public double? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The filter type for the AI Guardrail's contextual grounding filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public GuardrailContextualGroundingFilterType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
