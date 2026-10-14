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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the GetRepositorySyncStatus operation. Get the sync
    /// status of a repository used for Proton template sync. For more information about template
    /// sync, see . <note> <para> A repository sync status isn't tied to the Proton Repository
    /// resource (or any other Proton resource). Therefore, tags on an Proton Repository resource
    /// have no effect on this action. Specifically, you can't use these tags to control access
    /// to this action using Attribute-based access control (ABAC). </para> <para> For more
    /// information about ABAC, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/security_iam_service-with-iam.html#security_iam_service-with-iam-tags">ABAC</a>
    /// in the <i>Proton User Guide</i>. </para> </note>
    /// </summary>
    public partial class GetRepositorySyncStatusRequest : AmazonProtonRequest
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The repository branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property RepositoryProvider. 
        /// <para>
        /// The repository provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RepositoryProvider RepositoryProvider { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryProvider property is set.
        /// </summary>
        internal bool IsSetRepositoryProvider() => this.RepositoryProvider != null;

        /// <summary>
        /// Gets and sets the property SyncType. 
        /// <para>
        /// The repository sync type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SyncType SyncType { get; set; }

        /// <summary>
        /// Checks to see if the SyncType property is set.
        /// </summary>
        internal bool IsSetSyncType() => this.SyncType != null;
    }
}
