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
    /// Provides information that describes status of a schema at an endpoint specified by
    /// the <c>DescribeRefreshSchemaStatus</c> operation.
    /// </summary>
    public partial class RefreshSchemasStatus
    {
        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the endpoint.
        /// </para>
        /// </summary>
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// The last failure message for the schema.
        /// </para>
        /// </summary>
        public string LastFailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastFailureMessage property is set.
        /// </summary>
        internal bool IsSetLastFailureMessage() => this.LastFailureMessage != null;

        /// <summary>
        /// Gets and sets the property LastRefreshDate. 
        /// <para>
        /// The date the schema was last refreshed.
        /// </para>
        /// </summary>
        public DateTime? LastRefreshDate { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshDate property is set.
        /// </summary>
        internal bool IsSetLastRefreshDate() => this.LastRefreshDate.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication instance.
        /// </para>
        /// </summary>
        public string ReplicationInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInstanceArn property is set.
        /// </summary>
        internal bool IsSetReplicationInstanceArn() => this.ReplicationInstanceArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the schema.
        /// </para>
        /// </summary>
        public RefreshSchemasStatusTypeValue Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
