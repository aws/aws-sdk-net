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
    /// Represents the output of a <code>GetMLModel</code> operation. 
    /// 
    ///  
    /// <para>
    /// The content consists of the detailed metadata and the current status of the <code>MLModel</code>.
    /// </para>
    /// </summary>
    public partial class MLModel
    {
        private Algorithm _algorithm;
        private long? _computeTime;
        private DateTime? _createdAt;
        private string _createdByIamUser;
        private RealtimeEndpointInfo _endpointInfo;
        private DateTime? _finishedAt;
        private string _inputDataLocationS3;
        private DateTime? _lastUpdatedAt;
        private string _message;
        private string _mlModelId;
        private MLModelType _mlModelType;
        private string _name;
        private float? _scoreThreshold;
        private DateTime? _scoreThresholdLastUpdatedAt;
        private long? _sizeInBytes;
        private DateTime? _startedAt;
        private EntityStatus _status;
        private string _trainingDataSourceId;
        private Dictionary<string, string> _trainingParameters = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The algorithm used to train the <code>MLModel</code>. The following algorithm is supported:
        /// </para>
        ///  <ul> <li> <code>SGD</code> -- Stochastic gradient descent. The goal of <code>SGD</code>
        /// is to minimize the gradient of the loss function. </li> </ul>
        /// </summary>
        public Algorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeTime.
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
        /// The time that the <code>MLModel</code> was created. The time is expressed in epoch
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
        /// The AWS user account from which the <code>MLModel</code> was created. The account
        /// type can be either an AWS root account or an AWS Identity and Access Management (IAM)
        /// user account.
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
        /// Gets and sets the property EndpointInfo. 
        /// <para>
        /// The current endpoint of the <code>MLModel</code>.
        /// </para>
        /// </summary>
        public RealtimeEndpointInfo EndpointInfo
        {
            get { return this._endpointInfo; }
            set { this._endpointInfo = value; }
        }

        // Check to see if EndpointInfo property is set
        internal bool IsSetEndpointInfo()
        {
            return this._endpointInfo != null;
        }

        /// <summary>
        /// Gets and sets the property FinishedAt.
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
        /// The time of the most recent edit to the <code>MLModel</code>. The time is expressed
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
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about accessing the <code>MLModel</code>.
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
        /// The ID assigned to the <code>MLModel</code> at creation.
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
        /// Gets and sets the property MLModelType. 
        /// <para>
        /// Identifies the <code>MLModel</code> category. The following are the available types:
        /// </para>
        ///  <ul> <li> <code>REGRESSION</code> - Produces a numeric result. For example, "What
        /// price should a house be listed at?"</li> <li> <code>BINARY</code> - Produces one of
        /// two possible results. For example, "Is this a child-friendly web site?".</li> <li>
        /// <code>MULTICLASS</code> - Produces one of several possible results. For example, "Is
        /// this a HIGH-, LOW-, or MEDIUM-risk trade?".</li> </ul>
        /// </summary>
        public MLModelType MLModelType
        {
            get { return this._mlModelType; }
            set { this._mlModelType = value; }
        }

        // Check to see if MLModelType property is set
        internal bool IsSetMLModelType()
        {
            return this._mlModelType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-supplied name or description of the <code>MLModel</code>.
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
        /// Gets and sets the property ScoreThreshold.
        /// </summary>
        public float ScoreThreshold
        {
            get { return this._scoreThreshold.GetValueOrDefault(); }
            set { this._scoreThreshold = value; }
        }

        // Check to see if ScoreThreshold property is set
        internal bool IsSetScoreThreshold()
        {
            return this._scoreThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScoreThresholdLastUpdatedAt. 
        /// <para>
        /// The time of the most recent edit to the <code>ScoreThreshold</code>. The time is expressed
        /// in epoch time.
        /// </para>
        /// </summary>
        public DateTime ScoreThresholdLastUpdatedAt
        {
            get { return this._scoreThresholdLastUpdatedAt.GetValueOrDefault(); }
            set { this._scoreThresholdLastUpdatedAt = value; }
        }

        // Check to see if ScoreThresholdLastUpdatedAt property is set
        internal bool IsSetScoreThresholdLastUpdatedAt()
        {
            return this._scoreThresholdLastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInBytes.
        /// </summary>
        public long SizeInBytes
        {
            get { return this._sizeInBytes.GetValueOrDefault(); }
            set { this._sizeInBytes = value; }
        }

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this._sizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt.
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
        /// The current status of an <code>MLModel</code>. This element can have one of the following
        /// values: 
        /// </para>
        ///  <ul> <li> <code>PENDING</code> - Amazon Machine Learning (Amazon ML) submitted a
        /// request to create an <code>MLModel</code>.</li> <li> <code>INPROGRESS</code> - The
        /// creation process is underway.</li> <li> <code>FAILED</code> - The request to create
        /// an <code>MLModel</code> didn't run to completion. The model isn't usable.</li> <li>
        /// <code>COMPLETED</code> - The creation process completed successfully.</li> <li> <code>DELETED</code>
        /// - The <code>MLModel</code> is marked as deleted. It isn't usable.</li> </ul>
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

        /// <summary>
        /// Gets and sets the property TrainingDataSourceId. 
        /// <para>
        /// The ID of the training <code>DataSource</code>. The <code>CreateMLModel</code> operation
        /// uses the <code>TrainingDataSourceId</code>.
        /// </para>
        /// </summary>
        public string TrainingDataSourceId
        {
            get { return this._trainingDataSourceId; }
            set { this._trainingDataSourceId = value; }
        }

        // Check to see if TrainingDataSourceId property is set
        internal bool IsSetTrainingDataSourceId()
        {
            return this._trainingDataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingParameters. 
        /// <para>
        /// A list of the training parameters in the <code>MLModel</code>. The list is implemented
        /// as a map of key-value pairs.
        /// </para>
        ///  
        /// <para>
        /// The following is the current set of training parameters: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>sgd.maxMLModelSizeInBytes</code> - The maximum allowed size of the model. Depending
        /// on the input data, the size of the model might affect its performance.
        /// </para>
        ///  
        /// <para>
        ///  The value is an integer that ranges from <code>100000</code> to <code>2147483648</code>.
        /// The default value is <code>33554432</code>.
        /// </para>
        ///  </li> <li>
        /// <para>
        /// <code>sgd.maxPasses</code> - The number of times that the training process traverses
        /// the observations to build the <code>MLModel</code>. The value is an integer that ranges
        /// from <code>1</code> to <code>10000</code>. The default value is <code>10</code>.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>sgd.shuffleType</code> - Whether Amazon ML shuffles the training data. Shuffling
        /// the data improves a model's ability to find the optimal solution for a variety of
        /// data types. The valid values are <code>auto</code> and <code>none</code>. The default
        /// value is <code>none</code>.
        /// </para>
        /// </li> <li> 
        /// <para>
        /// <code>sgd.l1RegularizationAmount</code> - The coefficient regularization L1 norm,
        /// which controls overfitting the data by penalizing large coefficients. This parameter
        /// tends to drive coefficients to zero, resulting in sparse feature set. If you use this
        /// parameter, start by specifying a small value, such as <code>1.0E-08</code>.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from <code>0</code> to <code>MAX_DOUBLE</code>.
        /// The default is to not use L1 normalization. This parameter can't be used when <code>L2</code>
        /// is specified. Use this parameter sparingly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>sgd.l2RegularizationAmount</code> - The coefficient regularization L2 norm,
        /// which controls overfitting the data by penalizing large coefficients. This tends to
        /// drive coefficients to small, nonzero values. If you use this parameter, start by specifying
        /// a small value, such as <code>1.0E-08</code>.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from <code>0</code> to <code>MAX_DOUBLE</code>.
        /// The default is to not use L2 normalization. This parameter can't be used when <code>L1</code>
        /// is specified. Use this parameter sparingly.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> TrainingParameters
        {
            get { return this._trainingParameters; }
            set { this._trainingParameters = value; }
        }

        // Check to see if TrainingParameters property is set
        internal bool IsSetTrainingParameters()
        {
            return this._trainingParameters != null && this._trainingParameters.Count > 0; 
        }

    }
}