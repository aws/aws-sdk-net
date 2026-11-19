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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Describes an active user session. Amazon Cognito returns this type in the responses
    /// of <c>ListUserSessions</c> and <c>AdminListUserSessions</c>, for both token sessions
    /// and SSO sessions.
    /// </summary>
    public partial class SessionDescriptionType
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that the session belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the session was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// A description of the device associated with the most recent activity on the session,
        /// derived from the parsed user agent (operating system and browser or app). Amazon Cognito
        /// overwrites this value on each sign-in, refresh, and rotation. The value can be <c>unknown</c>.
        /// The maximum length is 1,024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Checks to see if the DeviceType property is set.
        /// </summary>
        internal bool IsSetDeviceType() => this.DeviceType != null;

        /// <summary>
        /// Gets and sets the property IsCurrentSession. 
        /// <para>
        /// Specifies whether this session matches the access token supplied in the request. This
        /// value is always <c>false</c> for the <c>AdminListUserSessions</c> operation, which
        /// doesn't take an access token.
        /// </para>
        /// </summary>
        public bool? IsCurrentSession { get; set; }

        /// <summary>
        /// Checks to see if the IsCurrentSession property is set.
        /// </summary>
        internal bool IsSetIsCurrentSession() => this.IsCurrentSession.HasValue;

        /// <summary>
        /// Gets and sets the property LastActiveDate. 
        /// <para>
        /// The date and time of the most recent activity on the session. For a token session,
        /// this is the most recent token refresh or rotation; a new authentication creates a
        /// new token session rather than updating an existing one. For an SSO session, this is
        /// the most recent authentication, token grant, or token rotation.
        /// </para>
        /// </summary>
        public DateTime? LastActiveDate { get; set; }

        /// <summary>
        /// Checks to see if the LastActiveDate property is set.
        /// </summary>
        internal bool IsSetLastActiveDate() => this.LastActiveDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastIPAddress. 
        /// <para>
        /// The IP address associated with the most recent activity on the session. Amazon Cognito
        /// overwrites this value on each refresh and rotation. The maximum length is 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 128)]
        public string LastIPAddress { get; set; }

        /// <summary>
        /// Checks to see if the LastIPAddress property is set.
        /// </summary>
        internal bool IsSetLastIPAddress() => this.LastIPAddress != null;

        /// <summary>
        /// Gets and sets the property LastLocation. 
        /// <para>
        /// The geographic location of the most recent activity on the session, derived from the
        /// IP address.
        /// </para>
        /// </summary>
        public SessionLocationType LastLocation { get; set; }

        /// <summary>
        /// Checks to see if the LastLocation property is set.
        /// </summary>
        internal bool IsSetLastLocation() => this.LastLocation != null;

        /// <summary>
        /// Gets and sets the property OriginSessionId. 
        /// <para>
        /// For a token session, the ID of the SSO session that the token session originated from.
        /// This value is null for sessions that were initiated through the API and didn't come
        /// through an SSO session. Amazon Cognito returns this value for token sessions only.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 28, Max = 28)]
        public string OriginSessionId { get; set; }

        /// <summary>
        /// Checks to see if the OriginSessionId property is set.
        /// </summary>
        internal bool IsSetOriginSessionId() => this.OriginSessionId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier for the session. This is a 28-character string of lowercase
        /// letters and digits, prefixed with <c>tkn</c> for a token session or <c>sso</c> for
        /// an SSO session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 28, Max = 28)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionType. 
        /// <para>
        /// The type of the session. Valid values are <c>TOKEN</c> and <c>SSO</c>.
        /// </para>
        /// </summary>
        public SessionTypeType SessionType { get; set; }

        /// <summary>
        /// Checks to see if the SessionType property is set.
        /// </summary>
        internal bool IsSetSessionType() => this.SessionType != null;
    }
}
