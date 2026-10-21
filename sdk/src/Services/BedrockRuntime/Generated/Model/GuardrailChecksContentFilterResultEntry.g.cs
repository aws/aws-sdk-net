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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The evaluation result for a single content filter category.
    /// </summary>
    public partial class GuardrailChecksContentFilterResultEntry
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The content filter category that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GuardrailChecksContentFilterCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property SeverityScore. 
        /// <para>
        /// The severity score for the category, ranging from 0.0 to 1.0. Higher values indicate
        /// greater severity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public double? SeverityScore { get; set; }

        /// <summary>
        /// Checks to see if the SeverityScore property is set.
        /// </summary>
        internal bool IsSetSeverityScore() => this.SeverityScore.HasValue;
    }
}
