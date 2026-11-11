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
    /// Container for the parameters to the CreateEvaluation operation. Creates a new <c>Evaluation</c>
    /// of an <c>MLModel</c>. An <c>MLModel</c> is evaluated on a set of observations associated
    /// to a <c>DataSource</c>. Like a <c>DataSource</c> for an <c>MLModel</c>, the <c>DataSource</c>
    /// for an <c>Evaluation</c> contains values for the <c>Target Variable</c>. The <c>Evaluation</c>
    /// compares the predicted result for each observation to the actual outcome and provides
    /// a summary so that you know how effective the <c>MLModel</c> functions on the test
    /// data. Evaluation generates a relevant performance metric, such as BinaryAUC, RegressionRMSE
    /// or MulticlassAvgFScore based on the corresponding <c>MLModelType</c>: <c>BINARY</c>,
    /// <c>REGRESSION</c> or <c>MULTICLASS</c>. <para> <c>CreateEvaluation</c> is an asynchronous
    /// operation. In response to <c>CreateEvaluation</c>, Amazon Machine Learning (Amazon
    /// ML) immediately returns and sets the evaluation status to <c>PENDING</c>. After the
    /// <c>Evaluation</c> is created and ready for use, Amazon ML sets the status to <c>COMPLETED</c>.
    /// </para> <para> You can use the <c>GetEvaluation</c> operation to check progress of
    /// the evaluation during the creation operation. </para>
    /// </summary>
    public partial class CreateEvaluationRequest : AmazonMachineLearningRequest
    {
        /// <summary>
        /// Gets and sets the property EvaluationDataSourceId. 
        /// <para>
        /// The ID of the <c>DataSource</c> for the evaluation. The schema of the <c>DataSource</c>
        /// must match the schema used to create the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EvaluationDataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationDataSourceId property is set.
        /// </summary>
        internal bool IsSetEvaluationDataSourceId() => this.EvaluationDataSourceId != null;

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <c>Evaluation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationId property is set.
        /// </summary>
        internal bool IsSetEvaluationId() => this.EvaluationId != null;

        /// <summary>
        /// Gets and sets the property EvaluationName. 
        /// <para>
        /// A user-supplied name or description of the <c>Evaluation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EvaluationName { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationName property is set.
        /// </summary>
        internal bool IsSetEvaluationName() => this.EvaluationName != null;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID of the <c>MLModel</c> to evaluate.
        /// </para>
        ///  
        /// <para>
        /// The schema used in creating the <c>MLModel</c> must match the schema of the <c>DataSource</c>
        /// used in the <c>Evaluation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string MLModelId { get; set; }

        /// <summary>
        /// Checks to see if the MLModelId property is set.
        /// </summary>
        internal bool IsSetMLModelId() => this.MLModelId != null;
    }
}
