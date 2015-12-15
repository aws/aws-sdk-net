/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEvaluation operation.
    /// Assigns the <code>DELETED</code> status to an <code>Evaluation</code>, rendering it
    /// unusable.
    /// 
    ///  
    /// <para>
    /// After invoking the <code>DeleteEvaluation</code> operation, you can use the <a>GetEvaluation</a>
    /// operation to verify that the status of the <code>Evaluation</code> changed to <code>DELETED</code>.
    /// </para>
    ///  
    /// <para>
    /// <b>Caution:</b> The results of the <code>DeleteEvaluation</code> operation are irreversible.
    /// </para>
    /// </summary>
    public partial class DeleteEvaluationRequest : AmazonMachineLearningRequest
    {
        private string _evaluationId;

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <code>Evaluation</code> to delete.
        /// </para>
        /// </summary>
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