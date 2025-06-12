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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Details about the status of the replication of a source Amazon Connect instance across
    /// Amazon Web Services Regions. Use these details to understand the general status of
    /// a given replication. For information about why a replication process may fail, see
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-replica-connect-instance.html#why-replicateinstance-fails">Why
    /// a ReplicateInstance call fails</a> in the <i>Create a replica of your existing Amazon
    /// Connect instance</i> topic in the <i>Amazon Connect Administrator Guide</i>.
    /// </summary>
    public partial class ReplicationConfiguration
    {
        private string _globalSignInEndpoint;
        private List<ReplicationStatusSummary> _replicationStatusSummaryList = AWSConfigs.InitializeCollections ? new List<ReplicationStatusSummary>() : null;
        private string _sourceRegion;

        /// <summary>
        /// Gets and sets the property GlobalSignInEndpoint. 
        /// <para>
        /// The URL that is used to sign-in to your Amazon Connect instance according to your
        /// traffic distribution group configuration. For more information about sign-in and traffic
        /// distribution groups, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-traffic-distribution-groups.html">Important
        /// things to know</a> in the <i>Create traffic distribution groups</i> topic in the <i>Amazon
        /// Connect Administrator Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string GlobalSignInEndpoint
        {
            get { return this._globalSignInEndpoint; }
            set { this._globalSignInEndpoint = value; }
        }

        // Check to see if GlobalSignInEndpoint property is set
        internal bool IsSetGlobalSignInEndpoint()
        {
            return this._globalSignInEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatusSummaryList. 
        /// <para>
        /// A list of replication status summaries. The summaries contain details about the replication
        /// of configuration information for Amazon Connect resources, for each Amazon Web Services
        /// Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=11)]
        public List<ReplicationStatusSummary> ReplicationStatusSummaryList
        {
            get { return this._replicationStatusSummaryList; }
            set { this._replicationStatusSummaryList = value; }
        }

        // Check to see if ReplicationStatusSummaryList property is set
        internal bool IsSetReplicationStatusSummaryList()
        {
            return this._replicationStatusSummaryList != null && (this._replicationStatusSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The Amazon Web Services Region where the source Amazon Connect instance was created.
        /// This is the Region where the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ReplicateInstance.html">ReplicateInstance</a>
        /// API was called to start the replication process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=31)]
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

    }
}