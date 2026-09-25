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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The status of an inbound cross-cluster connection for OpenSearch Service.
    /// </summary>
    public partial class InboundConnectionStatus
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Information about the connection.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code for the connection. Can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PENDING_ACCEPTANCE</b> - Inbound connection is not yet accepted by the remote
        /// domain owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>APPROVED</b>: Inbound connection is pending acceptance by the remote domain owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PROVISIONING</b>: Inbound connection is being provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b>: Inbound connection is active and ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REJECTING</b>: Inbound connection rejection is in process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REJECTED</b>: Inbound connection is rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETING</b>: Inbound connection deletion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DELETED</b>: Inbound connection is deleted and can no longer be used.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InboundConnectionStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;
    }
}
