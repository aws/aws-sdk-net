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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetSSHPublicKey operation.
    /// Retrieves the specified SSH public key, including metadata about the key.
    /// 
    ///  
    /// <para>
    /// The SSH public key retrieved by this operation is used only for authenticating the
    /// associated IAM user to an AWS CodeCommit repository. For more information about using
    /// SSH keys to authenticate to an AWS CodeCommit repository, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
    /// up AWS CodeCommit for SSH Connections</a> in the <i>AWS CodeCommit User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetSSHPublicKeyRequest : AmazonIdentityManagementServiceRequest
    {
        private EncodingType _encoding;
        private string _sshPublicKeyId;
        private string _userName;

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// Specifies the public key encoding format to use in the response. To retrieve the public
        /// key in ssh-rsa format, use <code>SSH</code>. To retrieve the public key in PEM format,
        /// use <code>PEM</code>.
        /// </para>
        /// </summary>
        public EncodingType Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
        }

        /// <summary>
        /// Gets and sets the property SSHPublicKeyId. 
        /// <para>
        /// The unique identifier for the SSH public key.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters that can consist of any upper or lowercased letter or digit.
        /// </para>
        /// </summary>
        public string SSHPublicKeyId
        {
            get { return this._sshPublicKeyId; }
            set { this._sshPublicKeyId = value; }
        }

        // Check to see if SSHPublicKeyId property is set
        internal bool IsSetSSHPublicKeyId()
        {
            return this._sshPublicKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the IAM user associated with the SSH public key.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
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