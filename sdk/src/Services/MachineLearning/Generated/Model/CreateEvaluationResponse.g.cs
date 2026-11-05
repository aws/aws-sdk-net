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

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// This is the response object from the CreateEvaluation operation.
    /// </summary>
    public partial class CreateEvaluationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// The user-supplied ID that uniquely identifies the <c>Evaluation</c>. This value should
        /// be identical to the value of the <c>EvaluationId</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationId property is set.
        /// </summary>
        internal bool IsSetEvaluationId() => this.EvaluationId != null;
    }
}
