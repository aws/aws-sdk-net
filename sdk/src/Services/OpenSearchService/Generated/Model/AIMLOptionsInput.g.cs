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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for parameters required to enable all machine learning features.
    /// </summary>
    public partial class AIMLOptionsInput
    {
        /// <summary>
        /// Gets and sets the property NaturalLanguageQueryGenerationOptions. 
        /// <para>
        /// Container for parameters required for natural language query generation on the specified
        /// domain.
        /// </para>
        /// </summary>
        public NaturalLanguageQueryGenerationOptionsInput NaturalLanguageQueryGenerationOptions { get; set; }

        /// <summary>
        /// Checks to see if the NaturalLanguageQueryGenerationOptions property is set.
        /// </summary>
        internal bool IsSetNaturalLanguageQueryGenerationOptions() => this.NaturalLanguageQueryGenerationOptions != null;

        /// <summary>
        /// Gets and sets the property S3VectorsEngine. 
        /// <para>
        /// Container for parameters required to enable S3 vectors engine features on the specified
        /// domain.
        /// </para>
        /// </summary>
        public S3VectorsEngine S3VectorsEngine { get; set; }

        /// <summary>
        /// Checks to see if the S3VectorsEngine property is set.
        /// </summary>
        internal bool IsSetS3VectorsEngine() => this.S3VectorsEngine != null;

        /// <summary>
        /// Gets and sets the property ServerlessVectorAcceleration. 
        /// <para>
        /// Specifies whether to enable serverless vector acceleration for the domain. When enabled,
        /// provides <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/gpu-acceleration-vector-index.html">GPU-accelerated</a>
        /// vector search capabilities for improved performance on vector workloads.
        /// </para>
        /// </summary>
        public ServerlessVectorAcceleration ServerlessVectorAcceleration { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessVectorAcceleration property is set.
        /// </summary>
        internal bool IsSetServerlessVectorAcceleration() => this.ServerlessVectorAcceleration != null;
    }
}
