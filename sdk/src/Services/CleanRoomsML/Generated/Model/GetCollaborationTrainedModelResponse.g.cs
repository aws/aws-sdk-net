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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// This is the response object from the GetCollaborationTrainedModel operation.
    /// </summary>
    public partial class GetCollaborationTrainedModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The collaboration ID of the collaboration that contains the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationIdentifier property is set.
        /// </summary>
        internal bool IsSetCollaborationIdentifier() => this.CollaborationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ConfiguredModelAlgorithmAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured model algorithm association that
        /// was used to create this trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ConfiguredModelAlgorithmAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredModelAlgorithmAssociationArn property is set.
        /// </summary>
        internal bool IsSetConfiguredModelAlgorithmAssociationArn() => this.ConfiguredModelAlgorithmAssociationArn != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the trained model was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The account ID of the member that created the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string CreatorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorAccountId property is set.
        /// </summary>
        internal bool IsSetCreatorAccountId() => this.CreatorAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IncrementalTrainingDataChannels. 
        /// <para>
        /// Information about the incremental training data channels used to create this version
        /// of the trained model. This includes details about the base model that was used for
        /// incremental training and the channel configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<IncrementalTrainingDataChannelOutput> IncrementalTrainingDataChannels { get; set; } = AWSConfigs.InitializeCollections ? new List<IncrementalTrainingDataChannelOutput>() : null;

        /// <summary>
        /// Checks to see if the IncrementalTrainingDataChannels property is set.
        /// </summary>
        internal bool IsSetIncrementalTrainingDataChannels() => this.IncrementalTrainingDataChannels != null && (this.IncrementalTrainingDataChannels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogsStatus. 
        /// <para>
        /// Status information for the logs.
        /// </para>
        /// </summary>
        public LogsStatus LogsStatus { get; set; }

        /// <summary>
        /// Checks to see if the LogsStatus property is set.
        /// </summary>
        internal bool IsSetLogsStatus() => this.LogsStatus != null;

        /// <summary>
        /// Gets and sets the property LogsStatusDetails. 
        /// <para>
        /// Details about the status information for the logs.
        /// </para>
        /// </summary>
        public string LogsStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the LogsStatusDetails property is set.
        /// </summary>
        internal bool IsSetLogsStatusDetails() => this.LogsStatusDetails != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the member that created the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property MetricsStatus. 
        /// <para>
        /// The status of the model metrics.
        /// </para>
        /// </summary>
        public MetricsStatus MetricsStatus { get; set; }

        /// <summary>
        /// Checks to see if the MetricsStatus property is set.
        /// </summary>
        internal bool IsSetMetricsStatus() => this.MetricsStatus != null;

        /// <summary>
        /// Gets and sets the property MetricsStatusDetails. 
        /// <para>
        /// Details about the status information for the model metrics.
        /// </para>
        /// </summary>
        public string MetricsStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the MetricsStatusDetails property is set.
        /// </summary>
        internal bool IsSetMetricsStatusDetails() => this.MetricsStatusDetails != null;

        /// <summary>
        /// Gets and sets the property MlModelTrainingPayerAccountId. 
        /// <para>
        /// The account ID of the member that is responsible for paying for model training costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string MlModelTrainingPayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the MlModelTrainingPayerAccountId property is set.
        /// </summary>
        internal bool IsSetMlModelTrainingPayerAccountId() => this.MlModelTrainingPayerAccountId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The EC2 resource configuration that was used to train this model.
        /// </para>
        /// </summary>
        public ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfig property is set.
        /// </summary>
        internal bool IsSetResourceConfig() => this.ResourceConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainedModelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails.
        /// </summary>
        public StatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The stopping condition that determined when model training ended.
        /// </para>
        /// </summary>
        public StoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TrainedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelArn property is set.
        /// </summary>
        internal bool IsSetTrainedModelArn() => this.TrainedModelArn != null;

        /// <summary>
        /// Gets and sets the property TrainingContainerImageDigest. 
        /// <para>
        /// Information about the training container image.
        /// </para>
        /// </summary>
        public string TrainingContainerImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the TrainingContainerImageDigest property is set.
        /// </summary>
        internal bool IsSetTrainingContainerImageDigest() => this.TrainingContainerImageDigest != null;

        /// <summary>
        /// Gets and sets the property TrainingInputMode. 
        /// <para>
        /// The input mode that was used for accessing the training data when this trained model
        /// was created. This indicates how the training data was made available to the training
        /// algorithm.
        /// </para>
        /// </summary>
        public TrainingInputMode TrainingInputMode { get; set; }

        /// <summary>
        /// Checks to see if the TrainingInputMode property is set.
        /// </summary>
        internal bool IsSetTrainingInputMode() => this.TrainingInputMode != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the trained model was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property VersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model. This unique identifier distinguishes
        /// this version from other versions of the same trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string VersionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VersionIdentifier property is set.
        /// </summary>
        internal bool IsSetVersionIdentifier() => this.VersionIdentifier != null;
    }
}
