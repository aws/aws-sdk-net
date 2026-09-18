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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// A summary of a RAG source used for a Knowledge Base evaluation job where you provide
    /// your own inference response data.
    /// </summary>
    public partial class EvaluationPrecomputedRagSourceConfig
    {
        /// <summary>
        /// Gets and sets the property RetrieveAndGenerateSourceConfig. 
        /// <para>
        /// A summary of a RAG source used for a retrieve-and-generate Knowledge Base evaluation
        /// job where you provide your own inference response data.
        /// </para>
        /// </summary>
        public EvaluationPrecomputedRetrieveAndGenerateSourceConfig RetrieveAndGenerateSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the RetrieveAndGenerateSourceConfig property is set.
        /// </summary>
        internal bool IsSetRetrieveAndGenerateSourceConfig() => this.RetrieveAndGenerateSourceConfig != null;

        /// <summary>
        /// Gets and sets the property RetrieveSourceConfig. 
        /// <para>
        /// A summary of a RAG source used for a retrieve-only Knowledge Base evaluation job where
        /// you provide your own inference response data.
        /// </para>
        /// </summary>
        public EvaluationPrecomputedRetrieveSourceConfig RetrieveSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the RetrieveSourceConfig property is set.
        /// </summary>
        internal bool IsSetRetrieveSourceConfig() => this.RetrieveSourceConfig != null;
    }
}
