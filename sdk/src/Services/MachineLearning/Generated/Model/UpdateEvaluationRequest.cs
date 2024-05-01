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
    /// Container for the parameters to the UpdateEvaluation operation.
    /// Updates the <c>EvaluationName</c> of an <c>Evaluation</c>.
    /// 
    ///  
    /// <para>
    /// You can use the <c>GetEvaluation</c> operation to view the contents of the updated
    /// data element.
    /// </para>
    /// </summary>
    public partial class UpdateEvaluationRequest : AmazonMachineLearningRequest
    {
        private string _evaluationId;
        private string _evaluationName;

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// The ID assigned to the <c>Evaluation</c> during creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property EvaluationName. 
        /// <para>
        /// A new user-supplied name or description of the <c>Evaluation</c> that will replace
        /// the current content. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string EvaluationName
        {
            get { return this._evaluationName; }
            set { this._evaluationName = value; }
        }

        // Check to see if EvaluationName property is set
        internal bool IsSetEvaluationName()
        {
            return this._evaluationName != null;
        }

    }
}