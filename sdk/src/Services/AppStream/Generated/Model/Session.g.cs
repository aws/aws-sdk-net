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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes a streaming session.
    /// </summary>
    public partial class Session
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// The authentication method. The user is authenticated using a streaming URL (<c>API</c>)
        /// or SAML 2.0 federation (<c>SAML</c>).
        /// </para>
        /// </summary>
        public AuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// Specifies whether a user is connected to the streaming session.
        /// </para>
        /// </summary>
        public SessionConnectionState ConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionState property is set.
        /// </summary>
        internal bool IsSetConnectionState() => this.ConnectionState != null;

        /// <summary>
        /// Gets and sets the property FleetName. 
        /// <para>
        /// The name of the fleet for the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string FleetName { get; set; }

        /// <summary>
        /// Checks to see if the FleetName property is set.
        /// </summary>
        internal bool IsSetFleetName() => this.FleetName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceDrainStatus. 
        /// <para>
        /// The drain status of the instance hosting the streaming session. This only applies
        /// to multi-session fleets.
        /// </para>
        /// </summary>
        public InstanceDrainStatus InstanceDrainStatus { get; set; }

        /// <summary>
        /// Checks to see if the InstanceDrainStatus property is set.
        /// </summary>
        internal bool IsSetInstanceDrainStatus() => this.InstanceDrainStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier for the instance hosting the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

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
        public DateTime? MaxExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the MaxExpirationTime property is set.
        /// </summary>
        internal bool IsSetMaxExpirationTime() => this.MaxExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkAccessConfiguration. 
        /// <para>
        /// The network details for the streaming session.
        /// </para>
        /// </summary>
        public NetworkAccessConfiguration NetworkAccessConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAccessConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkAccessConfiguration() => this.NetworkAccessConfiguration != null;

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name of the stack for the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string StackName { get; set; }

        /// <summary>
        /// Checks to see if the StackName property is set.
        /// </summary>
        internal bool IsSetStackName() => this.StackName != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when a streaming instance is dedicated for the user.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the streaming session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamSessionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user for whom the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
