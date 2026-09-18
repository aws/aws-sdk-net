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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSourceServerReplicationType operation. Allows
    /// you to change between the AGENT_BASED replication type and the SNAPSHOT_SHIPPING replication
    /// type. <para> SNAPSHOT_SHIPPING should be used for agentless replication. </para>
    /// </summary>
    public partial class UpdateSourceServerReplicationTypeRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// Account ID on which to update replication type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property ReplicationType. 
        /// <para>
        /// Replication type to which to update source server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationType ReplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationType property is set.
        /// </summary>
        internal bool IsSetReplicationType() => this.ReplicationType != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// ID of source server on which to update replication type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;
    }
}
