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
    /// Represents the output of <c>GetEvaluation</c> operation. 
    /// 
    ///  
    /// <para>
    /// The content consists of the detailed metadata and data file information and the current
    /// status of the <c>Evaluation</c>.
    /// </para>
    /// </summary>
    public partial class Evaluation
    {
        /// <summary>
        /// Gets and sets the property ComputeTime.
        /// </summary>
        public long? ComputeTime { get; set; }

        /// <summary>
        /// Checks to see if the ComputeTime property is set.
        /// </summary>
        internal bool IsSetComputeTime() => this.ComputeTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the <c>Evaluation</c> was created. The time is expressed in epoch time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedByIamUser. 
        /// <para>
        /// The AWS user account that invoked the evaluation. The account type can be either an
        /// AWS root account or an AWS Identity and Access Management (IAM) user account.
        /// </para>
        /// </summary>
        public string CreatedByIamUser { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByIamUser property is set.
        /// </summary>
        internal bool IsSetCreatedByIamUser() => this.CreatedByIamUser != null;

        /// <summary>
        /// Gets and sets the property EvaluationDataSourceId. 
        /// <para>
        /// The ID of the <c>DataSource</c> that is used to evaluate the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EvaluationDataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationDataSourceId property is set.
        /// </summary>
        internal bool IsSetEvaluationDataSourceId() => this.EvaluationDataSourceId != null;

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// The ID that is assigned to the <c>Evaluation</c> at creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationId property is set.
        /// </summary>
        internal bool IsSetEvaluationId() => this.EvaluationId != null;

        /// <summary>
        /// Gets and sets the property FinishedAt.
        /// </summary>
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Checks to see if the FinishedAt property is set.
        /// </summary>
        internal bool IsSetFinishedAt() => this.FinishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InputDataLocationS3. 
        /// <para>
        /// The location and name of the data in Amazon Simple Storage Server (Amazon S3) that
        /// is used in the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string InputDataLocationS3 { get; set; }

        /// <summary>
        /// Checks to see if the InputDataLocationS3 property is set.
        /// </summary>
        internal bool IsSetInputDataLocationS3() => this.InputDataLocationS3 != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time of the most recent edit to the <c>Evaluation</c>. The time is expressed in
        /// epoch time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID of the <c>MLModel</c> that is the focus of the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string MLModelId { get; set; }

        /// <summary>
        /// Checks to see if the MLModelId property is set.
        /// </summary>
        internal bool IsSetMLModelId() => this.MLModelId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about evaluating the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name or description of the <c>Evaluation</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PerformanceMetrics. 
        /// <para>
        /// Measurements of how well the <c>MLModel</c> performed, using observations referenced
        /// by the <c>DataSource</c>. One of the following metrics is returned, based on the type
        /// of the <c>MLModel</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BinaryAUC: A binary <c>MLModel</c> uses the Area Under the Curve (AUC) technique to
        /// measure performance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RegressionRMSE: A regression <c>MLModel</c> uses the Root Mean Square Error (RMSE)
        /// technique to measure performance. RMSE measures the difference between predicted and
        /// actual values for a single variable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MulticlassAvgFScore: A multiclass <c>MLModel</c> uses the F1 score technique to measure
        /// performance. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about performance metrics, please see the <a href="https://docs.aws.amazon.com/machine-learning/latest/dg">Amazon
        /// Machine Learning Developer Guide</a>. 
        /// </para>
        /// </summary>
        public PerformanceMetrics PerformanceMetrics { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceMetrics property is set.
        /// </summary>
        internal bool IsSetPerformanceMetrics() => this.PerformanceMetrics != null;

        /// <summary>
        /// Gets and sets the property StartedAt.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the evaluation. This element can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon Machine Learning (Amazon ML) submitted a request to evaluate
        /// an <c>MLModel</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INPROGRESS</c> - The evaluation is underway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The request to evaluate an <c>MLModel</c> did not run to completion.
        /// It is not usable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The evaluation process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The <c>Evaluation</c> is marked as deleted. It is not usable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EntityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
