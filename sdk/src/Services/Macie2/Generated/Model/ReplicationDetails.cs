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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about settings that define whether one or more objects in an
    /// S3 bucket are replicated to S3 buckets for other Amazon Web Services accounts and,
    /// if so, which accounts.
    /// </summary>
    public partial class ReplicationDetails
    {
        private bool? _replicated;
        private bool? _replicatedExternally;
        private List<string> _replicationAccounts = new List<string>();

        /// <summary>
        /// Gets and sets the property Replicated. 
        /// <para>
        /// Specifies whether the bucket is configured to replicate one or more objects to any
        /// destination.
        /// </para>
        /// </summary>
        public bool Replicated
        {
            get { return this._replicated.GetValueOrDefault(); }
            set { this._replicated = value; }
        }

        // Check to see if Replicated property is set
        internal bool IsSetReplicated()
        {
            return this._replicated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicatedExternally. 
        /// <para>
        /// Specifies whether the bucket is configured to replicate one or more objects to a bucket
        /// for an Amazon Web Services account that isn't part of your Amazon Macie organization.
        /// An <i>Amazon Macie organization</i> is a set of Macie accounts that are centrally
        /// managed as a group of related accounts through Organizations or by Macie invitation.
        /// </para>
        /// </summary>
        public bool ReplicatedExternally
        {
            get { return this._replicatedExternally.GetValueOrDefault(); }
            set { this._replicatedExternally = value; }
        }

        // Check to see if ReplicatedExternally property is set
        internal bool IsSetReplicatedExternally()
        {
            return this._replicatedExternally.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationAccounts. 
        /// <para>
        /// An array of Amazon Web Services account IDs, one for each Amazon Web Services account
        /// that owns a bucket that the bucket is configured to replicate one or more objects
        /// to.
        /// </para>
        /// </summary>
        public List<string> ReplicationAccounts
        {
            get { return this._replicationAccounts; }
            set { this._replicationAccounts = value; }
        }

        // Check to see if ReplicationAccounts property is set
        internal bool IsSetReplicationAccounts()
        {
            return this._replicationAccounts != null && this._replicationAccounts.Count > 0; 
        }

    }
}