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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Contains status information for a replication destination, including the current replication
    /// state, last successful update, and any error messages.
    /// </summary>
    public partial class ReplicationDestinationStatusModel
    {
        /// <summary>
        /// Gets and sets the property DestinationTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DestinationTableArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTableArn property is set.
        /// </summary>
        internal bool IsSetDestinationTableArn() => this.DestinationTableArn != null;

        /// <summary>
        /// Gets and sets the property DestinationTableBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationTableBucketArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationTableBucketArn property is set.
        /// </summary>
        internal bool IsSetDestinationTableBucketArn() => this.DestinationTableBucketArn != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// If replication has failed, this field contains an error message describing the failure
        /// reason.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfulReplicatedUpdate. 
        /// <para>
        /// Information about the most recent successful replication update to this destination.
        /// </para>
        /// </summary>
        public LastSuccessfulReplicatedUpdate LastSuccessfulReplicatedUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulReplicatedUpdate property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulReplicatedUpdate() => this.LastSuccessfulReplicatedUpdate != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// The current status of replication to this destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationStatus ReplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null;
    }
}
