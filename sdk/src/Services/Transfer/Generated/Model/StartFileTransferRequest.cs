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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the StartFileTransfer operation.
    /// Begins an outbound file transfer to a remote AS2 server. You specify the <code>ConnectorId</code>
    /// and the file paths for where to send the files.
    /// </summary>
    public partial class StartFileTransferRequest : AmazonTransferRequest
    {
        private string _connectorId;
        private List<string> _sendFilePaths = new List<string>();

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
        /// Gets and sets the property SendFilePaths. 
        /// <para>
        /// An array of strings. Each string represents the absolute path for one outbound file
        /// transfer. For example, <code> <i>DOC-EXAMPLE-BUCKET</i>/<i>myfile.txt</i> </code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> SendFilePaths
        {
            get { return this._sendFilePaths; }
            set { this._sendFilePaths = value; }
        }

        // Check to see if SendFilePaths property is set
        internal bool IsSetSendFilePaths()
        {
            return this._sendFilePaths != null && this._sendFilePaths.Count > 0; 
        }

    }
}