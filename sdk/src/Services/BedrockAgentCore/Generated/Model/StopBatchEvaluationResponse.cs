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
    /// This is the response object from the StopBatchEvaluation operation.
    /// </summary>
    public partial class StopBatchEvaluationResponse : AmazonWebServiceResponse
    {
        private string _batchEvaluationArn;
        private string _batchEvaluationId;
        private string _description;
        private BatchEvaluationStatus _status;

        /// <summary>
        /// Gets and sets the property BatchEvaluationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stopped batch evaluation.
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

        /// <summary>
        /// Gets and sets the property BatchEvaluationId. 
        /// <para>
        /// The unique identifier of the stopped batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BatchEvaluationId
        {
            get { return this._batchEvaluationId; }
            set { this._batchEvaluationId = value; }
        }

        // Check to see if BatchEvaluationId property is set
        internal bool IsSetBatchEvaluationId()
        {
            return this._batchEvaluationId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch evaluation after the stop request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchEvaluationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}