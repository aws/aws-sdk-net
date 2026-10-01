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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateQuery operation. Generates an SQL query
    /// from a natural language query. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-generate-query.html">Generate
    /// a query for structured data</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class GenerateQueryRequest : AmazonBedrockAgentRuntimeRequest
    {
        /// <summary>
        /// Gets and sets the property QueryGenerationInput. 
        /// <para>
        /// Specifies information about a natural language query to transform into SQL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public QueryGenerationInput QueryGenerationInput { get; set; }

        /// <summary>
        /// Checks to see if the QueryGenerationInput property is set.
        /// </summary>
        internal bool IsSetQueryGenerationInput() => this.QueryGenerationInput != null;

        /// <summary>
        /// Gets and sets the property TransformationConfiguration. 
        /// <para>
        /// Specifies configurations for transforming the natural language query into SQL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformationConfiguration TransformationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TransformationConfiguration property is set.
        /// </summary>
        internal bool IsSetTransformationConfiguration() => this.TransformationConfiguration != null;
    }
}
