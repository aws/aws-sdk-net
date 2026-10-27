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
    /// Information about the revision for a specific sync event, such as the branch, owner
    /// ID, and name of the repository.
    /// </summary>
    public partial class Revision
    {
        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch name for a specific revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Branch { get; set; }

        /// <summary>
        /// Checks to see if the Branch property is set.
        /// </summary>
        internal bool IsSetBranch() => this.Branch != null;

        /// <summary>
        /// Gets and sets the property Directory. 
        /// <para>
        /// The directory, if any, for a specific revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Directory { get; set; }

        /// <summary>
        /// Checks to see if the Directory property is set.
        /// </summary>
        internal bool IsSetDirectory() => this.Directory != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner ID for a specific revision, such as the GitHub owner ID for a GitHub repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The provider type for a revision, such as GitHub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name for a specific revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property Sha. 
        /// <para>
        /// The SHA, such as the commit ID, for a specific revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Sha { get; set; }

        /// <summary>
        /// Checks to see if the Sha property is set.
        /// </summary>
        internal bool IsSetSha() => this.Sha != null;
    }
}
