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
    /// Returns properties of the server that was specified.
    /// </summary>
    public partial class ListedServer
    {
        private string _arn;
        private IdentityProviderType _identityProviderType;
        private string _loggingRole;
        private string _serverId;
        private State _state;
        private int? _userCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for the server to be listed.
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
        /// Gets and sets the property IdentityProviderType. 
        /// <para>
        /// The authentication method used to validate a user for the server that was specified.
        /// listed. This can include Secure Shell (SSH), user name and password combinations,
        /// or your own custom authentication method. Valid values include <code>SERVICE_MANAGED</code>
        /// or <code>API_GATEWAY</code>.
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
        /// The AWS Identity and Access Management entity that allows the server to turn on Amazon
        /// CloudWatch logging.
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
        /// This value is the unique system assigned identifier for the SFTP servers that were
        /// listed.
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
        /// This property describes the condition of the SFTP server for the server that was described.
        /// A value of <code>ONLINE</code>&gt; indicates that the server can accept jobs and transfer
        /// files. A <code>State</code> value of <code>OFFLINE</code> means that the server cannot
        /// perform file transfer operations.
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
        /// Gets and sets the property UserCount. 
        /// <para>
        /// This property is a numeric value that indicates the number of users that are assigned
        /// to the SFTP server you specified with the <code>ServerId</code>.
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