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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Provides information about the public Secure Shell (SSH) key that is associated with
    /// a Transfer Family user for the specific file transfer protocol-enabled server (as
    /// identified by <c>ServerId</c>). The information returned includes the date the key
    /// was imported, the public key contents, and the public key ID. A user can store more
    /// than one SSH public key associated with their user name on a specific server.
    /// </summary>
    public partial class SshPublicKey
    {
        private DateTime? _dateImported;
        private string _sshPublicKeyBody;
        private string _sshPublicKeyId;

        /// <summary>
        /// Gets and sets the property DateImported. 
        /// <para>
        /// Specifies the date that the public key was added to the Transfer Family user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DateImported
        {
            get { return this._dateImported; }
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
        /// Specifies the content of the SSH public key as specified by the <c>PublicKeyId</c>.
        /// </para>
        ///  
        /// <para>
        /// Transfer Family accepts RSA, ECDSA, and ED25519 keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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
        /// Specifies the <c>SshPublicKeyId</c> parameter contains the identifier of the public
        /// key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
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