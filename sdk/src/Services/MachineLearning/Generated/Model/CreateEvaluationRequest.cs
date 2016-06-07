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
    /// Container for the parameters to the CreateEvaluation operation.
    /// Creates a new <code>Evaluation</code> of an <code>MLModel</code>. An <code>MLModel</code>
    /// is evaluated on a set of observations associated to a <code>DataSource</code>. Like
    /// a <code>DataSource</code> for an <code>MLModel</code>, the <code>DataSource</code>
    /// for an <code>Evaluation</code> contains values for the <code>Target Variable</code>.
    /// The <code>Evaluation</code> compares the predicted result for each observation to
    /// the actual outcome and provides a summary so that you know how effective the <code>MLModel</code>
    /// functions on the test data. Evaluation generates a relevant performance metric, such
    /// as BinaryAUC, RegressionRMSE or MulticlassAvgFScore based on the corresponding <code>MLModelType</code>:
    /// <code>BINARY</code>, <code>REGRESSION</code> or <code>MULTICLASS</code>. 
    /// 
    ///  
    /// <para>
    /// <code>CreateEvaluation</code> is an asynchronous operation. In response to <code>CreateEvaluation</code>,
    /// Amazon Machine Learning (Amazon ML) immediately returns and sets the evaluation status
    /// to <code>PENDING</code>. After the <code>Evaluation</code> is created and ready for
    /// use, Amazon ML sets the status to <code>COMPLETED</code>. 
    /// </para>
    ///  
    /// <para>
    /// You can use the <code>GetEvaluation</code> operation to check progress of the evaluation
    /// during the creation operation.
    /// </para>
    /// </summary>
    public partial class CreateEvaluationRequest : AmazonMachineLearningRequest
    {
        private string _evaluationDataSourceId;
        private string _evaluationId;
        private string _evaluationName;
        private string _mlModelId;

        /// <summary>
        /// Gets and sets the property EvaluationDataSourceId. 
        /// <para>
        /// The ID of the <code>DataSource</code> for the evaluation. The schema of the <code>DataSource</code>
        /// must match the schema used to create the <code>MLModel</code>.
        /// </para>
        /// </summary>
        public string EvaluationDataSourceId
        {
            get { return this._evaluationDataSourceId; }
            set { this._evaluationDataSourceId = value; }
        }

        // Check to see if EvaluationDataSourceId property is set
        internal bool IsSetEvaluationDataSourceId()
        {
            return this._evaluationDataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <code>Evaluation</code>.
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

        /// <summary>
        /// Gets and sets the property EvaluationName. 
        /// <para>
        /// A user-supplied name or description of the <code>Evaluation</code>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID of the <code>MLModel</code> to evaluate.
        /// </para>
        ///  
        /// <para>
        /// The schema used in creating the <code>MLModel</code> must match the schema of the
        /// <code>DataSource</code> used in the <code>Evaluation</code>.
        /// </para>
        /// </summary>
        public string MLModelId
        {
            get { return this._mlModelId; }
            set { this._mlModelId = value; }
        }

        // Check to see if MLModelId property is set
        internal bool IsSetMLModelId()
        {
            return this._mlModelId != null;
        }

    }
}