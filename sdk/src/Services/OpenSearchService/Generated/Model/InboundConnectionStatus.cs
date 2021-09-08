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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The connection status of an inbound cross-cluster connection.
    /// </summary>
    public partial class InboundConnectionStatus
    {
        private string _message;
        private InboundConnectionStatusCode _statusCode;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Verbose information for the inbound connection status.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The state code for the inbound connection. Can be one of the following:
        /// </para>
        ///  <ul> <li>PENDING_ACCEPTANCE: Inbound connection is not yet accepted by the remote
        /// domain owner.</li> <li>APPROVED: Inbound connection is pending acceptance by the remote
        /// domain owner.</li> <li>PROVISIONING: Inbound connection provisioning is in progress.</li>
        /// <li>ACTIVE: Inbound connection is active and ready to use.</li> <li>REJECTING: Inbound
        /// connection rejection is in process.</li> <li>REJECTED: Inbound connection is rejected.</li>
        /// <li>DELETING: Inbound connection deletion is in progress.</li> <li>DELETED: Inbound
        /// connection is deleted and can no longer be used.</li> </ul>
        /// </summary>
        public InboundConnectionStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}