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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// A pipeline-level variable used for a pipeline execution.
    /// </summary>
    public partial class ResolvedPipelineVariable
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a pipeline-level variable.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResolvedValue. 
        /// <para>
        /// The resolved value of a pipeline-level variable.
        /// </para>
        /// </summary>
        public string ResolvedValue { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedValue property is set.
        /// </summary>
        internal bool IsSetResolvedValue() => this.ResolvedValue != null;
    }
}
