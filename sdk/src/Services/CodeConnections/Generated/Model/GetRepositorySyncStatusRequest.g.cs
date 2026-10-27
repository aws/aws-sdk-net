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

namespace Amazon.CodeConnections.Model
{
    /// <summary>
    /// Container for the parameters to the GetRepositorySyncStatus operation. Returns details
    /// about the sync status for a repository. A repository sync uses Git sync to push and
    /// pull changes from your remote repository.
    /// </summary>
    public partial class GetRepositorySyncStatusRequest : AmazonCodeConnectionsRequest
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch of the repository link for the requested repository sync status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property RepositoryLinkId. 
        /// <para>
        /// The repository link ID for the requested repository sync status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RepositoryLinkId { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryLinkId property is set.
        /// </summary>
        internal bool IsSetRepositoryLinkId() => this.RepositoryLinkId != null;

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The sync type of the requested sync status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncConfigurationType SyncType { get; set; }

        /// <summary>
        /// Checks to see if the SyncType property is set.
        /// </summary>
        internal bool IsSetSyncType() => this.SyncType != null;
    }
}
