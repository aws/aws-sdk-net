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
    /// This is the response object from the GetCollaborationTrainedModel operation.
    /// </summary>
    public partial class GetCollaborationTrainedModelResponse : AmazonWebServiceResponse
    {
        private string _collaborationIdentifier;
        private string _configuredModelAlgorithmAssociationArn;
        private DateTime? _createTime;
        private string _creatorAccountId;
        private string _description;
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
        private string _trainedModelArn;
        private string _trainingContainerImageDigest;
        private DateTime? _updateTime;

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
        /// was used to create this trained model.
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
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The account ID of the member that created the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string CreatorAccountId
        {
            get { return this._creatorAccountId; }
            set { this._creatorAccountId = value; }
        }

        // Check to see if CreatorAccountId property is set
        internal bool IsSetCreatorAccountId()
        {
            return this._creatorAccountId != null;
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
        /// Gets and sets the property LogsStatus. 
        /// <para>
        /// Status information for the logs.
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
        /// Details about the status information for the logs.
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
        /// Details about the status information for the model metrics.
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
        /// The EC2 resource configuration that was used to train this model.
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
        /// The stopping condition that determined when model training ended.
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
        /// Information about the training container image.
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the trained model was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}