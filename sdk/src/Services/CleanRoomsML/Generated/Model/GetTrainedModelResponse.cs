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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// This is the response object from the GetTrainedModel operation.
    /// </summary>
    public partial class GetTrainedModelResponse : AmazonWebServiceResponse
    {
        private string _collaborationIdentifier;
        private string _configuredModelAlgorithmAssociationArn;
        private DateTime? _createTime;
        private List<ModelTrainingDataChannel> _dataChannels = AWSConfigs.InitializeCollections ? new List<ModelTrainingDataChannel>() : null;
        private string _description;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _hyperparameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<IncrementalTrainingDataChannelOutput> _incrementalTrainingDataChannels = AWSConfigs.InitializeCollections ? new List<IncrementalTrainingDataChannelOutput>() : null;
        private string _kmsKeyArn;
        private LogsStatus _logsStatus;
        private string _logsStatusDetails;
        private string _membershipIdentifier;
        private MetricsStatus _metricsStatus;
        private string _metricsStatusDetails;
        private string _name;
        private ResourceConfig _resourceConfig;
        private TrainedModelStatus _status;
        private StatusDetails _statusDetails;
        private StoppingCondition _stoppingCondition;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _trainedModelArn;
        private string _trainingContainerImageDigest;
        private TrainingInputMode _trainingInputMode;
        private DateTime? _updateTime;
        private string _versionIdentifier;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The collaboration ID of the collaboration that contains the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationIdentifier
        {
            get { return this._collaborationIdentifier; }
            set { this._collaborationIdentifier = value; }
        }

        // Check to see if CollaborationIdentifier property is set
        internal bool IsSetCollaborationIdentifier()
        {
            return this._collaborationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredModelAlgorithmAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured model algorithm association that
        /// was used to create the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ConfiguredModelAlgorithmAssociationArn
        {
            get { return this._configuredModelAlgorithmAssociationArn; }
            set { this._configuredModelAlgorithmAssociationArn = value; }
        }

        // Check to see if ConfiguredModelAlgorithmAssociationArn property is set
        internal bool IsSetConfiguredModelAlgorithmAssociationArn()
        {
            return this._configuredModelAlgorithmAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the trained model was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataChannels. 
        /// <para>
        /// The data channels that were used for the trained model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<ModelTrainingDataChannel> DataChannels
        {
            get { return this._dataChannels; }
            set { this._dataChannels = value; }
        }

        // Check to see if DataChannels property is set
        internal bool IsSetDataChannels()
        {
            return this._dataChannels != null && (this._dataChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The EC2 environment that was used to create the trained model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Hyperparameters. 
        /// <para>
        /// The hyperparameters that were used to create the trained model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> Hyperparameters
        {
            get { return this._hyperparameters; }
            set { this._hyperparameters = value; }
        }

        // Check to see if Hyperparameters property is set
        internal bool IsSetHyperparameters()
        {
            return this._hyperparameters != null && (this._hyperparameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncrementalTrainingDataChannels. 
        /// <para>
        /// Information about the incremental training data channels used to create this version
        /// of the trained model. This includes details about the base model that was used for
        /// incremental training and the channel configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<IncrementalTrainingDataChannelOutput> IncrementalTrainingDataChannels
        {
            get { return this._incrementalTrainingDataChannels; }
            set { this._incrementalTrainingDataChannels = value; }
        }

        // Check to see if IncrementalTrainingDataChannels property is set
        internal bool IsSetIncrementalTrainingDataChannels()
        {
            return this._incrementalTrainingDataChannels != null && (this._incrementalTrainingDataChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key. This key is used to encrypt and decrypt
        /// customer-owned data in the trained ML model and associated data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogsStatus. 
        /// <para>
        /// The logs status for the trained model.
        /// </para>
        /// </summary>
        public LogsStatus LogsStatus
        {
            get { return this._logsStatus; }
            set { this._logsStatus = value; }
        }

        // Check to see if LogsStatus property is set
        internal bool IsSetLogsStatus()
        {
            return this._logsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LogsStatusDetails. 
        /// <para>
        /// Details about the logs status for the trained model.
        /// </para>
        /// </summary>
        public string LogsStatusDetails
        {
            get { return this._logsStatusDetails; }
            set { this._logsStatusDetails = value; }
        }

        // Check to see if LogsStatusDetails property is set
        internal bool IsSetLogsStatusDetails()
        {
            return this._logsStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the member that created the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsStatus. 
        /// <para>
        /// The status of the model metrics.
        /// </para>
        /// </summary>
        public MetricsStatus MetricsStatus
        {
            get { return this._metricsStatus; }
            set { this._metricsStatus = value; }
        }

        // Check to see if MetricsStatus property is set
        internal bool IsSetMetricsStatus()
        {
            return this._metricsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsStatusDetails. 
        /// <para>
        /// Details about the metrics status for the trained model.
        /// </para>
        /// </summary>
        public string MetricsStatusDetails
        {
            get { return this._metricsStatusDetails; }
            set { this._metricsStatusDetails = value; }
        }

        // Check to see if MetricsStatusDetails property is set
        internal bool IsSetMetricsStatusDetails()
        {
            return this._metricsStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The EC2 resource configuration that was used to create the trained model.
        /// </para>
        /// </summary>
        public ResourceConfig ResourceConfig
        {
            get { return this._resourceConfig; }
            set { this._resourceConfig = value; }
        }

        // Check to see if ResourceConfig property is set
        internal bool IsSetResourceConfig()
        {
            return this._resourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainedModelStatus Status
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
        /// Gets and sets the property StatusDetails.
        /// </summary>
        public StatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The stopping condition that was used to terminate model training.
        /// </para>
        /// </summary>
        public StoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you applied to the resource to help you categorize and
        /// organize them. Each tag consists of a key and an optional value, both of which you
        /// define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use aws:, AWS:, or any upper or lowercase combination of such as a prefix for
        /// keys as it is reserved for AWS use. You cannot edit or delete tag keys with this prefix.
        /// Values can have this prefix. If a tag value has aws as its prefix but the key does
        /// not, then Clean Rooms ML considers it to be a user tag and will count against the
        /// limit of 50 tags. Tags with only the key prefix of aws do not count against your tags
        /// per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrainedModelArn
        {
            get { return this._trainedModelArn; }
            set { this._trainedModelArn = value; }
        }

        // Check to see if TrainedModelArn property is set
        internal bool IsSetTrainedModelArn()
        {
            return this._trainedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingContainerImageDigest. 
        /// <para>
        /// Information about the training image container.
        /// </para>
        /// </summary>
        public string TrainingContainerImageDigest
        {
            get { return this._trainingContainerImageDigest; }
            set { this._trainingContainerImageDigest = value; }
        }

        // Check to see if TrainingContainerImageDigest property is set
        internal bool IsSetTrainingContainerImageDigest()
        {
            return this._trainingContainerImageDigest != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingInputMode. 
        /// <para>
        /// The input mode that was used for accessing the training data when this trained model
        /// was created. This indicates how the training data was made available to the training
        /// algorithm.
        /// </para>
        /// </summary>
        public TrainingInputMode TrainingInputMode
        {
            get { return this._trainingInputMode; }
            set { this._trainingInputMode = value; }
        }

        // Check to see if TrainingInputMode property is set
        internal bool IsSetTrainingInputMode()
        {
            return this._trainingInputMode != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the trained model was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model. This unique identifier distinguishes
        /// this version from other versions of the same trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string VersionIdentifier
        {
            get { return this._versionIdentifier; }
            set { this._versionIdentifier = value; }
        }

        // Check to see if VersionIdentifier property is set
        internal bool IsSetVersionIdentifier()
        {
            return this._versionIdentifier != null;
        }

    }
}