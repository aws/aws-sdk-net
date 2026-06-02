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
    /// An evaluator to run against sessions.
    /// </summary>
    public partial class Evaluator
    {
        private string _evaluatorId;

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        /// The unique identifier of the evaluator. Can reference built-in evaluators (e.g., <c>Builtin.Helpfulness</c>)
        /// or custom evaluators.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorId
        {
            get { return this._evaluatorId; }
            set { this._evaluatorId = value; }
        }

        // Check to see if EvaluatorId property is set
        internal bool IsSetEvaluatorId()
        {
            return this._evaluatorId != null;
        }

    }
}