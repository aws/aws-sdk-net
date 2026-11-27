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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// The compute configuration for a graph session.
    /// </summary>
    public partial class GraphSessionConfiguration
    {
        /// <summary>
        /// Gets and sets the property MinMemory. 
        /// <para>
        /// The minimum Session Neptune Capacity Units (s-NCUs) available to the graph session.
        /// </para>
        ///  
        /// <para>
        /// A graph session can burst up to 2x the configured min memory. For example, a <c>minMemory</c>
        /// of 4 can burst up to 8 s-NCUs, and a <c>minMemory</c> of 8 can burst up to 16 s-NCUs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 8)]
        public int? MinMemory { get; set; }

        /// <summary>
        /// Checks to see if the MinMemory property is set.
        /// </summary>
        internal bool IsSetMinMemory() => this.MinMemory.HasValue;
    }
}
