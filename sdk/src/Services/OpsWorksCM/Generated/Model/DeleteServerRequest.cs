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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteServer operation.
    /// Deletes the server and the underlying CloudFormation stacks (including the server's
    /// EC2 instance). When you run this command, the server state is updated to <c>DELETING</c>.
    /// After the server is deleted, it is no longer returned by <c>DescribeServer</c> requests.
    /// If the CloudFormation stack cannot be deleted, the server cannot be deleted. 
    /// 
    ///  
    /// <para>
    ///  This operation is asynchronous. 
    /// </para>
    ///  
    /// <para>
    ///  An <c>InvalidStateException</c> is thrown when a server deletion is already in progress.
    /// A <c>ResourceNotFoundException</c> is thrown when the server does not exist. A <c>ValidationException</c>
    /// is raised when parameters of the request are not valid. 
    /// </para>
    ///  
    /// <para>
    ///  
    /// </para>
    /// </summary>
    public partial class DeleteServerRequest : AmazonOpsWorksCMRequest
    {
        private string _serverName;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The ID of the server to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}