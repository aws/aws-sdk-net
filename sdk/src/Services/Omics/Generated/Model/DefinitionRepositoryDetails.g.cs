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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Contains detailed information about the source code repository that hosts the workflow
    /// definition files.
    /// </summary>
    public partial class DefinitionRepositoryDetails
    {
        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection to the source code repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property FullRepositoryId. 
        /// <para>
        /// The full repository identifier, including the repository owner and name. For example,
        /// 'repository-owner/repository-name'.
        /// </para>
        /// </summary>
        public string FullRepositoryId { get; set; }

        /// <summary>
        /// Checks to see if the FullRepositoryId property is set.
        /// </summary>
        internal bool IsSetFullRepositoryId() => this.FullRepositoryId != null;

        /// <summary>
        /// Gets and sets the property ProviderEndpoint. 
        /// <para>
        /// The endpoint URL of the source code repository provider.
        /// </para>
        /// </summary>
        public string ProviderEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ProviderEndpoint property is set.
        /// </summary>
        internal bool IsSetProviderEndpoint() => this.ProviderEndpoint != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The provider type of the source code repository, such as Bitbucket, GitHub, GitHubEnterpriseServer,
        /// GitLab, and GitLabSelfManaged.
        /// </para>
        /// </summary>
        public string ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property SourceReference. 
        /// <para>
        /// The source reference for the repository, such as a branch name, tag, or commit ID.
        /// </para>
        /// </summary>
        public SourceReference SourceReference { get; set; }

        /// <summary>
        /// Checks to see if the SourceReference property is set.
        /// </summary>
        internal bool IsSetSourceReference() => this.SourceReference != null;
    }
}
