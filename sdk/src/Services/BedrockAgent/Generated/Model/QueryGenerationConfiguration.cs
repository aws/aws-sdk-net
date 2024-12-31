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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    /// Contains configurations for query generation. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-build-structured.html">Build
    /// a knowledge base by connecting to a structured data source</a> in the Amazon Bedrock
    /// User Guide..
    /// </summary>
    public partial class QueryGenerationConfiguration
    {
        private int? _executionTimeoutSeconds;
        private QueryGenerationContext _generationContext;

        /// <summary>
        /// Gets and sets the property ExecutionTimeoutSeconds. 
        /// <para>
        /// The time after which query generation will time out.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public int? ExecutionTimeoutSeconds
        {
            get { return this._executionTimeoutSeconds; }
            set { this._executionTimeoutSeconds = value; }
        }

        // Check to see if ExecutionTimeoutSeconds property is set
        internal bool IsSetExecutionTimeoutSeconds()
        {
            return this._executionTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GenerationContext. 
        /// <para>
        /// Specifies configurations for context to use during query generation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public QueryGenerationContext GenerationContext
        {
            get { return this._generationContext; }
            set { this._generationContext = value; }
        }

        // Check to see if GenerationContext property is set
        internal bool IsSetGenerationContext()
        {
            return this._generationContext != null;
        }

    }
}