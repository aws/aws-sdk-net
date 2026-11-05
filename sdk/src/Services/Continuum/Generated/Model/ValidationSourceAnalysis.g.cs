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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Proof of exploitability the validation agent produced by reading the repository's
    /// source, with nothing built or run. Further members, such as diagram and references,
    /// can be added later as optional details.
    /// </summary>
    public partial class ValidationSourceAnalysis
    {
        /// <summary>
        /// Gets and sets the property InferredEffect. Effect the agent concluded WOULD occur.
        /// Deliberately not `effect`: nothing was executed, so this is reasoned from the source
        /// and must not be read as an observation. See `ValidationExecutedProof.observedEffect`.
        /// </summary>
        public ExploitEffect InferredEffect { get; set; }

        /// <summary>
        /// Checks to see if the InferredEffect property is set.
        /// </summary>
        internal bool IsSetInferredEffect() => this.InferredEffect != null;

        /// <summary>
        /// Gets and sets the property Summary. The non-blank analysis as Markdown: the annotated
        /// entry-to-sink walk, its citations, and why the checked guards are absent or bypassed.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16384)]
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;
    }
}
