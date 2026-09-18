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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a single, indivisible statement extracted from a source document. Atomic
    /// statements are the fundamental units used to ground policy rules and variables to
    /// their source material.
    /// </summary>
    public partial class AutomatedReasoningPolicyAtomicStatement
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for this atomic statement within the fidelity report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 8)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about where this statement appears in the source document, including line
        /// numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyStatementLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The actual text content of the atomic statement as extracted from the source document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 1024)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;
    }
}
