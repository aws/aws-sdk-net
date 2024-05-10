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
    /// Container for the parameters to the TestIdentityProvider operation.
    /// If the <c>IdentityProviderType</c> of a file transfer protocol-enabled server is <c>AWS_DIRECTORY_SERVICE</c>
    /// or <c>API_Gateway</c>, tests whether your identity provider is set up successfully.
    /// We highly recommend that you call this operation to test your authentication method
    /// as soon as you create your server. By doing so, you can troubleshoot issues with the
    /// identity provider integration to ensure that your users can successfully use the service.
    /// 
    ///  
    /// <para>
    ///  The <c>ServerId</c> and <c>UserName</c> parameters are required. The <c>ServerProtocol</c>,
    /// <c>SourceIp</c>, and <c>UserPassword</c> are all optional. 
    /// </para>
    ///  
    /// <para>
    /// Note the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  You cannot use <c>TestIdentityProvider</c> if the <c>IdentityProviderType</c> of
    /// your server is <c>SERVICE_MANAGED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TestIdentityProvider</c> does not work with keys: it only accepts passwords.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TestIdentityProvider</c> can test the password operation for a custom Identity
    /// Provider that handles keys and passwords.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If you provide any incorrect values for any parameters, the <c>Response</c> field
    /// is empty. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If you provide a server ID for a server that uses service-managed users, you get
    /// an error: 
    /// </para>
    ///  
    /// <para>
    ///  <c> An error occurred (InvalidRequestException) when calling the TestIdentityProvider
    /// operation: s-<i>server-ID</i> not configured for external auth </c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If you enter a Server ID for the <c>--server-id</c> parameter that does not identify
    /// an actual Transfer server, you receive the following error: 
    /// </para>
    ///  
    /// <para>
    ///  <c>An error occurred (ResourceNotFoundException) when calling the TestIdentityProvider
    /// operation: Unknown server</c>. 
    /// </para>
    ///  
    /// <para>
    /// It is possible your sever is in a different region. You can specify a region by adding
    /// the following: <c>--region region-code</c>, such as <c>--region us-east-2</c> to specify
    /// a server in <b>US East (Ohio)</b>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TestIdentityProviderRequest : AmazonTransferRequest
    {
        private string _serverId;
        private Protocol _serverProtocol;
        private string _sourceIp;
        private string _userName;
        private string _userPassword;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned identifier for a specific server. That server's user authentication
        /// method is tested with a user name and password.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
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
        /// Gets and sets the property ServerProtocol. 
        /// <para>
        /// The type of file transfer protocol to be tested.
        /// </para>
        ///  
        /// <para>
        /// The available protocols are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Secure Shell (SSH) File Transfer Protocol (SFTP)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// File Transfer Protocol Secure (FTPS)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// File Transfer Protocol (FTP)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Applicability Statement 2 (AS2)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Protocol ServerProtocol
        {
            get { return this._serverProtocol; }
            set { this._serverProtocol = value; }
        }

        // Check to see if ServerProtocol property is set
        internal bool IsSetServerProtocol()
        {
            return this._serverProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// The source IP address of the account to be tested.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string SourceIp
        {
            get { return this._sourceIp; }
            set { this._sourceIp = value; }
        }

        // Check to see if SourceIp property is set
        internal bool IsSetSourceIp()
        {
            return this._sourceIp != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the account to be tested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=100)]
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

        /// <summary>
        /// Gets and sets the property UserPassword. 
        /// <para>
        /// The password of the account to be tested.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string UserPassword
        {
            get { return this._userPassword; }
            set { this._userPassword = value; }
        }

        // Check to see if UserPassword property is set
        internal bool IsSetUserPassword()
        {
            return this._userPassword != null;
        }

    }
}