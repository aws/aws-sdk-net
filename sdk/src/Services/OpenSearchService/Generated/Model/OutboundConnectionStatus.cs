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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The status of an outbound cross-cluster connection.
    /// </summary>
    public partial class OutboundConnectionStatus
    {
        private string _message;
        private OutboundConnectionStatusCode _statusCode;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Verbose information for the outbound connection.
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
        /// The status code for the outbound connection. Can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>VALIDATING</b> - The outbound connection request is being validated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VALIDATION_FAILED</b> - Validation failed for the connection request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PENDING_ACCEPTANCE</b>: Outbound connection request is validated and is not yet
        /// accepted by the remote domain owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>APPROVED</b> - Outbound connection has been approved by the remote domain owner
        /// for getting provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PROVISIONING</b> - Outbound connection request is in process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b> - Outbound connection is active and ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REJECTING</b> - Outbound connection rejection by remote domain owner is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REJECTED</b> - Outbound connection request is rejected by remote domain owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETING</b> - Outbound connection deletion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETED</b> - Outbound connection is deleted and can no longer be used.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OutboundConnectionStatusCode StatusCode
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