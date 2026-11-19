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
    /// One flow on a link: a set of modules that runs on the link's bid requests.
    /// </summary>
    public partial class Flow
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The flow's name, unique within the link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Pipeline. 
        /// <para>
        /// The pipeline that the flow's modules run in. In a sequential pipeline, each module
        /// sees the previous module's output. In a phased pipeline, a phase's modules see the
        /// prior phase's output, not each other's.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowPipeline Pipeline { get; set; }

        /// <summary>
        /// Checks to see if the Pipeline property is set.
        /// </summary>
        internal bool IsSetPipeline() => this.Pipeline != null;
    }
}
