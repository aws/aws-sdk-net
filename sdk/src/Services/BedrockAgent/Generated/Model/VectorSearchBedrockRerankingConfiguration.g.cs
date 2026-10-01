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
    /// Configures the Amazon Bedrock reranker model to improve the relevance of retrieved
    /// results.
    /// </summary>
    public partial class VectorSearchBedrockRerankingConfiguration
    {
        /// <summary>
        /// Gets and sets the property MetadataConfiguration. 
        /// <para>
        /// Specifies how metadata fields should be handled during the reranking process.
        /// </para>
        /// </summary>
        public MetadataConfigurationForReranking MetadataConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MetadataConfiguration property is set.
        /// </summary>
        internal bool IsSetMetadataConfiguration() => this.MetadataConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelConfiguration. 
        /// <para>
        /// Specifies the configuration for the Amazon Bedrock reranker model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VectorSearchBedrockRerankingModelConfiguration ModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ModelConfiguration property is set.
        /// </summary>
        internal bool IsSetModelConfiguration() => this.ModelConfiguration != null;

        /// <summary>
        /// Gets and sets the property NumberOfRerankedResults. 
        /// <para>
        /// Specifies the number of results to return after reranking.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? NumberOfRerankedResults { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRerankedResults property is set.
        /// </summary>
        internal bool IsSetNumberOfRerankedResults() => this.NumberOfRerankedResults.HasValue;
    }
}
