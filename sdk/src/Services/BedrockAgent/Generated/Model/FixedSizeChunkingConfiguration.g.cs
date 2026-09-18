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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configurations for when you choose fixed-size chunking. If you set the <c>chunkingStrategy</c>
    /// as <c>NONE</c>, exclude this field.
    /// </summary>
    public partial class FixedSizeChunkingConfiguration
    {
        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens to include in a chunk.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Checks to see if the MaxTokens property is set.
        /// </summary>
        internal bool IsSetMaxTokens() => this.MaxTokens.HasValue;

        /// <summary>
        /// Gets and sets the property OverlapPercentage. 
        /// <para>
        /// The percentage of overlap between adjacent chunks of a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 99)]
        public int? OverlapPercentage { get; set; }

        /// <summary>
        /// Checks to see if the OverlapPercentage property is set.
        /// </summary>
        internal bool IsSetOverlapPercentage() => this.OverlapPercentage.HasValue;
    }
}
