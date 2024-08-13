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
        private long? _computeTime;
        private DateTime? _createdAt;
        private string _createdByIamUser;
        private string _evaluationDataSourceId;
        private string _evaluationId;
        private DateTime? _finishedAt;
        private string _inputDataLocationS3;
        private DateTime? _lastUpdatedAt;
        private string _message;
        private string _mlModelId;
        private string _name;
        private PerformanceMetrics _performanceMetrics;
        private DateTime? _startedAt;
        private EntityStatus _status;

        /// <summary>
        /// Gets and sets the property ComputeTime.
        /// </summary>
        public long? ComputeTime
        {
            get { return this._computeTime; }
            set { this._computeTime = value; }
        }

        // Check to see if ComputeTime property is set
        internal bool IsSetComputeTime()
        {
            return this._computeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the <c>Evaluation</c> was created. The time is expressed in epoch time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedByIamUser. 
        /// <para>
        /// The AWS user account that invoked the evaluation. The account type can be either an
        /// AWS root account or an AWS Identity and Access Management (IAM) user account.
        /// </para>
        /// </summary>
        public string CreatedByIamUser
        {
            get { return this._createdByIamUser; }
            set { this._createdByIamUser = value; }
        }

        // Check to see if CreatedByIamUser property is set
        internal bool IsSetCreatedByIamUser()
        {
            return this._createdByIamUser != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationDataSourceId. 
        /// <para>
        /// The ID of the <c>DataSource</c> that is used to evaluate the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The ID that is assigned to the <c>Evaluation</c> at creation.
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

        /// <summary>
        /// Gets and sets the property FinishedAt.
        /// </summary>
        public DateTime? FinishedAt
        {
            get { return this._finishedAt; }
            set { this._finishedAt = value; }
        }

        // Check to see if FinishedAt property is set
        internal bool IsSetFinishedAt()
        {
            return this._finishedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataLocationS3. 
        /// <para>
        /// The location and name of the data in Amazon Simple Storage Server (Amazon S3) that
        /// is used in the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string InputDataLocationS3
        {
            get { return this._inputDataLocationS3; }
            set { this._inputDataLocationS3 = value; }
        }

        // Check to see if InputDataLocationS3 property is set
        internal bool IsSetInputDataLocationS3()
        {
            return this._inputDataLocationS3 != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time of the most recent edit to the <c>Evaluation</c>. The time is expressed in
        /// epoch time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about evaluating the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10240)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The ID of the <c>MLModel</c> that is the focus of the evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name or description of the <c>Evaluation</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        public PerformanceMetrics PerformanceMetrics
        {
            get { return this._performanceMetrics; }
            set { this._performanceMetrics = value; }
        }

        // Check to see if PerformanceMetrics property is set
        internal bool IsSetPerformanceMetrics()
        {
            return this._performanceMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt.
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

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
        public EntityStatus Status
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