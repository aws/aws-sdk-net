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
    /// This is the response object from the GetMLModel operation.
    /// </summary>
    public partial class GetMLModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ComputeTime. 
        /// <para>
        /// The approximate CPU time in milliseconds that Amazon Machine Learning spent processing
        /// the <c>MLModel</c>, normalized and scaled on computation resources. <c>ComputeTime</c>
        /// is only available if the <c>MLModel</c> is in the <c>COMPLETED</c> state.
        /// </para>
        /// </summary>
        public long? ComputeTime { get; set; }

        /// <summary>
        /// Checks to see if the ComputeTime property is set.
        /// </summary>
        internal bool IsSetComputeTime() => this.ComputeTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time that the <c>MLModel</c> was created. The time is expressed in epoch time.
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
        /// The AWS user account from which the <c>MLModel</c> was created. The account type can
        /// be either an AWS root account or an AWS Identity and Access Management (IAM) user
        /// account.
        /// </para>
        /// </summary>
        public string CreatedByIamUser { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByIamUser property is set.
        /// </summary>
        internal bool IsSetCreatedByIamUser() => this.CreatedByIamUser != null;

        /// <summary>
        /// Gets and sets the property EndpointInfo. 
        /// <para>
        /// The current endpoint of the <c>MLModel</c> 
        /// </para>
        /// </summary>
        public RealtimeEndpointInfo EndpointInfo { get; set; }

        /// <summary>
        /// Checks to see if the EndpointInfo property is set.
        /// </summary>
        internal bool IsSetEndpointInfo() => this.EndpointInfo != null;

        /// <summary>
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The epoch time when Amazon Machine Learning marked the <c>MLModel</c> as <c>COMPLETED</c>
        /// or <c>FAILED</c>. <c>FinishedAt</c> is only available when the <c>MLModel</c> is in
        /// the <c>COMPLETED</c> or <c>FAILED</c> state.
        /// </para>
        /// </summary>
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Checks to see if the FinishedAt property is set.
        /// </summary>
        internal bool IsSetFinishedAt() => this.FinishedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InputDataLocationS3. 
        /// <para>
        /// The location of the data file or directory in Amazon Simple Storage Service (Amazon
        /// S3).
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
        /// The time of the most recent edit to the <c>MLModel</c>. The time is expressed in epoch
        /// time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// A link to the file that contains logs of the <c>CreateMLModel</c> operation.
        /// </para>
        /// </summary>
        public string LogUri { get; set; }

        /// <summary>
        /// Checks to see if the LogUri property is set.
        /// </summary>
        internal bool IsSetLogUri() => this.LogUri != null;

        /// <summary>
        /// Gets and sets the property MLModelId. 
        /// <para>
        /// The MLModel ID, which is same as the <c>MLModelId</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string MLModelId { get; set; }

        /// <summary>
        /// Checks to see if the MLModelId property is set.
        /// </summary>
        internal bool IsSetMLModelId() => this.MLModelId != null;

        /// <summary>
        /// Gets and sets the property MLModelType. 
        /// <para>
        /// Identifies the <c>MLModel</c> category. The following are the available types: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// REGRESSION -- Produces a numeric result. For example, "What price should a house be
        /// listed at?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BINARY -- Produces one of two possible results. For example, "Is this an e-commerce
        /// website?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MULTICLASS -- Produces one of several possible results. For example, "Is this a HIGH,
        /// LOW or MEDIUM risk trade?"
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MLModelType MLModelType { get; set; }

        /// <summary>
        /// Checks to see if the MLModelType property is set.
        /// </summary>
        internal bool IsSetMLModelType() => this.MLModelType != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the most recent details about accessing the <c>MLModel</c>.
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
        /// A user-supplied name or description of the <c>MLModel</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Recipe. 
        /// <para>
        /// The recipe to use when training the <c>MLModel</c>. The <c>Recipe</c> provides detailed
        /// information about the observation data to use during training, and manipulations to
        /// perform on the observation data during training.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This parameter is provided as part of the verbose format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131071)]
        public string Recipe { get; set; }

        /// <summary>
        /// Checks to see if the Recipe property is set.
        /// </summary>
        internal bool IsSetRecipe() => this.Recipe != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema used by all of the data files referenced by the <c>DataSource</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This parameter is provided as part of the verbose format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131071)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property ScoreThreshold. 
        /// <para>
        /// The scoring threshold is used in binary classification <c>MLModel</c> models. It marks
        /// the boundary between a positive prediction and a negative prediction.
        /// </para>
        ///  
        /// <para>
        /// Output values greater than or equal to the threshold receive a positive result from
        /// the MLModel, such as <c>true</c>. Output values less than the threshold receive a
        /// negative response from the MLModel, such as <c>false</c>.
        /// </para>
        /// </summary>
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ScoreThreshold property is set.
        /// </summary>
        internal bool IsSetScoreThreshold() => this.ScoreThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property ScoreThresholdLastUpdatedAt. 
        /// <para>
        /// The time of the most recent edit to the <c>ScoreThreshold</c>. The time is expressed
        /// in epoch time.
        /// </para>
        /// </summary>
        public DateTime? ScoreThresholdLastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ScoreThresholdLastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetScoreThresholdLastUpdatedAt() => this.ScoreThresholdLastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInBytes.
        /// </summary>
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytes property is set.
        /// </summary>
        internal bool IsSetSizeInBytes() => this.SizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The epoch time when Amazon Machine Learning marked the <c>MLModel</c> as <c>INPROGRESS</c>.
        /// <c>StartedAt</c> isn't available if the <c>MLModel</c> is in the <c>PENDING</c> state.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the <c>MLModel</c>. This element can have one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon Machine Learning (Amazon ML) submitted a request to describe
        /// a <c>MLModel</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INPROGRESS</c> - The request is processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The request did not run to completion. The ML model isn't usable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The request completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - The <c>MLModel</c> is marked as deleted. It isn't usable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EntityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainingDataSourceId. 
        /// <para>
        /// The ID of the training <c>DataSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TrainingDataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataSourceId property is set.
        /// </summary>
        internal bool IsSetTrainingDataSourceId() => this.TrainingDataSourceId != null;

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
        /// data improves a model's ability to find the optimal solution for a variety of data
        /// types. The valid values are <c>auto</c> and <c>none</c>. The default value is <c>none</c>.
        /// We strongly recommend that you shuffle your data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.l1RegularizationAmount</c> - The coefficient regularization L1 norm. It controls
        /// overfitting the data by penalizing large coefficients. This tends to drive coefficients
        /// to zero, resulting in a sparse feature set. If you use this parameter, start by specifying
        /// a small value, such as <c>1.0E-08</c>.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from <c>0</c> to <c>MAX_DOUBLE</c>. The default
        /// is to not use L1 normalization. This parameter can't be used when <c>L2</c> is specified.
        /// Use this parameter sparingly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sgd.l2RegularizationAmount</c> - The coefficient regularization L2 norm. It controls
        /// overfitting the data by penalizing large coefficients. This tends to drive coefficients
        /// to small, nonzero values. If you use this parameter, start by specifying a small value,
        /// such as <c>1.0E-08</c>.
        /// </para>
        ///  
        /// <para>
        /// The value is a double that ranges from <c>0</c> to <c>MAX_DOUBLE</c>. The default
        /// is to not use L2 normalization. This parameter can't be used when <c>L1</c> is specified.
        /// Use this parameter sparingly.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TrainingParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TrainingParameters property is set.
        /// </summary>
        internal bool IsSetTrainingParameters() => this.TrainingParameters != null && (this.TrainingParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
