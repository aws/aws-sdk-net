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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// A Recovery Instance is a replica of a Source Server running on EC2.
    /// </summary>
    public partial class RecoveryInstance
    {
        private string _arn;
        private RecoveryInstanceDataReplicationInfo _dataReplicationInfo;
        private string _ec2InstanceID;
        private EC2InstanceState _ec2InstanceState;
        private RecoveryInstanceFailback _failback;
        private bool? _isDrill;
        private string _jobid;
        private OriginEnvironment _originEnvironment;
        private string _pointInTimeSnapshotDateTime;
        private string _recoveryInstanceID;
        private RecoveryInstanceProperties _recoveryInstanceProperties;
        private string _sourceServerID;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property DataReplicationInfo. 
        /// <para>
        /// The Data Replication Info of the Recovery Instance.
        /// </para>
        /// </summary>
        public RecoveryInstanceDataReplicationInfo DataReplicationInfo
        {
            get { return this._dataReplicationInfo; }
            set { this._dataReplicationInfo = value; }
        }

        // Check to see if DataReplicationInfo property is set
        internal bool IsSetDataReplicationInfo()
        {
            return this._dataReplicationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceID. 
        /// <para>
        /// The EC2 instance ID of the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Ec2InstanceID
        {
            get { return this._ec2InstanceID; }
            set { this._ec2InstanceID = value; }
        }

        // Check to see if Ec2InstanceID property is set
        internal bool IsSetEc2InstanceID()
        {
            return this._ec2InstanceID != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceState. 
        /// <para>
        /// The state of the EC2 instance for this Recovery Instance.
        /// </para>
        /// </summary>
        public EC2InstanceState Ec2InstanceState
        {
            get { return this._ec2InstanceState; }
            set { this._ec2InstanceState = value; }
        }

        // Check to see if Ec2InstanceState property is set
        internal bool IsSetEc2InstanceState()
        {
            return this._ec2InstanceState != null;
        }

        /// <summary>
        /// Gets and sets the property Failback. 
        /// <para>
        /// An object representing failback related information of the Recovery Instance.
        /// </para>
        /// </summary>
        public RecoveryInstanceFailback Failback
        {
            get { return this._failback; }
            set { this._failback = value; }
        }

        // Check to see if Failback property is set
        internal bool IsSetFailback()
        {
            return this._failback != null;
        }

        /// <summary>
        /// Gets and sets the property IsDrill. 
        /// <para>
        /// Whether this Recovery Instance was created for a drill or for an actual Recovery event.
        /// </para>
        /// </summary>
        public bool IsDrill
        {
            get { return this._isDrill.GetValueOrDefault(); }
            set { this._isDrill = value; }
        }

        // Check to see if IsDrill property is set
        internal bool IsSetIsDrill()
        {
            return this._isDrill.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The ID of the Job that created the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property OriginEnvironment. 
        /// <para>
        /// Environment (On Premises / AWS) of the instance that the recovery instance originated
        /// from. 
        /// </para>
        /// </summary>
        public OriginEnvironment OriginEnvironment
        {
            get { return this._originEnvironment; }
            set { this._originEnvironment = value; }
        }

        // Check to see if OriginEnvironment property is set
        internal bool IsSetOriginEnvironment()
        {
            return this._originEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property PointInTimeSnapshotDateTime. 
        /// <para>
        /// The date and time of the Point in Time (PIT) snapshot that this Recovery Instance
        /// was launched from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string PointInTimeSnapshotDateTime
        {
            get { return this._pointInTimeSnapshotDateTime; }
            set { this._pointInTimeSnapshotDateTime = value; }
        }

        // Check to see if PointInTimeSnapshotDateTime property is set
        internal bool IsSetPointInTimeSnapshotDateTime()
        {
            return this._pointInTimeSnapshotDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryInstanceID. 
        /// <para>
        /// The ID of the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=19)]
        public string RecoveryInstanceID
        {
            get { return this._recoveryInstanceID; }
            set { this._recoveryInstanceID = value; }
        }

        // Check to see if RecoveryInstanceID property is set
        internal bool IsSetRecoveryInstanceID()
        {
            return this._recoveryInstanceID != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryInstanceProperties. 
        /// <para>
        /// Properties of the Recovery Instance machine.
        /// </para>
        /// </summary>
        public RecoveryInstanceProperties RecoveryInstanceProperties
        {
            get { return this._recoveryInstanceProperties; }
            set { this._recoveryInstanceProperties = value; }
        }

        // Check to see if RecoveryInstanceProperties property is set
        internal bool IsSetRecoveryInstanceProperties()
        {
            return this._recoveryInstanceProperties != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The Source Server ID that this Recovery Instance is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags that are associated with the Recovery Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}