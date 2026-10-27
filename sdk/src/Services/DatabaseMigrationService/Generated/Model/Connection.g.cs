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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Status of the connection between an endpoint and a replication instance, including
    /// Amazon Resource Names (ARNs) and the last error message issued.
    /// </summary>
    public partial class Connection
    {
        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The ARN string that uniquely identifies the endpoint.
        /// </para>
        /// </summary>
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The identifier of the endpoint. Identifiers must begin with a letter and must contain
        /// only ASCII letters, digits, and hyphens. They can't end with a hyphen or contain two
        /// consecutive hyphens.
        /// </para>
        /// </summary>
        public string EndpointIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EndpointIdentifier property is set.
        /// </summary>
        internal bool IsSetEndpointIdentifier() => this.EndpointIdentifier != null;

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// The error message when the connection last failed.
        /// </para>
        /// </summary>
        public string LastFailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastFailureMessage property is set.
        /// </summary>
        internal bool IsSetLastFailureMessage() => this.LastFailureMessage != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The ARN of the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceArn() => this.ReplicationInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceIdentifier. 
        /// <para>
        /// The replication instance identifier. This parameter is stored as a lowercase string.
        /// </para>
        /// </summary>
        public string ReplicationInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceIdentifier() => this.ReplicationInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The connection status. This parameter can return one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"successful"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"testing"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"failed"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"deleting"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
