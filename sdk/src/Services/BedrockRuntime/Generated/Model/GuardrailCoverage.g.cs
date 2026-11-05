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
    /// The action of the guardrail coverage details.
    /// </summary>
    public partial class GuardrailCoverage
    {
        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// The guardrail coverage for images (the number of images that guardrails guarded).
        /// </para>
        /// </summary>
        public GuardrailImageCoverage Images { get; set; }

        /// <summary>
        /// Checks to see if the Images property is set.
        /// </summary>
        internal bool IsSetImages() => this.Images != null;

        /// <summary>
        /// Gets and sets the property TextCharacters. 
        /// <para>
        /// The text characters of the guardrail coverage details.
        /// </para>
        /// </summary>
        public GuardrailTextCharactersCoverage TextCharacters { get; set; }

        /// <summary>
        /// Checks to see if the TextCharacters property is set.
        /// </summary>
        internal bool IsSetTextCharacters() => this.TextCharacters != null;
    }
}
