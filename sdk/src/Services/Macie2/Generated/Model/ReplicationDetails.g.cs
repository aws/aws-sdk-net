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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about settings that define whether one or more objects in an
    /// S3 bucket are replicated to S3 buckets for other Amazon Web Services accounts and,
    /// if so, which accounts.
    /// </summary>
    public partial class ReplicationDetails
    {
        /// <summary>
        /// Gets and sets the property Replicated. 
        /// <para>
        /// Specifies whether the bucket is configured to replicate one or more objects to any
        /// destination.
        /// </para>
        /// </summary>
        public bool? Replicated { get; set; }

        /// <summary>
        /// Checks to see if the Replicated property is set.
        /// </summary>
        internal bool IsSetReplicated() => this.Replicated.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicatedExternally. 
        /// <para>
        /// Specifies whether the bucket is configured to replicate one or more objects to a bucket
        /// for an Amazon Web Services account that isn't part of your Amazon Macie organization.
        /// An <i>Amazon Macie organization</i> is a set of Macie accounts that are centrally
        /// managed as a group of related accounts through Organizations or by Macie invitation.
        /// </para>
        /// </summary>
        public bool? ReplicatedExternally { get; set; }

        /// <summary>
        /// Checks to see if the ReplicatedExternally property is set.
        /// </summary>
        internal bool IsSetReplicatedExternally() => this.ReplicatedExternally.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationAccounts. 
        /// <para>
        /// An array of Amazon Web Services account IDs, one for each Amazon Web Services account
        /// that owns a bucket that the bucket is configured to replicate one or more objects
        /// to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationAccounts property is set.
        /// </summary>
        internal bool IsSetReplicationAccounts() => this.ReplicationAccounts != null && (this.ReplicationAccounts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
