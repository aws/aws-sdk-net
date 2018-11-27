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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Represents a replication run.
    /// </summary>
    public partial class ReplicationRun
    {
        private string _amiId;
        private DateTime? _completedTime;
        private string _description;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _replicationRunId;
        private DateTime? _scheduledStartTime;
        private ReplicationRunStageDetails _stageDetails;
        private ReplicationRunState _state;
        private string _statusMessage;
        private ReplicationRunType _type;

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The identifier of the Amazon Machine Image (AMI) from the replication run.
        /// </para>
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedTime. 
        /// <para>
        /// The completion time of the last replication run.
        /// </para>
        /// </summary>
        public DateTime CompletedTime
        {
            get { return this._completedTime.GetValueOrDefault(); }
            set { this._completedTime = value; }
        }

        // Check to see if CompletedTime property is set
        internal bool IsSetCompletedTime()
        {
            return this._completedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the replication run.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Whether the replication run should produce encrypted AMI or not. See also <code>KmsKeyId</code>
        /// below.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// KMS key ID for replication jobs that produce encrypted AMIs. Can be any of the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KMS key alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN referring to KMS key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN referring to KMS key alias
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If encrypted is <i>true</i> but a KMS key id is not specified, the customer's default
        /// KMS key for EBS is used. 
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationRunId. 
        /// <para>
        /// The identifier of the replication run.
        /// </para>
        /// </summary>
        public string ReplicationRunId
        {
            get { return this._replicationRunId; }
            set { this._replicationRunId = value; }
        }

        // Check to see if ReplicationRunId property is set
        internal bool IsSetReplicationRunId()
        {
            return this._replicationRunId != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledStartTime. 
        /// <para>
        /// The start time of the next replication run.
        /// </para>
        /// </summary>
        public DateTime ScheduledStartTime
        {
            get { return this._scheduledStartTime.GetValueOrDefault(); }
            set { this._scheduledStartTime = value; }
        }

        // Check to see if ScheduledStartTime property is set
        internal bool IsSetScheduledStartTime()
        {
            return this._scheduledStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StageDetails. 
        /// <para>
        /// Details of the current stage of the replication run.
        /// </para>
        /// </summary>
        public ReplicationRunStageDetails StageDetails
        {
            get { return this._stageDetails; }
            set { this._stageDetails = value; }
        }

        // Check to see if StageDetails property is set
        internal bool IsSetStageDetails()
        {
            return this._stageDetails != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the replication run.
        /// </para>
        /// </summary>
        public ReplicationRunState State
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The description of the current status of the replication job.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of replication run.
        /// </para>
        /// </summary>
        public ReplicationRunType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}