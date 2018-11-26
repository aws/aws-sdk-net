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
    /// Container for the parameters to the CreateUser operation.
    /// Adds a user and associate them with an existing Secure File Transfer Protocol (SFTP)
    /// server. Using parameters for <code>CreateUser</code>, you can specify the user name,
    /// set the home directory, store the user's public key, and assign the user's AWS Identity
    /// and Access Management (IAM) role. You can also optionally add a scope-down policy,
    /// and assign metadata with tags that can be used to group and search for users.
    /// 
    ///  
    /// <para>
    /// The response returns the <code>UserName</code> and <code>ServerId</code> values of
    /// the new user for that server.
    /// </para>
    /// </summary>
    public partial class CreateUserRequest : AmazonTransferRequest
    {
        private string _homeDirectory;
        private string _policy;
        private string _role;
        private string _serverId;
        private string _sshPublicKeyBody;
        private List<Tag> _tags = new List<Tag>();
        private string _userName;

        /// <summary>
        /// Gets and sets the property HomeDirectory. 
        /// <para>
        /// The landing directory (folder) for a user when they log in to the server using their
        /// SFTP client. An example is <code>/home/<i>username</i> </code>.
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
        /// A scope-down policy for your user so you can use the same IAM role across multiple
        /// users. This policy scopes down user access to portions of their Amazon S3 bucket.
        /// Variables you can use inside this policy include <code>${Transfer:UserName}</code>,
        /// <code>${Transfer:HomeDirectory}</code>, and <code>${Transfer:HomeBucket}</code>.
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
        /// IAM role should also contain a trust relationship that allows the SFTP server to access
        /// your resources when servicing your SFTP user’s transfer requests.
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
        /// A system-assigned unique identifier for an SFTP server instance. This is the specific
        /// SFTP server that you added your user to.
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
        /// Gets and sets the property SshPublicKeyBody. 
        /// <para>
        /// The public portion of the Secure Shall (SSH) key used to authenticate the user to
        /// the SFTP server.
        /// </para>
        /// </summary>
        public string SshPublicKeyBody
        {
            get { return this._sshPublicKeyBody; }
            set { this._sshPublicKeyBody = value; }
        }

        // Check to see if SshPublicKeyBody property is set
        internal bool IsSetSshPublicKeyBody()
        {
            return this._sshPublicKeyBody != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for users. Tags are metadata
        /// attached to users for any purpose.
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// A unique string that identifies a user and is associated with a server as specified
        /// by the <code>ServerId</code>.
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