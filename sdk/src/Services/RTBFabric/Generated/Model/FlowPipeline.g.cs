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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// How a flow's modules run. In <c>sequential</c>, each module sees the previous module's
    /// output; in <c>phased</c>, a phase's modules see the prior phase's output, not each
    /// other's. Set exactly one. New members can be added, so handle an unknown one.
    /// </summary>
    public partial class FlowPipeline
    {
        /// <summary>
        /// Gets and sets the property Phased. 
        /// <para>
        /// Phases run in order; a phase's modules run concurrently on the same input. Use it
        /// when a phase's modules don't depend on each other.
        /// </para>
        /// </summary>
        public PhasedPipeline Phased { get; set; }

        /// <summary>
        /// Checks to see if the Phased property is set.
        /// </summary>
        internal bool IsSetPhased() => this.Phased != null;

        /// <summary>
        /// Gets and sets the property Sequential. 
        /// <para>
        /// Modules run in list order. Use it when each module needs the previous module's output.
        /// </para>
        /// </summary>
        public SequentialPipeline Sequential { get; set; }

        /// <summary>
        /// Checks to see if the Sequential property is set.
        /// </summary>
        internal bool IsSetSequential() => this.Sequential != null;
    }
}
