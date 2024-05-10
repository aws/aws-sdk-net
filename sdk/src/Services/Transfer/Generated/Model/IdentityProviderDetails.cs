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
    /// Returns information related to the type of user authentication that is in use for
    /// a file transfer protocol-enabled server's users. A server can have only one method
    /// of authentication.
    /// </summary>
    public partial class IdentityProviderDetails
    {
        private string _directoryId;
        private string _function;
        private string _invocationRole;
        private SftpAuthenticationMethods _sftpAuthenticationMethods;
        private string _url;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the Directory Service directory that you want to use as your identity
        /// provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The ARN for a Lambda function to use for the Identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=170)]
        public string Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationRole. 
        /// <para>
        /// This parameter is only applicable if your <c>IdentityProviderType</c> is <c>API_GATEWAY</c>.
        /// Provides the type of <c>InvocationRole</c> used to authenticate the user account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string InvocationRole
        {
            get { return this._invocationRole; }
            set { this._invocationRole = value; }
        }

        // Check to see if InvocationRole property is set
        internal bool IsSetInvocationRole()
        {
            return this._invocationRole != null;
        }

        /// <summary>
        /// Gets and sets the property SftpAuthenticationMethods. 
        /// <para>
        /// For SFTP-enabled servers, and for custom identity providers <i>only</i>, you can specify
        /// whether to authenticate using a password, SSH key pair, or both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PASSWORD</c> - users must provide their password to connect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC_KEY</c> - users must provide their private key to connect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC_KEY_OR_PASSWORD</c> - users can authenticate with either their password
        /// or their key. This is the default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PUBLIC_KEY_AND_PASSWORD</c> - users must provide both their private key and their
        /// password to connect. The server checks the key first, and then if the key is valid,
        /// the system prompts for a password. If the private key provided does not match the
        /// public key that is stored, authentication fails.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SftpAuthenticationMethods SftpAuthenticationMethods
        {
            get { return this._sftpAuthenticationMethods; }
            set { this._sftpAuthenticationMethods = value; }
        }

        // Check to see if SftpAuthenticationMethods property is set
        internal bool IsSetSftpAuthenticationMethods()
        {
            return this._sftpAuthenticationMethods != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// Provides the location of the service endpoint used to authenticate users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}