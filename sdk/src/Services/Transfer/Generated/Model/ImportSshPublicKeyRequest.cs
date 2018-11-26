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
    /// Container for the parameters to the ImportSshPublicKey operation.
    /// Adds a Secure Shell (SSH) public key to a user account identified by a <code>UserName</code>
    /// value assigned to a specific server, identified by <code>ServerId</code>.
    /// 
    ///  
    /// <para>
    /// The response returns the <code>UserName</code> value, the <code>ServerId</code> value,
    /// and the name of the <code>SshPublicKeyId</code>.
    /// </para>
    /// </summary>
    public partial class ImportSshPublicKeyRequest : AmazonTransferRequest
    {
        private string _serverId;
        private string _sshPublicKeyBody;
        private string _userName;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for an SFTP server.
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
        /// The public key portion of an SSH key pair.
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user account that is assigned to one or more servers.
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