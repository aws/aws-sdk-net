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
    /// Settings for semantic document chunking for a data source. Semantic chunking splits
    /// a document into smaller documents based on groups of similar content derived from
    /// the text with natural language processing.
    /// </summary>
    public partial class SemanticChunkingConfiguration
    {
        /// <summary>
        /// Gets and sets the property BreakpointPercentileThreshold. 
        /// <para>
        /// The dissimilarity threshold for splitting chunks.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 99)]
        public int? BreakpointPercentileThreshold { get; set; }

        /// <summary>
        /// Checks to see if the BreakpointPercentileThreshold property is set.
        /// </summary>
        internal bool IsSetBreakpointPercentileThreshold() => this.BreakpointPercentileThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property BufferSize. 
        /// <para>
        /// The buffer size.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public int? BufferSize { get; set; }

        /// <summary>
        /// Checks to see if the BufferSize property is set.
        /// </summary>
        internal bool IsSetBufferSize() => this.BufferSize.HasValue;

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens that a chunk can contain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Checks to see if the MaxTokens property is set.
        /// </summary>
        internal bool IsSetMaxTokens() => this.MaxTokens.HasValue;
    }
}
