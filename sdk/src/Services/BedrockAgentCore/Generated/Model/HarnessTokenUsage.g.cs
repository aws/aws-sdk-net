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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Token usage counts for the invocation.
    /// </summary>
    public partial class HarnessTokenUsage
    {
        /// <summary>
        /// Gets and sets the property CacheReadInputTokens. 
        /// <para>
        /// The number of input tokens read from cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Checks to see if the CacheReadInputTokens property is set.
        /// </summary>
        internal bool IsSetCacheReadInputTokens() => this.CacheReadInputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property CacheWriteInputTokens. 
        /// <para>
        /// The number of input tokens written to cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CacheWriteInputTokens { get; set; }

        /// <summary>
        /// Checks to see if the CacheWriteInputTokens property is set.
        /// </summary>
        internal bool IsSetCacheWriteInputTokens() => this.CacheWriteInputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property InputTokens. 
        /// <para>
        /// The number of input tokens consumed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Checks to see if the InputTokens property is set.
        /// </summary>
        internal bool IsSetInputTokens() => this.InputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property OutputTokens. 
        /// <para>
        /// The number of output tokens generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Checks to see if the OutputTokens property is set.
        /// </summary>
        internal bool IsSetOutputTokens() => this.OutputTokens.HasValue;

        /// <summary>
        /// Gets and sets the property TotalTokens. 
        /// <para>
        /// The total number of tokens consumed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Checks to see if the TotalTokens property is set.
        /// </summary>
        internal bool IsSetTotalTokens() => this.TotalTokens.HasValue;
    }
}
