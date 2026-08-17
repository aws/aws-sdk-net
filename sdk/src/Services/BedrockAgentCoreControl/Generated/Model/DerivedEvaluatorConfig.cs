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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for a derived evaluator. It reuses an existing evaluator's logic
    /// on your own model.
    /// </summary>
    public partial class DerivedEvaluatorConfig
    {
        private string _baseEvaluatorId;
        private EvaluatorModelConfig _modelConfig;

        /// <summary>
        /// Gets and sets the property BaseEvaluatorId. 
        /// <para>
        ///  The identifier of the base evaluator whose logic to run (a <c>Builtin.*</c> or <c>ThirdParty.*</c>
        /// evaluator). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=111)]
        public string BaseEvaluatorId
        {
            get { return this._baseEvaluatorId; }
            set { this._baseEvaluatorId = value; }
        }

        // Check to see if BaseEvaluatorId property is set
        internal bool IsSetBaseEvaluatorId()
        {
            return this._baseEvaluatorId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelConfig. 
        /// <para>
        ///  The configuration of the evaluator model that you supply. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluatorModelConfig ModelConfig
        {
            get { return this._modelConfig; }
            set { this._modelConfig = value; }
        }

        // Check to see if ModelConfig property is set
        internal bool IsSetModelConfig()
        {
            return this._modelConfig != null;
        }

    }
}