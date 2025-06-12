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
    /// Represents the output of a <c>GetMLModel</c> operation. 
    /// 
    ///  
    /// <para>
    /// The content consists of the detailed metadata and the current status of the <c>MLModel</c>.
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
        private Dictionary<string, string> _trainingParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The algorithm used to train the <c>MLModel</c>. The following algorithm is supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SGD</c> -- Stochastic gradient descent. The goal of <c>SGD</c> is to minimize
        /// the gradient of the loss function. 
        /// </para>
        ///  </li> </ul>
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
        /// The time that the <c>MLModel</c> was created. The time is expressed in epoch time.
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
        /// The AWS user account from which the <c>MLModel</c> was created. The account type can
        /// be either an AWS root account or an AWS Identity and Access Management (IAM) user
        /// account.
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
        /// The current endpoint of the <c>MLModel</c>.
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
        /// The location of the data file or directory in Amazon Simple Storage Service (Amazon
        /// S3).
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
        /// The time of the most recent edit to the <c>MLModel</c>. The time is expressed in epoch
        /// time.
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
        /// A description of the most recent details about accessing the <c>MLModel</c>.
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
        /// The ID assigned to the <c>MLModel</c> at creation.
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
        /// Gets and sets the property MLModelType. 
        /// <para>
        /// Identifies the <c>MLModel</c> category. The following are the available types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REGRESSION</c> - Produces a numeric result. For example, "What price should a
        /// house be listed at?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BINARY</c> - Produces one of two possible results. For example, "Is this a child-friendly
        /// web site?".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTICLASS</c> - Produces one of several possible results. For example, "Is this
        /// a HIGH-, LOW-, or MEDIUM-risk trade?".
        /// </para>
        ///  </li> </ul>
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
        /// A user-supplied name or description of the <c>MLModel</c>.
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
        /// Gets and sets the property ScoreThreshold.
        /// </summary>
        public float? ScoreThreshold
        {
            get { return this._scoreThreshold; }
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
        /// The time of the most recent edit to the <c>ScoreThreshold</c>. The time is expressed
        /// in epoch time.
        /// </para>
        /// </summary>
        public DateTime? ScoreThresholdLastUpdatedAt
        {
            get { return this._scoreThresholdLastUpdatedAt; }
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
        public long? SizeInBytes
        {
            get { return this._sizeInBytes; }
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
        /// The current status of an <c>MLModel</c>. This element can have one of the following
        /// values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon Machine Learning (Amazon ML) submitted a request to create
        /// an <c>MLModel</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INPROGRESS</c> - The creation process is underway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The request to create an <c>MLModel</c> didn't run to completion.
        /// The model isn't usable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The creation process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The <c>MLModel</c> is marked as deleted. It isn't usable.
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

        /// <summary>
        /// Gets and sets the property TrainingDataSourceId. 
        /// <para>
        /// The ID of the training <c>DataSource</c>. The <c>CreateMLModel</c> operation uses
        /// the <c>TrainingDataSourceId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// A list of the training parameters in the <c>MLModel</c>. The list is implemented as
        /// a map of key-value pairs.
        /// </para>
        ///  
        /// <para>
        /// The following is the current set of training parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>sgd.maxMLModelSizeInBytes</c> - The maximum allowed size of the model. Depending
        /// on the input data, the size of the model might affect its performance.
        /// </para>
        ///  
        /// <para>
        ///  The value is an integer that ranges from <c>100000</c> to <c>2147483648</c>. The
        /// default value is <c>33554432</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.maxPasses</c> - The number of times that the training process traverses the
        /// observations to build the <c>MLModel</c>. The value is an integer that ranges from
        /// <c>1</c> to <c>10000</c>. The default value is <c>10</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.shuffleType</c> - Whether Amazon ML shuffles the training data. Shuffling
        /// the data improves a model's ability to find the optimal solution for a variety of
        /// data types. The valid values are <c>auto</c> and <c>none</c>. The default value is
        /// <c>none</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.l1RegularizationAmount</c> - The coefficient regularization L1 norm, which
        /// controls overfitting the data by penalizing large coefficients. This parameter tends
        /// to drive coefficients to zero, resulting in sparse feature set. If you use this parameter,
        /// start by specifying a small value, such as <c>1.0E-08</c>.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from <c>0</c> to <c>MAX_DOUBLE</c>. The default
        /// is to not use L1 normalization. This parameter can't be used when <c>L2</c> is specified.
        /// Use this parameter sparingly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.l2RegularizationAmount</c> - The coefficient regularization L2 norm, which
        /// controls overfitting the data by penalizing large coefficients. This tends to drive
        /// coefficients to small, nonzero values. If you use this parameter, start by specifying
        /// a small value, such as <c>1.0E-08</c>.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from <c>0</c> to <c>MAX_DOUBLE</c>. The default
        /// is to not use L2 normalization. This parameter can't be used when <c>L1</c> is specified.
        /// Use this parameter sparingly.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TrainingParameters
        {
            get { return this._trainingParameters; }
            set { this._trainingParameters = value; }
        }

        // Check to see if TrainingParameters property is set
        internal bool IsSetTrainingParameters()
        {
            return this._trainingParameters != null && (this._trainingParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}