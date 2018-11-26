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
    /// Container for the parameters to the UpdateUser operation.
    /// Assigns new properties to a user. Parameters you pass modify any or all of the following:
    /// the home directory, role, and policy for the <code>UserName</code> and <code>ServerId</code>
    /// you specify.
    /// 
    ///  
    /// <para>
    /// The response returns the <code>ServerId</code> and the <code>UserName</code> for the
    /// updated user.
    /// </para>
    /// </summary>
    public partial class UpdateUserRequest : AmazonTransferRequest
    {
        private string _homeDirectory;
        private string _policy;
        private string _role;
        private string _serverId;
        private string _userName;

        /// <summary>
        /// Gets and sets the property HomeDirectory. 
        /// <para>
        /// The HomeDirectory parameter specifies the landing directory (folder) for a user when
        /// they log in to the server using their client. An example would be: <code>/home/<i>username</i>
        /// </code>.
        /// </para>
        /// </summary>
        public string HomeDirectory
        {
            get { return this._homeDirectory; }
            set { this._homeDirectory = value; }
        }

        // Check to see if HomeDirectory property is set
        internal bool IsSetHomeDirectory()
        {
            return this._homeDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Allows you to supply a scope-down policy for your user so you can use the same AWS
        /// Identity and Access Management (IAM) role across multiple users. The policy scopes
        /// down users access to portions of your Amazon S3 bucket. Variables you can use inside
        /// this policy include <code>${Transfer:UserName}</code>, <code>${Transfer:HomeDirectory}</code>,
        /// and <code>${Transfer:HomeBucket}</code>.
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that controls your user’s access to your Amazon S3 bucket. The policies
        /// attached to this role will determine the level of access you want to provide your
        /// users when transferring files into and out of your Amazon S3 bucket or buckets. The
        /// IAM role should also contain a trust relationship that allows the Secure File Transfer
        /// Protocol (SFTP) server to access your resources when servicing your SFTP user’s transfer
        /// requests.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for an SFTP server instance that the user account
        /// is assigned to.
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// A unique string that identifies a user and is associated with a server as specified
        /// by the ServerId. This is the string that will be used by your user when they log in
        /// to your SFTP server.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}