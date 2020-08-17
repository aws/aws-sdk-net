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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Returns information related to the type of user authentication that is in use for
    /// a file transfer protocol-enabled server's users. A server can have only one method
    /// of authentication.
    /// </summary>
    public partial class IdentityProviderDetails
    {
        private string _invocationRole;
        private string _url;

        /// <summary>
        /// Gets and sets the property InvocationRole. 
        /// <para>
        /// Provides the type of <code>InvocationRole</code> used to authenticate the user account.
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
        /// Gets and sets the property Url. 
        /// <para>
        /// Provides the location of the service endpoint used to authenticate users.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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