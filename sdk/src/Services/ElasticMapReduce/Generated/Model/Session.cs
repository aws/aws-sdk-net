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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Detailed information about a Spark Connect session.
    /// </summary>
    public partial class Session
    {
        private string _accountId;
        private string _arn;
        private CertificateAuthority _certificateAuthority;
        private string _clusterId;
        private DateTime? _createdAt;
        private DateTime? _endedAt;
        private List<Configuration> _engineConfigurations = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;
        private string _executionRoleArn;
        private string _id;
        private DateTime? _idleSince;
        private SessionMonitoringConfiguration _monitoringConfiguration;
        private string _name;
        private string _releaseLabel;
        private string _serverUrl;
        private long? _sessionIdleTimeoutInMinutes;
        private DateTime? _startedAt;
        private SessionState _state;
        private string _stateChangeReason;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property CertificateAuthority. 
        /// <para>
        /// The certificate authority used to establish an mTLS connection to the Spark Connect
        /// server when connecting directly over VPC peering.
        /// </para>
        /// </summary>
        public CertificateAuthority CertificateAuthority
        {
            get { return this._certificateAuthority; }
            set { this._certificateAuthority = value; }
        }

        // Check to see if CertificateAuthority property is set
        internal bool IsSetCertificateAuthority()
        {
            return this._certificateAuthority != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The ID of the cluster that the session belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the session was created.
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
        /// Gets and sets the property EngineConfigurations. 
        /// <para>
        /// The configuration overrides for the session. Only runtime configuration overrides
        /// are supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> EngineConfigurations
        {
            get { return this._engineConfigurations; }
            set { this._engineConfigurations = value; }
        }

        // Check to see if EngineConfigurations property is set
        internal bool IsSetEngineConfigurations()
        {
            return this._engineConfigurations != null && (this._engineConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN for the session. Amazon EMR uses this role to access Amazon
        /// Web Services resources on your behalf during session execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IdleSince. 
        /// <para>
        /// The date and time that the session last entered the <c>IDLE</c> state.
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
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// The monitoring configuration for the session.
        /// </para>
        /// </summary>
        public SessionMonitoringConfiguration MonitoringConfiguration
        {
            get { return this._monitoringConfiguration; }
            set { this._monitoringConfiguration = value; }
        }

        // Check to see if MonitoringConfiguration property is set
        internal bool IsSetMonitoringConfiguration()
        {
            return this._monitoringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the session, if one was provided at creation time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release label of the cluster that the session is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The Spark Connect server URL for the session. Use this URL with the <c>Credentials</c>
        /// returned by <c>GetSessionEndpoint</c> to connect directly to the session over VPC
        /// peering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string ServerUrl
        {
            get { return this._serverUrl; }
            set { this._serverUrl = value; }
        }

        // Check to see if ServerUrl property is set
        internal bool IsSetServerUrl()
        {
            return this._serverUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SessionIdleTimeoutInMinutes. 
        /// <para>
        /// The idle timeout, in minutes. If the session is idle for this duration, Amazon EMR
        /// automatically terminates it.
        /// </para>
        /// </summary>
        public long? SessionIdleTimeoutInMinutes
        {
            get { return this._sessionIdleTimeoutInMinutes; }
            set { this._sessionIdleTimeoutInMinutes = value; }
        }

        // Check to see if SessionIdleTimeoutInMinutes property is set
        internal bool IsSetSessionIdleTimeoutInMinutes()
        {
            return this._sessionIdleTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time that the session entered the <c>STARTED</c> state.
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
        /// The current state of the session. Valid values are <c>SUBMITTED</c>, <c>STARTING</c>,
        /// <c>STARTED</c>, <c>IDLE</c>, <c>BUSY</c>, <c>TERMINATING</c>, <c>TERMINATED</c>, and
        /// <c>FAILED</c>.
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
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// A human-readable message describing the most recent state change.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string StateChangeReason
        {
            get { return this._stateChangeReason; }
            set { this._stateChangeReason = value; }
        }

        // Check to see if StateChangeReason property is set
        internal bool IsSetStateChangeReason()
        {
            return this._stateChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the session was last updated.
        /// </para>
        /// </summary>
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