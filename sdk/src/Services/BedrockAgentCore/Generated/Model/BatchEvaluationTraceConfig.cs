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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// Configuration for using a batch evaluation as the source of agent traces for recommendations.
    /// </summary>
    public partial class BatchEvaluationTraceConfig
    {
        private string _batchEvaluationArn;

        /// <summary>
        /// Gets and sets the property BatchEvaluationArn. 
        /// <para>
        /// The ARN of the completed batch evaluation to use as the trace source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BatchEvaluationArn
        {
            get { return this._batchEvaluationArn; }
            set { this._batchEvaluationArn = value; }
        }

        // Check to see if BatchEvaluationArn property is set
        internal bool IsSetBatchEvaluationArn()
        {
            return this._batchEvaluationArn != null;
        }

    }
}