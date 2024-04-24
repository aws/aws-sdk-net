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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies the connection status of an outbound cross-cluster search connection.
    /// </summary>
    public partial class OutboundCrossClusterSearchConnectionStatus
    {
        private string _message;
        private OutboundCrossClusterSearchConnectionStatusCode _statusCode;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Specifies verbose information for the outbound connection status.
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
        /// The state code for outbound connection. This can be one of the following:
        /// </para>
        ///  <ul> <li>VALIDATING: The outbound connection request is being validated.</li> <li>VALIDATION_FAILED:
        /// Validation failed for the connection request.</li> <li>PENDING_ACCEPTANCE: Outbound
        /// connection request is validated and is not yet accepted by destination domain owner.</li>
        /// <li>PROVISIONING: Outbound connection request is in process.</li> <li>ACTIVE: Outbound
        /// connection is active and ready to use.</li> <li>REJECTED: Outbound connection request
        /// is rejected by destination domain owner.</li> <li>DELETING: Outbound connection deletion
        /// is in progress.</li> <li>DELETED: Outbound connection is deleted and cannot be used
        /// further.</li> </ul>
        /// </summary>
        public OutboundCrossClusterSearchConnectionStatusCode StatusCode
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