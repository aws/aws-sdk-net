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
    /// Container for the parameters to the StopServer operation.
    /// Changes the state of an SFTP server from <code>ONLINE</code> to <code>OFFLINE</code>.
    /// An <code>OFFLINE</code> server cannot accept and process file transfer jobs. Information
    /// tied to your server such as server and user properties are not affected by stopping
    /// your server. Stopping a server will not reduce or impact your Secure File Transfer
    /// Protocol (SFTP) endpoint billing.
    /// 
    ///  
    /// <para>
    /// The states of <code>STOPPING</code> indicates that the server is in an intermediate
    /// state, either not fully able to respond, or not fully offline. The values of <code>STOP_FAILED</code>
    /// can indicate an error condition.
    /// </para>
    ///  
    /// <para>
    /// No response is returned from this call.
    /// </para>
    /// </summary>
    public partial class StopServerRequest : AmazonTransferRequest
    {
        private string _serverId;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for an SFTP server that you stopped.
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