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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describe the properties of the server that was specified. Information returned includes:
    /// the server Amazon Resource Name (ARN), the authentication configuration and type,
    /// the logging role, server Id and state, and assigned tags or metadata.
    /// </summary>
    public partial class DescribedServer
    {
        private string _arn;
        private IdentityProviderDetails _identityProviderDetails;
        private IdentityProviderType _identityProviderType;
        private string _loggingRole;
        private string _serverId;
        private State _state;
        private List<Tag> _tags = new List<Tag>();
        private int? _userCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) for the server to be described.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        /// Specifies information to call a customer-supplied authentication API. This field is
        /// not populated when the <code>IdentityProviderType</code> of the server is <code>SERVICE_MANAGED</code>&gt;.
        /// </para>
        /// </summary>
        public IdentityProviderDetails IdentityProviderDetails
        {
            get { return this._identityProviderDetails; }
            set { this._identityProviderDetails = value; }
        }

        // Check to see if IdentityProviderDetails property is set
        internal bool IsSetIdentityProviderDetails()
        {
            return this._identityProviderDetails != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderType. 
        /// <para>
        /// This property defines the mode of authentication method enabled for this service.
        /// A value of <code>SERVICE_MANAGED</code>, means that you are using this Server to store
        /// and access SFTP user credentials within the service. A value of <code>API_GATEWAY</code>
        /// indicates that you have integrated an API Gateway endpoint that will be invoked for
        /// authenticating your user into the service.
        /// </para>
        /// </summary>
        public IdentityProviderType IdentityProviderType
        {
            get { return this._identityProviderType; }
            set { this._identityProviderType = value; }
        }

        // Check to see if IdentityProviderType property is set
        internal bool IsSetIdentityProviderType()
        {
            return this._identityProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// This property is an AWS Identity and Access Management (IAM) entity that allows the
        /// server to turn on Amazon CloudWatch logging for Amazon S3 events. When set, user activity
        /// can be view in your CloudWatch logs.
        /// </para>
        /// </summary>
        public string LoggingRole
        {
            get { return this._loggingRole; }
            set { this._loggingRole = value; }
        }

        // Check to see if LoggingRole property is set
        internal bool IsSetLoggingRole()
        {
            return this._loggingRole != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// This property is a unique system assigned identifier for the SFTP server that you
        /// instantiate.
        /// </para>
        /// </summary>
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The condition of the SFTP server for the server that was described. A value of <code>ONLINE</code>
        /// indicates that the server can accept jobs and transfer files. A <code>State</code>
        /// value of <code>OFFLINE</code> means that the server cannot perform file transfer operations.
        /// </para>
        ///  
        /// <para>
        /// The states of <code>STARTING</code> and <code>STOPPING</code> indicated that the server
        /// is in an intermediate state, either not fully able to respond, or not fully offline.
        /// The values of <code>START_FAILED</code> or <code>STOP_FAILED</code> can indicate an
        /// error condition.
        /// </para>
        /// </summary>
        public State State
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// This property contains the key-value pairs that you can use to search for and group
        /// servers that were assigned to the server that was described.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of users that are assigned to the SFTP server you specified with the <code>ServerId</code>.
        /// </para>
        /// </summary>
        public int UserCount
        {
            get { return this._userCount.GetValueOrDefault(); }
            set { this._userCount = value; }
        }

        // Check to see if UserCount property is set
        internal bool IsSetUserCount()
        {
            return this._userCount.HasValue; 
        }

    }
}