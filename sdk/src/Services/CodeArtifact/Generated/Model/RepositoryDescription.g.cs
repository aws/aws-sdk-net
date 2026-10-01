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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// The details of a repository stored in CodeArtifact. A CodeArtifact repository contains
    /// a set of package versions, each of which maps to a set of assets. Repositories are
    /// polyglot—a single repository can contain packages of any supported type. Each repository
    /// exposes endpoints for fetching and publishing packages using tools like the <c>npm</c>
    /// CLI, the Maven CLI (<c>mvn</c>), and <c>pip</c>. You can create up to 100 repositories
    /// per Amazon Web Services account.
    /// </summary>
    public partial class RepositoryDescription
    {
        /// <summary>
        /// Gets and sets the property AdministratorAccount. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that manages the repository.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AdministratorAccount { get; set; }

        /// <summary>
        /// Checks to see if the AdministratorAccount property is set.
        /// </summary>
        internal bool IsSetAdministratorAccount() => this.AdministratorAccount != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that represents the date and time the repository was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A text description of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain that contains the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain
        /// that contains the repository. It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DomainOwner { get; set; }

        /// <summary>
        /// Checks to see if the DomainOwner property is set.
        /// </summary>
        internal bool IsSetDomainOwner() => this.DomainOwner != null;

        /// <summary>
        /// Gets and sets the property ExternalConnections. 
        /// <para>
        ///  An array of external connections associated with the repository. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RepositoryExternalConnectionInfo> ExternalConnections { get; set; } = AWSConfigs.InitializeCollections ? new List<RepositoryExternalConnectionInfo>() : null;

        /// <summary>
        /// Checks to see if the ExternalConnections property is set.
        /// </summary>
        internal bool IsSetExternalConnections() => this.ExternalConnections != null && (this.ExternalConnections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Upstreams. 
        /// <para>
        ///  A list of upstream repositories to associate with the repository. The order of the
        /// upstream repositories in the list determines their priority order when CodeArtifact
        /// looks for a requested package version. For more information, see <a href="https://docs.aws.amazon.com/codeartifact/latest/ug/repos-upstream.html">Working
        /// with upstream repositories</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpstreamRepositoryInfo> Upstreams { get; set; } = AWSConfigs.InitializeCollections ? new List<UpstreamRepositoryInfo>() : null;

        /// <summary>
        /// Checks to see if the Upstreams property is set.
        /// </summary>
        internal bool IsSetUpstreams() => this.Upstreams != null && (this.Upstreams.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
