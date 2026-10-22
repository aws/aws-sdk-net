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
    /// Proof of exploitability the validation agent produced by executing code against the
    /// repository under test, with the output that execution produced.
    /// </summary>
    public partial class ValidationExecutedProof
    {
        /// <summary>
        /// Gets and sets the property Code. The code that was run. Not a request payload: it
        /// imports the repository's own modules and drives the vulnerable code path directly.
        /// </summary>
        [AWSProperty(Required = true)]
        public ValidationProofCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property ObservedEffect. Effect the execution actually produced.
        /// `observedEffect` rather than `effect`: this one was witnessed, and the name has to
        /// stay distinguishable from `ValidationSourceAnalysis.inferredEffect`, which was not.
        /// </summary>
        public ExploitEffect ObservedEffect { get; set; }

        /// <summary>
        /// Checks to see if the ObservedEffect property is set.
        /// </summary>
        internal bool IsSetObservedEffect() => this.ObservedEffect != null;

        /// <summary>
        /// Gets and sets the property Output. What the execution printed, including the agent's
        /// own PASS/FAIL assertions. Absent when the run printed nothing retained.
        /// </summary>
        public ValidationProofOutput Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;
    }
}
