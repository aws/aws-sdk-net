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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes a streaming session.
    /// </summary>
    public partial class Session
    {
        private AuthenticationType _authenticationType;
        private SessionConnectionState _connectionState;
        private string _fleetName;
        private string _id;
        private string _instanceId;
        private DateTime? _maxExpirationTime;
        private NetworkAccessConfiguration _networkAccessConfiguration;
        private string _stackName;
        private DateTime? _startTime;
        private StreamSessionState _state;
        private string _userId;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication method. The user is authenticated using a streaming URL (<c>API</c>)
        /// or SAML 2.0 federation (<c>SAML</c>).
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// Specifies whether a user is connected to the streaming session.
        /// </para>
        /// </summary>
        public SessionConnectionState ConnectionState
        {
            get { return this._connectionState; }
            set { this._connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this._connectionState != null;
        }

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet for the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string FleetName
        {
            get { return this._fleetName; }
            set { this._fleetName = value; }
        }

        // Check to see if FleetName property is set
        internal bool IsSetFleetName()
        {
            return this._fleetName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier for the instance hosting the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxExpirationTime. 
        /// <para>
        /// The time when the streaming session is set to expire. This time is based on the <c>MaxUserDurationinSeconds</c>
        /// value, which determines the maximum length of time that a streaming session can run.
        /// A streaming session might end earlier than the time specified in <c>SessionMaxExpirationTime</c>,
        /// when the <c>DisconnectTimeOutInSeconds</c> elapses or the user chooses to end his
        /// or her session. If the <c>DisconnectTimeOutInSeconds</c> elapses, or the user chooses
        /// to end his or her session, the streaming instance is terminated and the streaming
        /// session ends.
        /// </para>
        /// </summary>
        public DateTime? MaxExpirationTime
        {
            get { return this._maxExpirationTime; }
            set { this._maxExpirationTime = value; }
        }

        // Check to see if MaxExpirationTime property is set
        internal bool IsSetMaxExpirationTime()
        {
            return this._maxExpirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkAccessConfiguration. 
        /// <para>
        /// The network details for the streaming session.
        /// </para>
        /// </summary>
        public NetworkAccessConfiguration NetworkAccessConfiguration
        {
            get { return this._networkAccessConfiguration; }
            set { this._networkAccessConfiguration = value; }
        }

        // Check to see if NetworkAccessConfiguration property is set
        internal bool IsSetNetworkAccessConfiguration()
        {
            return this._networkAccessConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack for the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when a streaming instance is dedicated for the user.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamSessionState State
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
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user for whom the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=128)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}