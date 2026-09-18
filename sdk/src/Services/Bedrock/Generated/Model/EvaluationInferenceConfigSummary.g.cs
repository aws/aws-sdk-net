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
    /// Identifies the models, Knowledge Bases, or other RAG sources evaluated in a model
    /// or Knowledge Base evaluation job.
    /// </summary>
    public partial class EvaluationInferenceConfigSummary
    {
        /// <summary>
        /// Gets and sets the property ModelConfigSummary. 
        /// <para>
        /// A summary of the models used in an Amazon Bedrock model evaluation job. These resources
        /// can be models in Amazon Bedrock or models outside of Amazon Bedrock that you use to
        /// generate your own inference response data.
        /// </para>
        /// </summary>
        public EvaluationModelConfigSummary ModelConfigSummary { get; set; }

        /// <summary>
        /// Checks to see if the ModelConfigSummary property is set.
        /// </summary>
        internal bool IsSetModelConfigSummary() => this.ModelConfigSummary != null;

        /// <summary>
        /// Gets and sets the property RagConfigSummary. 
        /// <para>
        /// A summary of the RAG resources used in an Amazon Bedrock Knowledge Base evaluation
        /// job. These resources can be Knowledge Bases in Amazon Bedrock or RAG sources outside
        /// of Amazon Bedrock that you use to generate your own inference response data.
        /// </para>
        /// </summary>
        public EvaluationRagConfigSummary RagConfigSummary { get; set; }

        /// <summary>
        /// Checks to see if the RagConfigSummary property is set.
        /// </summary>
        internal bool IsSetRagConfigSummary() => this.RagConfigSummary != null;
    }
}
