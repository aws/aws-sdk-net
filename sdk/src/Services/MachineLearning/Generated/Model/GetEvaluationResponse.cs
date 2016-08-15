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
    /// Represents the output of a <code>GetEvaluation</code> operation and describes an <code>Evaluation</code>.
    /// </summary>
    public partial class GetEvaluationResponse : AmazonWebServiceResponse
    {
        private long? _computeTime;
        private DateTime? _createdAt;
        private string _createdByIamUser;
        private string _evaluationDataSourceId;
        private string _evaluationId;
        private DateTime? _finishedAt;
        private string _inputDataLocationS3;
        private DateTime? _lastUpdatedAt;
        private string _logUri;
        private string _message;
        private string _mlModelId;
        private string _name;
        private PerformanceMetrics _performanceMetrics;
        private DateTime? _startedAt;
        private EntityStatus _status;

        /// <summary>
        /// Gets and sets the property ComputeTime. 
        /// <para>
        /// The approximate CPU time in milliseconds that Amazon Machine Learning spent processing
        /// the <code>Evaluation</code>, normalized and scaled on computation resources. <code>ComputeTime</code>
        /// is only available if the <code>Evaluation</code> is in the <code>COMPLETED</code>
        /// state.
        /// </para>
        /// </summary>
        public long ComputeTime
        {
            get { return this._computeTime.GetValueOrDefault(); }
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
        /// The time that the <code>Evaluation</code> was created. The time is expressed in epoch
        /// time.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// The <code>DataSource</code> used for this evaluation.
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
        /// The evaluation ID which is same as the <code>EvaluationId</code> in the request.
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
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The epoch time when Amazon Machine Learning marked the <code>Evaluation</code> as
        /// <code>COMPLETED</code> or <code>FAILED</code>. <code>FinishedAt</code> is only available
        /// when the <code>Evaluation</code> is in the <code>COMPLETED</code> or <code>FAILED</code>
        /// state.
        /// </para>
        /// </summary>
        public DateTime FinishedAt
        {
            get { return this._finishedAt.GetValueOrDefault(); }
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
        /// The location of the data file or directory in Amazon Simple Storage Service (Amazon
        /// S3).
        /// </para>
        /// </summary>
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
        /// The time of the most recent edit to the <code>Evaluation</code>. The time is expressed
        /// in epoch time.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// A link to the file that contains logs of the <code>CreateEvaluation</code> operation.
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about evaluating the <code>MLModel</code>.
        /// </para>
        /// </summary>
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
        /// The ID of the <code>MLModel</code> that was the focus of the evaluation.
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name or description of the <code>Evaluation</code>. 
        /// </para>
        /// </summary>
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
        /// Measurements of how well the <code>MLModel</code> performed using observations referenced
        /// by the <code>DataSource</code>. One of the following metric is returned based on the
        /// type of the <code>MLModel</code>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BinaryAUC: A binary <code>MLModel</code> uses the Area Under the Curve (AUC) technique
        /// to measure performance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RegressionRMSE: A regression <code>MLModel</code> uses the Root Mean Square Error
        /// (RMSE) technique to measure performance. RMSE measures the difference between predicted
        /// and actual values for a single variable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MulticlassAvgFScore: A multiclass <code>MLModel</code> uses the F1 score technique
        /// to measure performance. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about performance metrics, please see the <a href="http://docs.aws.amazon.com/machine-learning/latest/dg">Amazon
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
        /// <para>
        /// The epoch time when Amazon Machine Learning marked the <code>Evaluation</code> as
        /// <code>INPROGRESS</code>. <code>StartedAt</code> isn't available if the <code>Evaluation</code>
        /// is in the <code>PENDING</code> state.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
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
        ///  <ul> <li> <code>PENDING</code> - Amazon Machine Language (Amazon ML) submitted a
        /// request to evaluate an <code>MLModel</code>.</li> <li> <code>INPROGRESS</code> - The
        /// evaluation is underway.</li> <li> <code>FAILED</code> - The request to evaluate an
        /// <code>MLModel</code> did not run to completion. It is not usable.</li> <li> <code>COMPLETED</code>
        /// - The evaluation process completed successfully.</li> <li> <code>DELETED</code> -
        /// The <code>Evaluation</code> is marked as deleted. It is not usable.</li> </ul>
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