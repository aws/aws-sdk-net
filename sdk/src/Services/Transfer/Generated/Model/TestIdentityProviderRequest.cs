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
    /// Container for the parameters to the TestIdentityProvider operation.
    /// If the <code>IdentityProviderType</code> of the server is <code>API_Gateway</code>,
    /// tests whether your API Gateway is set up successfully. We highly recommend that you
    /// call this method to test your authentication method as soon as you create your server.
    /// By doing so, you can troubleshoot issues with the API Gateway integration to ensure
    /// that your users can successfully use the service.
    /// </summary>
    public partial class TestIdentityProviderRequest : AmazonTransferRequest
    {
        private string _serverId;
        private string _userName;
        private string _userPassword;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system assigned identifier for a specific server. That server's user authentication
        /// method is tested with a user name and password.
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
        /// This request parameter is name of the user account to be tested.
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

        /// <summary>
        /// Gets and sets the property UserPassword. 
        /// <para>
        /// The password of the user account to be tested.
        /// </para>
        /// </summary>
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