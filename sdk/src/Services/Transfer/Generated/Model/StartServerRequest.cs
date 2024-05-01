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
    /// Container for the parameters to the StartServer operation.
    /// Changes the state of a file transfer protocol-enabled server from <c>OFFLINE</c> to
    /// <c>ONLINE</c>. It has no impact on a server that is already <c>ONLINE</c>. An <c>ONLINE</c>
    /// server can accept and process file transfer jobs.
    /// 
    ///  
    /// <para>
    /// The state of <c>STARTING</c> indicates that the server is in an intermediate state,
    /// either not fully able to respond, or not fully online. The values of <c>START_FAILED</c>
    /// can indicate an error condition.
    /// </para>
    ///  
    /// <para>
    /// No response is returned from this call.
    /// </para>
    /// </summary>
    public partial class StartServerRequest : AmazonTransferRequest
    {
        private string _serverId;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server that you start.
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

    }
}