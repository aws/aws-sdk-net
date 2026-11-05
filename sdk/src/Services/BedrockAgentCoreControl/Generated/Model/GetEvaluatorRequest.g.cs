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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the GetEvaluator operation. Retrieves detailed information
    /// about an evaluator, including its configuration, status, and metadata. Works with
    /// both built-in and custom evaluators.
    /// </summary>
    public partial class GetEvaluatorRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        ///  The unique identifier of the evaluator to retrieve. Can be a built-in evaluator ID
        /// (e.g., Builtin.Helpfulness) or a custom evaluator ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 111)]
        public string EvaluatorId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorId property is set.
        /// </summary>
        internal bool IsSetEvaluatorId() => this.EvaluatorId != null;

        /// <summary>
        /// Gets and sets the property IncludedData. 
        /// <para>
        ///  Controls which data is returned in the response. <c>ALL_DATA</c> (default) returns
        /// the full evaluator including decrypted instructions and rating scale. For evaluators
        /// encrypted with a customer managed KMS key, this requires <c>kms:Decrypt</c> permission
        /// on the key. <c>METADATA_ONLY</c> returns evaluator metadata and model configuration
        /// without instructions or rating scale, and does not require any KMS permissions. 
        /// </para>
        /// </summary>
        public IncludedData IncludedData { get; set; }

        /// <summary>
        /// Checks to see if the IncludedData property is set.
        /// </summary>
        internal bool IsSetIncludedData() => this.IncludedData != null;
    }
}
