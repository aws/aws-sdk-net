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
    /// Provides summary information about a trained model inference job in a collaboration.
    /// </summary>
    public partial class CollaborationTrainedModelInferenceJobSummary
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
        private InferenceOutputConfiguration _outputConfiguration;
        private TrainedModelInferenceJobStatus _status;
        private string _trainedModelArn;
        private string _trainedModelInferenceJobArn;
        private string _trainedModelVersionIdentifier;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The collaboration ID of the collaboration that contains the trained model inference
        /// job.
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
        /// is used for the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The time at which the trained model inference job was created.
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
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The account ID that created the trained model inference job.
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
        /// The description of the trained model inference job.
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
        /// The trained model inference job logs status.
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
        /// Details about the logs status for the trained model inference job.
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
        /// The membership ID of the membership that contains the trained model inference job.
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
        /// the trained model inference job metrics status.
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
        /// Details about the metrics status for trained model inference job.
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
        /// The name of the trained model inference job.
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
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// Returns output configuration information for the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceOutputConfiguration OutputConfiguration
        {
            get { return this._outputConfiguration; }
            set { this._outputConfiguration = value; }
        }

        // Check to see if OutputConfiguration property is set
        internal bool IsSetOutputConfiguration()
        {
            return this._outputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainedModelInferenceJobStatus Status
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
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model that is used for the trained model
        /// inference job.
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
        /// Gets and sets the property TrainedModelInferenceJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TrainedModelInferenceJobArn
        {
            get { return this._trainedModelInferenceJobArn; }
            set { this._trainedModelInferenceJobArn = value; }
        }

        // Check to see if TrainedModelInferenceJobArn property is set
        internal bool IsSetTrainedModelInferenceJobArn()
        {
            return this._trainedModelInferenceJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelVersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model that was used for inference in this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string TrainedModelVersionIdentifier
        {
            get { return this._trainedModelVersionIdentifier; }
            set { this._trainedModelVersionIdentifier = value; }
        }

        // Check to see if TrainedModelVersionIdentifier property is set
        internal bool IsSetTrainedModelVersionIdentifier()
        {
            return this._trainedModelVersionIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the trained model inference job was updated.
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

    }
}