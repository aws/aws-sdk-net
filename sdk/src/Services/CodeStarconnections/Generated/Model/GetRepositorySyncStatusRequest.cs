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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
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
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// Container for the parameters to the GetRepositorySyncStatus operation.
    /// Returns details about the sync status for a repository. A repository sync uses Git
    /// sync to push and pull changes from your remote repository.
    /// </summary>
    public partial class GetRepositorySyncStatusRequest : AmazonCodeStarconnectionsRequest
    {
        private string _branch;
        private string _repositoryLinkId;
        private SyncConfigurationType _syncType;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch of the repository link for the requested repository sync status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryLinkId. 
        /// <para>
        /// The repository link ID for the requested repository sync status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RepositoryLinkId
        {
            get { return this._repositoryLinkId; }
            set { this._repositoryLinkId = value; }
        }

        // Check to see if RepositoryLinkId property is set
        internal bool IsSetRepositoryLinkId()
        {
            return this._repositoryLinkId != null;
        }

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The sync type of the requested sync status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SyncConfigurationType SyncType
        {
            get { return this._syncType; }
            set { this._syncType = value; }
        }

        // Check to see if SyncType property is set
        internal bool IsSetSyncType()
        {
            return this._syncType != null;
        }

    }
}