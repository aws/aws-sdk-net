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
    /// Container for the parameters to the StartRemoteDelete operation.
    /// Deletes a file or directory on the remote SFTP server.
    /// </summary>
    public partial class StartRemoteDeleteRequest : AmazonTransferRequest
    {
        private string _connectorId;
        private string _deletePath;

        /// <summary>
        /// Gets and sets the property ConnectorId. 
        /// <para>
        /// The unique identifier for the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ConnectorId
        {
            get { return this._connectorId; }
            set { this._connectorId = value; }
        }

        // Check to see if ConnectorId property is set
        internal bool IsSetConnectorId()
        {
            return this._connectorId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletePath. 
        /// <para>
        /// The absolute path of the file or directory to delete. You can only specify one path
        /// per call to this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string DeletePath
        {
            get { return this._deletePath; }
            set { this._deletePath = value; }
        }

        // Check to see if DeletePath property is set
        internal bool IsSetDeletePath()
        {
            return this._deletePath != null;
        }

    }
}