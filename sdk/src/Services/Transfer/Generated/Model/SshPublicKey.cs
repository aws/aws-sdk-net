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
    /// Provides information about the public Secure Shell (SSH) key that is associated with
    /// a user account for a specific server (as identified by <code>ServerId</code>). The
    /// information returned includes the date the key was imported, the public key contents,
    /// and the public key ID. A user can store more than one SSH public key associated with
    /// their user name on a specific SFTP server.
    /// </summary>
    public partial class SshPublicKey
    {
        private DateTime? _dateImported;
        private string _sshPublicKeyBody;
        private string _sshPublicKeyId;

        /// <summary>
        /// Gets and sets the property DateImported. 
        /// <para>
        /// The date that the public key was added to the user account.
        /// </para>
        /// </summary>
        public DateTime DateImported
        {
            get { return this._dateImported.GetValueOrDefault(); }
            set { this._dateImported = value; }
        }

        // Check to see if DateImported property is set
        internal bool IsSetDateImported()
        {
            return this._dateImported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SshPublicKeyBody. 
        /// <para>
        /// The content of the SSH public key as specified by the <code>PublicKeyId</code>.
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
        /// Gets and sets the property SshPublicKeyId. 
        /// <para>
        /// The <code>SshPublicKeyId</code> parameter contains the identifier of the public key.
        /// </para>
        /// </summary>
        public string SshPublicKeyId
        {
            get { return this._sshPublicKeyId; }
            set { this._sshPublicKeyId = value; }
        }

        // Check to see if SshPublicKeyId property is set
        internal bool IsSetSshPublicKeyId()
        {
            return this._sshPublicKeyId != null;
        }

    }
}