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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The information for an RCS agent in an Amazon Web Services account.
    /// </summary>
    public partial class RcsAgentInformation
    {
        private DateTime? _createdTimestamp;
        private bool? _deletionProtectionEnabled;
        private string _optOutListName;
        private string _poolId;
        private string _rcsAgentArn;
        private string _rcsAgentId;
        private bool? _selfManagedOptOutsEnabled;
        private RcsAgentStatus _status;
        private TestingAgentInformation _testingAgent;
        private string _twoWayChannelArn;
        private string _twoWayChannelRole;
        private bool? _twoWayEnabled;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the RCS agent was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// When set to true the RCS agent can't be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the OptOutList associated with the RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OptOutListName
        {
            get { return this._optOutListName; }
            set { this._optOutListName = value; }
        }

        // Check to see if OptOutListName property is set
        internal bool IsSetOptOutListName()
        {
            return this._optOutListName != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The unique identifier of the pool associated with the RCS agent.
        /// </para>
        /// </summary>
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

        /// <summary>
        /// Gets and sets the property RcsAgentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RcsAgentArn
        {
            get { return this._rcsAgentArn; }
            set { this._rcsAgentArn = value; }
        }

        // Check to see if RcsAgentArn property is set
        internal bool IsSetRcsAgentArn()
        {
            return this._rcsAgentArn != null;
        }

        /// <summary>
        /// Gets and sets the property RcsAgentId. 
        /// <para>
        /// The unique identifier for the RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RcsAgentId
        {
            get { return this._rcsAgentId; }
            set { this._rcsAgentId = value; }
        }

        // Check to see if RcsAgentId property is set
        internal bool IsSetRcsAgentId()
        {
            return this._rcsAgentId != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedOptOutsEnabled. 
        /// <para>
        /// When set to true you're responsible for responding to HELP and STOP requests. You're
        /// also responsible for tracking and honoring opt-out requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? SelfManagedOptOutsEnabled
        {
            get { return this._selfManagedOptOutsEnabled; }
            set { this._selfManagedOptOutsEnabled = value; }
        }

        // Check to see if SelfManagedOptOutsEnabled property is set
        internal bool IsSetSelfManagedOptOutsEnabled()
        {
            return this._selfManagedOptOutsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the RCS agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RcsAgentStatus Status
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
        /// Gets and sets the property TestingAgent. 
        /// <para>
        /// The testing agent information associated with the RCS agent.
        /// </para>
        /// </summary>
        public TestingAgentInformation TestingAgent
        {
            get { return this._testingAgent; }
            set { this._testingAgent = value; }
        }

        // Check to see if TestingAgent property is set
        internal bool IsSetTestingAgent()
        {
            return this._testingAgent != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the two way channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TwoWayChannelArn
        {
            get { return this._twoWayChannelArn; }
            set { this._twoWayChannelArn = value; }
        }

        // Check to see if TwoWayChannelArn property is set
        internal bool IsSetTwoWayChannelArn()
        {
            return this._twoWayChannelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayChannelRole. 
        /// <para>
        /// An optional IAM Role Arn for a service to assume, to be able to post inbound SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TwoWayChannelRole
        {
            get { return this._twoWayChannelRole; }
            set { this._twoWayChannelRole = value; }
        }

        // Check to see if TwoWayChannelRole property is set
        internal bool IsSetTwoWayChannelRole()
        {
            return this._twoWayChannelRole != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayEnabled. 
        /// <para>
        /// When set to true you can receive incoming text messages from your end recipients using
        /// the TwoWayChannelArn.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? TwoWayEnabled
        {
            get { return this._twoWayEnabled; }
            set { this._twoWayEnabled = value; }
        }

        // Check to see if TwoWayEnabled property is set
        internal bool IsSetTwoWayEnabled()
        {
            return this._twoWayEnabled.HasValue; 
        }

    }
}