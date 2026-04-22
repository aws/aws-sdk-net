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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Information about a session, including the session state, configuration, and timestamps.
    /// </summary>
    public partial class Session
    {
        private string _applicationId;
        private string _arn;
        private ResourceUtilization _billedResourceUtilization;
        private SessionConfigurationOverrides _configurationOverrides;
        private DateTime? _createdAt;
        private string _createdBy;
        private DateTime? _endedAt;
        private string _executionRoleArn;
        private DateTime? _idleSince;
        private long? _idleTimeoutMinutes;
        private string _name;
        private NetworkConfiguration _networkConfiguration;
        private string _releaseLabel;
        private string _sessionId;
        private DateTime? _startedAt;
        private SessionState _state;
        private string _stateDetails;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _totalExecutionDurationSeconds;
        private TotalResourceUtilization _totalResourceUtilization;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application that the session belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BilledResourceUtilization. 
        /// <para>
        /// The aggregate vCPU, memory, and storage that Amazon Web Services has billed for the
        /// session. The billed resources include a 1-minute minimum usage for workers, plus additional
        /// storage over 20 GB per worker. Note that billed resources do not include usage for
        /// idle pre-initialized workers.
        /// </para>
        /// </summary>
        public ResourceUtilization BilledResourceUtilization
        {
            get { return this._billedResourceUtilization; }
            set { this._billedResourceUtilization = value; }
        }

        // Check to see if BilledResourceUtilization property is set
        internal bool IsSetBilledResourceUtilization()
        {
            return this._billedResourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// The configuration overrides for the session, including runtime configuration properties.
        /// </para>
        /// </summary>
        public SessionConfigurationOverrides ConfigurationOverrides
        {
            get { return this._configurationOverrides; }
            set { this._configurationOverrides = value; }
        }

        // Check to see if ConfigurationOverrides property is set
        internal bool IsSetConfigurationOverrides()
        {
            return this._configurationOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The IAM principal that created the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time that the session was terminated or failed.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the execution role for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdleSince. 
        /// <para>
        /// The date and time that the session became idle.
        /// </para>
        /// </summary>
        public DateTime? IdleSince
        {
            get { return this._idleSince; }
            set { this._idleSince = value; }
        }

        // Check to see if IdleSince property is set
        internal bool IsSetIdleSince()
        {
            return this._idleSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdleTimeoutMinutes. 
        /// <para>
        /// The idle timeout in minutes for the session. After the session remains idle for this
        /// duration, it is automatically terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public long? IdleTimeoutMinutes
        {
            get { return this._idleTimeoutMinutes; }
            set { this._idleTimeoutMinutes = value; }
        }

        // Check to see if IdleTimeoutMinutes property is set
        internal bool IsSetIdleTimeoutMinutes()
        {
            return this._idleTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional name of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for customer VPC connectivity for the session.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release label associated with the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time that the session moved to a running state.
        /// </para>
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// Additional details about the current state of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the session.
        /// </para>
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
        /// Gets and sets the property TotalExecutionDurationSeconds. 
        /// <para>
        /// The total execution duration of the session in seconds.
        /// </para>
        /// </summary>
        public long? TotalExecutionDurationSeconds
        {
            get { return this._totalExecutionDurationSeconds; }
            set { this._totalExecutionDurationSeconds = value; }
        }

        // Check to see if TotalExecutionDurationSeconds property is set
        internal bool IsSetTotalExecutionDurationSeconds()
        {
            return this._totalExecutionDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResourceUtilization. 
        /// <para>
        /// The aggregate vCPU, memory, and storage resources used from the time the session starts
        /// to execute, until the time the session terminates, rounded up to the nearest second.
        /// </para>
        /// </summary>
        public TotalResourceUtilization TotalResourceUtilization
        {
            get { return this._totalResourceUtilization; }
            set { this._totalResourceUtilization = value; }
        }

        // Check to see if TotalResourceUtilization property is set
        internal bool IsSetTotalResourceUtilization()
        {
            return this._totalResourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the session was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}