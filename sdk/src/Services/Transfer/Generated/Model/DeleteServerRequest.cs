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
    /// Container for the parameters to the DeleteServer operation.
    /// Deletes the Secure File Transfer Protocol (SFTP) server that you specify. If you used
    /// <code>SERVICE_MANAGED</code> as your <code>IdentityProviderType</code>, you need to
    /// delete all users associated with this server before deleting the server itself
    /// 
    ///  
    /// <para>
    /// No response returns from this call.
    /// </para>
    /// </summary>
    public partial class DeleteServerRequest : AmazonTransferRequest
    {
        private string _serverId;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A unique system-assigned identifier for an SFTP server instance.
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

    }
}