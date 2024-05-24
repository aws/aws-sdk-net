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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Represents the output of a <c>DeleteEvaluation</c> operation. The output indicates
    /// that Amazon Machine Learning (Amazon ML) received the request.
    /// 
    ///  
    /// <para>
    /// You can use the <c>GetEvaluation</c> operation and check the value of the <c>Status</c>
    /// parameter to see whether an <c>Evaluation</c> is marked as <c>DELETED</c>.
    /// </para>
    /// </summary>
    public partial class DeleteEvaluationResponse : AmazonWebServiceResponse
    {
        private string _evaluationId;

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <c>Evaluation</c>. This value should
        /// be identical to the value of the <c>EvaluationId</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EvaluationId
        {
            get { return this._evaluationId; }
            set { this._evaluationId = value; }
        }

        // Check to see if EvaluationId property is set
        internal bool IsSetEvaluationId()
        {
            return this._evaluationId != null;
        }

    }
}