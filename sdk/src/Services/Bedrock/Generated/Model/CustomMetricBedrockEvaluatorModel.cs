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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
    /// Defines the model you want to evaluate custom metrics in an Amazon Bedrock evaluation
    /// job.
    /// </summary>
    public partial class CustomMetricBedrockEvaluatorModel
    {
        private string _modelIdentifier;

        /// <summary>
        /// Gets and sets the property ModelIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the evaluator model for custom metrics. For a list
        /// of supported evaluator models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/evaluation-judge.html">Evaluate
        /// model performance using another LLM as a judge</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/evaluation-kb.html">Evaluate
        /// the performance of RAG sources using Amazon Bedrock evaluations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelIdentifier
        {
            get { return this._modelIdentifier; }
            set { this._modelIdentifier = value; }
        }

        // Check to see if ModelIdentifier property is set
        internal bool IsSetModelIdentifier()
        {
            return this._modelIdentifier != null;
        }

    }
}